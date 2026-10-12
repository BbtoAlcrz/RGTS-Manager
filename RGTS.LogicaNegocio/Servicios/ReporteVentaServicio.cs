using System;
using System.Collections.Generic;
using RGTS.AccesoDatos.Repositorios;
using RGTS.Entidades;

namespace RGTS.LogicaNegocio.Servicios
{
    public class ReporteVentaServicio
    {
        private readonly ReporteVentaRepositorio _reporteRepositorio;

        public ReporteVentaServicio()
        {
            _reporteRepositorio = new ReporteVentaRepositorio();
        }

        public List<VentaReporteDto> ObtenerReporteVentas(DateTime fechaDesde, DateTime fechaHasta, string? dniVendedor = null)
        {
            if (fechaDesde > fechaHasta)
            {
                throw new ArgumentException("La fecha 'Desde' no puede ser posterior a la fecha 'Hasta'.");
            }

            return _reporteRepositorio.ObtenerReporteVentas(fechaDesde, fechaHasta, dniVendedor);
        }

        public VentasMetricasDto CalcularMetricas(List<VentaReporteDto> ventas)
        {
            var metricas = new VentasMetricasDto();

            if (ventas == null || ventas.Count == 0)
                return metricas;

            // filtra ventas unicas para evitar duplicar totales de ventas
            var ventasUnicas = ventas.GroupBy(v => v.IdVenta).Select(g => g.First()).ToList();

            metricas.CantidadVentas = ventasUnicas.Count;
            metricas.TotalFacturado = ventasUnicas.Sum(v => v.TotalVenta);
            metricas.PromedioFacturado = metricas.CantidadVentas > 0 ? metricas.TotalFacturado / metricas.CantidadVentas : 0m;

            // Costo estimado, asume un 30% de margen de ganancia sobre el precio unitario de la venta
            decimal costoEstimado = ventas.Sum(v => (v.PrecioUnitario * 0.70m) * v.Cantidad);
            metricas.MargenGanancias = metricas.TotalFacturado - costoEstimado;

            // fecha con más ventas
            var fechaTop = ventasUnicas
                .GroupBy(v => v.Fecha.Date)
                .OrderByDescending(g => g.Count())
                .FirstOrDefault()?.Key;
            metricas.FechaConMasVentas = fechaTop.HasValue ? fechaTop.Value.ToString("dd/MM/yyyy") : "--";

            // Producto más vendido por unidades totales
            var productoTop = ventas
                .GroupBy(v => v.NombreProducto)
                .Select(g => new { Nombre = g.Key, Unidades = g.Sum(x => x.Cantidad) })
                .OrderByDescending(x => x.Unidades)
                .FirstOrDefault();

            if (productoTop != null)
                metricas.ProductoMasVendido = $"{productoTop.Nombre} ({productoTop.Unidades} un.)";

            // Categoría más vendida por monto total facturado
            var categoriaTop = ventas
                .GroupBy(v => v.NombreCategoria)
                .Select(g => new { Nombre = g.Key, Total = g.Sum(x => x.Subtotal) })
                .OrderByDescending(x => x.Total)
                .FirstOrDefault();

            if (categoriaTop != null)
                metricas.CategoriaMasVendida = categoriaTop.Nombre;

            return metricas;
        }
    }
}