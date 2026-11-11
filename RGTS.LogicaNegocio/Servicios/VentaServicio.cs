using System;
using System.Collections.Generic;
using System.Linq;
using RGTS.AccesoDatos.Repositorios;
using RGTS.Entidades;
using RGTS.LogicaNegocio.Validaciones;

namespace RGTS.LogicaNegocio.Servicios
{
    public class VentaServicio
    {
        private readonly VentaRepositorio _repositorio;
        private readonly ProductoServicio _productoServicio = new();

        public VentaServicio()
        {
            _repositorio = new VentaRepositorio();
        }

        public Producto? BuscarProducto(string filtro)
        {
            return _productoServicio.BuscarActivoParaVenta(filtro);
        }

        // Cambia la cantidad de un ítem del carrito ajustando la reserva en la BD por la diferencia
        public void ModificarCantidadDetalle(DetalleVenta detalle, int nuevaCantidad, string dniUsuario)
        {
            VentaValidacion.ValidarModificacionCantidad(nuevaCantidad);

            int diferencia = nuevaCantidad - detalle.Cantidad;

            if (diferencia > 0)
            {
                // Reserva las unidades extra; si otro vendedor las tiene reservadas, lanza excepción y el carrito no cambia
                _productoServicio.ReservarStock(detalle.IdProducto, dniUsuario, diferencia);
            }
            else if (diferencia < 0)
            {
                // Devuelve las unidades que ya no se van a vender, para que otros vendedores puedan usarlas
                _productoServicio.ReducirReserva(detalle.IdProducto, dniUsuario, -diferencia);
            }

            detalle.Cantidad = nuevaCantidad;
            detalle.SubtotalDerivado = detalle.Cantidad * detalle.PrecioUnitario;
        }

        // Quita un ítem del carrito liberando primero su reserva en la BD
        public void EliminarDetalle(DetalleVenta detalle, List<DetalleVenta> carrito, string dniUsuario)
        {
            _productoServicio.ReducirReserva(detalle.IdProducto, dniUsuario, detalle.Cantidad);
            carrito.Remove(detalle);
        }

        public List<Producto> BuscarCoincidenciasProducto(string filtro, int maxResultados = 10)
        {
            return _productoServicio.BuscarCoincidenciasActivos(filtro, maxResultados);
        }

        public int ObtenerStockDisponibleReal(int idProducto, int cantidadEnCarrito)
        {
            // El reservado ya incluye el carrito de este usuario y el de los demás; por eso no se resta de nuevo
            var producto = _productoServicio.ObtenerTodos().FirstOrDefault(p => p.IdProducto == idProducto);
            if (producto == null) return 0;
            return Math.Max(0, producto.StockActual - producto.StockReservado);
        }

        public DetalleVenta GenerarDetalle(Producto producto, int cantidad, List<DetalleVenta> carrito, string dniUsuario)
        {
            _productoServicio.ReservarStock(producto.IdProducto, dniUsuario, cantidad);

            return new DetalleVenta
            {
                IdProducto = producto.IdProducto,
                Cantidad = cantidad,
                PrecioUnitario = producto.Precio,
                SubtotalDerivado = cantidad * producto.Precio,
                Producto = producto
            };
        }

        public Venta RegistrarVenta(string dniUsuario, Cliente? cliente, List<DetalleVenta> detalles, string metodoPago, Usuario? usuarioSesion = null)
        {
            VentaValidacion.ValidarConfirmacionVenta(detalles, metodoPago, dniUsuario);

            decimal total = detalles.Sum(d => d.SubtotalDerivado);

            int nuevoId = _repositorio.RegistrarVenta(dniUsuario, cliente?.IdCliente, total, metodoPago, detalles);

            return new Venta
            {
                IdVenta = nuevoId,
                DniUsuario = dniUsuario,
                Usuario = usuarioSesion ?? new Usuario { Dni = dniUsuario, Nombre = "Vendedor", Apellido = dniUsuario },
                IdCliente = cliente?.IdCliente,
                Cliente = cliente,
                Fecha = DateTime.Now,
                TotalDerivado = total,
                Detalles = new List<DetalleVenta>(detalles)
            };
        }

        public List<Venta> ObtenerHistorialVentas(string? dniVendedor = null, string? filtroDniCliente = null, DateTime? fechaDesde = null, DateTime? fechaHasta = null)
        {
            return _repositorio.ObtenerHistorial(dniVendedor, filtroDniCliente, fechaDesde, fechaHasta);
        }

        public List<DetalleVenta> ObtenerDetallesPorVenta(int idVenta)
        {
            return _repositorio.ObtenerDetallesPorVenta(idVenta);
        }

        public List<(string Dni, string NombreCompleto)> ObtenerVendedoresConVentas()
        {
            return _repositorio.ObtenerVendedoresConVentas()
                .Select(v => (v.Dni, NombreCompleto: $"{v.Nombre} {v.Apellido}"))
                .ToList();
        }

        public void LiberarReservasUsuario(string dniUsuario) => _productoServicio.LiberarReservasUsuario(dniUsuario);

        public void RenovarReservas(string dniUsuario) => _productoServicio.RenovarReservas(dniUsuario);
    }
}