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

        public (string NombreBD, DateTime Fecha) ObtenerCabecera(string rutaArchivo)
        {
            using (SqlConnection con = _conexionBD.ObtenerConexion())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("RESTORE HEADERONLY FROM DISK = @Ruta;", con))
                {
                    cmd.Parameters.Add(new SqlParameter("@Ruta", SqlDbType.NVarChar, 260) { Value = rutaArchivo });
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                            throw new InvalidOperationException("El archivo no contiene un backup válido.");

                        return (reader["DatabaseName"].ToString() ?? "", Convert.ToDateTime(reader["BackupFinishDate"]));
                    }
                }
            }
        }

        public string ObtenerNombreBDActual()
        {
            using (SqlConnection con = _conexionBD.ObtenerConexion())
            {
                return con.Database;
            }
        }

        // Restaura la BD desde un .bak. Se conecta a master porque no se puede restaurar la BD en la que se está conectado.
        public void RestaurarBackup(string rutaArchivo)
        {
            string nombreBD;
            string cadenaMaster;

            using (SqlConnection conOrigen = _conexionBD.ObtenerConexion())
            {
                nombreBD = conOrigen.Database;
                var builder = new SqlConnectionStringBuilder(conOrigen.ConnectionString) { InitialCatalog = "master" };
                cadenaMaster = builder.ConnectionString;
            }

            SqlConnection.ClearAllPools(); // cierra las conexiones agrupadas de la propia app

            using (SqlConnection con = new SqlConnection(cadenaMaster))
            {
                con.Open();
                string bd = Quote(nombreBD);

                try
                {
                    using (SqlCommand cmd = new SqlCommand($"ALTER DATABASE {bd} SET SINGLE_USER WITH ROLLBACK IMMEDIATE;", con))
                        cmd.ExecuteNonQuery();

                    using (SqlCommand cmd = new SqlCommand($"RESTORE DATABASE {bd} FROM DISK = @Ruta WITH REPLACE;", con))
                    {
                        cmd.CommandTimeout = 600;
                        cmd.Parameters.Add(new SqlParameter("@Ruta", SqlDbType.NVarChar, 260) { Value = rutaArchivo });
                        cmd.ExecuteNonQuery();
                    }
                }
                finally
                {
                    // Pase lo que pase, la BD no puede quedar en modo un-solo-usuario
                    using (SqlCommand cmd = new SqlCommand($"ALTER DATABASE {bd} SET MULTI_USER;", con))
                        cmd.ExecuteNonQuery();
                }
            }
        }
    }
}