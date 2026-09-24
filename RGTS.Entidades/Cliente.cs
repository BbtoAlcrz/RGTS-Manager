namespace RGTS.Entidades
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string DNI { get; set; } = string.Empty;
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public bool Estado { get; set; }
    }
}
