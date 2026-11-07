using System;
using System.Collections.Generic;
using System.Linq;
using RGTS.AccesoDatos.Repositorios;
using RGTS.Entidades;

namespace RGTS.LogicaNegocio.Servicios
{
    public class ReporteProductoServicio
    {
        private readonly ReporteProductoRepositorio _repositorio = new();

        public List<ProductoReporteDto> ObtenerReporteProductos(DateTime fechaDesde, DateTime fechaHasta)
        {
            if (fechaDesde > fechaHasta)
            {
                throw new ArgumentException("La fecha 'Desde' no puede ser posterior a la fecha 'Hasta'");
            }
            
            return _repositorio.ObtenerReporteProductos(fechaDesde, fechaHasta);
        }

        public ProductosMetricasDto CalcularMetricas(List<ProductoReporteDto> productos)
        {
            var metricas = new ProductosMetricasDto();

            if (productos == null || productos.Count == 0)
                return metricas;

            var productosActivos = productos.Where(p => p.Activo).ToList();

            // VALORIZACIÓN DE INVENTARIO
            metricas.ValorTotalInventario = productosActivos.Sum(p => p.StockActual * p.PrecioVenta);
            metricas.TotalProductosActivos = productosActivos.Count;

            // STOCK
            metricas.ProductosAgotados = productosActivos.Count(p => p.StockActual == 0);
            metricas.ProductosStockCritico = productosActivos.Count(p => p.StockActual > 0 && p.StockActual <= p.StockMinimo);

            int productosOptimos = metricas.TotalProductosActivos - (metricas.ProductosAgotados + metricas.ProductosStockCritico);
            metricas.PorcentajeStockOptimo = metricas.TotalProductosActivos > 0
                ? ((decimal)productosOptimos / metricas.TotalProductosActivos) * 100m
                : 0m;

            // RENDIMIENTO Y ROTACIÓN
            int totalUnidadesVendidasEnPeriodo = productos.Sum(p => p.UnidadesVendidasEnPeriodo);

            if (totalUnidadesVendidasEnPeriodo == 0)
            {
                // Si no hay ventas en las fechas seleccionadas
                metricas.ProductoEstrella = "--";
                metricas.CategoriaEstrella = "--";
                metricas.PromedioUnidadesVendidas = 0m;

                // lista vacía y no hay barras que graficar
                metricas.Top5MasVendidos = new List<ProductoReporteDto>();
            }
            else
            {
                var productoEstrella = productos
                    .Where(p => p.UnidadesVendidasEnPeriodo > 0)
                    .OrderByDescending(p => p.UnidadesVendidasEnPeriodo)
                    .FirstOrDefault();

                if (productoEstrella != null)
                {
                    metricas.ProductoEstrella = $"{productoEstrella.NombreProducto} ({productoEstrella.UnidadesVendidasEnPeriodo} un.)";
                }

                var categoriaEstrella = productos
                    .Where(p => p.TotalFacturadoEnPeriodo > 0)
                    .GroupBy(p => p.NombreCategoria)
                    .Select(g => new { Categoria = g.Key, Total = g.Sum(x => x.TotalFacturadoEnPeriodo) })
                    .OrderByDescending(x => x.Total)
                    .FirstOrDefault();

                if (categoriaEstrella != null)
                {
                    metricas.CategoriaEstrella = categoriaEstrella.Categoria;
                }

                int productosVendidosCount = productos.Count(p => p.UnidadesVendidasEnPeriodo > 0);
                metricas.PromedioUnidadesVendidas = productosVendidosCount > 0
                    ? (decimal)totalUnidadesVendidasEnPeriodo / productosVendidosCount
                    : 0m;

                metricas.Top5MasVendidos = productos
                    .Where(p => p.UnidadesVendidasEnPeriodo > 0)
                    .OrderByDescending(p => p.UnidadesVendidasEnPeriodo)
                    .Take(5)
                    .ToList();
            }

            return metricas;
        }
    }
}