using System;
using System.Collections.Generic;
using System.Text;

namespace RGTS.Entidades
{
    public class DetalleVenta
    {
        public int IdDetalle { get; set; }
        public int IdVenta { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal SubtotalDerivado { get; set; }

        public decimal SubtotalCalculado => Cantidad * PrecioUnitario;

        // Propiedad para navegacion
        public Producto? Producto { get; set; }
    }
}
