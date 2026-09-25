using System.Collections.Generic;
using RGTS.AccesoDatos.Repositorios;
using RGTS.Entidades;
using RGTS.LogicaNegocio.Validaciones;

namespace RGTS.LogicaNegocio.Servicios
{
    public class ProductoServicio
    {
        private readonly ProductoRepositorio _repositorio;

        // TEMPORAL: servicio trabaja en memoria para esta entrega, reemplazar por _repositorio cuando se conecte la BD real
        private readonly List<Producto> _productos;
        private int _correlativoId = 7; // siguiente id libre (ya hay 6 de ejemplo)

        public ProductoServicio()
        {
            _repositorio = new ProductoRepositorio();

            // Inicializa datos de ejemplo en memoria
            _productos = new List<Producto>
            {
                new Producto { IdProducto = 1, Codigo = "CONS-001", Nombre = "PlayStation 5", Descripcion = "Consola Sony PS5", IdCategoria = 1, NombreCategoria = "Consolas", Precio = 599.99m, StockActual = 10, StockMinimo = 2, StockMaximo = 20, Activo = true },
                new Producto { IdProducto = 2, Codigo = "CONS-002", Nombre = "Xbox Series X", Descripcion = "Consola Microsoft", IdCategoria = 1, NombreCategoria = "Consolas", Precio = 499.99m, StockActual = 8, StockMinimo = 2, StockMaximo = 20, Activo = true },
                new Producto { IdProducto = 3, Codigo = "MAN-001", Nombre = "Joystick DualSense", Descripcion = "Control inalámbrico PS5", IdCategoria = 2, NombreCategoria = "Mandos", Precio = 69.99m, StockActual = 30, StockMinimo = 5, StockMaximo = 100, Activo = true },
                new Producto { IdProducto = 4, Codigo = "MAN-002", Nombre = "Xbox Controller", Descripcion = "Control Xbox Series", IdCategoria = 2, NombreCategoria = "Mandos", Precio = 59.99m, StockActual = 25, StockMinimo = 5, StockMaximo = 100, Activo = true },
                new Producto { IdProducto = 5, Codigo = "PORT-001", Nombre = "Nintendo Switch OLED", Descripcion = "Consola portátil Nintendo", IdCategoria = 3, NombreCategoria = "Portátiles", Precio = 349.99m, StockActual = 12, StockMinimo = 2, StockMaximo = 30, Activo = true },
                new Producto { IdProducto = 6, Codigo = "ACC-001", Nombre = "Cable HDMI 2.1", Descripcion = "Cable HDMI de alta velocidad", IdCategoria = 4, NombreCategoria = "Accesorios", Precio = 19.99m, StockActual = 100, StockMinimo = 10, StockMaximo = 500, Activo = true }
            };
        }

        // Valida los datos y registra un nuevo producto en la BD
        public void RegistrarProducto(string codigo, string nombre, string descripcion,
            int idCategoria, decimal precio, int stockActual, int stockMinimo, int stockMaximo)
        {
            // Verifica reglas de formato en Validaciones
            ProductoValidacion.Validar(codigo, nombre, descripcion, idCategoria, precio, stockActual, stockMinimo, stockMaximo);

            var nuevo = new Producto
            {
                IdProducto = _correlativoId++,
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

            // Buscar nombre de categoria en productos existentes
            var existing = _productos.Find(p => p.IdCategoria == idCategoria);
            nuevo.NombreCategoria = existing?.NombreCategoria ?? string.Empty;

            _productos.Add(nuevo);
        }

        // Valida los datos y modifica un producto existente en la BD
        public void ModificarProducto(int idProducto, string codigo, string nombre, string descripcion,
            int idCategoria, decimal precio, int stockActual, int stockMinimo, int stockMaximo)
        {
            // Verifica reglas de formato en Validaciones
            ProductoValidacion.Validar(codigo, nombre, descripcion, idCategoria, precio, stockActual, stockMinimo, stockMaximo);

            var producto = _productos.Find(p => p.IdProducto == idProducto);
            if (producto == null)
            {
                // No existe en memoria; no hacemos nada o lanzar según convenga
                throw new System.ArgumentException("Producto no encontrado para modificar.");
            }

            producto.Codigo = codigo.Trim();
            producto.Nombre = nombre.Trim();
            producto.Descripcion = descripcion?.Trim() ?? string.Empty;
            producto.IdCategoria = idCategoria;
            // Actualizar NombreCategoria buscando en productos existentes
            var existing = _productos.Find(p => p.IdCategoria == idCategoria && p.IdProducto != idProducto);
            producto.NombreCategoria = existing?.NombreCategoria ?? producto.NombreCategoria ?? string.Empty;
            producto.Precio = precio;
            producto.StockActual = stockActual;
            producto.StockMinimo = stockMinimo;
            producto.StockMaximo = stockMaximo;
            producto.Activo = true;
        }

        // Realiza la baja lógica de un producto (activo = 0)
        public void EliminarProducto(int idProducto)
        {
            var producto = _productos.Find(p => p.IdProducto == idProducto);
            if (producto != null)
            {
                producto.Activo = false;
            }
        }

        // TEMPORAL: trabaja en memoria. Cambia el estado activo/inactivo del producto (toggle)
        public void CambiarEstadoProducto(int idProducto, bool nuevoEstado)
        {
            var producto = _productos.FirstOrDefault(p => p.IdProducto == idProducto);
            if (producto == null)
                throw new ArgumentException("El producto no existe.");

            producto.Activo = nuevoEstado;
        }

        // Devuelve todos los productos con su categoría asociada
        public List<Producto> ListarProductos()
        {
            // Devuelve la lista en memoria
            return new List<Producto>(_productos);
        }

        // Devuelve productos filtrados por texto y/o categoría
        // idCategoria = 0 significa sin filtro de categoría
        public List<Producto> ListarPorFiltro(string texto, int idCategoria)
        {
            var consulta = _productos.AsReadOnly();
            var lista = new List<Producto>(consulta);

            if (!string.IsNullOrWhiteSpace(texto))
            {
                texto = texto.Trim();
                lista = lista.FindAll(p => p.Nombre.Contains(texto, System.StringComparison.OrdinalIgnoreCase)
                                          || p.Codigo.Contains(texto, System.StringComparison.OrdinalIgnoreCase));
            }

            if (idCategoria != 0)
            {
                lista = lista.FindAll(p => p.IdCategoria == idCategoria);
            }

            return lista;
        }
    }
}