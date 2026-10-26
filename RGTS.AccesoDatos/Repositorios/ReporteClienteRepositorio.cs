using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using RGTS.AccesoDatos.Conexion;
using RGTS.Entidades;

namespace RGTS.AccesoDatos.Repositorios
{
    public class ReporteClienteRepositorio
    {
        private readonly ConexionBD _conexionBD;

        public ReporteClienteRepositorio()
        {
            _conexionBD = new ConexionBD();
        }

        public List<ClienteReporteDto> ObtenerReporteClientes(DateTime fechaDesde, DateTime fechaHasta)
        {
            var lista = new List<ClienteReporteDto>();

            using (SqlConnection conexion = _conexionBD.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("dbo.sp_ReporteClientes", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add(new SqlParameter("@FechaDesde", SqlDbType.DateTime) { Value = fechaDesde });
                    comando.Parameters.Add(new SqlParameter("@FechaHasta", SqlDbType.DateTime) { Value = fechaHasta });

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new ClienteReporteDto
                            {
                                IdCliente = Convert.ToInt32(reader["IdCliente"]),
                                Dni = reader["Dni"]?.ToString() ?? string.Empty,
                                Nombre = reader["Nombre"]?.ToString() ?? string.Empty,
                                Apellido = reader["Apellido"]?.ToString() ?? string.Empty,
                                NombreCompleto = reader["NombreCompleto"]?.ToString() ?? string.Empty,
                                ComprasEnPeriodo = Convert.ToInt32(reader["ComprasEnPeriodo"]),
                                ComprasHistoricas = Convert.ToInt32(reader["ComprasHistoricas"]),
                                TotalGastadoPeriodo = Convert.ToDecimal(reader["TotalGastadoPeriodo"])
                            });
                        }
                    }
                }
            }

            return lista;
        }
    }
}