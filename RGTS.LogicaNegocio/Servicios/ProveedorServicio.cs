using System;
using System.Collections.Generic;
using System.Linq;
using RGTS.Entidades;
using RGTS.LogicaNegocio.Validaciones;

namespace RGTS.LogicaNegocio.Servicios
{
    public class ProveedorServicio
    {
        // Colección única en memoria compartida durante la ejecución
        private static readonly List<Proveedor> _proveedoresMemoria = new()
        {
            new Proveedor
            {
                IdProveedor = 1,
                RazonSocial = "TechImport S.A.",
                NombreComercial = "TechImport SA",
                TipoProveedor = "Consolas de Mesa",
                Telefono = "11-4567-8901",
                Email = "contacto@techimport.com",
                NombreContacto = "Martín",
                ApellidoContacto = "Pérez",
                Direccion = "Av. Corrientes 1234, CABA",
                Activo = true
            },
            new Proveedor
            {
                IdProveedor = 2,
                RazonSocial = "Distribuidora Gamer S.R.L.",
                NombreComercial = "Gamer Distribuidora",
                TipoProveedor = "Mandos",
                Telefono = "11-9876-5432",
                Email = "ventas@gamerdist.com",
                NombreContacto = "Gonzalo",
                ApellidoContacto = "Rodríguez",
                Direccion = "Belgrano 456, Rosario",
                Activo = true
            },
            new Proveedor
            {
                IdProveedor = 3,
                RazonSocial = "ElectroSur Argentina S.A.",
                NombreComercial = "ElectroSur",
                TipoProveedor = "Accesorios",
                Telefono = "379-412-3456",
                Email = "info@electrosur.com",
                NombreContacto = "Claudia",
                ApellidoContacto = "Fernández",
                Direccion = "Junín 789, Corrientes",
                Activo = true
            }
        };

        private static string? LimpiarTexto(string? texto)
        {
            return string.IsNullOrWhiteSpace(texto) ? null : texto.Trim();
        }

        public List<Proveedor> ObtenerTodos(string? filtro = null)
        {
            IEnumerable<Proveedor> query = _proveedoresMemoria;

            if (!string.IsNullOrWhiteSpace(filtro))
            {
                string normalizado = filtro.Trim().ToLower();
                query = query.Where(p =>
                    (!string.IsNullOrEmpty(p.RazonSocial) && p.RazonSocial.ToLower().Contains(normalizado)) ||
                    (!string.IsNullOrEmpty(p.NombreComercial) && p.NombreComercial.ToLower().Contains(normalizado)) ||
                    (!string.IsNullOrEmpty(p.Telefono) && p.Telefono.Contains(normalizado))
                );
            }

            return query.OrderBy(p => p.NombreComercial).ToList();
        }

        public Proveedor? BuscarPorId(int idProveedor)
        {
            return _proveedoresMemoria.FirstOrDefault(p => p.IdProveedor == idProveedor);
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

            int nuevoId = _proveedoresMemoria.Count > 0 ? _proveedoresMemoria.Max(p => p.IdProveedor) + 1 : 1;

            Proveedor nuevoProveedor = new Proveedor
            {
                IdProveedor = nuevoId,
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

            _proveedoresMemoria.Add(nuevoProveedor);
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

            var proveedor = _proveedoresMemoria.FirstOrDefault(p => p.IdProveedor == idProveedor)
                ?? throw new InvalidOperationException("El proveedor a modificar no fue encontrado.");

            proveedor.RazonSocial = razonSocial.Trim();
            proveedor.NombreComercial = nombreComercial.Trim();
            proveedor.TipoProveedor = tipoProveedor;
            proveedor.Telefono = telefono.Trim();
            proveedor.Email = LimpiarTexto(email);
            proveedor.NombreContacto = LimpiarTexto(nombreProveedor);
            proveedor.ApellidoContacto = LimpiarTexto(apellidoProveedor);
            proveedor.Direccion = direccion.Trim();
        }

        public void CambiarEstadoProveedor(int idProveedor, bool nuevoEstado)
        {
            var proveedor = _proveedoresMemoria.FirstOrDefault(p => p.IdProveedor == idProveedor)
                ?? throw new InvalidOperationException("El proveedor no fue encontrado.");

            if (proveedor.Activo == nuevoEstado)
            {
                string estadoTexto = nuevoEstado ? "habilitado" : "deshabilitado";
                throw new InvalidOperationException($"El proveedor ya se encuentra {estadoTexto}.");
            }

            proveedor.Activo = nuevoEstado;
        }
    }
}