using System;
using System.Text.RegularExpressions;

namespace RGTS.LogicaNegocio.Validaciones
{
    public static class InicioSesionValidacion
    {
        private static readonly Regex EmailRegex = new Regex(
            @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
            RegexOptions.Compiled | RegexOptions.IgnoreCase
        );

        /// <summary>
        /// Valida la sintaxis del email y la presencia de la contraseña antes de ir a la BD.
        /// </summary>
        public static void ValidarCredenciales(string email, string contrasena)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentException("El correo electrónico no puede estar vacío.");
            }

            if (!EmailRegex.IsMatch(email.Trim()))
            {
                throw new ArgumentException("El formato del correo electrónico ingresado no es válido.");
            }

            if (string.IsNullOrWhiteSpace(contrasena))
            {
                throw new ArgumentException("La contraseña no puede estar vacía.");
            }
        }
    }
}