namespace RGTS.Entidades
{
    public class Proveedor
    {
        public int IdProveedor { get; set; }
        public string RazonSocial { get; set; } = string.Empty;
        public string NombreComercial { get; set; } = string.Empty;
        public string TipoProveedor { get; set; } = string.Empty;
        public string? NombreContacto { get; set; }
        public string? ApellidoContacto { get; set; }
        public string Telefono { get; set; } = string.Empty;
        public string? Email { get; set; }
        public string Direccion { get; set; } = string.Empty;
        public bool Activo { get; set; }
    }
}
