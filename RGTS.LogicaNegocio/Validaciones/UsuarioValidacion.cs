using System;
using System.Text.RegularExpressions;

namespace RGTS.LogicaNegocio.Validaciones
{
    public static class UsuarioValidacion
    {
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

            if (!RegexValidaciones.SoloTexto.IsMatch(nombre.Trim()))
            {
                throw new ArgumentException("El nombre no puede contener números");
            }

            // valida apellido
            if (apellido.Trim().Length < 3 || apellido.Trim().Length > 50)
            {
                throw new ArgumentException("El apellido es obligatorio y debe contener entre 3 y 50 caracteres");
            }

            if (!RegexValidaciones.SoloTexto.IsMatch(apellido.Trim()))
            {
                throw new ArgumentException("El apellido no puede contener números");
            }

            // valida DNI
            if (!RegexValidaciones.Dni.IsMatch(dni.Trim()))
            {
                throw new ArgumentException("El DNI debe ser numérico y contener entre 7 y 8 dígitos");
            }

            // Email
            if (!RegexValidaciones.Email.IsMatch(email.Trim()))
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