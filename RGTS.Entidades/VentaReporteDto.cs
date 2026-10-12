using System;

namespace RGTS.Entidades
{
    public class VentaReporteDto
    {
        public int IdVenta { get; set; }
        public DateTime Fecha { get; set; }
        public string DniVendedor { get; set; } = string.Empty;
        public string NombreVendedor { get; set; } = string.Empty;
        public int? IdCliente { get; set; }
        public string NombreCliente { get; set; } = string.Empty;
        public decimal TotalVenta { get; set; }


        // Detalle de producto retornado por la fila
        public int IdProducto { get; set; }
        public string CodigoProducto { get; set; } = string.Empty;
        public string NombreProducto { get; set; } = string.Empty;
        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; } = string.Empty;
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }
        public decimal PrecioCostoActual { get; set; }
    }


    // Para rellenar las metricas en la pantalla de reportes de ventas
    public class VentasMetricasDto
    {
        public int CantidadVentas { get; set; }
        public decimal TotalFacturado { get; set; }
        public decimal PromedioFacturado { get; set; }
        public decimal MargenGanancias { get; set; }
        public string FechaConMasVentas { get; set; } = "--";
        public string ProductoMasVendido { get; set; } = "--";
        public string CategoriaMasVendida { get; set; } = "--";
    }
}