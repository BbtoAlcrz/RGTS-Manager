/* ======================================================================
   RGTS Manager - 01_esquema_rgts.sql
   Base de datos: RGTS_Manager_BD  (SQL Server / SQL Server Express)

   Qué hace: crea la base (si no existe), las 11 tablas con sus claves y
   restricciones, y los 48 procedimientos almacenados del sistema.
   NO inserta ningún dato (para eso está 02_datos_precargados.sql).

   Cómo usarlo: ejecutarlo COMPLETO sobre un servidor donde todavía no exista
   el esquema. Si la base ya tiene las tablas, el script se detiene solo y no
   modifica nada (borrar o renombrar la base antes de volver a ejecutarlo).
   En ese caso SQL Server igual compila los procedimientos y puede mostrar
   errores 'Invalid column name': son solo avisos, la base no cambia.

   Orden de ejecución:  1) 01_esquema_rgts.sql   2) 02_datos_precargados.sql
   Generado a partir de la base de desarrollo el 07/11/2026.
   ====================================================================== */

IF DB_ID('RGTS_Manager_BD') IS NULL
    CREATE DATABASE RGTS_Manager_BD;
GO

USE RGTS_Manager_BD;
GO

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO

-- Protección: si el esquema ya existe, saltea todo el script
IF OBJECT_ID('dbo.USUARIO', 'U') IS NOT NULL
BEGIN
    RAISERROR('La base RGTS_Manager_BD ya tiene el esquema creado: NO SE MODIFICO NADA. Borre la base y vuelva a ejecutar. Los errores que aparezcan debajo son solo de compilacion y no cambian la base.', 16, 1);
    SET NOEXEC ON;
END
GO

/* ======================================================================
   PARTE 1 - TABLAS
   ====================================================================== */
-- Tabla CATEGORIA
CREATE TABLE [dbo].[CATEGORIA](
	[id_categoria] [int] IDENTITY(1,1) NOT NULL,
	[nombre_categoria] [varchar](50) NOT NULL,
	[descripcion] [varchar](200) NULL,
	[activo] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[nombre_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

-- Tabla CLIENTE
CREATE TABLE [dbo].[CLIENTE](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[dni] [varchar](20) NOT NULL,
	[telefono] [varchar](30) NULL,
	[email] [varchar](100) NULL,
	[activo] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

-- Tabla COMPRA
CREATE TABLE [dbo].[COMPRA](
	[id_compra] [int] IDENTITY(1,1) NOT NULL,
	[dni_usuario] [varchar](20) NOT NULL,
	[id_proveedor] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[total_derivado] [decimal](10, 2) NOT NULL,
	[estado] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

-- Tabla DETALLE_COMPRA
CREATE TABLE [dbo].[DETALLE_COMPRA](
	[id_detalle_compra] [int] IDENTITY(1,1) NOT NULL,
	[id_compra] [int] NOT NULL,
	[id_producto] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[costo_unitario] [decimal](10, 2) NOT NULL,
	[subtotal_derivado] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_detalle_compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

-- Tabla DETALLE_VENTA
CREATE TABLE [dbo].[DETALLE_VENTA](
	[id_detalle] [int] IDENTITY(1,1) NOT NULL,
	[id_venta] [int] NOT NULL,
	[id_producto] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[precio_unitario] [decimal](10, 2) NOT NULL,
	[subtotal_derivado] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_detalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

-- Tabla PRODUCTO
CREATE TABLE [dbo].[PRODUCTO](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[id_categoria] [int] NOT NULL,
	[codigo] [varchar](50) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[descripcion] [varchar](255) NULL,
	[precio] [decimal](10, 2) NOT NULL,
	[stock_actual] [int] NOT NULL,
	[stock_minimo] [int] NOT NULL,
	[stock_maximo] [int] NOT NULL,
	[activo] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

-- Tabla PROVEEDOR
CREATE TABLE [dbo].[PROVEEDOR](
	[id_proveedor] [int] IDENTITY(1,1) NOT NULL,
	[razon_social] [varchar](100) NOT NULL,
	[nombre_comercial] [varchar](100) NOT NULL,
	[tipo_proveedor] [varchar](50) NULL,
	[nombre_contacto] [varchar](50) NULL,
	[apellido_contacto] [varchar](50) NULL,
	[telefono] [varchar](30) NULL,
	[correo] [varchar](100) NULL,
	[direccion] [varchar](150) NULL,
	[activo] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Proveedor_NombreComercial] UNIQUE NONCLUSTERED 
(
	[nombre_comercial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

-- Tabla RESERVA_STOCK
CREATE TABLE [dbo].[RESERVA_STOCK](
	[id_reserva] [int] IDENTITY(1,1) NOT NULL,
	[id_producto] [int] NOT NULL,
	[dni_usuario] [varchar](20) NOT NULL,
	[cantidad] [int] NOT NULL,
	[fecha_vencimiento] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_reserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Reserva_Producto_Usuario] UNIQUE NONCLUSTERED 
(
	[id_producto] ASC,
	[dni_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

-- Tabla ROL
CREATE TABLE [dbo].[ROL](
	[id_rol] [int] IDENTITY(1,1) NOT NULL,
	[nombre_rol] [varchar](50) NOT NULL,
	[descripcion] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[nombre_rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

-- Tabla USUARIO
CREATE TABLE [dbo].[USUARIO](
	[dni] [varchar](20) NOT NULL,
	[id_rol] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[contrasena_hash] [varchar](255) NOT NULL,
	[activo] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

-- Tabla VENTA
CREATE TABLE [dbo].[VENTA](
	[id_venta] [int] IDENTITY(1,1) NOT NULL,
	[dni_usuario] [varchar](20) NOT NULL,
	[id_cliente] [int] NULL,
	[fecha] [datetime] NOT NULL,
	[total_derivado] [decimal](10, 2) NOT NULL,
	[metodo_pago] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/* ======================================================================
   PARTE 2 - VALORES POR DEFECTO, CLAVES FORANEAS Y CHECKS
   ====================================================================== */
ALTER TABLE [dbo].[CATEGORIA] ADD  DEFAULT ((1)) FOR [activo]
GO
ALTER TABLE [dbo].[CLIENTE] ADD  DEFAULT ((1)) FOR [activo]
GO
ALTER TABLE [dbo].[COMPRA] ADD  DEFAULT (getdate()) FOR [fecha]
GO
ALTER TABLE [dbo].[COMPRA] ADD  DEFAULT ((0.00)) FOR [total_derivado]
GO
ALTER TABLE [dbo].[COMPRA] ADD  DEFAULT ('Pendiente') FOR [estado]
GO
ALTER TABLE [dbo].[PRODUCTO] ADD  DEFAULT ((0.00)) FOR [precio]
GO
ALTER TABLE [dbo].[PRODUCTO] ADD  DEFAULT ((0)) FOR [stock_actual]
GO
ALTER TABLE [dbo].[PRODUCTO] ADD  DEFAULT ((0)) FOR [stock_minimo]
GO
ALTER TABLE [dbo].[PRODUCTO] ADD  DEFAULT ((0)) FOR [stock_maximo]
GO
ALTER TABLE [dbo].[PRODUCTO] ADD  DEFAULT ((1)) FOR [activo]
GO
ALTER TABLE [dbo].[PROVEEDOR] ADD  DEFAULT ((1)) FOR [activo]
GO
ALTER TABLE [dbo].[USUARIO] ADD  DEFAULT ((1)) FOR [activo]
GO
ALTER TABLE [dbo].[VENTA] ADD  DEFAULT (getdate()) FOR [fecha]
GO
ALTER TABLE [dbo].[VENTA] ADD  DEFAULT ((0.00)) FOR [total_derivado]
GO
ALTER TABLE [dbo].[COMPRA]  WITH CHECK ADD  CONSTRAINT [FK_Compra_Proveedor] FOREIGN KEY([id_proveedor])
REFERENCES [dbo].[PROVEEDOR] ([id_proveedor])
GO
ALTER TABLE [dbo].[COMPRA] CHECK CONSTRAINT [FK_Compra_Proveedor]
GO
ALTER TABLE [dbo].[COMPRA]  WITH CHECK ADD  CONSTRAINT [FK_Compra_Usuario] FOREIGN KEY([dni_usuario])
REFERENCES [dbo].[USUARIO] ([dni])
GO
ALTER TABLE [dbo].[COMPRA] CHECK CONSTRAINT [FK_Compra_Usuario]
GO
ALTER TABLE [dbo].[DETALLE_COMPRA]  WITH CHECK ADD  CONSTRAINT [FK_DetalleCompra_Compra] FOREIGN KEY([id_compra])
REFERENCES [dbo].[COMPRA] ([id_compra])
GO
ALTER TABLE [dbo].[DETALLE_COMPRA] CHECK CONSTRAINT [FK_DetalleCompra_Compra]
GO
ALTER TABLE [dbo].[DETALLE_COMPRA]  WITH CHECK ADD  CONSTRAINT [FK_DetalleCompra_Producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[PRODUCTO] ([id_producto])
GO
ALTER TABLE [dbo].[DETALLE_COMPRA] CHECK CONSTRAINT [FK_DetalleCompra_Producto]
GO
ALTER TABLE [dbo].[DETALLE_VENTA]  WITH CHECK ADD  CONSTRAINT [FK_DetalleVenta_Producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[PRODUCTO] ([id_producto])
GO
ALTER TABLE [dbo].[DETALLE_VENTA] CHECK CONSTRAINT [FK_DetalleVenta_Producto]
GO
ALTER TABLE [dbo].[DETALLE_VENTA]  WITH CHECK ADD  CONSTRAINT [FK_DetalleVenta_Venta] FOREIGN KEY([id_venta])
REFERENCES [dbo].[VENTA] ([id_venta])
GO
ALTER TABLE [dbo].[DETALLE_VENTA] CHECK CONSTRAINT [FK_DetalleVenta_Venta]
GO
ALTER TABLE [dbo].[PRODUCTO]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Categoria] FOREIGN KEY([id_categoria])
REFERENCES [dbo].[CATEGORIA] ([id_categoria])
GO
ALTER TABLE [dbo].[PRODUCTO] CHECK CONSTRAINT [FK_Producto_Categoria]
GO
ALTER TABLE [dbo].[RESERVA_STOCK]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[PRODUCTO] ([id_producto])
GO
ALTER TABLE [dbo].[RESERVA_STOCK] CHECK CONSTRAINT [FK_Reserva_Producto]
GO
ALTER TABLE [dbo].[USUARIO]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Rol] FOREIGN KEY([id_rol])
REFERENCES [dbo].[ROL] ([id_rol])
GO
ALTER TABLE [dbo].[USUARIO] CHECK CONSTRAINT [FK_Usuario_Rol]
GO
ALTER TABLE [dbo].[VENTA]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[CLIENTE] ([id_cliente])
GO
ALTER TABLE [dbo].[VENTA] CHECK CONSTRAINT [FK_Venta_Cliente]
GO
ALTER TABLE [dbo].[VENTA]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Usuario] FOREIGN KEY([dni_usuario])
REFERENCES [dbo].[USUARIO] ([dni])
GO
ALTER TABLE [dbo].[VENTA] CHECK CONSTRAINT [FK_Venta_Usuario]
GO
ALTER TABLE [dbo].[RESERVA_STOCK]  WITH CHECK ADD CHECK  (([cantidad]>=(0)))
GO

/* ======================================================================
   PARTE 3 - PROCEDIMIENTOS ALMACENADOS
   ====================================================================== */
-- ---------- 1. Categorías ----------

CREATE OR ALTER PROCEDURE [dbo].[sp_ActualizarCategoria]
    @IdCategoria INT,
    @NombreCategoria VARCHAR(50),
    @Descripcion VARCHAR(200) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE CATEGORIA
    SET nombre_categoria = @NombreCategoria,
        descripcion = @Descripcion
    WHERE id_categoria = @IdCategoria;
END
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_CambiarEstadoCategoria]
    @IdCategoria INT,
    @NuevoEstado BIT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE CATEGORIA
    SET activo = @NuevoEstado
    WHERE id_categoria = @IdCategoria;
END
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_InsertarCategoria]
    @NombreCategoria VARCHAR(50),
    @Descripcion VARCHAR(200) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO CATEGORIA (nombre_categoria, descripcion, activo)
    VALUES (@NombreCategoria, @Descripcion, 1);

    -- Devuelve el id generado para que el repositorio lo use en la entidad
    SELECT SCOPE_IDENTITY() AS IdCategoria;
END
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_ListarCategorias]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT id_categoria, nombre_categoria, descripcion, activo
    FROM CATEGORIA
    ORDER BY nombre_categoria;
END
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_ObtenerCategoriaPorId]
    @IdCategoria INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT id_categoria, nombre_categoria, descripcion, activo
    FROM CATEGORIA
    WHERE id_categoria = @IdCategoria;
END
GO

-- ---------- 2. Productos ----------

CREATE OR ALTER PROCEDURE [dbo].[sp_ActualizarProducto]
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

CREATE OR ALTER PROCEDURE [dbo].[sp_CambiarEstadoProducto]
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

CREATE OR ALTER PROCEDURE [dbo].[sp_InsertarProducto]
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

    INSERT INTO PRODUCTO (id_categoria, codigo, nombre, descripcion, precio, stock_actual, stock_minimo, stock_maximo, activo)
    VALUES (@IdCategoria, @Codigo, @Nombre, @Descripcion, @Precio, @StockActual, @StockMinimo, @StockMaximo, 1);

    SELECT SCOPE_IDENTITY() AS IdProducto;
END
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_ListarProductos]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT p.id_producto, p.id_categoria, c.nombre_categoria,
           p.codigo, p.nombre, p.descripcion,
           p.precio, p.stock_actual, ISNULL(r.reservado, 0) AS stock_reservado,
           p.stock_minimo, p.stock_maximo, p.activo
    FROM PRODUCTO p
    INNER JOIN CATEGORIA c ON p.id_categoria = c.id_categoria
    OUTER APPLY (SELECT SUM(rs.cantidad) AS reservado
                 FROM RESERVA_STOCK rs
                 WHERE rs.id_producto = p.id_producto AND rs.fecha_vencimiento > GETDATE()) r
    ORDER BY p.nombre;
END
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_ListarProductosActivosPorFiltro]
    @Texto VARCHAR(100),
    @Max INT = 10
AS
BEGIN
    SET NOCOUNT ON;

    SELECT TOP (@Max) p.id_producto, p.id_categoria, c.nombre_categoria,
           p.codigo, p.nombre, p.descripcion,
           p.precio, p.stock_actual, ISNULL(r.reservado, 0) AS stock_reservado,
           p.stock_minimo, p.stock_maximo, p.activo
    FROM PRODUCTO p
    INNER JOIN CATEGORIA c ON p.id_categoria = c.id_categoria
    OUTER APPLY (SELECT SUM(rs.cantidad) AS reservado
                 FROM RESERVA_STOCK rs
                 WHERE rs.id_producto = p.id_producto AND rs.fecha_vencimiento > GETDATE()) r
    WHERE p.activo = 1
      AND (p.nombre LIKE '%' + @Texto + '%' OR p.codigo LIKE '%' + @Texto + '%');
END
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_ListarProductosPorFiltro]
    @Texto VARCHAR(100) = '',
    @IdCategoria INT = 0
AS
BEGIN
    SET NOCOUNT ON;

    SELECT p.id_producto, p.id_categoria, c.nombre_categoria,
           p.codigo, p.nombre, p.descripcion,
           p.precio, p.stock_actual, ISNULL(r.reservado, 0) AS stock_reservado,
           p.stock_minimo, p.stock_maximo, p.activo
    FROM PRODUCTO p
    INNER JOIN CATEGORIA c ON p.id_categoria = c.id_categoria
    OUTER APPLY (SELECT SUM(rs.cantidad) AS reservado
                 FROM RESERVA_STOCK rs
                 WHERE rs.id_producto = p.id_producto AND rs.fecha_vencimiento > GETDATE()) r
    WHERE (@Texto = '' OR p.nombre LIKE '%' + @Texto + '%' OR p.codigo LIKE '%' + @Texto + '%')
      AND (@IdCategoria = 0 OR p.id_categoria = @IdCategoria)
    ORDER BY p.nombre;
END
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_ObtenerProductoPorId]
    @IdProducto INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT p.id_producto, p.id_categoria, c.nombre_categoria,
           p.codigo, p.nombre, p.descripcion,
           p.precio, p.stock_actual, ISNULL(r.reservado, 0) AS stock_reservado,
           p.stock_minimo, p.stock_maximo, p.activo
    FROM PRODUCTO p
    INNER JOIN CATEGORIA c ON p.id_categoria = c.id_categoria
    OUTER APPLY (SELECT SUM(rs.cantidad) AS reservado
                 FROM RESERVA_STOCK rs
                 WHERE rs.id_producto = p.id_producto AND rs.fecha_vencimiento > GETDATE()) r
    WHERE p.id_producto = @IdProducto;
END
GO

-- ---------- 2. Productos: stock y reservas ----------

CREATE OR ALTER PROCEDURE [dbo].[sp_ActualizarStockProducto]
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

CREATE OR ALTER PROCEDURE [dbo].[sp_ConfirmarStockProducto]
    @IdProducto INT,
    @DniUsuario VARCHAR(20),
    @Cantidad INT
AS
BEGIN
    SET NOCOUNT ON;

    IF @@TRANCOUNT = 0
        THROW 50012, 'sp_ConfirmarStockProducto debe ejecutarse dentro de la transaccion de la venta.', 1;

    DECLARE @StockActual INT;

    SELECT @StockActual = stock_actual
    FROM PRODUCTO WITH (UPDLOCK, HOLDLOCK)
    WHERE id_producto = @IdProducto;

    IF @StockActual IS NULL
        THROW 50010, 'El producto de la venta no existe.', 1;

    DELETE FROM RESERVA_STOCK
    WHERE id_producto = @IdProducto AND fecha_vencimiento <= GETDATE();

    DECLARE @ReservadoPorOtros INT =
        ISNULL((SELECT SUM(cantidad) FROM RESERVA_STOCK
                WHERE id_producto = @IdProducto AND dni_usuario <> @DniUsuario), 0);

    IF (@StockActual - @ReservadoPorOtros) < @Cantidad
        THROW 50011, 'La reserva de un producto vencio y el stock ya no esta disponible. Vuelva a cargar el carrito.', 1;

    UPDATE PRODUCTO
    SET stock_actual = stock_actual - @Cantidad
    WHERE id_producto = @IdProducto;

    UPDATE RESERVA_STOCK
    SET cantidad = CASE WHEN cantidad > @Cantidad THEN cantidad - @Cantidad ELSE 0 END
    WHERE id_producto = @IdProducto AND dni_usuario = @DniUsuario;

    DELETE FROM RESERVA_STOCK
    WHERE id_producto = @IdProducto AND dni_usuario = @DniUsuario AND cantidad = 0;
END
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_LiberarReservasUsuario]
    @DniUsuario VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM RESERVA_STOCK WHERE dni_usuario = @DniUsuario;
END
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_RenovarReservasUsuario]
    @DniUsuario VARCHAR(20),
    @Minutos INT = 5
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE RESERVA_STOCK
    SET fecha_vencimiento = DATEADD(MINUTE, @Minutos, GETDATE())
    WHERE dni_usuario = @DniUsuario AND fecha_vencimiento > GETDATE();
END
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_ReservarStockProducto]
    @IdProducto INT,
    @DniUsuario VARCHAR(20),
    @Cantidad INT,
    @Minutos INT = 5
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    BEGIN TRANSACTION;

    DECLARE @StockActual INT;

    -- Bloquea la fila del producto: dos vendedores reservando a la vez se atienden de a uno
    SELECT @StockActual = stock_actual
    FROM PRODUCTO WITH (UPDLOCK, HOLDLOCK)
    WHERE id_producto = @IdProducto AND activo = 1;

    IF @StockActual IS NULL OR @Cantidad <= 0
    BEGIN
        ROLLBACK TRANSACTION;
        SELECT 0 AS FilasAfectadas;
        RETURN;
    END

    -- Las reservas vencidas de este producto ya no cuentan: se eliminan
    DELETE FROM RESERVA_STOCK
    WHERE id_producto = @IdProducto AND fecha_vencimiento <= GETDATE();

    DECLARE @Reservado INT =
        ISNULL((SELECT SUM(cantidad) FROM RESERVA_STOCK WHERE id_producto = @IdProducto), 0);

    IF (@StockActual - @Reservado) < @Cantidad
    BEGIN
        ROLLBACK TRANSACTION;
        SELECT 0 AS FilasAfectadas;
        RETURN;
    END

    UPDATE RESERVA_STOCK
    SET cantidad = cantidad + @Cantidad,
        fecha_vencimiento = DATEADD(MINUTE, @Minutos, GETDATE())
    WHERE id_producto = @IdProducto AND dni_usuario = @DniUsuario;

    IF @@ROWCOUNT = 0
        INSERT INTO RESERVA_STOCK (id_producto, dni_usuario, cantidad, fecha_vencimiento)
        VALUES (@IdProducto, @DniUsuario, @Cantidad, DATEADD(MINUTE, @Minutos, GETDATE()));

    COMMIT TRANSACTION;
    SELECT 1 AS FilasAfectadas;
END
GO

-- ---------- 3. Clientes ----------

CREATE OR ALTER PROCEDURE [dbo].[sp_ActualizarCliente]
    @IdCliente INT,
    @Nombre VARCHAR(50),
    @Apellido VARCHAR(50),
    @Dni VARCHAR(20),
    @Telefono VARCHAR(30) = NULL,
    @Email VARCHAR(100) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE CLIENTE
    SET nombre = @Nombre,
        apellido = @Apellido,
        dni = @Dni,
        telefono = @Telefono,
        email = @Email
    WHERE id_cliente = @IdCliente;
END
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_CambiarEstadoCliente]
    @IdCliente INT,
    @NuevoEstado BIT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE CLIENTE
    SET activo = @NuevoEstado
    WHERE id_cliente = @IdCliente;
END
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_InsertarCliente]
    @Nombre VARCHAR(50),
    @Apellido VARCHAR(50),
    @Dni VARCHAR(20),
    @Telefono VARCHAR(30) = NULL,
    @Email VARCHAR(100) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO CLIENTE (nombre, apellido, dni, telefono, email, activo)
    VALUES (@Nombre, @Apellido, @Dni, @Telefono, @Email, 1);

    SELECT SCOPE_IDENTITY() AS IdCliente;
END
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_ListarClientes]
    @Filtro VARCHAR(100) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT id_cliente, nombre, apellido, dni, telefono, email, activo
    FROM CLIENTE
    WHERE (@Filtro IS NULL
           OR dni LIKE '%' + @Filtro + '%'
           OR nombre LIKE '%' + @Filtro + '%'
           OR apellido LIKE '%' + @Filtro + '%')
    ORDER BY apellido, nombre;
END
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_ObtenerClientePorDni]
    @Dni VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT id_cliente, nombre, apellido, dni, telefono, email, activo
    FROM CLIENTE
    WHERE dni = @Dni AND activo = 1;
END
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_ObtenerClientePorId]
    @IdCliente INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT id_cliente, nombre, apellido, dni, telefono, email, activo
    FROM CLIENTE
    WHERE id_cliente = @IdCliente;
END
GO

-- ---------- 4. Proveedores ----------

CREATE OR ALTER PROCEDURE [dbo].[sp_ActualizarProveedor]
    @IdProveedor INT,
    @RazonSocial VARCHAR(100),
    @NombreComercial VARCHAR(100),
    @TipoProveedor VARCHAR(50) = NULL,
    @NombreContacto VARCHAR(50) = NULL,
    @ApellidoContacto VARCHAR(50) = NULL,
    @Telefono VARCHAR(30) = NULL,
    @Correo VARCHAR(100) = NULL,
    @Direccion VARCHAR(150) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE PROVEEDOR
    SET razon_social = @RazonSocial,
        nombre_comercial = @NombreComercial,
        tipo_proveedor = @TipoProveedor,
        nombre_contacto = @NombreContacto,
        apellido_contacto = @ApellidoContacto,
        telefono = @Telefono,
        correo = @Correo,
        direccion = @Direccion
    WHERE id_proveedor = @IdProveedor;
END
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_CambiarEstadoProveedor]
    @IdProveedor INT,
    @NuevoEstado BIT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE PROVEEDOR
    SET activo = @NuevoEstado
    WHERE id_proveedor = @IdProveedor;
END
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_InsertarProveedor]
    @RazonSocial VARCHAR(100),
    @NombreComercial VARCHAR(100),
    @TipoProveedor VARCHAR(50) = NULL,
    @NombreContacto VARCHAR(50) = NULL,
    @ApellidoContacto VARCHAR(50) = NULL,
    @Telefono VARCHAR(30) = NULL,
    @Correo VARCHAR(100) = NULL,
    @Direccion VARCHAR(150) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO PROVEEDOR
        (razon_social, nombre_comercial, tipo_proveedor, nombre_contacto,
         apellido_contacto, telefono, correo, direccion, activo)
    VALUES
        (@RazonSocial, @NombreComercial, @TipoProveedor, @NombreContacto,
         @ApellidoContacto, @Telefono, @Correo, @Direccion, 1);

    SELECT SCOPE_IDENTITY() AS IdProveedor;
END
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_ListarProveedores]
    @Filtro VARCHAR(100) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT id_proveedor, razon_social, nombre_comercial, tipo_proveedor,
           nombre_contacto, apellido_contacto, telefono, correo, direccion, activo
    FROM PROVEEDOR
    WHERE (@Filtro IS NULL
           OR razon_social LIKE '%' + @Filtro + '%'
           OR nombre_comercial LIKE '%' + @Filtro + '%'
           OR telefono LIKE '%' + @Filtro + '%')
    ORDER BY nombre_comercial;
END
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_ObtenerProveedorPorId]
    @IdProveedor INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT id_proveedor, razon_social, nombre_comercial, tipo_proveedor,
           nombre_contacto, apellido_contacto, telefono, correo, direccion, activo
    FROM PROVEEDOR
    WHERE id_proveedor = @IdProveedor;
END
GO

-- ---------- 5. Compras ----------

CREATE OR ALTER PROCEDURE [dbo].[sp_CambiarEstadoCompra]
    @IdCompra INT,
    @NuevoEstado VARCHAR(30)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE COMPRA
    SET estado = @NuevoEstado
    WHERE id_compra = @IdCompra AND estado = 'Pendiente';

    SELECT @@ROWCOUNT AS FilasAfectadas;
END

GO

CREATE OR ALTER PROCEDURE [dbo].[sp_InsertarCompra]
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

CREATE OR ALTER PROCEDURE [dbo].[sp_InsertarDetalleCompra]
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

CREATE OR ALTER PROCEDURE [dbo].[sp_ListarCompras]
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

CREATE OR ALTER PROCEDURE [dbo].[sp_ObtenerCompraPorId]
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

CREATE OR ALTER PROCEDURE [dbo].[sp_ObtenerDetalleCompra]
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

CREATE OR ALTER PROCEDURE [dbo].[sp_RecibirCompra]
    @IdCompra INT
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;   -- cualquier error revierte toda la transacción

    BEGIN TRANSACTION;

    DECLARE @Estado VARCHAR(30);

    -- Bloquea la compra: si dos usuarios la reciben a la vez, el segundo espera y ve que ya no está Pendiente
    SELECT @Estado = estado
    FROM COMPRA WITH (UPDLOCK, HOLDLOCK)
    WHERE id_compra = @IdCompra;

    IF @Estado IS NULL
        THROW 50020, 'No se encontró la compra especificada.', 1;

    IF @Estado <> 'Pendiente'
        THROW 50021, 'Solo se pueden modificar compras en estado Pendiente. Esta compra ya fue procesada.', 1;

    -- Bloquea los productos involucrados (en orden de id, igual que las ventas, para evitar bloqueos cruzados)
    DECLARE @Bloqueados INT;
    SELECT @Bloqueados = COUNT(*)
    FROM PRODUCTO WITH (UPDLOCK, HOLDLOCK)
    WHERE id_producto IN (SELECT id_producto FROM DETALLE_COMPRA WHERE id_compra = @IdCompra);

    -- Regla de stock máximo (la que antes validaba IncrementarStock en C#)
    DECLARE @Nombre VARCHAR(100), @Cantidad INT, @Actual INT, @Maximo INT;

    SELECT TOP 1 @Nombre = p.nombre, @Cantidad = d.cantidad, @Actual = p.stock_actual, @Maximo = p.stock_maximo
    FROM PRODUCTO p
    INNER JOIN (SELECT id_producto, SUM(cantidad) AS cantidad
                FROM DETALLE_COMPRA
                WHERE id_compra = @IdCompra
                GROUP BY id_producto) d ON d.id_producto = p.id_producto
    WHERE p.stock_actual + d.cantidad > p.stock_maximo
    ORDER BY p.id_producto;

    IF @Nombre IS NOT NULL
    BEGIN
        DECLARE @Mensaje NVARCHAR(400) = CONCAT(
            'No se puede recibir ', @Cantidad, ' unidades para ''', @Nombre, '''. ',
            'Esto superaría el stock máximo permitido de (', @Maximo, '). Stock actual: ', @Actual);
        THROW 50022, @Mensaje, 1;
    END

    -- Suma el stock de todos los ítems en una sola sentencia (sin leer-y-reescribir desde la app)
    UPDATE p
    SET p.stock_actual = p.stock_actual + d.cantidad
    FROM PRODUCTO p
    INNER JOIN (SELECT id_producto, SUM(cantidad) AS cantidad
                FROM DETALLE_COMPRA
                WHERE id_compra = @IdCompra
                GROUP BY id_producto) d ON d.id_producto = p.id_producto;

    UPDATE COMPRA SET estado = 'Recibida' WHERE id_compra = @IdCompra;

    COMMIT TRANSACTION;
END

GO

-- ---------- 6. Ventas ----------

CREATE OR ALTER PROCEDURE [dbo].[sp_InsertarDetalleVenta]
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

CREATE OR ALTER PROCEDURE [dbo].[sp_InsertarVenta]
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

CREATE OR ALTER PROCEDURE [dbo].[sp_ListarVentas]
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

CREATE OR ALTER PROCEDURE [dbo].[sp_ObtenerDetalleVenta]
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

CREATE OR ALTER PROCEDURE [dbo].[sp_ObtenerVendedoresConVentas]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT DISTINCT v.dni_usuario, u.nombre, u.apellido
    FROM VENTA v
    INNER JOIN USUARIO u ON v.dni_usuario = u.dni;
END
GO

-- ---------- 7. Reportes ----------

CREATE OR ALTER PROCEDURE [dbo].[sp_ReporteClientes]
    @FechaDesde DATETIME,
    @FechaHasta DATETIME
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @HastaAjustado DATETIME;
    SET @HastaAjustado = DATEADD(SECOND, -1, DATEADD(DAY, 1, CAST(CAST(@FechaHasta AS DATE) AS DATETIME)));

    -- Detalle por cliente registrado (incluye activos sin compras o con compras)
    SELECT 
        c.id_cliente AS IdCliente,
        c.dni AS Dni,
        c.nombre AS Nombre,
        c.apellido AS Apellido,
        ISNULL(c.nombre + ' ' + c.apellido, 'Consumidor Final') AS NombreCompleto,
        c.activo AS Activo,
        COUNT(v_periodo.id_venta) AS ComprasEnPeriodo,
        COUNT(v_historico.id_venta) AS ComprasHistoricas,
        ISNULL(SUM(v_periodo.total_derivado), 0.00) AS TotalGastadoPeriodo
    FROM CLIENTE c
    LEFT JOIN VENTA v_periodo ON c.id_cliente = v_periodo.id_cliente 
                             AND v_periodo.fecha >= @FechaDesde 
                             AND v_periodo.fecha <= @HastaAjustado
    LEFT JOIN VENTA v_historico ON c.id_cliente = v_historico.id_cliente
    WHERE c.activo = 1
    GROUP BY c.id_cliente, c.dni, c.nombre, c.apellido, c.activo

    UNION ALL

    -- 2. Fila acumulada para ventas a Consumidor Final (id_cliente NULL) en el período
    SELECT 
        0 AS IdCliente,
        '000' AS Dni,
        'Consumidor' AS Nombre,
        'Final' AS Apellido,
        'Consumidor Final' AS NombreCompleto,
        CAST(1 AS BIT) AS Activo,
        COUNT(v.id_venta) AS ComprasEnPeriodo,
        COUNT(v.id_venta) AS ComprasHistoricas,
        ISNULL(SUM(v.total_derivado), 0.00) AS TotalGastadoPeriodo
    FROM VENTA v
    WHERE v.id_cliente IS NULL 
      AND v.fecha >= @FechaDesde 
      AND v.fecha <= @HastaAjustado

    ORDER BY ComprasEnPeriodo DESC, TotalGastadoPeriodo DESC;
END

CREATE OR ALTER PROCEDURE [dbo].[sp_ReporteProductos]
    @FechaDesde DATETIME,
    @FechaHasta DATETIME
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @HastaAjustado DATETIME;
    SET @HastaAjustado = DATEADD(SECOND, -1, DATEADD(DAY, 1, CAST(CAST(@FechaHasta AS DATE) AS DATETIME)));

    SELECT 
        p.id_producto AS IdProducto,
        p.codigo AS Codigo,
        p.nombre AS NombreProducto,
        cat.nombre_categoria AS NombreCategoria,
        p.precio AS PrecioVenta,
        p.stock_actual AS StockActual,
        p.stock_minimo AS StockMinimo,
        p.activo AS Activo,
        ISNULL(SUM(dv.cantidad), 0) AS UnidadesVendidasEnPeriodo,
        ISNULL(SUM(dv.cantidad * dv.precio_unitario), 0.00) AS TotalFacturadoEnPeriodo
    FROM PRODUCTO p
    INNER JOIN CATEGORIA cat ON p.id_categoria = cat.id_categoria
    LEFT JOIN (
        DETALLE_VENTA dv
        INNER JOIN VENTA v ON dv.id_venta = v.id_venta
            AND v.fecha >= @FechaDesde
            AND v.fecha <= @HastaAjustado
    ) ON p.id_producto = dv.id_producto
    GROUP BY 
        p.id_producto, 
        p.codigo, 
        p.nombre, 
        cat.nombre_categoria, 
        p.precio, 
        p.stock_actual, 
        p.stock_minimo, 
        p.activo
    ORDER BY UnidadesVendidasEnPeriodo DESC, TotalFacturadoEnPeriodo DESC;
END
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_ReporteVentas]
    @FechaDesde DATETIME,
    @FechaHasta DATETIME,
    @DniVendedor VARCHAR(20) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @HastaAjustado DATETIME;
    SET @HastaAjustado = DATEADD(SECOND, -1, DATEADD(DAY, 1, CAST(CAST(@FechaHasta AS DATE) AS DATETIME)));

    SELECT 
        v.id_venta AS IdVenta,
        v.fecha AS Fecha,
        v.dni_usuario AS DniVendedor,
        ISNULL(u.nombre + ' ' + u.apellido, v.dni_usuario) AS NombreVendedor,
        v.id_cliente AS IdCliente,
        ISNULL(c.nombre + ' ' + c.apellido, 'Consumidor Final') AS NombreCliente,
        v.total_derivado AS TotalVenta,
        dv.id_producto AS IdProducto,
        p.codigo AS CodigoProducto,
        p.nombre AS NombreProducto,
        p.id_categoria AS IdCategoria,
        cat.nombre_categoria AS NombreCategoria,
        dv.cantidad AS Cantidad,
        dv.precio_unitario AS PrecioUnitario,
        (dv.cantidad * dv.precio_unitario) AS Subtotal,
        p.precio AS PrecioCostoActual
    FROM VENTA v
    INNER JOIN DETALLE_VENTA dv ON v.id_venta = dv.id_venta
    INNER JOIN PRODUCTO p ON dv.id_producto = p.id_producto
    INNER JOIN CATEGORIA cat ON p.id_categoria = cat.id_categoria
    LEFT JOIN USUARIO u ON v.dni_usuario = u.dni
    LEFT JOIN CLIENTE c ON v.id_cliente = c.id_cliente
    WHERE v.fecha >= @FechaDesde 
      AND v.fecha <= @HastaAjustado
      AND (@DniVendedor IS NULL OR @DniVendedor = '' OR v.dni_usuario = @DniVendedor)
    ORDER BY v.fecha ASC;
END
GO

-- ---------- 8. Usuarios ----------

CREATE OR ALTER PROCEDURE [dbo].[sp_ActualizarUsuario]
    @Dni VARCHAR(20),
    @IdRol INT,
    @Nombre VARCHAR(50),
    @Apellido VARCHAR(50),
    @Email VARCHAR(100),
    @ContrasenaHash VARCHAR(255) = NULL -- Si el camppo viene vacio es xq no modifica la contraseña actual
AS
BEGIN
    SET NOCOUNT ON;

    -- Validar que el nuevo email no esté tomado por OTRO usuario
    IF EXISTS (SELECT 1 FROM USUARIO WHERE email = @Email AND dni != @Dni)
    BEGIN
        RAISERROR('El correo electrónico ya se encuentra registrado por otro usuario.', 16, 1);
        RETURN;
    END

    UPDATE USUARIO
    SET 
        id_rol = @IdRol,
        nombre = @Nombre,
        apellido = @Apellido,
        email = @Email,
        contrasena_hash = ISNULL(@ContrasenaHash, contrasena_hash)
    WHERE dni = @Dni;
END
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_CambiarEstadoUsuario]
    @Dni VARCHAR(20),
    @NuevoEstado BIT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE USUARIO
    SET activo = @NuevoEstado
    WHERE dni = @Dni;
END
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_InsertarUsuario]
    @Dni VARCHAR(20),
    @IdRol INT,
    @Nombre VARCHAR(50),
    @Apellido VARCHAR(50),
    @Email VARCHAR(100),
    @ContrasenaHash VARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    -- Validar Email unico antes de insertar
    IF EXISTS (SELECT 1 FROM USUARIO WHERE email = @Email)
    BEGIN
        RAISERROR('El email ingresado ya se encuentra registrado en el sistema.', 16, 1);
        RETURN;
    END

    -- Validar DNI unico antes de insertar
    IF EXISTS (SELECT 1 FROM USUARIO WHERE dni = @Dni)
    BEGIN
        RAISERROR('El DNI ingresado ya se encuentra registrado en el sistema.', 16, 1);
        RETURN;
    END

    INSERT INTO USUARIO (dni, id_rol, nombre, apellido, email, contrasena_hash, activo)
    VALUES (@Dni, @IdRol, @Nombre, @Apellido, @Email, @ContrasenaHash, 1);
END
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_ListarUsuarios]
    @FiltroTexto VARCHAR(100) = NULL,
    @IdRol INT = NULL,
    @Activo BIT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        U.dni,
        U.id_rol,
        U.nombre,
        U.apellido,
        U.email,
        U.contrasena_hash,
        U.activo,
        R.nombre_rol,
        R.descripcion AS descripcion_rol
    FROM USUARIO U
    INNER JOIN ROL R ON U.id_rol = R.id_rol
    WHERE 
        (@FiltroTexto IS NULL OR @FiltroTexto = '' 
         OR U.dni LIKE '%' + @FiltroTexto + '%' 
         OR U.nombre LIKE '%' + @FiltroTexto + '%' 
         OR U.apellido LIKE '%' + @FiltroTexto + '%')
        AND (@IdRol IS NULL OR @IdRol = 0 OR U.id_rol = @IdRol)
        AND (@Activo IS NULL OR U.activo = @Activo)
    ORDER BY U.apellido, U.nombre;
END
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_ObtenerUsuarioPorEmail]
    @Email VARCHAR(100)
AS
BEGIN
    -- optimiza rendimiento
    SET NOCOUNT ON;

    SELECT 
        U.dni,
        U.id_rol,
        U.nombre,
        U.apellido,
        U.email,
        U.contrasena_hash,
        U.activo,
        R.nombre_rol,
        R.descripcion AS descripcion_rol
    FROM USUARIO U
    INNER JOIN ROL R ON U.id_rol = R.id_rol
    WHERE U.email = @Email;
END
GO

-- ----------------------------------------------------------------------
-- Verificación: debe devolver tablas = 11 y procedimientos = 48
-- ----------------------------------------------------------------------
SELECT
    (SELECT COUNT(*) FROM sys.tables WHERE schema_id = SCHEMA_ID('dbo'))     AS tablas,
    (SELECT COUNT(*) FROM sys.procedures WHERE schema_id = SCHEMA_ID('dbo')) AS procedimientos;
GO

SET NOEXEC OFF;
GO
