using System;
using System.Collections.Generic;
using System.Linq;
using RGTS.AccesoDatos.Repositorios;
using RGTS.Entidades;
using RGTS.LogicaNegocio.Validaciones;

namespace RGTS.LogicaNegocio.Servicios
{
    public class ProveedorServicio
    {
        private readonly ProveedorRepositorio _repositorio;

        public ProveedorServicio()
        {
            _repositorio = new ProveedorRepositorio();
        }

        private static string? LimpiarTexto(string? texto)
        {
            return string.IsNullOrWhiteSpace(texto) ? null : texto.Trim();
        }

        public List<Proveedor> ObtenerTodos(string? filtro = null)
        {
            return _repositorio.ObtenerTodos(filtro);
        }

        public Proveedor? BuscarPorId(int idProveedor)
        {
            return _repositorio.BuscarPorId(idProveedor);
        }

        public void RegistrarProveedor(
            string razonSocial,
            string nombreComercial,
            string tipoProveedor,
            string telefono,
            string? email,
            string? nombreProveedor,
            string? apellidoProveedor,
            string direccion)
        {
            ProveedorValidacion.Validar(razonSocial, nombreComercial, tipoProveedor, telefono, email, nombreProveedor, apellidoProveedor, direccion);

            var existentes = _repositorio.ObtenerTodos();
            if (existentes.Any(p => p.NombreComercial.Equals(nombreComercial.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                throw new InvalidOperationException("Ya existe un proveedor registrado con ese nombre comercial.");
            }

            var nuevoProveedor = new Proveedor
            {
                RazonSocial = razonSocial.Trim(),
                NombreComercial = nombreComercial.Trim(),
                TipoProveedor = tipoProveedor,
                Telefono = telefono.Trim(),
                Email = LimpiarTexto(email),
                NombreContacto = LimpiarTexto(nombreProveedor),
                ApellidoContacto = LimpiarTexto(apellidoProveedor),
                Direccion = direccion.Trim(),
                Activo = true
            };

            _repositorio.Insertar(nuevoProveedor);
        }

        public void ModificarProveedor(
            int idProveedor,
            string razonSocial,
            string nombreComercial,
            string tipoProveedor,
            string telefono,
            string? email,
            string? nombreProveedor,
            string? apellidoProveedor,
            string direccion)
        {
            ProveedorValidacion.Validar(razonSocial, nombreComercial, tipoProveedor, telefono, email, nombreProveedor, apellidoProveedor, direccion);

            var proveedor = _repositorio.BuscarPorId(idProveedor)
                ?? throw new InvalidOperationException("El proveedor a modificar no fue encontrado.");

            var existentes = _repositorio.ObtenerTodos();
            if (existentes.Any(p => p.NombreComercial.Equals(nombreComercial.Trim(), StringComparison.OrdinalIgnoreCase) && p.IdProveedor != idProveedor))
            {
                throw new InvalidOperationException("Ya existe otro proveedor registrado con ese nombre comercial.");
            }

            proveedor.RazonSocial = razonSocial.Trim();
            proveedor.NombreComercial = nombreComercial.Trim();
            proveedor.TipoProveedor = tipoProveedor;
            proveedor.Telefono = telefono.Trim();
            proveedor.Email = LimpiarTexto(email);
            proveedor.NombreContacto = LimpiarTexto(nombreProveedor);
            proveedor.ApellidoContacto = LimpiarTexto(apellidoProveedor);
            proveedor.Direccion = direccion.Trim();

            _repositorio.Actualizar(proveedor);
        }

        public void CambiarEstadoProveedor(int idProveedor, bool nuevoEstado)
        {
            var proveedor = _repositorio.BuscarPorId(idProveedor)
                ?? throw new InvalidOperationException("El proveedor no fue encontrado.");

            if (proveedor.Activo == nuevoEstado)
            {
                string estadoTexto = nuevoEstado ? "habilitado" : "deshabilitado";
                throw new InvalidOperationException($"El proveedor ya se encuentra {estadoTexto}.");
            }

            _repositorio.CambiarEstado(idProveedor, nuevoEstado);
        }
    }
}