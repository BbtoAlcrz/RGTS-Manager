using System;

namespace RGTS.Entidades
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public string DniUsuario { get; set; } = string.Empty;
        public int IdProveedor { get; set; }
        public string NombreProveedor { get; set; } = string.Empty; // solo para mostrar en grillas
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; } = "Pendiente";
    }
}