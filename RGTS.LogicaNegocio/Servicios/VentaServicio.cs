using System;
using System.Collections.Generic;
using System.Linq;
using RGTS.Entidades;
using RGTS.LogicaNegocio.Validaciones;

namespace RGTS.LogicaNegocio.Servicios
{
    public class VentaServicio
    {
        // Datos temporales
        

        private readonly List<Producto> _catalogoTemporal = new()
        {
            new Producto { IdProducto = 1, Codigo = "CON-001", Nombre = "PlayStation 2 Slim", Precio = 85000m, StockActual = 10, Activo = true },
            new Producto { IdProducto = 2, Codigo = "CON-002", Nombre = "Nintendo GameCube", Precio = 120000m, StockActual = 4, Activo = true },
            new Producto { IdProducto = 3, Codigo = "MAN-001", Nombre = "Joystick DualShock 2", Precio = 15000m, StockActual = 25, Activo = true },
            new Producto { IdProducto = 4, Codigo = "ACC-001", Nombre = "Memory Card 8MB", Precio = 6000m, StockActual = 15, Activo = true }
        };

        // vetnas temporales para el historial
        private readonly List<Venta> _historialVentasMemoria = new()
        {
            new Venta
            {
                IdVenta = 1,
                DniUsuario = "45020546",
                Usuario = new Usuario { Dni = "45020546", Nombre = "Benito", Apellido = "Alcaraz" },
                IdCliente = 2,
                Cliente = new Cliente { IdCliente = 2, DNI = "87654321", Nombre = "María", Apellido = "López" },
                Fecha = DateTime.Now.AddDays(-1),
                TotalDerivado = 30000m,
                Detalles = new List<DetalleVenta>
                {
                    new DetalleVenta { IdDetalle = 2, IdVenta = 1, IdProducto = 3, Cantidad = 2, PrecioUnitario = 15000m, SubtotalDerivado = 30000m,
                        Producto = new Producto { Codigo = "MAN-001", Nombre = "Joystick DualShock 2", Precio = 15000m } }
                }
            },
            new Venta
            {
                IdVenta = 2,
                DniUsuario = "41234567", // Vendedor 1
                Usuario = new Usuario { Dni = "41234567", Nombre = "Fausto", Apellido = "Avalos" },
                IdCliente = null, // Consumidor Final
                Cliente = null,
                Fecha = DateTime.Now,
                TotalDerivado = 120000m,
                Detalles = new List<DetalleVenta>
                {
                    new DetalleVenta { IdDetalle = 3, IdVenta = 2, IdProducto = 2, Cantidad = 1, PrecioUnitario = 120000m, SubtotalDerivado = 120000m,
                        Producto = new Producto { Codigo = "CON-002", Nombre = "Nintendo GameCube", Precio = 120000m } }
                }
            }
        };



        public Producto? BuscarProducto(string filtro)
        {
            if (string.IsNullOrWhiteSpace(filtro)) return null;
            string normalizado = filtro.Trim().ToLower();

            return _catalogoTemporal.FirstOrDefault(p =>
                p.Activo && (p.Codigo.ToLower() == normalizado || p.Nombre.ToLower().Contains(normalizado)));
        }


        public int ObtenerStockDisponibleReal(int idProducto, int cantidadEnCarrito)
        {
            var producto = _catalogoTemporal.FirstOrDefault(p => p.IdProducto == idProducto);
            if (producto == null) return 0;
            return Math.Max(0, producto.StockActual - cantidadEnCarrito);
        }

        // inserta los productos a la lista del detalle de venta
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

        
        public Venta RegistrarVenta(string dniUsuario, Cliente? cliente, List<DetalleVenta> detalles, string metodoPago)
        {
            VentaValidacion.ValidarConfirmacionVenta(detalles, metodoPago, dniUsuario);

            decimal total = detalles.Sum(d => d.SubtotalDerivado);

            var nuevaVenta = new Venta
            {
                DniUsuario = dniUsuario,
                IdCliente = cliente?.IdCliente,
                Cliente = cliente,
                Fecha = DateTime.Now,
                TotalDerivado = total,
                Detalles = new List<DetalleVenta>(detalles)
            };

            // luego se usará _ventaRepositorio.Insertar(nuevaVenta))
            foreach (var detalle in detalles)
            {
                var prod = _catalogoTemporal.First(p => p.IdProducto == detalle.IdProducto);
                prod.StockActual -= detalle.Cantidad;
            }

            return nuevaVenta;
        }


        public List<Venta> ObtenerHistorialVentas(string? dniVendedor = null, string? filtroDniCliente = null, DateTime? fechaDesde = null, DateTime? fechaHasta = null)
        {
            IEnumerable<Venta> query = _historialVentasMemoria;

            // Filtro por vendedor: limita solo a sus ventas
            if (!string.IsNullOrWhiteSpace(dniVendedor))
            {
                query = query.Where(v => v.DniUsuario == dniVendedor.Trim());
            }

            // Filtro por DNI de cliente
            if (!string.IsNullOrWhiteSpace(filtroDniCliente))
            {
                string dniBuscado = filtroDniCliente.Trim();
                query = query.Where(v => v.Cliente != null && v.Cliente.DNI.Contains(dniBuscado));
            }

            // Filtro por rango de fechas
            if (fechaDesde.HasValue)
            {
                DateTime desde = fechaDesde.Value.Date;
                query = query.Where(v => v.Fecha.Date >= desde);
            }

            if (fechaHasta.HasValue)
            {
                DateTime hasta = fechaHasta.Value.Date;
                query = query.Where(v => v.Fecha.Date <= hasta);
            }

            return query.OrderByDescending(v => v.Fecha).ToList();
        }

    }
}