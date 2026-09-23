using System;
using BCrypt.Net;
using System.Collections.Generic;
using RGTS.AccesoDatos.Repositorios;
using RGTS.Entidades;
using RGTS.LogicaNegocio.Validaciones;

namespace RGTS.LogicaNegocio.Servicios
{
    public class UsuarioServicio
    {
        private readonly UsuarioRepositorio _usuarioRepositorio;

        public UsuarioServicio()
        {
            _usuarioRepositorio = new UsuarioRepositorio();
        }


        // funcion para registrar un usuario nuevo, recibe y valida los datos y usa el repositorio para insertar en la BD
        public void RegistrarUsuario(string dni, string nombre, string apellido, string email, int idRol, string contrasena)
        {
            // Verifica reglas de formato en Validaciones
            UsuarioValidacion.Validar(nombre, apellido, dni, email, idRol, contrasena, esNuevo: true);

            // Hashea la contraseña con BCrypt
            // string contrasenaHash = BCrypt.Net.BCrypt.HashPassword(contrasena.Trim());

            // Empaqueta una entidad y la envía al metodo en AccesoDatos->Repositorio
            Usuario nuevoUsuario = new Usuario
            {
                Dni = dni.Trim(),
                Nombre = nombre.Trim(),
                Apellido = apellido.Trim(),
                Email = email.Trim(),
                IdRol = idRol,
                ContrasenaHash = contrasena,
                Activo = true
            };

            _usuarioRepositorio.Insertar(nuevoUsuario);
        }



        // funcion para modificar un usuario ya existente, valida sus datos y usa el repositorio para actualizar en la BD
        public void ModificarUsuario(string dni, string nombre, string apellido, string email, int idRol, string contrasenaNueva)
        {
            bool cambioContrasena = !string.IsNullOrEmpty(contrasenaNueva);
            // Si escribe en el campo de contraseña, validamos que tenga mínimo 8 caracteres
            UsuarioValidacion.Validar(nombre, apellido, dni, email, idRol, contrasenaNueva, esNuevo: cambioContrasena);

          //  string hash = string.Empty;
          //  if (cambioContrasena)
          //  {
          //      hash = BCrypt.Net.BCrypt.HashPassword(contrasenaNueva.Trim());
          //  }

            Usuario usuario = new Usuario
            {
                Dni = dni.Trim(),
                Nombre = nombre.Trim(),
                Apellido = apellido.Trim(),
                Email = email.Trim(),
                IdRol = idRol,
                ContrasenaHash = contrasenaNueva
            };

            _usuarioRepositorio.Actualizar(usuario, cambioContrasena);
        }


        // funcion para listar usuarios de la BD, recibe filtros opcionales y usa el repositorio para hacerlo
        public List<Usuario> ListarUsuarios(string? filtroTexto = null, int? idRol = null, bool? activo = null)
        {
            return _usuarioRepositorio.ObtenerTodos(filtroTexto, idRol, activo);
        }


        // funcion para cambiar el estado de un usuario, recibe el dni a cambiar y el dni de la sesion actual para evitar
        // deshabilitar su propia cuenta activa por segurirdad
        public void CambiarEstadoUsuario(string dniObjetivo, bool nuevoEstado, string dniSesionActual)
        {
            if (!nuevoEstado && dniObjetivo == dniSesionActual)
            {
                throw new InvalidOperationException("No puede deshabilitar su propio usuario mientras está en sesión.");
            }

            _usuarioRepositorio.CambiarEstado(dniObjetivo, nuevoEstado);
        }

    }
}