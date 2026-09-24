using RGTS.Entidades;
using RGTS.LogicaNegocio.Validaciones;

namespace RGTS.LogicaNegocio.Servicios
{
    public class ClienteServicio
    {
        private static readonly List<Cliente> _clientesTemporales = new()
        {
            new Cliente { IdCliente = 1, DNI = "12345678", Nombre = "Carlos", Apellido = "Gómez", Estado = true },
            new Cliente { IdCliente = 2, DNI = "87654321", Nombre = "María", Apellido = "López", Estado = true },
            new Cliente { IdCliente = 3, DNI = "12131415", Nombre = "Julian", Apellido = "Alvarez", Estado = true},
            new Cliente { IdCliente = 4, DNI = "51413121", Nombre = "Tom", Apellido = "Holland", Estado = true}
        };

        // para la lista de clientes
        public List<Cliente> ObtenerTodos(string? filtro = null)
        {
            if (string.IsNullOrWhiteSpace(filtro))
                return _clientesTemporales.ToList();

            string busqueda = filtro.Trim().ToLower();
            return _clientesTemporales
                .Where(cliente =>
                    cliente.DNI.Contains(busqueda) ||
                    cliente.Nombre.ToLower().Contains(busqueda) ||
                    cliente.Apellido.ToLower().Contains(busqueda))
                .ToList();
        }

        // para buscar un cliente puntual por dni
        public Cliente? BuscarPorDni(string dni)
        {
            if (string.IsNullOrWhiteSpace(dni)) return null;
            return _clientesTemporales.FirstOrDefault(cliente => cliente.DNI == dni.Trim() && cliente.Estado);
        }

        // cambiar de estado activo a inactivo
        public void CambiarEstadoCliente(int idCliente, bool nuevoEstado)
        {
            var cliente = _clientesTemporales.FirstOrDefault(cliente => cliente.IdCliente == idCliente)
                ?? throw new InvalidOperationException("El cliente no fue encontrado.");

            if (cliente.Estado == nuevoEstado)
            {
                string estadoTexto = nuevoEstado ? "activo" : "inactivo";
                throw new InvalidOperationException($"El cliente ya se encuentra {estadoTexto}");
            }

            cliente.Estado = nuevoEstado;
        }


        // Valida los datos y arma la entidad Cliente
        public void RegistrarCliente(string nombre, string apellido, string dni, string? telefono, string? email)
        {
            ClienteValidacion.Validar(nombre, apellido, dni, telefono, email);

            if (_clientesTemporales.Any(cliente => cliente.DNI == dni.Trim()))
            {
                throw new InvalidOperationException("Un cliente ya se encuentra registrado con éste DNI");
            }

            // si es el primer cliente id = 1, sino el id anterior +1
            int idNuevoCliente = _clientesTemporales.Count > 0 ? _clientesTemporales.Max(cliente => cliente.IdCliente) + 1 : 1;
            
            _clientesTemporales.Add(new Cliente
            {
                IdCliente = idNuevoCliente,
                Nombre = nombre.Trim(),
                Apellido = apellido.Trim(),
                DNI = dni.Trim(),
                Telefono = telefono?.Trim(),
                Email = email?.Trim(),
                Estado = true
            });
        }

        public void ModificarCliente(int idCliente, string nombre, string apellido, string dni, string? telefono, string? email)
        {
            ClienteValidacion.Validar(nombre, apellido, dni, telefono, email);

            // busca en la lista temporal
            var cliente = _clientesTemporales.FirstOrDefault(cliente => cliente.IdCliente == idCliente)
                ?? throw new InvalidOperationException("Este cliente no fue encontrado");

            // Comprobar que no haya DNI duplicado con otro cliente
            if (_clientesTemporales.Any(cliente => cliente.DNI == dni.Trim() && cliente.IdCliente != idCliente))
            {
                throw new InvalidOperationException("El DNI ingresado ya pertenece a otro cliente");
            }

            cliente.Nombre = nombre.Trim();
            cliente.Apellido = apellido.Trim();
            cliente.DNI = dni.Trim();
            cliente.Telefono = telefono?.Trim();
            cliente.Email = email?.Trim();
        }
    }
}