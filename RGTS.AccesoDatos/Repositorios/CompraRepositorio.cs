using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using RGTS.AccesoDatos.Conexion;
using RGTS.Entidades;

namespace RGTS.AccesoDatos.Repositorios
{
    public class CompraRepositorio
    {
        private readonly ConexionBD _conexionBD;

        public CompraRepositorio()
        {
            _conexionBD = new ConexionBD();
        }

        // Obtiene las compras dentro de un rango de fechas, opcionalmente filtradas por proveedor
        public List<Compra> ObtenerCompras(DateTime fechaDesde, DateTime fechaHasta, int? idProveedor = null)
        {
            var lista = new List<Compra>();

            using (SqlConnection conexion = _conexionBD.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("dbo.sp_ListarCompras", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add(new SqlParameter("@FechaDesde", SqlDbType.Date) { Value = fechaDesde.Date });
                    comando.Parameters.Add(new SqlParameter("@FechaHasta", SqlDbType.Date) { Value = fechaHasta.Date });

                    if (idProveedor.HasValue && idProveedor.Value > 0)
                        comando.Parameters.Add(new SqlParameter("@IdProveedor", SqlDbType.Int) { Value = idProveedor.Value });
                    else
                        comando.Parameters.Add(new SqlParameter("@IdProveedor", SqlDbType.Int) { Value = DBNull.Value });

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(MapearCompra(reader));
                        }
                    }
                }
            }

            return lista;
        }

        // Obtiene una compra puntual por id, con el nombre de proveedor ya resuelto
        public Compra? ObtenerPorId(int idCompra)
        {
            Compra? compra = null;

            using (SqlConnection conexion = _conexionBD.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("dbo.sp_ObtenerCompraPorId", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add(new SqlParameter("@IdCompra", SqlDbType.Int) { Value = idCompra });

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            compra = MapearCompra(reader);
                        }
                    }
                }
            }

            return compra;
        }

        // Obtiene el detalle de productos de una compra, con código/nombre resueltos desde PRODUCTO
        public List<DetalleCompra> ObtenerDetallesPorCompra(int idCompra)
        {
            var lista = new List<DetalleCompra>();

            using (SqlConnection conexion = _conexionBD.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("dbo.sp_ObtenerDetalleCompra", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add(new SqlParameter("@IdCompra", SqlDbType.Int) { Value = idCompra });

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new DetalleCompra
                            {
                                IdDetalleCompra = Convert.ToInt32(reader["id_detalle_compra"]),
                                IdCompra = Convert.ToInt32(reader["id_compra"]),
                                IdProducto = Convert.ToInt32(reader["id_producto"]),
                                CodigoProducto = reader["codigo_producto"]?.ToString() ?? string.Empty,
                                NombreProducto = reader["nombre_producto"]?.ToString() ?? string.Empty,
                                Cantidad = Convert.ToInt32(reader["cantidad"]),
                                CostoUnitario = Convert.ToDecimal(reader["costo_unitario"])
                            });
                        }
                    }
                }
            }

            return lista;
        }

        // Cambia el estado de una compra (Pendiente -> Recibida/Cancelada)
        public void CambiarEstado(int idCompra, string nuevoEstado)
        {
            using (SqlConnection conexion = _conexionBD.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("dbo.sp_CambiarEstadoCompra", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add(new SqlParameter("@IdCompra", SqlDbType.Int) { Value = idCompra });
                    comando.Parameters.Add(new SqlParameter("@NuevoEstado", SqlDbType.VarChar, 30) { Value = nuevoEstado });

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        // Inserta la cabecera de la compra y todos sus ítems de detalle en una sola transacción.
        // Si algún ítem falla, se revierte todo (no queda una compra a medias en la base).
        public int RegistrarCompra(string dniUsuario, int idProveedor, decimal total, List<DetalleCompra> detalles)
        {
            int nuevoId;

            using (SqlConnection conexion = _conexionBD.ObtenerConexion())
            {
                conexion.Open();
                using (SqlTransaction transaccion = conexion.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand comandoCabecera = new SqlCommand("dbo.sp_InsertarCompra", conexion, transaccion))
                        {
                            comandoCabecera.CommandType = CommandType.StoredProcedure;
                            comandoCabecera.Parameters.Add(new SqlParameter("@DniUsuario", SqlDbType.VarChar, 20) { Value = dniUsuario });
                            comandoCabecera.Parameters.Add(new SqlParameter("@IdProveedor", SqlDbType.Int) { Value = idProveedor });
                            comandoCabecera.Parameters.Add(new SqlParameter("@TotalDerivado", SqlDbType.Decimal) { Value = total });

                            nuevoId = Convert.ToInt32(comandoCabecera.ExecuteScalar());
                        }

                        foreach (var item in detalles)
                        {
                            using (SqlCommand comandoDetalle = new SqlCommand("dbo.sp_InsertarDetalleCompra", conexion, transaccion))
                            {
                                comandoDetalle.CommandType = CommandType.StoredProcedure;
                                comandoDetalle.Parameters.Add(new SqlParameter("@IdCompra", SqlDbType.Int) { Value = nuevoId });
                                comandoDetalle.Parameters.Add(new SqlParameter("@IdProducto", SqlDbType.Int) { Value = item.IdProducto });
                                comandoDetalle.Parameters.Add(new SqlParameter("@Cantidad", SqlDbType.Int) { Value = item.Cantidad });
                                comandoDetalle.Parameters.Add(new SqlParameter("@CostoUnitario", SqlDbType.Decimal) { Value = item.CostoUnitario });

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

        // Mapea una fila del SqlDataReader a un objeto Compra
        private Compra MapearCompra(SqlDataReader reader)
        {
            return new Compra
            {
                IdCompra = Convert.ToInt32(reader["id_compra"]),
                DniUsuario = reader["dni_usuario"]?.ToString() ?? string.Empty,
                IdProveedor = Convert.ToInt32(reader["id_proveedor"]),
                NombreProveedor = reader["nombre_proveedor"]?.ToString() ?? string.Empty,
                Fecha = Convert.ToDateTime(reader["fecha"]),
                Total = Convert.ToDecimal(reader["total_derivado"]),
                Estado = reader["estado"]?.ToString() ?? string.Empty
            };
        }
    }
}