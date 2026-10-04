using System;
using System.Collections.Generic;
using System.Linq;
using RGTS.AccesoDatos.Repositorios;
using RGTS.Entidades;
using RGTS.LogicaNegocio.Validaciones;

namespace RGTS.LogicaNegocio.Servicios
{
    public class CompraServicio
    {
        private readonly CompraRepositorio _repositorio;
        private readonly ProductoServicio _productoServicio = new();

        public CompraServicio()
        {
            _repositorio = new CompraRepositorio();
        }

        public List<Compra> ObtenerCompras(DateTime fechaDesde, DateTime fechaHasta, int? idProveedor = null)
        {
            return _repositorio.ObtenerCompras(fechaDesde, fechaHasta, idProveedor);
        }

        public List<DetalleCompra> ObtenerDetallesPorCompra(int idCompra)
        {
            return _repositorio.ObtenerDetallesPorCompra(idCompra);
        }

        // Confirmar recepción actualizando automáticamente el stock
        public void CambiarEstadoCompra(int idCompra, string nuevoEstado)
        {
            var compra = _repositorio.ObtenerPorId(idCompra)
                ?? throw new InvalidOperationException("No se encontró la compra especificada.");

            if (compra.Estado != "Pendiente")
            {
                throw new InvalidOperationException($"Solo se pueden modificar compras en estado Pendiente. La compra actual está {compra.Estado}.");
            }

            if (nuevoEstado != "Recibida" && nuevoEstado != "Cancelada")
            {
                throw new ArgumentException("El estado destino no es válido.");
            }

            // Si la compra se marca como recibida, impactamos el inventario
            if (nuevoEstado == "Recibida")
            {
                var detalles = _repositorio.ObtenerDetallesPorCompra(idCompra);
                foreach (var item in detalles)
                {
                    _productoServicio.IncrementarStock(item.IdProducto, item.Cantidad);
                }
            }

            _repositorio.CambiarEstado(idCompra, nuevoEstado);
        }

        public DetalleCompra ValidarYArmarItem(int idProveedorSeleccionado, Producto producto,
            string busquedaProducto, decimal costoUnitario, int cantidad, int correlativo)
        {
            CompraValidacion.ValidarItem(idProveedorSeleccionado, busquedaProducto, costoUnitario, cantidad);

            return new DetalleCompra
            {
                IdDetalleCompra = correlativo,
                IdProducto = producto.IdProducto,
                CodigoProducto = producto.Codigo,
                NombreProducto = producto.Nombre,
                Cantidad = cantidad,
                CostoUnitario = costoUnitario
            };
        }

        public void ValidarRegistro(int idProveedorSeleccionado, int cantidadItems)
        {
            CompraValidacion.ValidarRegistro(idProveedorSeleccionado, cantidadItems);
        }

        public Compra RegistrarCompra(string dniUsuario, Proveedor proveedor, List<DetalleCompra> detalles)
        {
            CompraValidacion.ValidarRegistro(proveedor?.IdProveedor ?? -1, detalles?.Count ?? 0);

            decimal totalCalculado = detalles!.Sum(d => d.Cantidad * d.CostoUnitario);

            int nuevoId = _repositorio.RegistrarCompra(dniUsuario, proveedor!.IdProveedor, totalCalculado, detalles);

            return new Compra
            {
                IdCompra = nuevoId,
                DniUsuario = dniUsuario,
                IdProveedor = proveedor.IdProveedor,
                NombreProveedor = proveedor.NombreComercial,
                Fecha = DateTime.Now,
                Total = totalCalculado,
                Estado = "Pendiente"
            };
        }
    }
}