using System;
using System.Collections.Generic;
using System.Linq;
using RGTS.Entidades;
using RGTS.LogicaNegocio.Validaciones;

namespace RGTS.LogicaNegocio.Servicios
{
    public class CategoriaServicio
    {
        private static readonly List<Categoria> _categoriasMemoria = new()
        {
            new Categoria { IdCategoria = 1, NombreCategoria = "Consolas",  Descripcion = "Consolas de videojuegos", Activo = true },
            new Categoria { IdCategoria = 2, NombreCategoria = "Mandos",    Descripcion = "Mandos y controles", Activo = true },
            new Categoria { IdCategoria = 3, NombreCategoria = "Portátiles", Descripcion = "Consolas portátiles", Activo = true },
            new Categoria { IdCategoria = 4, NombreCategoria = "Accesorios", Descripcion = "Accesorios varios", Activo = true }
        };


        // Obtiene todas las categorías o filtra por nombre
        public List<Categoria> ObtenerTodas(string? filtroNombre = null, bool soloActivas = false)
        {
            IEnumerable<Categoria> query = _categoriasMemoria;

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
            return _categoriasMemoria.FirstOrDefault(c => c.IdCategoria == idCategoria);
        }


        // Valida y registra una nueva categoría
        public void RegistrarCategoria(string nombre, string descripcion)
        {
            CategoriaValidacion.Validar(nombre, descripcion);

            string nombreNormalizado = nombre.Trim();
            if (_categoriasMemoria.Any(c => c.NombreCategoria.Equals(nombreNormalizado, StringComparison.OrdinalIgnoreCase)))
            {
                throw new InvalidOperationException("Ya existe una categoría registrada con ese nombre");
            }

            int nuevoId = _categoriasMemoria.Count > 0 ? _categoriasMemoria.Max(c => c.IdCategoria) + 1 : 1;

            var nuevaCategoria = new Categoria
            {
                IdCategoria = nuevoId,
                NombreCategoria = nombreNormalizado,
                Descripcion = descripcion?.Trim() ?? string.Empty,
                Activo = true
            };

            _categoriasMemoria.Add(nuevaCategoria);
        }


        // Valida y modifica una categoría existente
        public void ModificarCategoria(int idCategoria, string nombre, string descripcion)
        {
            CategoriaValidacion.Validar(nombre, descripcion);

            var categoria = _categoriasMemoria.FirstOrDefault(c => c.IdCategoria == idCategoria)
                ?? throw new InvalidOperationException("No se encontró la categoría a modificar");

            string nombreNormalizado = nombre.Trim();
            if (_categoriasMemoria.Any(c => c.NombreCategoria.Equals(nombreNormalizado, StringComparison.OrdinalIgnoreCase) && c.IdCategoria != idCategoria))
            {
                throw new InvalidOperationException("Ya existe otra categoría registrada con ese nombre");
            }

            categoria.NombreCategoria = nombreNormalizado;
            categoria.Descripcion = descripcion?.Trim() ?? string.Empty;
        }

        // Baja / Reactivación
        public void CambiarEstadoCategoria(int idCategoria, bool nuevoEstado)
        {
            var categoria = _categoriasMemoria.FirstOrDefault(c => c.IdCategoria == idCategoria)
                ?? throw new InvalidOperationException("No se encontró la categoría");

            if (categoria.Activo == nuevoEstado)
            {
                string estadoTexto = nuevoEstado ? "activa" : "inactiva";
                throw new InvalidOperationException($"La categoría ya se encuentra {estadoTexto}");
            }

            categoria.Activo = nuevoEstado;
        }


        // el armado de entidad
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