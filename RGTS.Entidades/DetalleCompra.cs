namespace RGTS.Entidades
{
    public class DetalleCompra
    {
        public int IdDetalleCompra { get; set; }
        public int IdCompra { get; set; }
        public int IdProducto { get; set; }
        public string CodigoProducto { get; set; } = string.Empty; // para mostrar en grilla
        public string NombreProducto { get; set; } = string.Empty; // para mostrar en grilla
        public int Cantidad { get; set; }
        public decimal CostoUnitario { get; set; }
        public decimal Subtotal => Cantidad * CostoUnitario;
    }
}