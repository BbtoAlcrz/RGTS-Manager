using System;
using System.Collections.Generic;
using System.Linq;
using RGTS.AccesoDatos.Repositorios;
using RGTS.Entidades;
using RGTS.LogicaNegocio.Validaciones;

namespace RGTS.LogicaNegocio.Servicios
{
    public class ProductoServicio
    {
        private readonly ProductoRepositorio _repositorio;

        public ProductoServicio()
        {
            _repositorio = new ProductoRepositorio();
        }

        public List<Producto> ObtenerTodos(string? filtroTexto = null, int idCategoria = 0)
        {
            if (string.IsNullOrWhiteSpace(filtroTexto) && idCategoria == 0)
                return _repositorio.ObtenerTodos();

            return _repositorio.ObtenerPorFiltro(filtroTexto ?? "", idCategoria);
        }

        public void RegistrarProducto(string codigo, string nombre, string descripcion,
            int idCategoria, decimal precio, int stockActual, int stockMinimo, int stockMaximo)
        {
            ProductoValidacion.Validar(codigo, nombre, descripcion, idCategoria, precio, stockActual, stockMinimo, stockMaximo);

            var existentes = _repositorio.ObtenerTodos();
            if (existentes.Any(p => p.Codigo.Equals(codigo.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                throw new InvalidOperationException("Ya existe un producto registrado con ese código.");
            }

            var nuevo = new Producto
            {
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

            _repositorio.Insertar(nuevo);
        }

        public Producto? BuscarActivoParaVenta(string filtro)
        {
            if (string.IsNullOrWhiteSpace(filtro)) return null;

            var coincidencias = _repositorio.ObtenerActivosPorFiltro(filtro, 1);
            return coincidencias.FirstOrDefault();
        }

        public List<Producto> BuscarCoincidenciasActivos(string filtro, int maxResultados = 10)
        {
            if (string.IsNullOrWhiteSpace(filtro)) return new List<Producto>();
            return _repositorio.ObtenerActivosPorFiltro(filtro, maxResultados);
        }

        public void ModificarProducto(int idProducto, string codigo, string nombre, string descripcion,
            int idCategoria, decimal precio, int stockActual, int stockMinimo, int stockMaximo)
        {
            ProductoValidacion.Validar(codigo, nombre, descripcion, idCategoria, precio, stockActual, stockMinimo, stockMaximo);

            var producto = _repositorio.ObtenerPorId(idProducto)
                ?? throw new InvalidOperationException("El producto solicitado no fue encontrado.");

            var existentes = _repositorio.ObtenerTodos();
            if (existentes.Any(p => p.Codigo.Equals(codigo.Trim(), StringComparison.OrdinalIgnoreCase) && p.IdProducto != idProducto))
            {
                throw new InvalidOperationException("El código ingresado ya pertenece a otro producto.");
            }

            producto.Codigo = codigo.Trim();
            producto.Nombre = nombre.Trim();
            producto.Descripcion = descripcion?.Trim() ?? string.Empty;
            producto.IdCategoria = idCategoria;
            producto.Precio = precio;
            producto.StockActual = stockActual;
            producto.StockMinimo = stockMinimo;
            producto.StockMaximo = stockMaximo;

            _repositorio.Actualizar(producto);
        }

        public void CambiarEstadoProducto(int idProducto, bool nuevoEstado)
        {
            var producto = _repositorio.ObtenerPorId(idProducto)
                ?? throw new InvalidOperationException("El producto solicitado no fue encontrado.");

            if (producto.Activo == nuevoEstado)
            {
                string estadoTexto = nuevoEstado ? "activo" : "inactivo";
                throw new InvalidOperationException($"El producto ya se encuentra {estadoTexto}.");
            }

            _repositorio.CambiarEstado(idProducto, nuevoEstado);
        }

        public void IncrementarStock(int idProducto, int cantidad)
        {
            if (cantidad <= 0)
                throw new ArgumentException("La cantidad a ingresar debe ser mayor a cero");

            var producto = _repositorio.ObtenerPorId(idProducto)
                ?? throw new InvalidOperationException($"No se encontró el producto con ID {idProducto} en el inventario");

            if (producto.StockActual + cantidad > producto.StockMaximo)
            {
                throw new InvalidOperationException(
                    $"No se puede recibir {cantidad} unidades para '{producto.Nombre}'. " +
                    $"Esto superaría el stock máximo permitido de ({producto.StockMaximo}). " +
                    $"Stock actual: {producto.StockActual}");
            }

            _repositorio.ActualizarStock(idProducto, producto.StockActual + cantidad);
        }

        public void DescontarStock(int idProducto, int cantidad)
        {
            if (cantidad <= 0)
                throw new ArgumentException("La cantidad a descontar debe ser mayor a cero.");

            var producto = _repositorio.ObtenerPorId(idProducto)
                ?? throw new InvalidOperationException($"No se encontró el producto con ID {idProducto}.");

            if (producto.StockActual < cantidad)
            {
                throw new InvalidOperationException(
                    $"No hay stock suficiente para '{producto.Nombre}'. Stock actual: {producto.StockActual}, solicitado: {cantidad}.");
            }

            _repositorio.ActualizarStock(idProducto, producto.StockActual - cantidad);
        }

        // Reserva stock para el carrito; lanza excepción si no hay disponible suficiente
        public void ReservarStock(int idProducto, int cantidad)
        {
            var producto = _repositorio.ObtenerPorId(idProducto)
                ?? throw new InvalidOperationException("El producto solicitado no fue encontrado.");

            bool reservado = _repositorio.ReservarStock(idProducto, cantidad);
            if (!reservado)
            {
                int disponible = producto.StockActual - producto.StockReservado;
                throw new InvalidOperationException(
                    $"No hay stock suficiente para '{producto.Nombre}'. Disponible: {disponible}, solicitado: {cantidad}.");
            }
        }

        // Libera una reserva previa (cancelación de venta o quitar ítem del carrito)
        public void LiberarStock(int idProducto, int cantidad)
        {
            _repositorio.LiberarStock(idProducto, cantidad);
        }

        // Confirma la venta: descuenta stock real y libera la reserva
        public void ConfirmarStock(int idProducto, int cantidad)
        {
            _repositorio.ConfirmarStock(idProducto, cantidad);
        }
    }
}