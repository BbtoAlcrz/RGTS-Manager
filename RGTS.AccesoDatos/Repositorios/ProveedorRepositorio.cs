using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using RGTS.AccesoDatos.Conexion;
using RGTS.Entidades;

namespace RGTS.AccesoDatos.Repositorios
{
    public class ProveedorRepositorio
    {
        private readonly ConexionBD _conexionBD;

        public ProveedorRepositorio()
        {
            _conexionBD = new ConexionBD();
        }

        // Obtiene todos los proveedores, opcionalmente filtrados por texto, mediante sp_ListarProveedores
        public List<Proveedor> ObtenerTodos(string? filtro = null)
        {
            var lista = new List<Proveedor>();

            using (SqlConnection conexion = _conexionBD.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("dbo.sp_ListarProveedores", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    if (string.IsNullOrWhiteSpace(filtro))
                        comando.Parameters.Add(new SqlParameter("@Filtro", SqlDbType.VarChar, 100) { Value = DBNull.Value });
                    else
                        comando.Parameters.Add(new SqlParameter("@Filtro", SqlDbType.VarChar, 100) { Value = filtro.Trim() });

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(MapearProveedor(reader));
                        }
                    }
                }
            }

            return lista;
        }

        // Obtiene un proveedor puntual por id mediante sp_ObtenerProveedorPorId
        public Proveedor? BuscarPorId(int idProveedor)
        {
            Proveedor? proveedor = null;

            using (SqlConnection conexion = _conexionBD.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("dbo.sp_ObtenerProveedorPorId", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add(new SqlParameter("@IdProveedor", SqlDbType.Int) { Value = idProveedor });

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            proveedor = MapearProveedor(reader);
                        }
                    }
                }
            }

            return proveedor;
        }

        // Inserta un nuevo proveedor mediante sp_InsertarProveedor y devuelve el id generado
        public int Insertar(Proveedor proveedor)
        {
            int nuevoId;

            using (SqlConnection conexion = _conexionBD.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("dbo.sp_InsertarProveedor", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    AgregarParametros(comando, proveedor);

                    conexion.Open();
                    nuevoId = Convert.ToInt32(comando.ExecuteScalar());
                }
            }

            return nuevoId;
        }

        // Actualiza un proveedor existente mediante sp_ActualizarProveedor
        public void Actualizar(Proveedor proveedor)
        {
            using (SqlConnection conexion = _conexionBD.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("dbo.sp_ActualizarProveedor", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add(new SqlParameter("@IdProveedor", SqlDbType.Int) { Value = proveedor.IdProveedor });
                    AgregarParametros(comando, proveedor);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        // Cambia el estado activo/inactivo mediante sp_CambiarEstadoProveedor
        public void CambiarEstado(int idProveedor, bool nuevoEstado)
        {
            using (SqlConnection conexion = _conexionBD.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("dbo.sp_CambiarEstadoProveedor", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add(new SqlParameter("@IdProveedor", SqlDbType.Int) { Value = idProveedor });
                    comando.Parameters.Add(new SqlParameter("@NuevoEstado", SqlDbType.Bit) { Value = nuevoEstado });

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        // Centraliza la asignación de parámetros comunes entre Insertar y Actualizar
        private void AgregarParametros(SqlCommand comando, Proveedor proveedor)
        {
            comando.Parameters.Add(new SqlParameter("@RazonSocial", SqlDbType.VarChar, 100) { Value = proveedor.RazonSocial });
            comando.Parameters.Add(new SqlParameter("@NombreComercial", SqlDbType.VarChar, 100) { Value = proveedor.NombreComercial });
            comando.Parameters.Add(new SqlParameter("@TipoProveedor", SqlDbType.VarChar, 50) { Value = (object?)proveedor.TipoProveedor ?? DBNull.Value });
            comando.Parameters.Add(new SqlParameter("@NombreContacto", SqlDbType.VarChar, 50) { Value = (object?)proveedor.NombreContacto ?? DBNull.Value });
            comando.Parameters.Add(new SqlParameter("@ApellidoContacto", SqlDbType.VarChar, 50) { Value = (object?)proveedor.ApellidoContacto ?? DBNull.Value });
            comando.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.VarChar, 30) { Value = (object?)proveedor.Telefono ?? DBNull.Value });
            comando.Parameters.Add(new SqlParameter("@Correo", SqlDbType.VarChar, 100) { Value = (object?)proveedor.Email ?? DBNull.Value });
            comando.Parameters.Add(new SqlParameter("@Direccion", SqlDbType.VarChar, 150) { Value = (object?)proveedor.Direccion ?? DBNull.Value });
        }

        // Mapea una fila del SqlDataReader a un objeto Proveedor
        private Proveedor MapearProveedor(SqlDataReader reader)
        {
            return new Proveedor
            {
                IdProveedor = Convert.ToInt32(reader["id_proveedor"]),
                RazonSocial = reader["razon_social"]?.ToString() ?? string.Empty,
                NombreComercial = reader["nombre_comercial"]?.ToString() ?? string.Empty,
                TipoProveedor = reader["tipo_proveedor"] == DBNull.Value ? string.Empty : reader["tipo_proveedor"]?.ToString() ?? string.Empty,
                NombreContacto = reader["nombre_contacto"] == DBNull.Value ? null : reader["nombre_contacto"]?.ToString(),
                ApellidoContacto = reader["apellido_contacto"] == DBNull.Value ? null : reader["apellido_contacto"]?.ToString(),
                Telefono = reader["telefono"] == DBNull.Value ? string.Empty : reader["telefono"]?.ToString() ?? string.Empty,
                Email = reader["correo"] == DBNull.Value ? null : reader["correo"]?.ToString(),
                Direccion = reader["direccion"] == DBNull.Value ? string.Empty : reader["direccion"]?.ToString() ?? string.Empty,
                Activo = Convert.ToBoolean(reader["activo"])
            };
        }
    }
}