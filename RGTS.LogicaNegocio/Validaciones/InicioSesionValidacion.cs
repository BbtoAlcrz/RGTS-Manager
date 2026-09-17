using System;
using System.Text.RegularExpressions;

namespace RGTS.LogicaNegocio.Validaciones
{
    public static class InicioSesionValidacion
    {
        private static readonly Regex EmailRegex = new Regex(
           @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
           RegexOptions.Compiled | RegexOptions.IgnoreCase
       );

        // Valida la sintaxis del email y la presencia de la contraseña antes de ir a la BD.        
        public static void ValidarCredenciales(string email, string contrasena)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(contrasena))
            {
                throw new ArgumentException("El email o la contraseña no pueden estar vacíos");
            }

            if (!EmailRegex.IsMatch(email.Trim()))
            {
                throw new ArgumentException("El correo electrónico no posee un formato válido");
            }
        }
    }
}