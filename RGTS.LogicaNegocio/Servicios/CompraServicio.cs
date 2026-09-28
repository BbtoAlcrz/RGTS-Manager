using System;
using System.Collections.Generic;
using System.Linq;
using RGTS.Entidades;
using RGTS.LogicaNegocio.Validaciones;

namespace RGTS.LogicaNegocio.Servicios
{
    public class CompraServicio
    {
        private readonly ProductoServicio _productoServicio = new();

        // Colecciones compartidas en memoria
        private static readonly List<Compra> _comprasMemoria = new()
        {
            new Compra { IdCompra = 1, DniUsuario = "Carlos", IdProveedor = 1, NombreProveedor = "TechImport SA", Fecha = DateTime.Today.AddDays(-5), Total = 450000m, Estado = "Pendiente" },
            new Compra { IdCompra = 2, DniUsuario = "María", IdProveedor = 2, NombreProveedor = "Gamer Distribuidora", Fecha = DateTime.Today.AddDays(-2), Total = 120000m, Estado = "Recibida" },
            new Compra { IdCompra = 3, DniUsuario = "Carlos", IdProveedor = 3, NombreProveedor = "ElectroSur", Fecha = DateTime.Today, Total = 89000m, Estado = "Cancelada" }
        };

        private static readonly Dictionary<int, List<DetalleCompra>> _detallesPorCompraMemoria = new()
        {
            { 1, new List<DetalleCompra> {
                new DetalleCompra { IdDetalleCompra = 1, IdProducto = 1, CodigoProducto = "CONS-001", NombreProducto = "PlayStation 5", Cantidad = 3, CostoUnitario = 150000m }
            }},
            { 2, new List<DetalleCompra> {
                new DetalleCompra { IdDetalleCompra = 2, IdProducto = 2, CodigoProducto = "MAN-001", NombreProducto = "Joystick DualSense", Cantidad = 6, CostoUnitario = 20000m }
            }},
            { 3, new List<DetalleCompra> {
                new DetalleCompra { IdDetalleCompra = 3, IdProducto = 3, CodigoProducto = "PORT-001", NombreProducto = "Nintendo Switch OLED", Cantidad = 1, CostoUnitario = 89000m }
            }}
        };

        public List<Compra> ObtenerCompras(DateTime fechaDesde, DateTime fechaHasta, int? idProveedor = null)
        {
            DateTime desde = fechaDesde.Date;
            DateTime hasta = fechaHasta.Date;

            IEnumerable<Compra> query = _comprasMemoria.Where(c => c.Fecha.Date >= desde && c.Fecha.Date <= hasta);

            if (idProveedor.HasValue && idProveedor.Value > 0)
            {
                query = query.Where(c => c.IdProveedor == idProveedor.Value);
            }

            return query.OrderByDescending(c => c.Fecha).ToList();
        }

        public List<DetalleCompra> ObtenerDetallesPorCompra(int idCompra)
        {
            if (_detallesPorCompraMemoria.TryGetValue(idCompra, out var detalles))
            {
                return detalles.ToList();
            }

            return new List<DetalleCompra>();
        }

        //Confirmar recepción actualizando automáticamente el stock
        public void CambiarEstadoCompra(int idCompra, string nuevoEstado)
        {
            var compra = _comprasMemoria.FirstOrDefault(c => c.IdCompra == idCompra)
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
                if (_detallesPorCompraMemoria.TryGetValue(idCompra, out var detalles))
                {
                    foreach (var item in detalles)
                    {
                        _productoServicio.IncrementarStock(item.IdProducto, item.Cantidad);
                    }
                }
            }

            compra.Estado = nuevoEstado;
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

            int nuevoId = _comprasMemoria.Count > 0 ? _comprasMemoria.Max(c => c.IdCompra) + 1 : 1;
            decimal totalCalculado = detalles!.Sum(d => d.Cantidad * d.CostoUnitario);

            var nuevaCompra = new Compra
            {
                IdCompra = nuevoId,
                DniUsuario = dniUsuario,
                IdProveedor = proveedor!.IdProveedor,
                NombreProveedor = proveedor.NombreComercial,
                Fecha = DateTime.Now,
                Total = totalCalculado,
                Estado = "Pendiente"
            };

            _comprasMemoria.Add(nuevaCompra);
            _detallesPorCompraMemoria.Add(nuevoId, new List<DetalleCompra>(detalles));

            return nuevaCompra;
        }
    }
}