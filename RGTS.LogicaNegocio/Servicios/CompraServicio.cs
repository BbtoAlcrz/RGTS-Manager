using System.Collections.Generic;
using RGTS.Entidades;
using RGTS.LogicaNegocio.Validaciones;

namespace RGTS.LogicaNegocio.Servicios
{
    public class CompraServicio
    {
        // Valida y arma un ítem de detalle para agregarlo a la orden de compra en construcción
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

        // Valida que la orden de compra esté lista para registrarse
        // Por ahora no persiste en BD (no existe CompraRepositorio todavía)
        public void ValidarRegistro(int idProveedorSeleccionado, int cantidadItems)
        {
            CompraValidacion.ValidarRegistro(idProveedorSeleccionado, cantidadItems);
        }
    }
}