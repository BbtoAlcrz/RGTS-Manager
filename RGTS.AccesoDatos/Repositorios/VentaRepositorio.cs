using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using RGTS.AccesoDatos.Conexion;
using RGTS.Entidades;

namespace RGTS.AccesoDatos.Repositorios
{
    public class VentaRepositorio
    {
        private readonly ConexionBD _conexionBD;

        public VentaRepositorio()
        {
            _conexionBD = new ConexionBD();
        }

        // Obtiene el historial de ventas con filtros opcionales, resolviendo usuario y cliente por JOIN
        public List<Venta> ObtenerHistorial(string? dniVendedor = null, string? filtroDniCliente = null,
            DateTime? fechaDesde = null, DateTime? fechaHasta = null)
        {
            var lista = new List<Venta>();

            using (SqlConnection conexion = _conexionBD.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("dbo.sp_ListarVentas", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.Add(new SqlParameter("@DniVendedor", SqlDbType.VarChar, 20)
                    { Value = string.IsNullOrWhiteSpace(dniVendedor) ? DBNull.Value : dniVendedor.Trim() });

                    comando.Parameters.Add(new SqlParameter("@FiltroDniCliente", SqlDbType.VarChar, 20)
                    { Value = string.IsNullOrWhiteSpace(filtroDniCliente) ? DBNull.Value : filtroDniCliente.Trim() });

                    comando.Parameters.Add(new SqlParameter("@FechaDesde", SqlDbType.Date)
                    { Value = fechaDesde.HasValue ? fechaDesde.Value.Date : DBNull.Value });

                    comando.Parameters.Add(new SqlParameter("@FechaHasta", SqlDbType.Date)
                    { Value = fechaHasta.HasValue ? fechaHasta.Value.Date : DBNull.Value });

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(MapearVenta(reader));
                        }
                    }
                }
            }

            return lista;
        }

        // Obtiene el detalle de productos de una venta puntual
        public List<DetalleVenta> ObtenerDetallesPorVenta(int idVenta)
        {
            var lista = new List<DetalleVenta>();

            using (SqlConnection conexion = _conexionBD.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("dbo.sp_ObtenerDetalleVenta", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add(new SqlParameter("@IdVenta", SqlDbType.Int) { Value = idVenta });

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new DetalleVenta
                            {
                                IdDetalle = Convert.ToInt32(reader["id_detalle"]),
                                IdVenta = Convert.ToInt32(reader["id_venta"]),
                                IdProducto = Convert.ToInt32(reader["id_producto"]),
                                Cantidad = Convert.ToInt32(reader["cantidad"]),
                                PrecioUnitario = Convert.ToDecimal(reader["precio_unitario"]),
                                SubtotalDerivado = Convert.ToDecimal(reader["subtotal_derivado"]),
                                Producto = new Producto
                                {
                                    IdProducto = Convert.ToInt32(reader["id_producto"]),
                                    Codigo = reader["codigo_producto"]?.ToString() ?? string.Empty,
                                    Nombre = reader["nombre_producto"]?.ToString() ?? string.Empty
                                }
                            });
                        }
                    }
                }
            }

            return lista;
        }

        // Inserta la cabecera de la venta y todos sus ítems de detalle en una sola transacción
        public int RegistrarVenta(string dniUsuario, int? idCliente, decimal total, string metodoPago, List<DetalleVenta> detalles)
        {
            int nuevoId;

            using (SqlConnection conexion = _conexionBD.ObtenerConexion())
            {
                conexion.Open();
                using (SqlTransaction transaccion = conexion.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand comandoCabecera = new SqlCommand("dbo.sp_InsertarVenta", conexion, transaccion))
                        {
                            comandoCabecera.CommandType = CommandType.StoredProcedure;
                            comandoCabecera.Parameters.Add(new SqlParameter("@DniUsuario", SqlDbType.VarChar, 20) { Value = dniUsuario });
                            comandoCabecera.Parameters.Add(new SqlParameter("@IdCliente", SqlDbType.Int)
                            { Value = idCliente.HasValue ? idCliente.Value : DBNull.Value });
                            comandoCabecera.Parameters.Add(new SqlParameter("@TotalDerivado", SqlDbType.Decimal) { Value = total });
                            comandoCabecera.Parameters.Add(new SqlParameter("@MetodoPago", SqlDbType.VarChar, 30)
                            { Value = (object?)metodoPago ?? DBNull.Value });

                            nuevoId = Convert.ToInt32(comandoCabecera.ExecuteScalar());
                        }

                        foreach (var item in detalles)
                        {
                            using (SqlCommand comandoDetalle = new SqlCommand("dbo.sp_InsertarDetalleVenta", conexion, transaccion))
                            {
                                comandoDetalle.CommandType = CommandType.StoredProcedure;
                                comandoDetalle.Parameters.Add(new SqlParameter("@IdVenta", SqlDbType.Int) { Value = nuevoId });
                                comandoDetalle.Parameters.Add(new SqlParameter("@IdProducto", SqlDbType.Int) { Value = item.IdProducto });
                                comandoDetalle.Parameters.Add(new SqlParameter("@Cantidad", SqlDbType.Int) { Value = item.Cantidad });
                                comandoDetalle.Parameters.Add(new SqlParameter("@PrecioUnitario", SqlDbType.Decimal) { Value = item.PrecioUnitario });

                                comandoDetalle.ExecuteNonQuery();
                            }
                        }

                        transaccion.Commit();
                    }
                    catch
                    {
                        transaccion.Rollback();
                        throw;
                    }
                }
            }

            return nuevoId;
        }

        // Lista los vendedores que registraron al menos una venta
        public List<(string Dni, string Nombre, string Apellido)> ObtenerVendedoresConVentas()
        {
            var lista = new List<(string, string, string)>();

            using (SqlConnection conexion = _conexionBD.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("dbo.sp_ObtenerVendedoresConVentas", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add((
                                reader["dni_usuario"]?.ToString() ?? string.Empty,
                                reader["nombre"]?.ToString() ?? string.Empty,
                                reader["apellido"]?.ToString() ?? string.Empty
                            ));
                        }
                    }
                }
            }

            return lista;
        }

        // Mapea una fila del SqlDataReader a un objeto Venta, con Usuario y Cliente resueltos
        private Venta MapearVenta(SqlDataReader reader)
        {
            var venta = new Venta
            {
                IdVenta = Convert.ToInt32(reader["id_venta"]),
                DniUsuario = reader["dni_usuario"]?.ToString() ?? string.Empty,
                Usuario = new Usuario
                {
                    Dni = reader["dni_usuario"]?.ToString() ?? string.Empty,
                    Nombre = reader["usuario_nombre"]?.ToString() ?? string.Empty,
                    Apellido = reader["usuario_apellido"]?.ToString() ?? string.Empty
                },
                Fecha = Convert.ToDateTime(reader["fecha"]),
                TotalDerivado = Convert.ToDecimal(reader["total_derivado"])
            };

            if (reader["id_cliente"] != DBNull.Value)
            {
                venta.IdCliente = Convert.ToInt32(reader["id_cliente"]);
                venta.Cliente = new Cliente
                {
                    IdCliente = venta.IdCliente.Value,
                    DNI = reader["cliente_dni"]?.ToString() ?? string.Empty,
                    Nombre = reader["cliente_nombre"]?.ToString() ?? string.Empty,
                    Apellido = reader["cliente_apellido"]?.ToString() ?? string.Empty
                };
            }

            return venta;
        }
    }
}