using System;
using BCrypt.Net;
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
        public void RegistrarUsuario(string dni, string nombre, string apellido, string email, int idRol, string contrasena)
        {
            // Verifica reglas de formato en Validaciones
            UsuarioValidacion.Validar(nombre, apellido, dni, email, idRol, contrasena, esNuevo: true);

            // Hashea la contraseña con BCrypt
            string contrasenaHash = BCrypt.Net.BCrypt.HashPassword(contrasena.Trim());

            // Empaqueta una entidad y la envía al metodo en AccesoDatos->Repositorio
            Usuario nuevoUsuario = new Usuario
            {
                Dni = dni.Trim(),
                Nombre = nombre.Trim(),
                Apellido = apellido.Trim(),
                Email = email.Trim(),
                IdRol = idRol,
                ContrasenaHash = contrasenaHash,
                Activo = true
            };

            _usuarioRepositorio.Insertar(nuevoUsuario);
        }
    }
}