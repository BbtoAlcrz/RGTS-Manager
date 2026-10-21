using System;
using System.IO;
using System.Runtime.Versioning;
using System.Security.AccessControl;
using System.Security.Principal;
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

        [SupportedOSPlatform("windows")]
        private void AsegurarCarpetaTrabajo()
        {
            try
            {
                if (!Directory.Exists(CarpetaTemporal))
                {
                    Directory.CreateDirectory(CarpetaTemporal);
                }

                var info = new DirectoryInfo(CarpetaTemporal);
                var seguridad = info.GetAccessControl();
                var herencia = InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit;

                // Intenta dar permiso explícito a la instancia Express estándar
                bool permisoServicioAsignado = false;
                try
                {
                    var servicioSqlExpress = new NTAccount(@"NT SERVICE\MSSQL$SQLEXPRESS");
                    seguridad.AddAccessRule(new FileSystemAccessRule(
                        servicioSqlExpress, FileSystemRights.FullControl, herencia, PropagationFlags.None, AccessControlType.Allow));
                    permisoServicioAsignado = true;
                }
                catch (IdentityNotMappedException)
                {
                    // La instancia local no es SQLEXPRESS
                }

                // Intenta dar permiso explícito a la instancia por defecto (MSSQLSERVER) si la anterior no aplicó
                if (!permisoServicioAsignado)
                {
                    try
                    {
                        var servicioSqlDefault = new NTAccount(@"NT SERVICE\MSSQLSERVER");
                        seguridad.AddAccessRule(new FileSystemAccessRule(
                            servicioSqlDefault, FileSystemRights.FullControl, herencia, PropagationFlags.None, AccessControlType.Allow));
                    }
                    catch (IdentityNotMappedException)
                    {
                        // Instancia con nombre personalizado o entorno atípico
                    }
                }

                // Asigna permisos al grupo integrado de usuarios de Windows (la app C# que copia/borra)
                seguridad.AddAccessRule(new FileSystemAccessRule(
                    new SecurityIdentifier(WellKnownSidType.BuiltinUsersSid, null),
                    FileSystemRights.Modify, herencia, PropagationFlags.None, AccessControlType.Allow));

                // Asigna permisos a Usuarios Autenticados (Fallback universal para cualquier servicio local de SQL)
                seguridad.AddAccessRule(new FileSystemAccessRule(
                    new SecurityIdentifier(WellKnownSidType.AuthenticatedUserSid, null),
                    FileSystemRights.FullControl, herencia, PropagationFlags.None, AccessControlType.Allow));

                info.SetAccessControl(seguridad);
            }
            catch (Exception ex)
            {
                // Se registra para depuración interna sin romper el flujo si el SO restringe la modificación de ACL
                System.Diagnostics.Debug.WriteLine($"[BackupServicio] Advertencia al configurar ACLs: {ex.Message}");
            }
        }

        public void ExportarBackup(Usuario? usuario, string rutaDestino)
        {
            if (usuario == null || usuario.Rol?.NombreRol != "Administrador")
                throw new UnauthorizedAccessException("Solo un Administrador puede generar backups.");

            if (string.IsNullOrWhiteSpace(rutaDestino))
                throw new ArgumentException("Debe indicar dónde guardar el backup.");

            // Se crea la carpeta y se asegura permisos dinámicamente
            AsegurarCarpetaTrabajo();

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

            AsegurarCarpetaTrabajo();

            string temporal = Path.Combine(CarpetaTemporal, $"val_{Guid.NewGuid():N}.bak");
            try
            {
                File.Copy(rutaOrigen, temporal, overwrite: true);
                _repositorio.VerificarBackup(temporal);

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
            ValidarArchivoParaRestaurar(usuario, rutaOrigen);

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
                _repositorio.RealizarBackup(respaldoSeguridad);
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