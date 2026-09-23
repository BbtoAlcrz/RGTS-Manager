using RGTS.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace RGTS.LogicaNegocio.Validaciones
{
    public static class VentaValidacion
    {
        public static void ValidarAgregarProducto(Producto? producto, int cantidad, int cantidadYaEnCarrito)
        {
            if (producto == null)
            {
                throw new ArgumentException("Seleccione un producto válido");
            }

            if (!producto.Activo)
            {
                throw new InvalidOperationException("El producto seleccionado se encuentra dado de baja");
            }

            if (cantidad <= 0)
            {
                throw new ArgumentException("La cantidad debe ser mayor a 0");
            }

            int stockRestante = producto.StockActual - cantidadYaEnCarrito;
            if (cantidad > stockRestante)
            {
                throw new InvalidOperationException($"Stock insuficiente. Solo quedan {Math.Max(0, stockRestante)} unidades disponibles.");
            }
        }

        public static void ValidarConfirmacionVenta(List<DetalleVenta> detalles, string? metodoPago, string dniUsuario)
        {
            if (string.IsNullOrWhiteSpace(dniUsuario))
            {
                throw new InvalidOperationException("No se identifica al vendedor de esta sesión");
            }

            if (detalles == null || detalles.Count == 0)
            {
                throw new InvalidOperationException("El carrito está vacío. Agregue al menos un producto");
            }

            if (string.IsNullOrWhiteSpace(metodoPago))
            {
                throw new ArgumentException("Seleccione un método de pago válido");
            }

            foreach (var item in detalles)
            {
                if (item.Cantidad <= 0)
                {
                    throw new InvalidOperationException($"La cantidad para el ítem {item.Producto?.Nombre ?? item.IdProducto.ToString()} no es válida");
                }

                if (item.PrecioUnitario <= 0)
                {
                    throw new InvalidOperationException($"El precio unitario para el ítem {item.Producto?.Nombre ?? item.IdProducto.ToString()} es incorrecto");
                }
            }
        }
    }
}
