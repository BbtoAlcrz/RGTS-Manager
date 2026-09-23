using System;
using System.Text.RegularExpressions;

namespace RGTS.LogicaNegocio.Validaciones
{
    public static class UsuarioValidacion
    {
        private static readonly Regex EmailRegex = new Regex(
            @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
            RegexOptions.Compiled | RegexOptions.IgnoreCase
        );

        private static readonly Regex DniRegex = new Regex(
            @"^\d{7,8}$",
            RegexOptions.Compiled
        );

        public static void Validar(
            string nombre,
            string apellido,
            string dni,
            string email,
            int idRol,
            string contrasena,
            bool esNuevo = true)
        {
            // Valida campos vacios o en blanco
            if(string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || 
               string.IsNullOrWhiteSpace(dni) || string.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentException("Debe completar todos los campos");
            }

            // valida nombre
            if (nombre.Trim().Length < 3 || nombre.Trim().Length > 50)
            {
                throw new ArgumentException("El nombre debe contener entre 3 y 50 caracteres");
            }

            // valida apellido
            if (apellido.Trim().Length < 3 || apellido.Trim().Length > 50)
            {
                throw new ArgumentException("El apellido es obligatorio y debe contener entre 3 y 50 caracteres");
            }

            // valida DNI
            if (!DniRegex.IsMatch(dni.Trim()))
            {
                throw new ArgumentException("El DNI debe ser numérico y contener entre 7 y 8 dígitos");
            }

            // Email
            if (!EmailRegex.IsMatch(email.Trim()))
            {
                throw new ArgumentException("El correo electrónico no posee un formato válido");
            }

            // Rol
            if (idRol <= 0)
            {
                throw new ArgumentException("Debe seleccionar un rol válido");
            }

            // Contraseña inicial (solo obligatoria al crear un usuario nuevo)
            if (esNuevo)
            {
                if (contrasena.Length < 8)
                {
                    throw new ArgumentException("La contraseña inicial debe contener al menos 8 caracteres");
                }
            }
        }
    }
}