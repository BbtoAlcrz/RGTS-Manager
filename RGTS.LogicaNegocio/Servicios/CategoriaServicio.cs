using System.Collections.Generic;
using RGTS.Entidades;
using RGTS.LogicaNegocio.Validaciones;

namespace RGTS.LogicaNegocio.Servicios
{
    public class CategoriaServicio
    {
        // Valida los datos de una categoría nueva o editada
        // Por ahora no persiste en BD (no existe CategoriaRepositorio todavía)
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