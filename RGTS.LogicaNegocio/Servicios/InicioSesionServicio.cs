using System;
using RGTS.AccesoDatos.Repositorios;
using RGTS.Entidades;
using RGTS.LogicaNegocio.Validaciones;

namespace RGTS.LogicaNegocio.Servicios
{
    public class AutenticacionServicio
    {
        private readonly UsuarioRepositorio _usuarioRepositorio;

        public AutenticacionServicio()
        {
            _usuarioRepositorio = new UsuarioRepositorio();
        }

        public Usuario IniciarSesion(string email, string contrasena)
        {
            // 1. Reglas de entrada delegadas a la carpeta Validaciones
            InicioSesionValidacion.ValidarCredenciales(email, contrasena);

            // 2. Consulta y reglas de negocio contra los datos
            Usuario? usuario = _usuarioRepositorio.ObtenerPorEmail(email.Trim());

            if (usuario == null)
            {
                throw new UnauthorizedAccessException("Credenciales inválidas. Compruebe el correo y la contraseña.");
            }

            if (!usuario.Activo)
            {
                throw new UnauthorizedAccessException("Su cuenta se encuentra inactiva. Contacte al administrador.");
            }

            // 3. La contraseña se compara contra el hash BCrypt guardado en la BD (nunca en texto plano)
            bool contrasenaValida;
            try
            {
                contrasenaValida = BCrypt.Net.BCrypt.Verify(contrasena.Trim(), usuario.ContrasenaHash);
            }
            catch (BCrypt.Net.SaltParseException)
            {
                // El valor guardado no es un hash BCrypt válido (por ejemplo, una contraseña vieja en texto plano)
                contrasenaValida = false;
            }

            if (!contrasenaValida)
            {
                throw new UnauthorizedAccessException("Credenciales inválidas. Compruebe el correo y la contraseña.");
            }

            return usuario;
        }
    }
}