using System;
using System.Text.RegularExpressions;

namespace RGTS.LogicaNegocio.Validaciones
{
    public static class ProveedorValidacion
    {
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

            if (!RegexValidaciones.NoSoloNumeros.IsMatch(razonSocial.Trim()))
            {
                throw new ArgumentException("La Razón Social no debe contener solo números");
            }

            if (string.IsNullOrWhiteSpace(nombreComercial))
            {
                throw new ArgumentException("El Nombre Comercial es un campo obligatorio");
            }

            if (nombreComercial.Trim().Length < 3 || nombreComercial.Trim().Length > 100)
            {
                throw new ArgumentException("El Nombre Comercial debe tener entre 3 y 100 caracteres");
            }

            if (!RegexValidaciones.NoSoloNumeros.IsMatch(nombreComercial.Trim()))
            {
                throw new ArgumentException("El Nombre Comercial no debe contener solo números");
            }

            if (string.IsNullOrWhiteSpace(telefono))
            {
                throw new ArgumentException("El Teléfono es un campo obligatorio");
            }

            if (!RegexValidaciones.Telefono.IsMatch(telefono.Trim()))
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

            if (!RegexValidaciones.NoSoloNumeros.IsMatch(direccion.Trim()))
            {
                throw new ArgumentException("La Dirección no debe contener solo números");
            }



            if (!string.IsNullOrWhiteSpace(nombre))
            {
                var nombreLimpio = nombre.Trim();

                if (nombreLimpio.Length < 2 || nombreLimpio.Length > 50)
                {
                    throw new ArgumentException("El nombre de contacto debe tener entre 2 y 50 caracteres");
                }

                if (!RegexValidaciones.SoloTexto.IsMatch(nombreLimpio))
                {
                    throw new ArgumentException("El nombre de contacto no puede contener números");
                }
            }

            if (!string.IsNullOrWhiteSpace(apellido))
            {
                var apellidoLimpio = apellido.Trim();

                if (apellidoLimpio.Length < 2 || apellidoLimpio.Length > 50)
                {
                    throw new ArgumentException("El apellido de contacto debe tener entre 2 y 50 caracteres");
                }

                if (!RegexValidaciones.SoloTexto.IsMatch(apellidoLimpio))
                {
                    throw new ArgumentException("El apellido de contacto no puede contener números");
                }
            }

            if (!string.IsNullOrWhiteSpace(email))
            {
                var emailLimpio = email.Trim();

                if (emailLimpio.Length > 100) // ajustá al largo de tu columna en la BD
                {
                    throw new ArgumentException("El correo electrónico no puede superar los 80 caracteres");
                }

                if (!RegexValidaciones.Email.IsMatch(emailLimpio))
                {
                    throw new ArgumentException("El correo electrónico no posee un formato válido");
                }
            }
        }
    }
}