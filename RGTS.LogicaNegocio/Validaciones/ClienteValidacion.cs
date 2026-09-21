using System;
using System.Text.RegularExpressions;

namespace RGTS.LogicaNegocio.Validaciones
{
    public static class ClienteValidacion
    {
        private static readonly Regex EmailRegex = new Regex(
            @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
            RegexOptions.Compiled | RegexOptions.IgnoreCase
        );

        private static readonly Regex DniRegex = new Regex(
            @"^\d{7,8}$",
            RegexOptions.Compiled
        );

        public static void Validar(string nombre, string apellido, string dni, string telefono, string email)
        {
            // Valida campos obligatorios vacíos o en blanco
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(dni))
                throw new ArgumentException("Nombre, apellido y DNI son obligatorios.");

            // Valida nombre
            if (nombre.Trim().Length < 3 || nombre.Trim().Length > 50)
                throw new ArgumentException("El nombre debe contener entre 3 y 50 caracteres.");

            // Valida apellido
            if (apellido.Trim().Length < 3 || apellido.Trim().Length > 50)
                throw new ArgumentException("El apellido debe contener entre 3 y 50 caracteres.");

            // Valida DNI
            if (!DniRegex.IsMatch(dni.Trim()))
                throw new ArgumentException("El DNI debe ser numérico y contener entre 7 y 8 dígitos.");

            // Email (opcional, pero si se ingresa debe tener formato válido)
            if (!string.IsNullOrWhiteSpace(email) && !EmailRegex.IsMatch(email.Trim()))
                throw new ArgumentException("El correo electrónico no posee un formato válido.");

            // Teléfono (opcional, pero si se ingresa se valida longitud)
            if (!string.IsNullOrWhiteSpace(telefono) && (telefono.Trim().Length < 6 || telefono.Trim().Length > 30))
                throw new ArgumentException("El teléfono debe contener entre 6 y 30 caracteres.");
        }
    }
}