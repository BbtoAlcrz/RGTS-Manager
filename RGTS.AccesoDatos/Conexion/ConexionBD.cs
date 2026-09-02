using Microsoft.Data.SqlClient;

namespace RGTS.AccesoDatos.Conexion
{
    public class ConexionBD
    {
        private readonly string _cadenaConexion =
            "Server=.\\SQLEXPRESS;Database=RGTS_Manager_BD;Integrated Security=True;TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(_cadenaConexion);
        }
    }
}

