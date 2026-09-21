using System;

namespace RGTS.LogicaNegocio.Validaciones
{
    public static class CompraValidacion
    {
        // Valida los datos de un ítem antes de agregarlo al detalle de la compra
        public static void ValidarItem(int idProveedorSeleccionado, string busquedaProducto, decimal costoUnitario, int cantidad)
        {
            if (idProveedorSeleccionado < 0)
                throw new ArgumentException("Debe seleccionar un proveedor.");

            if (string.IsNullOrWhiteSpace(busquedaProducto))
                throw new ArgumentException("Debe ingresar el código o nombre del producto.");

            if (costoUnitario <= 0)
                throw new ArgumentException("El costo unitario debe ser mayor a cero.");

            if (cantidad <= 0)
                throw new ArgumentException("La cantidad debe ser mayor a cero.");

            if (cantidad > 10000)
                throw new ArgumentException("La cantidad ingresada parece excesiva. Verifique el valor.");
        }

        // Valida que la compra tenga lo mínimo antes de registrarse
        public static void ValidarRegistro(int idProveedorSeleccionado, int cantidadItems)
        {
            if (idProveedorSeleccionado < 0)
                throw new ArgumentException("Debe seleccionar un proveedor.");

            if (cantidadItems == 0)
                throw new ArgumentException("Debe añadir al menos un producto a la orden de compra.");
        }
    }
}