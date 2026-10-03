using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using RGTS.AccesoDatos.Conexion;
using RGTS.Entidades;

namespace RGTS.AccesoDatos.Repositorios
{
    public class CategoriaRepositorio
    {
        private readonly ConexionBD _conexionBD;

        public CategoriaRepositorio()
        {
            _conexionBD = new ConexionBD();
        }

        // Obtiene todas las categorías (activas e inactivas) mediante sp_ListarCategorias
        public List<Categoria> ObtenerTodas()
        {
            var lista = new List<Categoria>();

            using (SqlConnection conexion = _conexionBD.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("dbo.sp_ListarCategorias", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(MapearCategoria(reader));
                        }
                    }
                }
            }

            return lista;
        }

        // Obtiene una categoría puntual por su id mediante sp_ObtenerCategoriaPorId
        public Categoria? ObtenerPorId(int idCategoria)
        {
            Categoria? categoria = null;

            using (SqlConnection conexion = _conexionBD.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("dbo.sp_ObtenerCategoriaPorId", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add(new SqlParameter("@IdCategoria", SqlDbType.Int) { Value = idCategoria });

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            categoria = MapearCategoria(reader);
                        }
                    }
                }
            }

            return categoria;
        }

        // Inserta una nueva categoría mediante sp_InsertarCategoria y devuelve el id generado
        public int Insertar(Categoria categoria)
        {
            int nuevoId;

            using (SqlConnection conexion = _conexionBD.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("dbo.sp_InsertarCategoria", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.Add(new SqlParameter("@NombreCategoria", SqlDbType.VarChar, 50) { Value = categoria.NombreCategoria });
                    comando.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar, 200) { Value = (object?)categoria.Descripcion ?? DBNull.Value });

                    conexion.Open();

                    // El SP devuelve el id generado con SELECT SCOPE_IDENTITY()
                    nuevoId = Convert.ToInt32(comando.ExecuteScalar());
                }
            }

            return nuevoId;
        }

        // Actualiza una categoría existente mediante sp_ActualizarCategoria
        public void Actualizar(Categoria categoria)
        {
            using (SqlConnection conexion = _conexionBD.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("dbo.sp_ActualizarCategoria", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.Add(new SqlParameter("@IdCategoria", SqlDbType.Int) { Value = categoria.IdCategoria });
                    comando.Parameters.Add(new SqlParameter("@NombreCategoria", SqlDbType.VarChar, 50) { Value = categoria.NombreCategoria });
                    comando.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar, 200) { Value = (object?)categoria.Descripcion ?? DBNull.Value });

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        // Cambia el estado activo/inactivo mediante sp_CambiarEstadoCategoria
        public void CambiarEstado(int idCategoria, bool nuevoEstado)
        {
            using (SqlConnection conexion = _conexionBD.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("dbo.sp_CambiarEstadoCategoria", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.Add(new SqlParameter("@IdCategoria", SqlDbType.Int) { Value = idCategoria });
                    comando.Parameters.Add(new SqlParameter("@NuevoEstado", SqlDbType.Bit) { Value = nuevoEstado });

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        // Mapea una fila del SqlDataReader a un objeto Categoria
        private Categoria MapearCategoria(SqlDataReader reader)
        {
            return new Categoria
            {
                IdCategoria = Convert.ToInt32(reader["id_categoria"]),
                NombreCategoria = reader["nombre_categoria"]?.ToString() ?? string.Empty,
                Descripcion = reader["descripcion"] == DBNull.Value ? string.Empty : reader["descripcion"]?.ToString() ?? string.Empty,
                Activo = Convert.ToBoolean(reader["activo"])
            };
        }
    }
}