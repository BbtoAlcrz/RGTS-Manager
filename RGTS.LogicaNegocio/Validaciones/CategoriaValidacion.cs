using System;

namespace RGTS.LogicaNegocio.Validaciones
{
    public static class CategoriaValidacion
    {
        public static void Validar(string nombre, string descripcion)
        {
            // Valida nombre obligatorio
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre de la categoría es obligatorio.");

            // Valida longitud del nombre
            if (nombre.Trim().Length < 3 || nombre.Trim().Length > 50)
                throw new ArgumentException("El nombre debe contener entre 3 y 50 caracteres.");

            // Valida longitud de la descripción (opcional, pero con límite si se ingresa)
            if (!string.IsNullOrWhiteSpace(descripcion) && descripcion.Trim().Length > 200)
                throw new ArgumentException("La descripción no puede superar los 200 caracteres.");
        }
    }
}