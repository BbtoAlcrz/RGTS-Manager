using System;
using System.Collections.Generic;
using System.Linq;
using RGTS.Entidades;
using RGTS.LogicaNegocio.Validaciones;

namespace RGTS.LogicaNegocio.Servicios
{
    public class VentaServicio
    {
        // Reutilizamos el servicio central de productos
        private readonly ProductoServicio _productoServicio = new();

        // Ventas precargadas en memoria compartida
        private static readonly List<Venta> _historialVentasMemoria = new()
        {
            new Venta
            {
                IdVenta = 1,
                DniUsuario = "45020546",
                Usuario = new Usuario { Dni = "45020546", Nombre = "Benito", Apellido = "Alcaraz" },
                IdCliente = 2,
                Cliente = new Cliente { IdCliente = 2, DNI = "87654321", Nombre = "María", Apellido = "López" },
                Fecha = DateTime.Now.AddDays(-1),
                TotalDerivado = 139.98m,
                Detalles = new List<DetalleVenta>
                {
                    new DetalleVenta
                    {
                        IdDetalle = 1, IdVenta = 1, IdProducto = 3, Cantidad = 2, PrecioUnitario = 69.99m, SubtotalDerivado = 139.98m,
                        Producto = new Producto { IdProducto = 3, Codigo = "MAN-001", Nombre = "Joystick DualSense", Precio = 69.99m }
                    }
                }
            },
            new Venta
            {
                IdVenta = 2,
                DniUsuario = "41234567",
                Usuario = new Usuario { Dni = "41234567", Nombre = "Fausto", Apellido = "Avalos" },
                IdCliente = null,
                Cliente = null,
                Fecha = DateTime.Now,
                TotalDerivado = 599.99m,
                Detalles = new List<DetalleVenta>
                {
                    new DetalleVenta
                    {
                        IdDetalle = 2, IdVenta = 2, IdProducto = 1, Cantidad = 1, PrecioUnitario = 599.99m, SubtotalDerivado = 599.99m,
                        Producto = new Producto { IdProducto = 1, Codigo = "CONS-001", Nombre = "PlayStation 5", Precio = 599.99m }
                    }
                }
            }
        };

        // Busquedas de productos en ProductoServicio
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
            var producto = _productoServicio.ObtenerTodos().FirstOrDefault(p => p.IdProducto == idProducto);
            if (producto == null) return 0;
            return Math.Max(0, producto.StockActual - cantidadEnCarrito);
        }


        public DetalleVenta GenerarDetalle(Producto producto, int cantidad, List<DetalleVenta> carrito)
        {
            int yaEnCarrito = carrito.Where(d => d.IdProducto == producto.IdProducto).Sum(d => d.Cantidad);
            VentaValidacion.ValidarAgregarProducto(producto, cantidad, yaEnCarrito);

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
            int nuevoIdVenta = _historialVentasMemoria.Count > 0 ? _historialVentasMemoria.Max(v => v.IdVenta) + 1 : 1;

            var nuevaVenta = new Venta
            {
                IdVenta = nuevoIdVenta,
                DniUsuario = dniUsuario,
                Usuario = usuarioSesion ?? new Usuario { Dni = dniUsuario, Nombre = "Vendedor", Apellido = dniUsuario },
                IdCliente = cliente?.IdCliente,
                Cliente = cliente,
                Fecha = DateTime.Now,
                TotalDerivado = total,
                Detalles = new List<DetalleVenta>(detalles)
            };

            // Descontar inventario real en productoServicio
            foreach (var detalle in detalles)
            {
                _productoServicio.DescontarStock(detalle.IdProducto, detalle.Cantidad);
            }

            // Persistir la venta en el historial
            _historialVentasMemoria.Add(nuevaVenta);

            return nuevaVenta;
        }

        public List<Venta> ObtenerHistorialVentas(string? dniVendedor = null, string? filtroDniCliente = null, DateTime? fechaDesde = null, DateTime? fechaHasta = null)
        {
            IEnumerable<Venta> query = _historialVentasMemoria;

            if (!string.IsNullOrWhiteSpace(dniVendedor))
            {
                query = query.Where(v => v.DniUsuario == dniVendedor.Trim());
            }

            if (!string.IsNullOrWhiteSpace(filtroDniCliente))
            {
                string dniBuscado = filtroDniCliente.Trim();
                query = query.Where(v => v.Cliente != null && v.Cliente.DNI.Contains(dniBuscado));
            }

            if (fechaDesde.HasValue)
            {
                query = query.Where(v => v.Fecha.Date >= fechaDesde.Value.Date);
            }

            if (fechaHasta.HasValue)
            {
                query = query.Where(v => v.Fecha.Date <= fechaHasta.Value.Date);
            }

            return query.OrderByDescending(v => v.Fecha).ToList();
        }

        public List<(string Dni, string NombreCompleto)> ObtenerVendedoresConVentas()
        {
            return _historialVentasMemoria
                .GroupBy(v => v.DniUsuario)
                .Select(g => (
                    Dni: g.Key,
                    NombreCompleto: g.First().Usuario != null ? g.First().Usuario!.NombreCompleto : g.Key
                ))
                .ToList();
        }
    }
}