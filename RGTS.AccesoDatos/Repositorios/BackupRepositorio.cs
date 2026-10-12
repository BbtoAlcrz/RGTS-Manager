using System.Data;
using Microsoft.Data.SqlClient;
using RGTS.AccesoDatos.Conexion;

namespace RGTS.AccesoDatos.Repositorios
{
    public class BackupRepositorio
    {
        private readonly ConexionBD _conexionBD;

        public BackupRepositorio()
        {
            _conexionBD = new ConexionBD();
        }

        // El nombre de la BD no se puede parametrizar en BACKUP, por eso se escapa con corchetes
        private static string Quote(string nombre) => "[" + nombre.Replace("]", "]]") + "]";

        public void RealizarBackup(string rutaArchivo)
        {
            using (SqlConnection con = _conexionBD.ObtenerConexion())
            {
                con.Open();
                string sql = $"BACKUP DATABASE {Quote(con.Database)} TO DISK = @Ruta WITH INIT, CHECKSUM;";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.CommandTimeout = 300;
                    cmd.Parameters.Add(new SqlParameter("@Ruta", SqlDbType.NVarChar, 260) { Value = rutaArchivo });
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Comprueba que el archivo sea legible sin restaurar nada
        public void VerificarBackup(string rutaArchivo)
        {
            using (SqlConnection con = _conexionBD.ObtenerConexion())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("RESTORE VERIFYONLY FROM DISK = @Ruta WITH CHECKSUM;", con))
                {
                    cmd.CommandTimeout = 300;
                    cmd.Parameters.Add(new SqlParameter("@Ruta", SqlDbType.NVarChar, 260) { Value = rutaArchivo });
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}