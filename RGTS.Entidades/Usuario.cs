using System.ComponentModel.DataAnnotations;

namespace RGTS.Entidades
{
    internal class Usuario
    {
        public int IdUsuario { get; set; }
        public int IdRol { get; set; }
        public required string Nombre { get; set; }
        public required string Apellido { get; set; }
        public required string Email { get; set; }
        public required string ContrasenaHash { get; set; }
        public bool Activo { get; set; }

        public string NombreCompleto => $"{Nombre} {Apellido}";
        public required Rol Rol { get; set; }
    }
}
