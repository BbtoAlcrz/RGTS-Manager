using System;
using System.Collections.Generic;
using System.Linq;
using RGTS.AccesoDatos.Repositorios;
using RGTS.Entidades;
using RGTS.LogicaNegocio.Validaciones;

namespace RGTS.LogicaNegocio.Servicios
{
    public class CategoriaServicio
    {
        private readonly CategoriaRepositorio _categoriaRepositorio;

        public CategoriaServicio()
        {
            _categoriaRepositorio = new CategoriaRepositorio();
        }

        // Obtiene todas las categorías o filtra por nombre
        public List<Categoria> ObtenerTodas(string? filtroNombre = null, bool soloActivas = false)
        {
            IEnumerable<Categoria> query = _categoriaRepositorio.ObtenerTodas();

            if (soloActivas)
            {
                query = query.Where(c => c.Activo);
            }

            if (!string.IsNullOrWhiteSpace(filtroNombre))
            {
                string busqueda = filtroNombre.Trim().ToLower();
                query = query.Where(c => c.NombreCategoria.ToLower().Contains(busqueda));
            }

            return query.ToList();
        }

        public Categoria? ObtenerPorId(int idCategoria)
        {
            return _categoriaRepositorio.ObtenerPorId(idCategoria);
        }

        // Valida y registra una nueva categoría
        public void RegistrarCategoria(string nombre, string descripcion)
        {
            CategoriaValidacion.Validar(nombre, descripcion);

            string nombreNormalizado = nombre.Trim();
            var existentes = _categoriaRepositorio.ObtenerTodas();

            if (existentes.Any(c => c.NombreCategoria.Equals(nombreNormalizado, StringComparison.OrdinalIgnoreCase)))
            {
                throw new InvalidOperationException("Ya existe una categoría registrada con ese nombre");
            }

            var nuevaCategoria = new Categoria
            {
                NombreCategoria = nombreNormalizado,
                Descripcion = descripcion?.Trim() ?? string.Empty,
                Activo = true
            };

            _categoriaRepositorio.Insertar(nuevaCategoria);
        }

        // Valida y modifica una categoría existente
        public void ModificarCategoria(int idCategoria, string nombre, string descripcion)
        {
            CategoriaValidacion.Validar(nombre, descripcion);

            var categoria = _categoriaRepositorio.ObtenerPorId(idCategoria)
                ?? throw new InvalidOperationException("No se encontró la categoría a modificar");

            string nombreNormalizado = nombre.Trim();
            var existentes = _categoriaRepositorio.ObtenerTodas();

            if (existentes.Any(c => c.NombreCategoria.Equals(nombreNormalizado, StringComparison.OrdinalIgnoreCase) && c.IdCategoria != idCategoria))
            {
                throw new InvalidOperationException("Ya existe otra categoría registrada con ese nombre");
            }

            categoria.NombreCategoria = nombreNormalizado;
            categoria.Descripcion = descripcion?.Trim() ?? string.Empty;

            _categoriaRepositorio.Actualizar(categoria);
        }

        // Baja / Reactivación
        public void CambiarEstadoCategoria(int idCategoria, bool nuevoEstado)
        {
            var categoria = _categoriaRepositorio.ObtenerPorId(idCategoria)
                ?? throw new InvalidOperationException("No se encontró la categoría");

            if (categoria.Activo == nuevoEstado)
            {
                string estadoTexto = nuevoEstado ? "activa" : "inactiva";
                throw new InvalidOperationException($"La categoría ya se encuentra {estadoTexto}");
            }

            _categoriaRepositorio.CambiarEstado(idCategoria, nuevoEstado);
        }

        // Armado de entidad sin persistir (usado si algún formulario solo necesita validar + armar)
        public Categoria ValidarYArmarCategoria(int idCategoria, string nombre, string descripcion)
        {
            CategoriaValidacion.Validar(nombre, descripcion);

            return new Categoria
            {
                IdCategoria = idCategoria,
                NombreCategoria = nombre.Trim(),
                Descripcion = descripcion?.Trim() ?? string.Empty
            };
        }
    }
}