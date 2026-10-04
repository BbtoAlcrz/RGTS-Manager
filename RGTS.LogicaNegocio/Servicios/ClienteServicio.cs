using System;
using System.Collections.Generic;
using System.Linq;
using RGTS.AccesoDatos.Repositorios;
using RGTS.Entidades;
using RGTS.LogicaNegocio.Validaciones;

namespace RGTS.LogicaNegocio.Servicios
{
    public class ClienteServicio
    {
        private readonly ClienteRepositorio _repositorio;

        public ClienteServicio()
        {
            _repositorio = new ClienteRepositorio();
        }

        public List<Cliente> ObtenerTodos(string? filtro = null)
        {
            return _repositorio.ObtenerTodos(filtro);
        }

        public Cliente? BuscarPorDni(string dni)
        {
            if (string.IsNullOrWhiteSpace(dni)) return null;
            return _repositorio.BuscarPorDni(dni);
        }

        public void CambiarEstadoCliente(int idCliente, bool nuevoEstado)
        {
            var cliente = _repositorio.ObtenerPorId(idCliente)
                ?? throw new InvalidOperationException("El cliente no fue encontrado.");

            if (cliente.Estado == nuevoEstado)
            {
                string estadoTexto = nuevoEstado ? "activo" : "inactivo";
                throw new InvalidOperationException($"El cliente ya se encuentra {estadoTexto}");
            }

            _repositorio.CambiarEstado(idCliente, nuevoEstado);
        }

        public void RegistrarCliente(string nombre, string apellido, string dni, string? telefono, string? email)
        {
            ClienteValidacion.Validar(nombre, apellido, dni, telefono, email);

            var existentes = _repositorio.ObtenerTodos();
            if (existentes.Any(cliente => cliente.DNI == dni.Trim()))
            {
                throw new InvalidOperationException("Un cliente ya se encuentra registrado con éste DNI");
            }

            var nuevoCliente = new Cliente
            {
                Nombre = nombre.Trim(),
                Apellido = apellido.Trim(),
                DNI = dni.Trim(),
                Telefono = telefono?.Trim(),
                Email = email?.Trim(),
                Estado = true
            };

            _repositorio.Insertar(nuevoCliente);
        }

        public void ModificarCliente(int idCliente, string nombre, string apellido, string dni, string? telefono, string? email)
        {
            ClienteValidacion.Validar(nombre, apellido, dni, telefono, email);

            var cliente = _repositorio.ObtenerPorId(idCliente)
                ?? throw new InvalidOperationException("Este cliente no fue encontrado");

            var existentes = _repositorio.ObtenerTodos();
            if (existentes.Any(c => c.DNI == dni.Trim() && c.IdCliente != idCliente))
            {
                throw new InvalidOperationException("El DNI ingresado ya pertenece a otro cliente");
            }

            cliente.Nombre = nombre.Trim();
            cliente.Apellido = apellido.Trim();
            cliente.DNI = dni.Trim();
            cliente.Telefono = telefono?.Trim();
            cliente.Email = email?.Trim();

            _repositorio.Actualizar(cliente);
        }
    }
}