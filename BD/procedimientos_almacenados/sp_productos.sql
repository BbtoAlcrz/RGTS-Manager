USE RGTS_Manager_BD;
GO

-- ===== sp_ListarProductos =====
DROP PROCEDURE IF EXISTS dbo.sp_ListarProductos;
GO

CREATE PROCEDURE dbo.sp_ListarProductos
AS
BEGIN
    SET NOCOUNT ON;

    SELECT p.id_producto, p.id_categoria, c.nombre_categoria,
           p.codigo, p.nombre, p.descripcion,
           p.precio, p.stock_actual, p.stock_reservado, p.stock_minimo, p.stock_maximo, p.activo
    FROM PRODUCTO p
    INNER JOIN CATEGORIA c ON p.id_categoria = c.id_categoria
    ORDER BY p.nombre;
END
GO

-- ===== sp_ListarProductosPorFiltro =====
DROP PROCEDURE IF EXISTS dbo.sp_ListarProductosPorFiltro;
GO

CREATE PROCEDURE dbo.sp_ListarProductosPorFiltro
    @Texto VARCHAR(100) = '',
    @IdCategoria INT = 0
AS
BEGIN
    SET NOCOUNT ON;

    SELECT p.id_producto, p.id_categoria, c.nombre_categoria,
           p.codigo, p.nombre, p.descripcion,
           p.precio, p.stock_actual, p.stock_reservado, p.stock_minimo, p.stock_maximo, p.activo
    FROM PRODUCTO p
    INNER JOIN CATEGORIA c ON p.id_categoria = c.id_categoria
    WHERE (@Texto = '' OR p.nombre LIKE '%' + @Texto + '%' OR p.codigo LIKE '%' + @Texto + '%')
      AND (@IdCategoria = 0 OR p.id_categoria = @IdCategoria)
    ORDER BY p.nombre;
END
GO

-- ===== sp_ObtenerProductoPorId =====
DROP PROCEDURE IF EXISTS dbo.sp_ObtenerProductoPorId;
GO

CREATE PROCEDURE dbo.sp_ObtenerProductoPorId
    @IdProducto INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT p.id_producto, p.id_categoria, c.nombre_categoria,
           p.codigo, p.nombre, p.descripcion,
           p.precio, p.stock_actual, p.stock_reservado, p.stock_minimo, p.stock_maximo, p.activo
    FROM PRODUCTO p
    INNER JOIN CATEGORIA c ON p.id_categoria = c.id_categoria
    WHERE p.id_producto = @IdProducto;
END
GO

-- ===== sp_ListarProductosActivosPorFiltro =====
-- Usado en Ventas; el disponible real para vender es stock_actual - stock_reservado
DROP PROCEDURE IF EXISTS dbo.sp_ListarProductosActivosPorFiltro;
GO

CREATE PROCEDURE dbo.sp_ListarProductosActivosPorFiltro
    @Texto VARCHAR(100),
    @Max INT = 10
AS
BEGIN
    SET NOCOUNT ON;

    SELECT TOP (@Max) p.id_producto, p.id_categoria, c.nombre_categoria,
           p.codigo, p.nombre, p.descripcion,
           p.precio, p.stock_actual, p.stock_reservado, p.stock_minimo, p.stock_maximo, p.activo
    FROM PRODUCTO p
    INNER JOIN CATEGORIA c ON p.id_categoria = c.id_categoria
    WHERE p.activo = 1
      AND (p.nombre LIKE '%' + @Texto + '%' OR p.codigo LIKE '%' + @Texto + '%');
END
GO

-- ===== sp_InsertarProducto =====
DROP PROCEDURE IF EXISTS dbo.sp_InsertarProducto;
GO

CREATE PROCEDURE dbo.sp_InsertarProducto
    @IdCategoria INT,
    @Codigo VARCHAR(50),
    @Nombre VARCHAR(100),
    @Descripcion VARCHAR(255) = NULL,
    @Precio DECIMAL(10,2),
    @StockActual INT,
    @StockMinimo INT,
    @StockMaximo INT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO PRODUCTO (id_categoria, codigo, nombre, descripcion, precio, stock_actual, stock_reservado, stock_minimo, stock_maximo, activo)
    VALUES (@IdCategoria, @Codigo, @Nombre, @Descripcion, @Precio, @StockActual, 0, @StockMinimo, @StockMaximo, 1);

    SELECT SCOPE_IDENTITY() AS IdProducto;
END
GO

-- ===== sp_ActualizarProducto =====
DROP PROCEDURE IF EXISTS dbo.sp_ActualizarProducto;
GO

CREATE PROCEDURE dbo.sp_ActualizarProducto
    @IdProducto INT,
    @IdCategoria INT,
    @Codigo VARCHAR(50),
    @Nombre VARCHAR(100),
    @Descripcion VARCHAR(255) = NULL,
    @Precio DECIMAL(10,2),
    @StockActual INT,
    @StockMinimo INT,
    @StockMaximo INT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE PRODUCTO
    SET id_categoria = @IdCategoria,
        codigo = @Codigo,
        nombre = @Nombre,
        descripcion = @Descripcion,
        precio = @Precio,
        stock_actual = @StockActual,
        stock_minimo = @StockMinimo,
        stock_maximo = @StockMaximo
    WHERE id_producto = @IdProducto;
END
GO

-- ===== sp_CambiarEstadoProducto =====
DROP PROCEDURE IF EXISTS dbo.sp_CambiarEstadoProducto;
GO

CREATE PROCEDURE dbo.sp_CambiarEstadoProducto
    @IdProducto INT,
    @NuevoEstado BIT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE PRODUCTO
    SET activo = @NuevoEstado
    WHERE id_producto = @IdProducto;
END
GO

-- ===== sp_ActualizarStockProducto =====
-- Usado al recibir una compra (incrementa stock_actual, no toca reservas)
DROP PROCEDURE IF EXISTS dbo.sp_ActualizarStockProducto;
GO

CREATE PROCEDURE dbo.sp_ActualizarStockProducto
    @IdProducto INT,
    @NuevoStock INT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE PRODUCTO
    SET stock_actual = @NuevoStock
    WHERE id_producto = @IdProducto;
END
GO

-- ===== sp_ReservarStockProducto =====
-- Suma a stock_reservado cuando un vendedor agrega el producto a un carrito de venta.
-- Valida atómicamente (dentro del propio UPDATE) que haya disponible suficiente,
-- evitando que dos vendedores reserven al mismo tiempo más de lo que hay en stock.
DROP PROCEDURE IF EXISTS dbo.sp_ReservarStockProducto;
GO

CREATE PROCEDURE dbo.sp_ReservarStockProducto
    @IdProducto INT,
    @Cantidad INT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE PRODUCTO
    SET stock_reservado = stock_reservado + @Cantidad
    WHERE id_producto = @IdProducto
      AND (stock_actual - stock_reservado) >= @Cantidad;

    -- Si no se actualizó ninguna fila, no había disponible suficiente
    SELECT @@ROWCOUNT AS FilasAfectadas;
END
GO

-- ===== sp_LiberarStockProducto =====
-- Resta de stock_reservado cuando se cancela una venta o se quita un ítem del carrito
DROP PROCEDURE IF EXISTS dbo.sp_LiberarStockProducto;
GO

CREATE PROCEDURE dbo.sp_LiberarStockProducto
    @IdProducto INT,
    @Cantidad INT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE PRODUCTO
    SET stock_reservado = CASE WHEN stock_reservado - @Cantidad < 0 THEN 0 ELSE stock_reservado - @Cantidad END
    WHERE id_producto = @IdProducto;
END
GO

-- ===== sp_ConfirmarStockProducto =====
-- Al confirmar la venta: descuenta stock_actual y libera stock_reservado en la misma cantidad
DROP PROCEDURE IF EXISTS dbo.sp_ConfirmarStockProducto;
GO

CREATE PROCEDURE dbo.sp_ConfirmarStockProducto
    @IdProducto INT,
    @Cantidad INT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE PRODUCTO
    SET stock_actual = stock_actual - @Cantidad,
        stock_reservado = CASE WHEN stock_reservado - @Cantidad < 0 THEN 0 ELSE stock_reservado - @Cantidad END
    WHERE id_producto = @IdProducto;
END
GO
