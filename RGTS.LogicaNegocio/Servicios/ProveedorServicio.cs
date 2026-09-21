using System.Collections.Generic;
using RGTS.AccesoDatos.Repositorios;
using RGTS.Entidades;
using RGTS.LogicaNegocio.Validaciones;

namespace RGTS.LogicaNegocio.Servicios
{
    public class ProveedorServicio
    {
        //guarga posibles valores nulos de los datos opcionales
        private static string? LimpiarTexto(string? texto)
        {
            return string.IsNullOrWhiteSpace(texto) ? null : texto.Trim();
        }


        // funcion para registrar un proveedor nuevo, recibe sus datos del formulario y los valida
        public void RegistrarProveedor(
            string razonSocial,
            string nombreComercial,
            string tipoProveedor,
            string telefono,
            string? email,
            string? nombreProveedor,
            string? apellidoProveedor,
            string direccion)
        {
            
            ProveedorValidacion.Validar(razonSocial, nombreComercial, tipoProveedor, telefono, email, nombreProveedor, apellidoProveedor, direccion);

            Proveedor nuevoProveedor = new Proveedor
            {
                RazonSocial = razonSocial.Trim(),
                NombreComercial = nombreComercial.Trim(),
                TipoProveedor = tipoProveedor,
                Telefono = telefono.Trim(),
                Email = LimpiarTexto(email),
                NombreContacto = LimpiarTexto(nombreProveedor),
                ApellidoContacto = LimpiarTexto(apellidoProveedor),
                Direccion = direccion.Trim(),
                Activo = true
            };

            // y aca insertar en la lista temporal sin BD
            // proveedor.insertar(nuevoProveedor)
        }

        public void ModificarProveedor(
            string razonSocial,
            string nombreComercial,
            string tipoProveedor,
            string telefono,
            string? email,
            string? nombreProveedor,
            string? apellidoProveedor,
            string direccion)
        {

            ProveedorValidacion.Validar(razonSocial, nombreComercial, tipoProveedor, telefono, email, nombreProveedor, apellidoProveedor, direccion);

            Proveedor proveedorActualizado = new Proveedor
            {
                RazonSocial = razonSocial.Trim(),
                NombreComercial = nombreComercial.Trim(),
                TipoProveedor = tipoProveedor,
                Telefono = telefono.Trim(),
                Email = LimpiarTexto(email),
                NombreContacto = LimpiarTexto(nombreProveedor),
                ApellidoContacto = LimpiarTexto(apellidoProveedor),
                Direccion = direccion.Trim()
            };

            //proveedor.actualizar(proveedorActualizado)
        }

        // falta funcion para listar y para cambiar estado
    }
}
