using RGTS.Entidades;
using RGTS.LogicaNegocio.Validaciones;

namespace RGTS.LogicaNegocio.Servicios
{
    public class ClienteServicio
    {
        // Valida los datos y arma la entidad Cliente
        // Por ahora no persiste en BD (no existe ClienteRepositorio todavía)
        public Cliente ValidarYArmarCliente(int idCliente, string nombre, string apellido, string dni, string telefono, string email, bool estado)
        {
            ClienteValidacion.Validar(nombre, apellido, dni, telefono, email);

            return new Cliente
            {
                IdCliente = idCliente,
                Nombre = nombre.Trim(),
                Apellido = apellido.Trim(),
                DNI = dni.Trim(),
                Telefono = telefono?.Trim() ?? string.Empty,
                Email = email?.Trim() ?? string.Empty,
                Estado = estado
            };
        }
    }
}