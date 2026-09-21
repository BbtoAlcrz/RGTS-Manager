using System;
using System.Data;
using System.Collections.Generic;
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

        // Obtiene todos los productos con su categoría asociada mediante un JOIN entre PRODUCTO y CATEGORIA
        public List<Producto> ObtenerTodos()
        {
            var lista = new List<Producto>();
            string query = @"
                SELECT p.id_producto, p.id_categoria, c.nombre_categoria,
                       p.codigo, p.nombre, p.descripcion,
                       p.precio, p.stock_actual, p.stock_minimo, p.stock_maximo, p.activo
                FROM PRODUCTO p
                INNER JOIN CATEGORIA c ON p.id_categoria = c.id_categoria";

            // abre y cierra la conexión automáticamente
            using (var con = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(query, con))
            {
                con.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        lista.Add(MapearProducto(reader));
                }
            }
            return lista;
        }

        // Obtiene productos filtrados por texto (nombre o código) y/o por categoría
        // Si texto es vacío y idCategoria es 0, devuelve todos los productos
        public List<Producto> ObtenerPorFiltro(string texto, int idCategoria)
        {
            var lista = new List<Producto>();
            string query = @"
                SELECT p.id_producto, p.id_categoria, c.nombre_categoria,
                       p.codigo, p.nombre, p.descripcion,
                       p.precio, p.stock_actual, p.stock_minimo, p.stock_maximo, p.activo
                FROM PRODUCTO p
                INNER JOIN CATEGORIA c ON p.id_categoria = c.id_categoria
                WHERE (@Texto = '' OR p.nombre LIKE '%' + @Texto + '%' OR p.codigo LIKE '%' + @Texto + '%')
                  AND (@IdCategoria = 0 OR p.id_categoria = @IdCategoria)";

            using (var con = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(query, con))
            {
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

        // Inserta un nuevo producto en la base de datos
        public void Insertar(Producto p)
        {
            string query = @"
                INSERT INTO PRODUCTO (id_categoria, codigo, nombre, descripcion, precio, stock_actual, stock_minimo, stock_maximo, activo)
                VALUES (@IdCategoria, @Codigo, @Nombre, @Descripcion, @Precio, @StockActual, @StockMinimo, @StockMaximo, @Activo)";

            using (var con = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(query, con))
            {
                AgregarParametros(cmd, p);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Actualiza los datos de un producto existente identificado por su id_producto
        public void Actualizar(Producto p)
        {
            string query = @"
                UPDATE PRODUCTO SET
                    id_categoria = @IdCategoria,
                    codigo = @Codigo,
                    nombre = @Nombre,
                    descripcion = @Descripcion,
                    precio = @Precio,
                    stock_actual = @StockActual,
                    stock_minimo = @StockMinimo,
                    stock_maximo = @StockMaximo,
                    activo = @Activo
                WHERE id_producto = @IdProducto";

            using (var con = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(query, con))
            {
                AgregarParametros(cmd, p);
                cmd.Parameters.Add(new SqlParameter("@IdProducto", SqlDbType.Int) { Value = p.IdProducto });
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Realiza una baja lógica del producto: no elimina el registro, solo marca activo = 0
        public void Eliminar(int idProducto)
        {
            string query = "UPDATE PRODUCTO SET activo = 0 WHERE id_producto = @IdProducto";

            using (var con = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.Add(new SqlParameter("@IdProducto", SqlDbType.Int) { Value = idProducto });
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
            cmd.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar, 255) { Value = p.Descripcion ?? "" });
            cmd.Parameters.Add(new SqlParameter("@Precio", SqlDbType.Decimal) { Value = p.Precio });
            cmd.Parameters.Add(new SqlParameter("@StockActual", SqlDbType.Int) { Value = p.StockActual });
            cmd.Parameters.Add(new SqlParameter("@StockMinimo", SqlDbType.Int) { Value = p.StockMinimo });
            cmd.Parameters.Add(new SqlParameter("@StockMaximo", SqlDbType.Int) { Value = p.StockMaximo });
            cmd.Parameters.Add(new SqlParameter("@Activo", SqlDbType.Bit) { Value = p.Activo });
        }

        // Mapea una fila del SqlDataReader a un objeto Producto
        // descripcion puede ser NULL en la BD, por eso se verifica DBNull antes de asignar
        private Producto MapearProducto(SqlDataReader reader)
        {
            return new Producto
            {
                IdProducto = (int)reader["id_producto"],
                IdCategoria = (int)reader["id_categoria"],
                NombreCategoria = reader["nombre_categoria"]?.ToString() ?? string.Empty,
                Codigo = reader["codigo"]?.ToString() ?? string.Empty,
                Nombre = reader["nombre"]?.ToString() ?? string.Empty,
                Descripcion = reader["descripcion"] == DBNull.Value ? string.Empty : reader["descripcion"]?.ToString() ?? string.Empty,
                Precio = (decimal)reader["precio"],
                StockActual = (int)reader["stock_actual"],
                StockMinimo = (int)reader["stock_minimo"],
                StockMaximo = (int)reader["stock_maximo"],
                Activo = Convert.ToBoolean(reader["activo"])
            };
        }
    }
}