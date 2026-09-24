
namespace RGTS.LogicaNegocio.Validaciones
{
    public static class ClienteValidacion
    {
        public static void Validar(string nombre, string apellido, string dni, string? telefono, string? email)
        {
            // Valida campos obligatorios vacíos o en blanco
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(dni))
                throw new ArgumentException("Nombre, Apellido y DNI son obligatorios");

            // Valida nombre
            if (nombre.Trim().Length < 3 || nombre.Trim().Length > 50)
                throw new ArgumentException("El nombre debe contener entre 3 y 50 caracteres");

            if (!RegexValidaciones.SoloTexto.IsMatch(nombre.Trim()))
                throw new ArgumentException("El nombre solo debe contener letras o espacios");

            // Valida apellido
            if (apellido.Trim().Length < 3 || apellido.Trim().Length > 50)
                throw new ArgumentException("El apellido debe contener entre 3 y 50 caracteres");

            if (!RegexValidaciones.SoloTexto.IsMatch(apellido.Trim()))
                throw new ArgumentException("El apellido solo debe contener letras o espacios");

            // Valida DNI
            if (!RegexValidaciones.Dni.IsMatch(dni.Trim()))
                throw new ArgumentException("El DNI debe ser numérico y contener entre 7 y 8 dígitos");

            // Email (opcional, pero si se ingresa debe tener formato válido)
            if (!string.IsNullOrWhiteSpace(email) && !RegexValidaciones.Email.IsMatch(email.Trim()))
                throw new ArgumentException("El correo electrónico no posee un formato válido.");

            // Teléfono (opcional, pero si se ingresa se valida longitud y caracteres)
            if (!string.IsNullOrWhiteSpace(telefono) && !RegexValidaciones.Telefono.IsMatch(telefono.Trim()))
                throw new ArgumentException("El teléfono debe ser válido y contener entre 7 y 15 dígitos");
        }
    }
}