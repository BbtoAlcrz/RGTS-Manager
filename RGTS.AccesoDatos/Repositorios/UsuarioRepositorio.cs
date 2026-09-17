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

       
        // Obtiene un usuario y su rol asociado mediante el Procedimiento Almacenado sp_ObtenerUsuarioPorEmail.
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
                                Dni = reader["dni"]?.ToString() ?? string.Empty,
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

        // Inserta un nuevo Usuario en la base de datos mediante el Procedimiento Almacenado sp_InsertarUsuario.
        public void Insertar(Usuario usuario)
        {
            using (SqlConnection conexion = _conexionBD.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("dbo.sp_InsertarUsuario", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.Add(new SqlParameter("@Dni", SqlDbType.VarChar, 20) { Value = usuario.Dni });
                    comando.Parameters.Add(new SqlParameter("@IdRol", SqlDbType.Int) { Value = usuario.IdRol });
                    comando.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar, 50) { Value = usuario.Nombre });
                    comando.Parameters.Add(new SqlParameter("@Apellido", SqlDbType.VarChar, 50) { Value = usuario.Apellido });
                    comando.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar, 100) { Value = usuario.Email });
                    comando.Parameters.Add(new SqlParameter("@ContrasenaHash", SqlDbType.VarChar, 255) { Value = usuario.ContrasenaHash });

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }


    }
}