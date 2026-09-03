-- ********** CREACIÓN DE LA BASE DE DATOS **********

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'RGTS_Manager_BD')
BEGIN
    CREATE DATABASE RGTS_Manager_BD;
END
GO

USE RGTS_Manager_BD;
GO

-- TABLAS DE ROLES Y USUARIOS
IF OBJECT_ID('dbo.USUARIO', 'U') IS NULL
BEGIN
    CREATE TABLE ROL (
        id_rol INT IDENTITY(1,1) PRIMARY KEY,
        nombre_rol VARCHAR(50) NOT NULL UNIQUE,
        descripcion VARCHAR(200) NULL
    );

    CREATE TABLE USUARIO (
        id_usuario INT IDENTITY(1,1) PRIMARY KEY,
        id_rol INT NOT NULL,
        nombre VARCHAR(50) NOT NULL,
        apellido VARCHAR(50) NOT NULL,
        email VARCHAR(100) NOT NULL UNIQUE,
        contrasena_hash VARCHAR(255) NOT NULL,
        activo BIT NOT NULL DEFAULT 1,
        CONSTRAINT FK_Usuario_Rol FOREIGN KEY (id_rol) REFERENCES ROL(id_rol)
    );
END
GO

-- CLIENTES, CATEGORÍAS Y PROVEEDORES
IF OBJECT_ID('dbo.CLIENTE', 'U') IS NULL
BEGIN
    CREATE TABLE CLIENTE (
        id_cliente INT IDENTITY(1,1) PRIMARY KEY,
        nombre VARCHAR(50) NOT NULL,
        apellido VARCHAR(50) NOT NULL,
        dni VARCHAR(20) NOT NULL UNIQUE,
        telefono VARCHAR(30) NULL,
        email VARCHAR(100) NULL,
        activo BIT NOT NULL DEFAULT 1
    );

    CREATE TABLE CATEGORIA (
        id_categoria INT IDENTITY(1,1) PRIMARY KEY,
        nombre_categoria VARCHAR(50) NOT NULL UNIQUE,
        descripcion VARCHAR(200) NULL
    );

    CREATE TABLE PROVEEDOR (
        id_proveedor INT IDENTITY(1,1) PRIMARY KEY,
        razon_social VARCHAR(100) NOT NULL,
        nombre_comercial VARCHAR(100) NOT NULL,
        tipo_proveedor VARCHAR(50) NULL,
        nombre_contacto VARCHAR(50) NULL,
        apellido_contacto VARCHAR(50) NULL,
        telefono VARCHAR(30) NULL,
        correo VARCHAR(100) NULL,
        direccion VARCHAR(150) NULL,
        activo BIT NOT NULL DEFAULT 1
    );
END
GO

-- PRODUCTOS
IF OBJECT_ID('dbo.PRODUCTO', 'U') IS NULL
BEGIN
    CREATE TABLE PRODUCTO (
        id_producto INT IDENTITY(1,1) PRIMARY KEY,
        id_categoria INT NOT NULL,
        codigo VARCHAR(50) NOT NULL UNIQUE,
        nombre VARCHAR(100) NOT NULL,
        descripcion VARCHAR(255) NULL,
        precio DECIMAL(10,2) NOT NULL DEFAULT 0.00,
        stock_actual INT NOT NULL DEFAULT 0,
        stock_minimo INT NOT NULL DEFAULT 0,
        stock_maximo INT NOT NULL DEFAULT 0,
        activo BIT NOT NULL DEFAULT 1,
        CONSTRAINT FK_Producto_Categoria FOREIGN KEY (id_categoria) REFERENCES CATEGORIA(id_categoria)
    );
END
GO

-- COMPRAS Y DETALLE DE COMPRA
IF OBJECT_ID('dbo.COMPRA', 'U') IS NULL
BEGIN
    CREATE TABLE COMPRA (
        id_compra INT IDENTITY(1,1) PRIMARY KEY,
        id_usuario INT NOT NULL,
        id_proveedor INT NOT NULL,
        fecha DATETIME NOT NULL DEFAULT GETDATE(),
        total_derivado DECIMAL(10,2) NOT NULL DEFAULT 0.00,
        estado VARCHAR(30) NOT NULL DEFAULT 'Pendiente',
        CONSTRAINT FK_Compra_Usuario FOREIGN KEY (id_usuario) REFERENCES USUARIO(id_usuario),
        CONSTRAINT FK_Compra_Proveedor FOREIGN KEY (id_proveedor) REFERENCES PROVEEDOR(id_proveedor)
    );

    CREATE TABLE DETALLE_COMPRA (
        id_detalle_compra INT IDENTITY(1,1) PRIMARY KEY,
        id_compra INT NOT NULL,
        id_producto INT NOT NULL,
        cantidad INT NOT NULL,
        costo_unitario DECIMAL(10,2) NOT NULL,
        subtotal_derivado DECIMAL(10,2) NOT NULL,
        CONSTRAINT FK_DetalleCompra_Compra FOREIGN KEY (id_compra) REFERENCES COMPRA(id_compra),
        CONSTRAINT FK_DetalleCompra_Producto FOREIGN KEY (id_producto) REFERENCES PRODUCTO(id_producto)
    );
END
GO

-- VENTAS Y DETALLE DE VENTA
IF OBJECT_ID('dbo.VENTA', 'U') IS NULL
BEGIN
    CREATE TABLE VENTA (
        id_venta INT IDENTITY(1,1) PRIMARY KEY,
        id_usuario INT NOT NULL,
        id_cliente INT NULL,
        fecha DATETIME NOT NULL DEFAULT GETDATE(),
        total_derivado DECIMAL(10,2) NOT NULL DEFAULT 0.00,
        CONSTRAINT FK_Venta_Usuario FOREIGN KEY (id_usuario) REFERENCES USUARIO(id_usuario),
        CONSTRAINT FK_Venta_Cliente FOREIGN KEY (id_cliente) REFERENCES CLIENTE(id_cliente)
    );

    CREATE TABLE DETALLE_VENTA (
        id_detalle INT IDENTITY(1,1) PRIMARY KEY,
        id_venta INT NOT NULL,
        id_producto INT NOT NULL,
        cantidad INT NOT NULL,
        precio_unitario DECIMAL(10,2) NOT NULL,
        subtotal_derivado DECIMAL(10,2) NOT NULL,
        CONSTRAINT FK_DetalleVenta_Venta FOREIGN KEY (id_venta) REFERENCES VENTA(id_venta),
        CONSTRAINT FK_DetalleVenta_Producto FOREIGN KEY (id_producto) REFERENCES PRODUCTO(id_producto)
    );
END
GO




-- ********* PROCEDIMIENTOS ALMACENADOS *********

-- OBTENER USUARIO POR ROL Si ya existía, lo eliminamos para crearlo limpio
IF OBJECT_ID('dbo.sp_ObtenerUsuarioPorEmail', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_ObtenerUsuarioPorEmail;
GO

CREATE PROCEDURE dbo.sp_ObtenerUsuarioPorEmail
    @Email VARCHAR(100)
AS
BEGIN
    -- optimiza rendimiento
    SET NOCOUNT ON;

    SELECT 
        U.id_usuario,
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


-- **********************************************

-- SEEDERS (DEJAR SIEMPRE A LO ÚLTIMO) **********
IF NOT EXISTS (SELECT 1 FROM ROL)
BEGIN
    INSERT INTO ROL (nombre_rol, descripcion) VALUES 
    ('Administrador', 'Control y administración total del sistema'),
    ('Vendedor', 'Gestion de ventas y consultas de catálogo'),
    ('Encargado de Deposito', 'Control de stock, compras y proveedores');
END
GO

IF NOT EXISTS (SELECT 1 FROM USUARIO)
BEGIN
    -- Contraseña inicial sin hashear como prueba
    INSERT INTO USUARIO (id_rol, nombre, apellido, email, contrasena_hash, activo) VALUES
    (1, 'Fausto', 'Avalos Alurralde', 'admin@a.com', 'admin123', 1),
    (2, 'Benito', 'Alcaraz', 'vendedor@v.com', 'vendedor123', 1),
    (3, 'Carlos', 'Deposito', 'deposito@d.com', 'deposito123', 1);
END
GO