using System;
using System.Data;
using Microsoft.Data.SqlClient;
using RGTS.AccesoDatos.Conexion;
using RGTS.Entidades;

namespace RGTS.AccesoDatos.Repositorios
{
    public class UsuarioRepositorio
    {
        private readonly ConexionBD _conexionBD;

        public UsuarioRepositorio()
        {
            _conexionBD = new ConexionBD();
        }

        /// <summary>
        /// Obtiene un usuario y su rol asociado mediante el Procedimiento Almacenado sp_ObtenerUsuarioPorEmail.
        /// </summary>
        public Usuario? ObtenerPorEmail(string email)
        {
            Usuario? usuario = null;

           // abre y cierra la conexión automaticamente
            using (SqlConnection conexion = _conexionBD.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("dbo.sp_ObtenerUsuarioPorEmail", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar, 100)
                    {
                        Value = email
                    });

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = new Usuario
                            {
                                IdUsuario = Convert.ToInt32(reader["id_usuario"]),
                                IdRol = Convert.ToInt32(reader["id_rol"]),
                                Nombre = reader["nombre"]?.ToString() ?? string.Empty,
                                Apellido = reader["apellido"]?.ToString() ?? string.Empty,
                                Email = reader["email"]?.ToString() ?? string.Empty,
                                ContrasenaHash = reader["contrasena_hash"]?.ToString() ?? string.Empty,
                                Activo = Convert.ToBoolean(reader["activo"]),
                                Rol = new Rol
                                {
                                    IdRol = Convert.ToInt32(reader["id_rol"]),
                                    NombreRol = reader["nombre_rol"]?.ToString() ?? string.Empty,
                                    DescripcionRol = reader["descripcion_rol"]?.ToString() ?? string.Empty
                                }
                            };
                        }
                    }
                }
            }

            return usuario;
        }
    }
}