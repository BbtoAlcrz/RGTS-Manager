using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using RGTS.AccesoDatos.Conexion;
using RGTS.Entidades;

namespace RGTS.AccesoDatos.Repositorios
{
    public class ReporteProductoRepositorio
    {
        private readonly ConexionBD _conexionBD = new();

        public List<ProductoReporteDto> ObtenerReporteProductos(DateTime fechaDesde, DateTime fechaHasta)
        {
            var lista = new List<ProductoReporteDto>();

            using (SqlConnection conexion = _conexionBD.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("dbo.sp_ReporteProductos", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add(new SqlParameter("@FechaDesde", SqlDbType.DateTime) { Value = fechaDesde });
                    comando.Parameters.Add(new SqlParameter("@FechaHasta", SqlDbType.DateTime) { Value = fechaHasta });

                    conexion.Open();
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new ProductoReporteDto
                            {
                                IdProducto = Convert.ToInt32(reader["IdProducto"]),
                                Codigo = reader["Codigo"]?.ToString() ?? string.Empty,
                                NombreProducto = reader["NombreProducto"]?.ToString() ?? string.Empty,
                                NombreCategoria = reader["NombreCategoria"]?.ToString() ?? string.Empty,
                                PrecioVenta = Convert.ToDecimal(reader["PrecioVenta"]),
                                StockActual = Convert.ToInt32(reader["StockActual"]),
                                StockMinimo = Convert.ToInt32(reader["StockMinimo"]),
                                Activo = Convert.ToBoolean(reader["Activo"]),
                                UnidadesVendidasEnPeriodo = Convert.ToInt32(reader["UnidadesVendidasEnPeriodo"]),
                                TotalFacturadoEnPeriodo = Convert.ToDecimal(reader["TotalFacturadoEnPeriodo"])
                            });
                        }
                    }
                }
            }

            return lista;
        }
    }
}