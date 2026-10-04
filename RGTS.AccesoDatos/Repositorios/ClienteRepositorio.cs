using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using RGTS.AccesoDatos.Conexion;
using RGTS.Entidades;

namespace RGTS.AccesoDatos.Repositorios
{
    public class ClienteRepositorio
    {
        private readonly ConexionBD _conexionBD;

        public ClienteRepositorio()
        {
            _conexionBD = new ConexionBD();
        }

        // Obtiene todos los clientes, opcionalmente filtrados, mediante sp_ListarClientes
        public List<Cliente> ObtenerTodos(string? filtro = null)
        {
            var lista = new List<Cliente>();

            using (SqlConnection conexion = _conexionBD.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("dbo.sp_ListarClientes", conexion))
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
                            lista.Add(MapearCliente(reader));
                        }
                    }
                }
            }

            return lista;
        }

        // Obtiene un cliente puntual por id mediante sp_ObtenerClientePorId
        public Cliente? ObtenerPorId(int idCliente)
        {
            Cliente? cliente = null;

            using (SqlConnection conexion = _conexionBD.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("dbo.sp_ObtenerClientePorId", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add(new SqlParameter("@IdCliente", SqlDbType.Int) { Value = idCliente });

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cliente = MapearCliente(reader);
                        }
                    }
                }
            }

            return cliente;
        }

        // Busca un cliente activo por DNI mediante sp_ObtenerClientePorDni
        public Cliente? BuscarPorDni(string dni)
        {
            Cliente? cliente = null;

            using (SqlConnection conexion = _conexionBD.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("dbo.sp_ObtenerClientePorDni", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add(new SqlParameter("@Dni", SqlDbType.VarChar, 20) { Value = dni.Trim() });

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cliente = MapearCliente(reader);
                        }
                    }
                }
            }

            return cliente;
        }

        // Inserta un nuevo cliente mediante sp_InsertarCliente y devuelve el id generado
        public int Insertar(Cliente cliente)
        {
            int nuevoId;

            using (SqlConnection conexion = _conexionBD.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("dbo.sp_InsertarCliente", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    AgregarParametros(comando, cliente);

                    conexion.Open();
                    nuevoId = Convert.ToInt32(comando.ExecuteScalar());
                }
            }

            return nuevoId;
        }

        // Actualiza un cliente existente mediante sp_ActualizarCliente
        public void Actualizar(Cliente cliente)
        {
            using (SqlConnection conexion = _conexionBD.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("dbo.sp_ActualizarCliente", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add(new SqlParameter("@IdCliente", SqlDbType.Int) { Value = cliente.IdCliente });
                    AgregarParametros(comando, cliente);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        // Cambia el estado activo/inactivo mediante sp_CambiarEstadoCliente
        public void CambiarEstado(int idCliente, bool nuevoEstado)
        {
            using (SqlConnection conexion = _conexionBD.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("dbo.sp_CambiarEstadoCliente", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add(new SqlParameter("@IdCliente", SqlDbType.Int) { Value = idCliente });
                    comando.Parameters.Add(new SqlParameter("@NuevoEstado", SqlDbType.Bit) { Value = nuevoEstado });

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        // Centraliza la asignación de parámetros comunes entre Insertar y Actualizar
        private void AgregarParametros(SqlCommand comando, Cliente cliente)
        {
            comando.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar, 50) { Value = cliente.Nombre });
            comando.Parameters.Add(new SqlParameter("@Apellido", SqlDbType.VarChar, 50) { Value = cliente.Apellido });
            comando.Parameters.Add(new SqlParameter("@Dni", SqlDbType.VarChar, 20) { Value = cliente.DNI });
            comando.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.VarChar, 30) { Value = (object?)cliente.Telefono ?? DBNull.Value });
            comando.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar, 100) { Value = (object?)cliente.Email ?? DBNull.Value });
        }

        // Mapea una fila del SqlDataReader a un objeto Cliente
        private Cliente MapearCliente(SqlDataReader reader)
        {
            return new Cliente
            {
                IdCliente = Convert.ToInt32(reader["id_cliente"]),
                Nombre = reader["nombre"]?.ToString() ?? string.Empty,
                Apellido = reader["apellido"]?.ToString() ?? string.Empty,
                DNI = reader["dni"]?.ToString() ?? string.Empty,
                Telefono = reader["telefono"] == DBNull.Value ? null : reader["telefono"]?.ToString(),
                Email = reader["email"] == DBNull.Value ? null : reader["email"]?.ToString(),
                Estado = Convert.ToBoolean(reader["activo"])
            };
        }
    }
}