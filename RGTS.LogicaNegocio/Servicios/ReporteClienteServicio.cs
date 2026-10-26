using System;
using System.Collections.Generic;
using System.Linq;
using RGTS.AccesoDatos.Repositorios;
using RGTS.Entidades;

namespace RGTS.LogicaNegocio.Servicios
{
    public class ReporteClienteServicio
    {
        private readonly ReporteClienteRepositorio _repositorio;

        public ReporteClienteServicio()
        {
            _repositorio = new ReporteClienteRepositorio();
        }

        public List<ClienteReporteDto> ObtenerReporteClientes(DateTime fechaDesde, DateTime fechaHasta)
        {
            if (fechaDesde > fechaHasta)
            {
                throw new ArgumentException("La fecha 'Desde' no puede ser posterior a la fecha 'Hasta'");
            }

            return _repositorio.ObtenerReporteClientes(fechaDesde, fechaHasta);
        }

        public ClientesMetricasDto CalcularMetricas(List<ClienteReporteDto> listaReporte)
        {
            var metricas = new ClientesMetricasDto();

            if (listaReporte == null || listaReporte.Count == 0)
                return metricas;

            // separar clientes registrados del Consumidor Final (Dni '000')
            var clientesRegistrados = listaReporte.Where(c => c.IdCliente > 0 && c.Dni != "000").ToList();
            var consumidorFinal = listaReporte.FirstOrDefault(c => c.IdCliente == 0 || c.Dni == "000");

            // facturación total del período
            decimal facturacionRegistrados = clientesRegistrados.Sum(c => c.TotalGastadoPeriodo);
            decimal facturacionConsumidorFinal = consumidorFinal?.TotalGastadoPeriodo ?? 0m;
            decimal facturacionTotalGeneral = facturacionRegistrados + facturacionConsumidorFinal;

            // total de clientes activos habilitados en el sistema
            metricas.TotalClientesActivos = clientesRegistrados.Count;

            // clientes nuevos (primera compra ocurrió en este periodo)
            metricas.ClientesNuevos = clientesRegistrados.Count(c => c.ComprasHistoricas > 0 && c.ComprasHistoricas == c.ComprasEnPeriodo);

            // aporte de registrados sobre la facturación general
            metricas.AporteClientesRegistradosPorcentaje = facturacionTotalGeneral > 0
                ? (facturacionRegistrados / facturacionTotalGeneral) * 100m
                : 0m;


            // Cliente Estrella (mayor gasto en el período)
            var clienteEstrella = clientesRegistrados
                .Where(c => c.ComprasEnPeriodo > 0)
                .OrderByDescending(c => c.TotalGastadoPeriodo)
                .ThenByDescending(c => c.ComprasEnPeriodo)
                .FirstOrDefault();

            if (clienteEstrella != null)
            {
                metricas.ClienteEstrella = $"{clienteEstrella.Apellido}, {clienteEstrella.Nombre} ({clienteEstrella.TotalGastadoPeriodo:C2})";
            }
            else
            {
                metricas.ClienteEstrella = "Sin Compras";
            }

            // Clientes Compradores Unicos en el periodo
            var compradoresEnPeriodo = clientesRegistrados.Where(c => c.ComprasEnPeriodo > 0).ToList();
            metricas.ClientesCompradoresUnicos = compradoresEnPeriodo.Count;

            // Cantidad de Clientes Recurrentes (2 o más compras)
            metricas.CantidadClientesRecurrentes = clientesRegistrados.Count(c => c.ComprasEnPeriodo >= 2);

            // Porcentaje de Recurrencia sobre los compradores del periodo
            metricas.PorcentajeRecurrencia = metricas.ClientesCompradoresUnicos > 0
                ? ((decimal)metricas.CantidadClientesRecurrentes / metricas.ClientesCompradoresUnicos) * 100m
                : 0m;

            // Facturacion total obtenida de clientes registrados
            metricas.FacturacionClientesRegistrados = facturacionRegistrados;

            // Promedio de compras por cliente activo
            int totalComprasRegistrados = clientesRegistrados.Sum(c => c.ComprasEnPeriodo);
            metricas.PromedioComprasPorCliente = metricas.ClientesCompradoresUnicos > 0
                ? (decimal)totalComprasRegistrados / metricas.ClientesCompradoresUnicos
                : 0m;

            // DATOS PARA EL GRÁFICO 
            metricas.CantidadNuncaCompraron = clientesRegistrados.Count(c => c.ComprasHistoricas == 0);
            metricas.CantidadCompraronUnaVez = clientesRegistrados.Count(c => c.ComprasHistoricas == 1);
            metricas.CantidadCompraronMultiple = clientesRegistrados.Count(c => c.ComprasHistoricas > 1);

            return metricas;
        }
    }
}