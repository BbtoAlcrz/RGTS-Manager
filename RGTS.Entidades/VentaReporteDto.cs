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

    // Para la tarjeta de informacion en la vista de reportes de ventas
    public class VentasMetricasDto
    {
        // Desempeño Financiero
        public int CantidadVentas { get; set; }
        public decimal TotalFacturado { get; set; }
        public decimal PromedioFacturadoPorVendedor { get; set; }
        public decimal MargenGananciasTotal { get; set; }

        // Rendimiento de Vendedores
        public string VendedorEstrella { get; set; } = "--";
        public string VendedorConMasOperaciones { get; set; } = "--";

        // Desempeño Temporal
        public string FechaPicoVentas { get; set; } = "--";
        public string DiaConMasVentas { get; set; } = "--";
        public string HoraPicoVentas { get; set; } = "--";
    }
}