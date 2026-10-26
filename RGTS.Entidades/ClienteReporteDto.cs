using System;

namespace RGTS.Entidades
{
    public class ClienteReporteDto
    {
        public int IdCliente { get; set; }
        public string Dni { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string NombreCompleto { get; set; } = string.Empty;
        public int ComprasEnPeriodo { get; set; }
        public int ComprasHistoricas { get; set; }
        public decimal TotalGastadoPeriodo { get; set; }
    }

    public class ClientesMetricasDto
    {
        // Desempeño de Clientes
        public int TotalClientesActivos { get; set; }
        public int ClientesNuevos { get; set; }
        public decimal AporteClientesRegistradosPorcentaje { get; set; }

        // Metricas de Recurrencia
        public string ClienteEstrella { get; set; } = "--";
        public int CantidadClientesRecurrentes { get; set; }
        public decimal PorcentajeRecurrencia { get; set; }

        // Promedio Comercial
        public decimal FacturacionClientesRegistrados { get; set; }
        public decimal PromedioComprasPorCliente { get; set; }
        public int ClientesCompradoresUnicos { get; set; }


        // Datos para el gráfico de torta
        public int CantidadNuncaCompraron { get; set; }
        public int CantidadCompraronUnaVez { get; set; }
        public int CantidadCompraronMultiple { get; set; }
    }
}