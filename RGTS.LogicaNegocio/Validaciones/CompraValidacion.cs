using RGTS.Entidades;
using System;

namespace RGTS.LogicaNegocio.Validaciones
{
    public static class CompraValidacion
    {
        // Valida los datos de un ítem antes de agregarlo al detalle de la compra
        public static void ValidarItem(int idProveedorSeleccionado, string busquedaProducto, decimal costoUnitario, int cantidad, int stockMaximo)
        {
            if (idProveedorSeleccionado <= 0)
                throw new ArgumentException("Debe seleccionar un proveedor válido.");

            if (string.IsNullOrWhiteSpace(busquedaProducto))
                throw new ArgumentException("Debe ingresar el código o nombre del producto.");

            if (costoUnitario <= 0)
                throw new ArgumentException("El costo unitario debe ser mayor a cero.");

            if (cantidad <= 0)
                throw new ArgumentException("La cantidad debe ser mayor a cero.");

            if (cantidad > stockMaximo)
                throw new ArgumentException($"La cantidad solicitada supera el stock máximo permitido ({stockMaximo}) para el producto seleccionado.");
        }

        // Valida que la compra tenga lo mínimo antes de registrarse
        public static void ValidarRegistro(int idProveedorSeleccionado, int cantidadItems)
        {
            if (idProveedorSeleccionado <= 0)
                throw new ArgumentException("Debe seleccionar un proveedor válido.");

            if (cantidadItems == 0)
                throw new ArgumentException("Debe añadir al menos un producto a la orden de compra.");
        }

        public static void ValidarEstadoCompra(Compra compra, int idCompra, string nuevoEstado)
        {
            if (compra.Estado != "Pendiente")
            {
                throw new InvalidOperationException($"Solo se pueden modificar compras en estado Pendiente. La compra actual está {compra.Estado}.");
            }

            if (nuevoEstado != "Recibida" && nuevoEstado != "Cancelada")
            {
                throw new ArgumentException("El estado destino no es válido.");
            }
        }

        // Valida que la nueva cantidad ingresada para un ítem del carrito sea coherente
        public static void ValidarModificacionCantidad(int nuevaCantidad, int stockMaximoPermitido)
        {
            if (nuevaCantidad <= 0)
            {
                throw new ArgumentException("La cantidad debe ser mayor a cero.");
            }

            if (nuevaCantidad > stockMaximoPermitido)
            {
                throw new InvalidOperationException($"La cantidad ingresada: ( {nuevaCantidad} ) supera el stock máximo disponible para este producto: ( {stockMaximoPermitido} )");
            }
        }
    }
}