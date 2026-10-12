using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using RGTS.AccesoDatos.Conexion;
using RGTS.Entidades;

namespace RGTS.AccesoDatos.Repositorios
{
    public class ReporteVentaRepositorio
    {
        private readonly ConexionBD _conexionBD;

        public ReporteVentaRepositorio()
        {
            _conexionBD = new ConexionBD();
        }

        public List<VentaReporteDto> ObtenerReporteVentas(DateTime fechaDesde, DateTime fechaHasta, string? dniVendedor = null)
        {
            var lista = new List<VentaReporteDto>();

            using (SqlConnection conexion = _conexionBD.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("dbo.sp_ReporteVentas", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.Add(new SqlParameter("@FechaDesde", SqlDbType.DateTime) { Value = fechaDesde });
                    comando.Parameters.Add(new SqlParameter("@FechaHasta", SqlDbType.DateTime) { Value = fechaHasta });

                    if (string.IsNullOrWhiteSpace(dniVendedor))
                        comando.Parameters.Add(new SqlParameter("@DniVendedor", SqlDbType.VarChar, 20) { Value = DBNull.Value });
                    else
                        comando.Parameters.Add(new SqlParameter("@DniVendedor", SqlDbType.VarChar, 20) { Value = dniVendedor.Trim() });

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new VentaReporteDto
                            {
                                IdVenta = Convert.ToInt32(reader["IdVenta"]),
                                Fecha = Convert.ToDateTime(reader["Fecha"]),
                                DniVendedor = reader["DniVendedor"]?.ToString() ?? string.Empty,
                                NombreVendedor = reader["NombreVendedor"]?.ToString() ?? string.Empty,
                                IdCliente = reader["IdCliente"] != DBNull.Value ? Convert.ToInt32(reader["IdCliente"]) : null,
                                NombreCliente = reader["NombreCliente"]?.ToString() ?? "Consumidor Final",
                                TotalVenta = Convert.ToDecimal(reader["TotalVenta"]),
                                IdProducto = Convert.ToInt32(reader["IdProducto"]),
                                CodigoProducto = reader["CodigoProducto"]?.ToString() ?? string.Empty,
                                NombreProducto = reader["NombreProducto"]?.ToString() ?? string.Empty,
                                IdCategoria = Convert.ToInt32(reader["IdCategoria"]),
                                NombreCategoria = reader["NombreCategoria"]?.ToString() ?? string.Empty,
                                Cantidad = Convert.ToInt32(reader["Cantidad"]),
                                PrecioUnitario = Convert.ToDecimal(reader["PrecioUnitario"]),
                                Subtotal = Convert.ToDecimal(reader["Subtotal"]),
                                PrecioCostoActual = Convert.ToDecimal(reader["PrecioCostoActual"])
                            });
                        }
                    }
                }
            }

            return lista;
        }
    }
}