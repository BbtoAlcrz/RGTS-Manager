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