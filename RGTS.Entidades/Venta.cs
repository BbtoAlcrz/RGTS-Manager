using System;
using System.Collections.Generic;
using System.Text;

namespace RGTS.Entidades
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public string DniUsuario { get; set; } = string.Empty;
        public int? IdCliente { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public decimal TotalDerivado { get; set; }

        // Objetos para navegación
        public Usuario? Usuario { get; set; }
        public Cliente? Cliente { get; set; }
        public List<DetalleVenta> Detalles { get; set; } = new();
    }
}
