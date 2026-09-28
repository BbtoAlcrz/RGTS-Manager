using System.Collections.Generic;
using RGTS.AccesoDatos.Repositorios;
using System.Linq;
using RGTS.Entidades;
using RGTS.LogicaNegocio.Validaciones;

namespace RGTS.LogicaNegocio.Servicios
{
    public class ProductoServicio
    {
        //private readonly ProductoRepositorio _repositorio;
       
            //_repositorio = new ProductoRepositorio();

            // Inicializa datos de ejemplo en memoria
            private static readonly List<Producto> _productos = new()
            {
                new Producto { IdProducto = 1, Codigo = "CONS-001", Nombre = "PlayStation 5", Descripcion = "Consola Sony PS5", IdCategoria = 1, NombreCategoria = "Consolas", Precio = 599.99m, StockActual = 10, StockMinimo = 2, StockMaximo = 20, Activo = true },
                new Producto { IdProducto = 2, Codigo = "CONS-002", Nombre = "Xbox Series X", Descripcion = "Consola Microsoft", IdCategoria = 1, NombreCategoria = "Consolas", Precio = 499.99m, StockActual = 8, StockMinimo = 2, StockMaximo = 20, Activo = true },
                new Producto { IdProducto = 3, Codigo = "MAN-001", Nombre = "Joystick DualSense", Descripcion = "Control inalámbrico PS5", IdCategoria = 2, NombreCategoria = "Mandos", Precio = 69.99m, StockActual = 30, StockMinimo = 5, StockMaximo = 100, Activo = true },
                new Producto { IdProducto = 4, Codigo = "MAN-002", Nombre = "Xbox Controller", Descripcion = "Control Xbox Series", IdCategoria = 2, NombreCategoria = "Mandos", Precio = 59.99m, StockActual = 25, StockMinimo = 5, StockMaximo = 100, Activo = true },
                new Producto { IdProducto = 5, Codigo = "PORT-001", Nombre = "Nintendo Switch OLED", Descripcion = "Consola portátil Nintendo", IdCategoria = 3, NombreCategoria = "Portátiles", Precio = 349.99m, StockActual = 12, StockMinimo = 2, StockMaximo = 30, Activo = true },
                new Producto { IdProducto = 6, Codigo = "ACC-001", Nombre = "Cable HDMI 2.1", Descripcion = "Cable HDMI de alta velocidad", IdCategoria = 4, NombreCategoria = "Accesorios", Precio = 19.99m, StockActual = 100, StockMinimo = 10, StockMaximo = 500, Activo = true }
            };

        public List<Producto> ObtenerTodos(string? filtroTexto = null, int idCategoria = 0)
        {
            IEnumerable<Producto> query = _productos;

            if (idCategoria > 0)
            {
                query = query.Where(p => p.IdCategoria == idCategoria);
            }

            if (!string.IsNullOrWhiteSpace(filtroTexto))
            {
                string busqueda = filtroTexto.Trim().ToLower();
                query = query.Where(p =>
                    p.Nombre.ToLower().Contains(busqueda) ||
                    p.Codigo.ToLower().Contains(busqueda));
            }

            return query.ToList();
        }

        public void RegistrarProducto(string codigo, string nombre, string descripcion,
            int idCategoria, decimal precio, int stockActual, int stockMinimo, int stockMaximo)
        {
            ProductoValidacion.Validar(codigo, nombre, descripcion, idCategoria, precio, stockActual, stockMinimo, stockMaximo);

            if (_productos.Any(p => p.Codigo.Equals(codigo.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                throw new InvalidOperationException("Ya existe un producto registrado con ese código.");
            }

            int idNuevo = _productos.Count > 0 ? _productos.Max(p => p.IdProducto) + 1 : 1;

            var nuevo = new Producto
            {
                IdProducto = idNuevo,
                Codigo = codigo.Trim(),
                Nombre = nombre.Trim(),
                Descripcion = descripcion?.Trim() ?? string.Empty,
                IdCategoria = idCategoria,
                Precio = precio,
                StockActual = stockActual,
                StockMinimo = stockMinimo,
                StockMaximo = stockMaximo,
                Activo = true
            };

            var existing = _productos.FirstOrDefault(p => p.IdCategoria == idCategoria);
            nuevo.NombreCategoria = existing?.NombreCategoria ?? string.Empty;

            _productos.Add(nuevo);
        }

        public void ModificarProducto(int idProducto, string codigo, string nombre, string descripcion,
            int idCategoria, decimal precio, int stockActual, int stockMinimo, int stockMaximo)
        {
            ProductoValidacion.Validar(codigo, nombre, descripcion, idCategoria, precio, stockActual, stockMinimo, stockMaximo);

            var producto = _productos.FirstOrDefault(p => p.IdProducto == idProducto)
                ?? throw new InvalidOperationException("El producto solicitado no fue encontrado.");

            if (_productos.Any(p => p.Codigo.Equals(codigo.Trim(), StringComparison.OrdinalIgnoreCase) && p.IdProducto != idProducto))
            {
                throw new InvalidOperationException("El código ingresado ya pertenece a otro producto.");
            }

            producto.Codigo = codigo.Trim();
            producto.Nombre = nombre.Trim();
            producto.Descripcion = descripcion?.Trim() ?? string.Empty;
            producto.IdCategoria = idCategoria;

            var existing = _productos.FirstOrDefault(p => p.IdCategoria == idCategoria && p.IdProducto != idProducto);
            producto.NombreCategoria = existing?.NombreCategoria ?? producto.NombreCategoria;

            producto.Precio = precio;
            producto.StockActual = stockActual;
            producto.StockMinimo = stockMinimo;
            producto.StockMaximo = stockMaximo;
        }

        public void CambiarEstadoProducto(int idProducto, bool nuevoEstado)
        {
            var producto = _productos.FirstOrDefault(p => p.IdProducto == idProducto)
                ?? throw new InvalidOperationException("El producto solicitado no fue encontrado.");

            if (producto.Activo == nuevoEstado)
            {
                string estadoTexto = nuevoEstado ? "activo" : "inactivo";
                throw new InvalidOperationException($"El producto ya se encuentra {estadoTexto}.");
            }

            producto.Activo = nuevoEstado;
        }


        public void IncrementarStock(int idProducto, int cantidad)
        {
            if (cantidad <= 0)
                throw new ArgumentException("La cantidad a ingresar debe ser mayor a cero");

            var producto = _productos.FirstOrDefault(p => p.IdProducto == idProducto)
                ?? throw new InvalidOperationException($"No se encontró el producto con ID {idProducto} en el inventario");

            if (producto.StockActual + cantidad > producto.StockMaximo)
            {
                throw new InvalidOperationException(
                    $"No se puede recibir {cantidad} unidades para '{producto.Nombre}'" +
                    $"Ésto superaría el stock máximo permitido de ({producto.StockMaximo})" +
                    $"Stock actual: {producto.StockActual}");
            }

            producto.StockActual += cantidad;
        }
    }
}