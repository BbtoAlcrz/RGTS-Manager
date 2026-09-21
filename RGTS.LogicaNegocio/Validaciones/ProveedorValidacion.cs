using System;
using System.Text.RegularExpressions;

namespace RGTS.LogicaNegocio.Validaciones
{
    public static class ProveedorValidacion
    {
        private static readonly Regex TelefonoRegex = new Regex(
            @"^\+?[\d\s-]{7,15}$",
            RegexOptions.Compiled
        );

        private static readonly Regex EmailRegex = new Regex(
            @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled | RegexOptions.IgnoreCase
        );

        public static void Validar(
            string razonSocial,
            string nombreComercial,
            string idTipoProveedor,
            string telefono,
            string? email,
            string? nombre,
            string? apellido,
            string direccion
        )
        {
            // Campos obligatorios principales
            if (string.IsNullOrWhiteSpace(razonSocial))
            {
                throw new ArgumentException("La Razón Social es un campo obligatorio");
            }

            if (razonSocial.Trim().Length < 3 || razonSocial.Trim().Length > 100)
            {
                throw new ArgumentException("La Razón Social debe contener entre 3 y 100 caracteres");
            }


            if (string.IsNullOrWhiteSpace(nombreComercial))
            {
                throw new ArgumentException("El Nombre Comercial es un campo obligatorio");
            }

            if (nombreComercial.Trim().Length < 3 || nombreComercial.Trim().Length > 100)
            {
                throw new ArgumentException("El Nombre Comercial debe tener entre 3 y 100 caracteres");
            }


            if (string.IsNullOrWhiteSpace(telefono))
            {
                throw new ArgumentException("El Teléfono es un campo obligatorio.");
            }

            if (!TelefonoRegex.IsMatch(telefono.Trim()))
            {
                throw new ArgumentException("El Teléfono ingresado no posee un formato válido");
            }


            if (string.IsNullOrWhiteSpace(direccion))
            {
                throw new ArgumentException("La Dirección es un campo Obligatorio");
            }

            if (direccion.Trim().Length < 5 || direccion.Trim().Length > 150)
            {
                throw new ArgumentException("La Dirección debe tener entre 5 y 150 caracteres");
            }



            // datos opcionales
            if (!string.IsNullOrWhiteSpace(nombre) && (nombre.Trim().Length < 2 || nombre.Trim().Length > 50))
            {
                throw new ArgumentException("El nombre de contacto debe tener entre 2 y 50 caracteres");
            }

            if (!string.IsNullOrWhiteSpace(apellido) && (apellido.Trim().Length < 2 || apellido.Trim().Length > 50))
            {
                throw new ArgumentException("El apellido de contacto debe tener entre 2 y 50 caracteres");
            }

            if (!string.IsNullOrWhiteSpace(email) && !EmailRegex.IsMatch(email.Trim()))
            {
                throw new ArgumentException("El correo electrónico no posee un formato válido");
            }
        }
    }
}