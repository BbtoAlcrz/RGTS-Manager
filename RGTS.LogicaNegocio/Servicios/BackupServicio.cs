using System;
using System.IO;
using RGTS.AccesoDatos.Repositorios;
using RGTS.Entidades;

namespace RGTS.LogicaNegocio.Servicios
{
    public class BackupServicio
    {
        private readonly BackupRepositorio _repositorio = new();
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
    }
}