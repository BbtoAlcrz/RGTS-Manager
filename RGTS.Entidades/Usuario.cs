using System.ComponentModel.DataAnnotations;

namespace RGTS.Entidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public int IdRol { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string ContrasenaHash { get; set; } = string.Empty;
        public bool Activo { get; set; }

        public string NombreCompleto => $"{Nombre} {Apellido}";
        public required Rol Rol { get; set; }
    }
}
