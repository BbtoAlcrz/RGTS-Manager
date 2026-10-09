USE RGTS_Manager_BD;
GO

-- ===== sp_ListarVentas =====
-- Usado por VentaRepositorio.ObtenerHistorial(...)
DROP PROCEDURE IF EXISTS dbo.sp_ListarVentas;
GO

CREATE PROCEDURE dbo.sp_ListarVentas
    @DniVendedor VARCHAR(20) = NULL,
    @FiltroDniCliente VARCHAR(20) = NULL,
    @FechaDesde DATE = NULL,
    @FechaHasta DATE = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT v.id_venta, v.dni_usuario, u.nombre AS usuario_nombre, u.apellido AS usuario_apellido,
           v.id_cliente, c.dni AS cliente_dni, c.nombre AS cliente_nombre, c.apellido AS cliente_apellido,
           v.fecha, v.total_derivado, v.metodo_pago
    FROM VENTA v
    INNER JOIN USUARIO u ON v.dni_usuario = u.dni
    LEFT JOIN CLIENTE c ON v.id_cliente = c.id_cliente
    WHERE (@DniVendedor IS NULL OR v.dni_usuario = @DniVendedor)
      AND (@FiltroDniCliente IS NULL OR c.dni LIKE '%' + @FiltroDniCliente + '%')
      AND (@FechaDesde IS NULL OR CAST(v.fecha AS DATE) >= @FechaDesde)
      AND (@FechaHasta IS NULL OR CAST(v.fecha AS DATE) <= @FechaHasta)
    ORDER BY v.fecha DESC;
END
GO

-- ===== sp_ObtenerDetalleVenta =====
-- Usado por VentaRepositorio.ObtenerDetallesPorVenta(idVenta)
DROP PROCEDURE IF EXISTS dbo.sp_ObtenerDetalleVenta;
GO

CREATE PROCEDURE dbo.sp_ObtenerDetalleVenta
    @IdVenta INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT dv.id_detalle, dv.id_venta, dv.id_producto,
           p.codigo AS codigo_producto, p.nombre AS nombre_producto,
           dv.cantidad, dv.precio_unitario, dv.subtotal_derivado
    FROM DETALLE_VENTA dv
    INNER JOIN PRODUCTO p ON dv.id_producto = p.id_producto
    WHERE dv.id_venta = @IdVenta;
END
GO

-- ===== sp_InsertarVenta =====
-- Usado por VentaRepositorio.RegistrarVenta(...) — cabecera
DROP PROCEDURE IF EXISTS dbo.sp_InsertarVenta;
GO

CREATE PROCEDURE dbo.sp_InsertarVenta
    @DniUsuario VARCHAR(20),
    @IdCliente INT = NULL,
    @TotalDerivado DECIMAL(10,2),
    @MetodoPago VARCHAR(30) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO VENTA (dni_usuario, id_cliente, fecha, total_derivado, metodo_pago)
    VALUES (@DniUsuario, @IdCliente, GETDATE(), @TotalDerivado, @MetodoPago);

    SELECT SCOPE_IDENTITY() AS IdVenta;
END
GO

-- ===== sp_InsertarDetalleVenta =====
-- Usado por VentaRepositorio.RegistrarVenta(...) — se llama una vez por cada ítem del carrito
DROP PROCEDURE IF EXISTS dbo.sp_InsertarDetalleVenta;
GO

CREATE PROCEDURE dbo.sp_InsertarDetalleVenta
    @IdVenta INT,
    @IdProducto INT,
    @Cantidad INT,
    @PrecioUnitario DECIMAL(10,2)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO DETALLE_VENTA (id_venta, id_producto, cantidad, precio_unitario, subtotal_derivado)
    VALUES (@IdVenta, @IdProducto, @Cantidad, @PrecioUnitario, @Cantidad * @PrecioUnitario);
END
GO

-- ===== sp_ObtenerVendedoresConVentas =====
-- Usado por VentaRepositorio.ObtenerVendedoresConVentas()
DROP PROCEDURE IF EXISTS dbo.sp_ObtenerVendedoresConVentas;
GO

CREATE PROCEDURE dbo.sp_ObtenerVendedoresConVentas
AS
BEGIN
    SET NOCOUNT ON;

    SELECT DISTINCT v.dni_usuario, u.nombre, u.apellido
    FROM VENTA v
    INNER JOIN USUARIO u ON v.dni_usuario = u.dni;
END
GO
