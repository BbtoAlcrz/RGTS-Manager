USE RGTS_Manager_BD;
GO

-- ===== sp_ListarCompras =====
-- Usado por CompraRepositorio.ObtenerCompras(fechaDesde, fechaHasta, idProveedor)
DROP PROCEDURE IF EXISTS dbo.sp_ListarCompras;
GO

CREATE PROCEDURE dbo.sp_ListarCompras
    @FechaDesde DATE,
    @FechaHasta DATE,
    @IdProveedor INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT c.id_compra, c.dni_usuario, c.id_proveedor, p.nombre_comercial AS nombre_proveedor,
           c.fecha, c.total_derivado, c.estado
    FROM COMPRA c
    INNER JOIN PROVEEDOR p ON c.id_proveedor = p.id_proveedor
    WHERE CAST(c.fecha AS DATE) BETWEEN @FechaDesde AND @FechaHasta
      AND (@IdProveedor IS NULL OR c.id_proveedor = @IdProveedor)
    ORDER BY c.fecha DESC;
END
GO

-- ===== sp_ObtenerCompraPorId =====
-- Usado por CompraRepositorio.ObtenerPorId(idCompra)
DROP PROCEDURE IF EXISTS dbo.sp_ObtenerCompraPorId;
GO

CREATE PROCEDURE dbo.sp_ObtenerCompraPorId
    @IdCompra INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT c.id_compra, c.dni_usuario, c.id_proveedor, p.nombre_comercial AS nombre_proveedor,
           c.fecha, c.total_derivado, c.estado
    FROM COMPRA c
    INNER JOIN PROVEEDOR p ON c.id_proveedor = p.id_proveedor
    WHERE c.id_compra = @IdCompra;
END
GO

-- ===== sp_ObtenerDetalleCompra =====
-- Usado por CompraRepositorio.ObtenerDetallesPorCompra(idCompra)
DROP PROCEDURE IF EXISTS dbo.sp_ObtenerDetalleCompra;
GO

CREATE PROCEDURE dbo.sp_ObtenerDetalleCompra
    @IdCompra INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT dc.id_detalle_compra, dc.id_compra, dc.id_producto,
           pr.codigo AS codigo_producto, pr.nombre AS nombre_producto,
           dc.cantidad, dc.costo_unitario, dc.subtotal_derivado
    FROM DETALLE_COMPRA dc
    INNER JOIN PRODUCTO pr ON dc.id_producto = pr.id_producto
    WHERE dc.id_compra = @IdCompra;
END
GO

-- ===== sp_InsertarCompra =====
-- Usado por CompraRepositorio.RegistrarCompra(...) — cabecera de la compra
DROP PROCEDURE IF EXISTS dbo.sp_InsertarCompra;
GO

CREATE PROCEDURE dbo.sp_InsertarCompra
    @DniUsuario VARCHAR(20),
    @IdProveedor INT,
    @TotalDerivado DECIMAL(10,2)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO COMPRA (dni_usuario, id_proveedor, fecha, total_derivado, estado)
    VALUES (@DniUsuario, @IdProveedor, GETDATE(), @TotalDerivado, 'Pendiente');

    SELECT SCOPE_IDENTITY() AS IdCompra;
END
GO

-- ===== sp_InsertarDetalleCompra =====
-- Usado por CompraRepositorio.RegistrarCompra(...) — se llama una vez por cada ítem del detalle
DROP PROCEDURE IF EXISTS dbo.sp_InsertarDetalleCompra;
GO

CREATE PROCEDURE dbo.sp_InsertarDetalleCompra
    @IdCompra INT,
    @IdProducto INT,
    @Cantidad INT,
    @CostoUnitario DECIMAL(10,2)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO DETALLE_COMPRA (id_compra, id_producto, cantidad, costo_unitario, subtotal_derivado)
    VALUES (@IdCompra, @IdProducto, @Cantidad, @CostoUnitario, @Cantidad * @CostoUnitario);
END
GO

-- ===== sp_CambiarEstadoCompra =====
-- Usado por CompraRepositorio.CambiarEstado(idCompra, nuevoEstado)
DROP PROCEDURE IF EXISTS dbo.sp_CambiarEstadoCompra;
GO

CREATE PROCEDURE dbo.sp_CambiarEstadoCompra
    @IdCompra INT,
    @NuevoEstado VARCHAR(30)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE COMPRA
    SET estado = @NuevoEstado
    WHERE id_compra = @IdCompra;
END
GO
