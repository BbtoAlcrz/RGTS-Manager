using System;
using System.Collections.Generic;

namespace RGTS.Entidades
{
    public class ProductoReporteDto
    {
        public int IdProducto { get; set; }
        public string Codigo { get; set; } = string.Empty;
        public string NombreProducto { get; set; } = string.Empty;
        public string NombreCategoria { get; set; } = string.Empty;
        public decimal PrecioVenta { get; set; }
        public int StockActual { get; set; }
        public int StockMinimo { get; set; }
        public bool Activo { get; set; }
        public int UnidadesVendidasEnPeriodo { get; set; }
        public decimal TotalFacturadoEnPeriodo { get; set; }
    }

    public class ProductosMetricasDto
    {
        // Valorización de Inventario
        public decimal ValorTotalInventario { get; set; }
        public int TotalProductosActivos { get; set; }
        public int TotalProductosInactivos { get; set; }

        // Control de Stock
        public int ProductosStockCritico { get; set; }
        public int ProductosAgotados { get; set; }
        public decimal PorcentajeStockOptimo { get; set; }

        // Rendimiento y Rotación
        public string ProductoEstrella { get; set; } = "--";
        public string CategoriaEstrella { get; set; } = "--";
        public decimal PromedioUnidadesVendidas { get; set; }

        // Lista ordenada para el Top 5
        public List<ProductoReporteDto> Top5MasVendidos { get; set; } = new();
    }
}