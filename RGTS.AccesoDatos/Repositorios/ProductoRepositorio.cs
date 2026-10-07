using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using RGTS.AccesoDatos.Conexion;
using RGTS.Entidades;

namespace RGTS.AccesoDatos.Repositorios
{
    public class ProductoRepositorio
    {
        private readonly ConexionBD _conexion;

        public ProductoRepositorio()
        {
            _conexion = new ConexionBD();
        }

        // Obtiene todos los productos con su categoría asociada mediante sp_ListarProductos
        public List<Producto> ObtenerTodos()
        {
            var lista = new List<Producto>();

            using (var con = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand("dbo.sp_ListarProductos", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        lista.Add(MapearProducto(reader));
                }
            }
            return lista;
        }

        // Obtiene productos filtrados por texto y/o categoría mediante sp_ListarProductosPorFiltro
        public List<Producto> ObtenerPorFiltro(string texto, int idCategoria)
        {
            var lista = new List<Producto>();

            using (var con = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand("dbo.sp_ListarProductosPorFiltro", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Texto", SqlDbType.VarChar, 100) { Value = texto ?? "" });
                cmd.Parameters.Add(new SqlParameter("@IdCategoria", SqlDbType.Int) { Value = idCategoria });
                con.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        lista.Add(MapearProducto(reader));
                }
            }
            return lista;
        }

        // Obtiene un producto puntual por id mediante sp_ObtenerProductoPorId
        public Producto? ObtenerPorId(int idProducto)
        {
            Producto? producto = null;

            using (var con = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand("dbo.sp_ObtenerProductoPorId", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@IdProducto", SqlDbType.Int) { Value = idProducto });
                con.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                        producto = MapearProducto(reader);
                }
            }
            return producto;
        }

        // Obtiene productos activos filtrados por texto mediante sp_ListarProductosActivosPorFiltro (usado en Ventas)
        public List<Producto> ObtenerActivosPorFiltro(string texto, int maxResultados = 10)
        {
            var lista = new List<Producto>();

            using (var con = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand("dbo.sp_ListarProductosActivosPorFiltro", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Texto", SqlDbType.VarChar, 100) { Value = texto ?? "" });
                cmd.Parameters.Add(new SqlParameter("@Max", SqlDbType.Int) { Value = maxResultados });
                con.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        lista.Add(MapearProducto(reader));
                }
            }
            return lista;
        }

        // Inserta un nuevo producto mediante sp_InsertarProducto y devuelve el id generado
        public int Insertar(Producto p)
        {
            int nuevoId;

            using (var con = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand("dbo.sp_InsertarProducto", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                AgregarParametros(cmd, p);
                con.Open();
                nuevoId = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return nuevoId;
        }

        // Actualiza los datos de un producto existente mediante sp_ActualizarProducto
        public void Actualizar(Producto p)
        {
            using (var con = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand("dbo.sp_ActualizarProducto", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@IdProducto", SqlDbType.Int) { Value = p.IdProducto });
                AgregarParametros(cmd, p);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Cambia el estado activo/inactivo mediante sp_CambiarEstadoProducto
        public void CambiarEstado(int idProducto, bool nuevoEstado)
        {
            using (var con = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand("dbo.sp_CambiarEstadoProducto", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@IdProducto", SqlDbType.Int) { Value = idProducto });
                cmd.Parameters.Add(new SqlParameter("@NuevoEstado", SqlDbType.Bit) { Value = nuevoEstado });
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Actualiza solamente el stock de un producto mediante sp_ActualizarStockProducto
        public void ActualizarStock(int idProducto, int nuevoStock)
        {
            using (var con = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand("dbo.sp_ActualizarStockProducto", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@IdProducto", SqlDbType.Int) { Value = idProducto });
                cmd.Parameters.Add(new SqlParameter("@NuevoStock", SqlDbType.Int) { Value = nuevoStock });
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Centraliza la asignación de parámetros comunes entre Insertar y Actualizar
        private void AgregarParametros(SqlCommand cmd, Producto p)
        {
            cmd.Parameters.Add(new SqlParameter("@IdCategoria", SqlDbType.Int) { Value = p.IdCategoria });
            cmd.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.VarChar, 50) { Value = p.Codigo });
            cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar, 100) { Value = p.Nombre });
            cmd.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar, 255) { Value = (object?)p.Descripcion ?? DBNull.Value });
            cmd.Parameters.Add(new SqlParameter("@Precio", SqlDbType.Decimal) { Value = p.Precio });
            cmd.Parameters.Add(new SqlParameter("@StockActual", SqlDbType.Int) { Value = p.StockActual });
            cmd.Parameters.Add(new SqlParameter("@StockMinimo", SqlDbType.Int) { Value = p.StockMinimo });
            cmd.Parameters.Add(new SqlParameter("@StockMaximo", SqlDbType.Int) { Value = p.StockMaximo });
        }
        // Reserva stock para un carrito en curso. Devuelve false si no había disponible suficiente
        // (la validación ocurre dentro del propio UPDATE en el SP, evitando condiciones de carrera
        // entre vendedores simultáneos).
        public bool ReservarStock(int idProducto, int cantidad)
        {
            using (var con = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand("dbo.sp_ReservarStockProducto", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@IdProducto", SqlDbType.Int) { Value = idProducto });
                cmd.Parameters.Add(new SqlParameter("@Cantidad", SqlDbType.Int) { Value = cantidad });
                con.Open();
                int filasAfectadas = Convert.ToInt32(cmd.ExecuteScalar());
                return filasAfectadas > 0;
            }
        }

        // Libera una reserva (al cancelar una venta o quitar un ítem del carrito)
        public void LiberarStock(int idProducto, int cantidad)
        {
            using (var con = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand("dbo.sp_LiberarStockProducto", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@IdProducto", SqlDbType.Int) { Value = idProducto });
                cmd.Parameters.Add(new SqlParameter("@Cantidad", SqlDbType.Int) { Value = cantidad });
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Confirma la venta: descuenta stock_actual y libera la reserva correspondiente
        public void ConfirmarStock(int idProducto, int cantidad)
        {
            using (var con = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand("dbo.sp_ConfirmarStockProducto", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@IdProducto", SqlDbType.Int) { Value = idProducto });
                cmd.Parameters.Add(new SqlParameter("@Cantidad", SqlDbType.Int) { Value = cantidad });
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        // Mapea una fila del SqlDataReader a un objeto Producto
        private Producto MapearProducto(SqlDataReader reader)
        {
            return new Producto
            {
                IdProducto = Convert.ToInt32(reader["id_producto"]),
                IdCategoria = Convert.ToInt32(reader["id_categoria"]),
                NombreCategoria = reader["nombre_categoria"]?.ToString() ?? string.Empty,
                Codigo = reader["codigo"]?.ToString() ?? string.Empty,
                Nombre = reader["nombre"]?.ToString() ?? string.Empty,
                Descripcion = reader["descripcion"] == DBNull.Value ? string.Empty : reader["descripcion"]?.ToString() ?? string.Empty,
                Precio = Convert.ToDecimal(reader["precio"]),
                StockActual = Convert.ToInt32(reader["stock_actual"]),
                StockMinimo = Convert.ToInt32(reader["stock_minimo"]),
                StockMaximo = Convert.ToInt32(reader["stock_maximo"]),
                StockReservado = Convert.ToInt32(reader["stock_reservado"]),
                Activo = Convert.ToBoolean(reader["activo"])
            };
        }
    }
}