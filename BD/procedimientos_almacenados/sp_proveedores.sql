USE RGTS_Manager_BD;
GO

-- ===== sp_ListarProveedores =====
-- Usado por ProveedorRepositorio.ObtenerTodos(filtro)
DROP PROCEDURE IF EXISTS dbo.sp_ListarProveedores;
GO

CREATE PROCEDURE dbo.sp_ListarProveedores
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

-- ===== sp_ObtenerProveedorPorId =====
-- Usado por ProveedorRepositorio.BuscarPorId(idProveedor)
DROP PROCEDURE IF EXISTS dbo.sp_ObtenerProveedorPorId;
GO

CREATE PROCEDURE dbo.sp_ObtenerProveedorPorId
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

-- ===== sp_InsertarProveedor =====
-- Usado por ProveedorRepositorio.Insertar(proveedor)
DROP PROCEDURE IF EXISTS dbo.sp_InsertarProveedor;
GO

CREATE PROCEDURE dbo.sp_InsertarProveedor
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

-- ===== sp_ActualizarProveedor =====
-- Usado por ProveedorRepositorio.Actualizar(proveedor)
DROP PROCEDURE IF EXISTS dbo.sp_ActualizarProveedor;
GO

CREATE PROCEDURE dbo.sp_ActualizarProveedor
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

-- ===== sp_CambiarEstadoProveedor =====
-- Usado por ProveedorRepositorio.CambiarEstado(idProveedor, nuevoEstado)
DROP PROCEDURE IF EXISTS dbo.sp_CambiarEstadoProveedor;
GO

CREATE PROCEDURE dbo.sp_CambiarEstadoProveedor
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
