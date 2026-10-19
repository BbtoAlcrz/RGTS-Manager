using System;
using System.IO;
using RGTS.AccesoDatos.Repositorios;
using RGTS.Entidades;

namespace RGTS.LogicaNegocio.Servicios
{
    public class BackupServicio
    {
        private readonly BackupRepositorio _repositorio = new();
        private readonly AutenticacionServicio _autenticacionServicio = new();
        private const string CarpetaTemporal = @"C:\RGTS_Backups";

        public string NombreSugerido() => $"RGTS_Manager_BD_{DateTime.Now:yyyyMMdd_HHmm}.bak";

        // Genera el backup y lo deja en rutaDestino (la ruta que eligió el usuario)
        public void ExportarBackup(Usuario? usuario, string rutaDestino)
        {
            // Ajustá al nombre real de la propiedad del rol
            if (usuario == null || usuario.Rol?.NombreRol != "Administrador")
                throw new UnauthorizedAccessException("Solo un Administrador puede generar backups.");

            if (string.IsNullOrWhiteSpace(rutaDestino))
                throw new ArgumentException("Debe indicar dónde guardar el backup.");

            if (!Directory.Exists(CarpetaTemporal))
                throw new DirectoryNotFoundException(
                    $"No existe la carpeta de trabajo {CarpetaTemporal}. Hay que crearla y darle permisos al servicio de SQL Server.");

            string temporal = Path.Combine(CarpetaTemporal, $"tmp_{Guid.NewGuid():N}.bak");

            try
            {
                _repositorio.RealizarBackup(temporal);
                _repositorio.VerificarBackup(temporal);
                File.Copy(temporal, rutaDestino, overwrite: true);
            }
            finally
            {
                if (File.Exists(temporal)) File.Delete(temporal);
            }
        }

        public DateTime ValidarArchivoParaRestaurar(Usuario? usuario, string rutaOrigen)
        {
            if (usuario == null || usuario.Rol?.NombreRol != "Administrador")
                throw new UnauthorizedAccessException("Solo un Administrador puede restaurar la base de datos.");

            if (string.IsNullOrWhiteSpace(rutaOrigen) || !File.Exists(rutaOrigen))
                throw new FileNotFoundException("El archivo seleccionado no existe.");

            if (!Directory.Exists(CarpetaTemporal))
                throw new DirectoryNotFoundException($"No existe la carpeta de trabajo {CarpetaTemporal}.");

            string temporal = Path.Combine(CarpetaTemporal, $"val_{Guid.NewGuid():N}.bak");
            try
            {
                File.Copy(rutaOrigen, temporal, overwrite: true);
                _repositorio.VerificarBackup(temporal); // archivo íntegro

                var (nombreBD, fecha) = _repositorio.ObtenerCabecera(temporal);
                if (!string.Equals(nombreBD, _repositorio.ObtenerNombreBDActual(), StringComparison.OrdinalIgnoreCase))
                    throw new InvalidOperationException(
                        $"Este backup pertenece a la base '{nombreBD}', no a '{_repositorio.ObtenerNombreBDActual()}'.");

                return fecha;
            }
            finally
            {
                if (File.Exists(temporal)) File.Delete(temporal);
            }
        }

        public string RestaurarBackup(Usuario? usuario, string rutaOrigen, string contrasena)
        {
            // Se revalida todo, no se confía en que la UI ya lo hizo
            ValidarArchivoParaRestaurar(usuario, rutaOrigen);

            // Revalida la contraseña con el mismo servicio que usa el login (BCrypt)
            try
            {
                _autenticacionServicio.IniciarSesion(usuario!.Email, contrasena);
            }
            catch (UnauthorizedAccessException)
            {
                throw new UnauthorizedAccessException("La contraseña es incorrecta.");
            }

            string temporal = Path.Combine(CarpetaTemporal, $"tmp_{Guid.NewGuid():N}.bak");
            string respaldoSeguridad = Path.Combine(CarpetaTemporal, $"antes_de_restaurar_{DateTime.Now:yyyyMMdd_HHmmss}.bak");

            try
            {
                File.Copy(rutaOrigen, temporal, overwrite: true);
                _repositorio.RealizarBackup(respaldoSeguridad); // red de seguridad: estado actual antes de pisarlo
                _repositorio.RestaurarBackup(temporal);
            }
            finally
            {
                if (File.Exists(temporal)) File.Delete(temporal);
            }

            return respaldoSeguridad;
        }


    }
}