USE RGTS_Manager_BD;
GO

-- ===== sp_ListarClientes =====
-- Usado por ClienteRepositorio.ObtenerTodos(filtro)
DROP PROCEDURE IF EXISTS dbo.sp_ListarClientes;
GO

CREATE PROCEDURE dbo.sp_ListarClientes
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

-- ===== sp_ObtenerClientePorId =====
-- Usado por ClienteRepositorio.ObtenerPorId(idCliente)
DROP PROCEDURE IF EXISTS dbo.sp_ObtenerClientePorId;
GO

CREATE PROCEDURE dbo.sp_ObtenerClientePorId
    @IdCliente INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT id_cliente, nombre, apellido, dni, telefono, email, activo
    FROM CLIENTE
    WHERE id_cliente = @IdCliente;
END
GO

-- ===== sp_ObtenerClientePorDni =====
-- Usado por ClienteRepositorio.BuscarPorDni(dni)
DROP PROCEDURE IF EXISTS dbo.sp_ObtenerClientePorDni;
GO

CREATE PROCEDURE dbo.sp_ObtenerClientePorDni
    @Dni VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT id_cliente, nombre, apellido, dni, telefono, email, activo
    FROM CLIENTE
    WHERE dni = @Dni AND activo = 1;
END
GO

-- ===== sp_InsertarCliente =====
-- Usado por ClienteRepositorio.Insertar(cliente)
DROP PROCEDURE IF EXISTS dbo.sp_InsertarCliente;
GO

CREATE PROCEDURE dbo.sp_InsertarCliente
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

-- ===== sp_ActualizarCliente =====
-- Usado por ClienteRepositorio.Actualizar(cliente)
DROP PROCEDURE IF EXISTS dbo.sp_ActualizarCliente;
GO

CREATE PROCEDURE dbo.sp_ActualizarCliente
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

-- ===== sp_CambiarEstadoCliente =====
-- Usado por ClienteRepositorio.CambiarEstado(idCliente, nuevoEstado)
DROP PROCEDURE IF EXISTS dbo.sp_CambiarEstadoCliente;
GO

CREATE PROCEDURE dbo.sp_CambiarEstadoCliente
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
