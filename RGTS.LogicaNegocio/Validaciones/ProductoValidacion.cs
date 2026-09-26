using System;

namespace RGTS.LogicaNegocio.Validaciones
{
    public static class ProductoValidacion
    {
        public static void Validar(
            string codigo,
            string nombre,
            string descripcion,
            int idCategoria,
            decimal precio,
            int stockActual,
            int stockMinimo,
            int stockMaximo)
        {
            // Valida campos obligatorios vacíos o en blanco
            if (string.IsNullOrWhiteSpace(codigo) || string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El código y el nombre del producto son obligatorios.");

            // Valida longitud del código
            if (codigo.Trim().Length > 50)
                throw new ArgumentException("El código no puede superar los 50 caracteres.");

            if (!RegexValidaciones.NoSoloNumeros.IsMatch(codigo.Trim()))
                 throw new ArgumentException("El código del producto no puede ser solo numerico");

            // Valida longitud del nombre
            if (nombre.Trim().Length < 3 || nombre.Trim().Length > 100)
                throw new ArgumentException("El nombre debe contener entre 3 y 100 caracteres.");

            if (!RegexValidaciones.NoSoloNumeros.IsMatch(nombre.Trim()))
                throw new ArgumentException("El nombre del producto no puede ser solo numerico");

            // Valida longitud de la descripción (opcional, pero si se ingresa tiene límite)
            if (!string.IsNullOrWhiteSpace(descripcion)){
                if(descripcion.Trim().Length > 255)
                throw new ArgumentException("La descripción no puede superar los 255 caracteres.");

                if (!RegexValidaciones.NoSoloNumeros.IsMatch(descripcion.Trim()))
                    throw new ArgumentException("La descripción del producto no puede ser solo numerica");
            }

            if (!RegexValidaciones.NoSoloNumeros.IsMatch(codigo))
                throw new ArgumentException("La descripción del producto no puede ser solo numerica");

            // Valida que se haya seleccionado una categoría válida
            if (idCategoria <= 0)
                throw new ArgumentException("Debe seleccionar una categoría válida.");

            // Valida precio
            if (precio <= 0)
                throw new ArgumentException("El precio debe ser mayor a cero.");

            
            // Valida stock mínimo no negativo
            if (stockMinimo < 0)
                throw new ArgumentException("El stock mínimo no puede ser negativo.");
            
            // Valida stock máximo mayor al mínimo
            if (stockMaximo <= 0)
                throw new ArgumentException("El stock máximo debe ser mayor a cero.");

            // Valida stock actual no negativo
            if (stockActual < 0)
                throw new ArgumentException("El stock actual no puede ser negativo.");

            if (stockActual > stockMaximo)
                throw new ArgumentException("El stock actual no puede superar al stock maximo establecido.");
            
            if (stockMaximo <= stockMinimo)
                throw new ArgumentException("El stock minimo no puede ser mayor o igual al stock máximo");

            if (stockActual < stockMinimo)
                throw new ArgumentException("El stock actual no puede ser menor al stock mínimo.");
        }
    }
}