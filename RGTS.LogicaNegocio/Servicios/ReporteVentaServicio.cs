using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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
                throw new ArgumentException("La fecha 'Desde' no puede ser posterior a la fecha 'Hasta'...");
            }

            return _reporteRepositorio.ObtenerReporteVentas(fechaDesde, fechaHasta, dniVendedor);
        }

        public VentasMetricasDto CalcularMetricas(List<VentaReporteDto> ventas)
        {
            var metricas = new VentasMetricasDto();

            if (ventas == null || ventas.Count == 0)
                return metricas;

            // Agrupar ventas unicas para evitar duplicar cada ítem de detalle
            var ventasUnicas = ventas.GroupBy(v => v.IdVenta).Select(g => g.First()).ToList();

            // DESEMPEÑO FINANCIERO
            metricas.CantidadVentas = ventasUnicas.Count;
            metricas.TotalFacturado = ventasUnicas.Sum(v => v.TotalVenta);

            int cantidadVendedoresActivos = ventasUnicas.Select(v => v.DniVendedor).Distinct().Count();
            metricas.PromedioFacturadoPorVendedor = cantidadVendedoresActivos > 0
                ? metricas.TotalFacturado / cantidadVendedoresActivos
                : 0m;

            // margen de ganancias (30% sobre el total facturado)
            decimal costoEstimado = ventas.Sum(v => (v.PrecioUnitario * 0.70m) * v.Cantidad);
            metricas.MargenGananciasTotal = metricas.TotalFacturado - costoEstimado;

            // RENDIMIENTO DE VENDEDORES
            var vendedorEstrellaGroup = ventasUnicas
                .GroupBy(v => v.NombreVendedor)
                .OrderByDescending(g => g.Sum(x => x.TotalVenta))
                .FirstOrDefault();

            if (vendedorEstrellaGroup != null)
            {
                metricas.VendedorEstrella = $"{vendedorEstrellaGroup.Key} ({vendedorEstrellaGroup.Sum(x => x.TotalVenta):C2})";
            }

            var vendedorMasOperacionesGroup = ventasUnicas
                .GroupBy(v => v.NombreVendedor)
                .OrderByDescending(g => g.Count())
                .FirstOrDefault();

            if (vendedorMasOperacionesGroup != null)
            {
                metricas.VendedorConMasOperaciones = $"{vendedorMasOperacionesGroup.Key} ({vendedorMasOperacionesGroup.Count()} op.)";
            }

            // DESEMPEÑO TEMPORAL
            // Fecha con más recaudación
            var fechaPicoGroup = ventasUnicas
                .GroupBy(v => v.Fecha.Date)
                .OrderByDescending(g => g.Sum(x => x.TotalVenta))
                .FirstOrDefault();

            if (fechaPicoGroup != null)
            {
                metricas.FechaPicoVentas = fechaPicoGroup.Key.ToString("dd/MM/yyyy");
            }

            // Día de la semana con más operaciones
            var culturaEs = new CultureInfo("es-ES");
            var diaPicoGroup = ventasUnicas
                .GroupBy(v => v.Fecha.ToString("dddd", culturaEs))
                .OrderByDescending(g => g.Count())
                .FirstOrDefault();

            if (diaPicoGroup != null)
            {
                metricas.DiaConMasVentas = culturaEs.TextInfo.ToTitleCase(diaPicoGroup.Key);
            }

            // Hora pico de operaciones
            var horaPicoGroup = ventasUnicas
                .GroupBy(v => v.Fecha.Hour)
                .OrderByDescending(g => g.Count())
                .FirstOrDefault();

            if (horaPicoGroup != null)
            {
                metricas.HoraPicoVentas = $"{horaPicoGroup.Key:D2}:00 - {horaPicoGroup.Key + 1:D2}:00 hs";
            }

            return metricas;
        }
    }
}