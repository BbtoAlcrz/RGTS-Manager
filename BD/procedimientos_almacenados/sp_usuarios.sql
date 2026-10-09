-- OBTENER USUARIOS POR SU ROL
IF OBJECT_ID('dbo.sp_ObtenerUsuarioPorEmail', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_ObtenerUsuarioPorEmail;
GO

CREATE PROCEDURE dbo.sp_ObtenerUsuarioPorEmail
    @Email VARCHAR(100)
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
    WHERE U.email = @Email;
END
GO


-- INSERTAR UN USUARIO
IF OBJECT_ID('dbo.sp_InsertarUsuario', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_InsertarUsuario;
GO

CREATE PROCEDURE dbo.sp_InsertarUsuario
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


-- ACTUALIZAR DATOS DE UN USUARIO
IF OBJECT_ID('dbo.sp_ActualizarUsuario', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_ActualizarUsuario;
GO

CREATE PROCEDURE dbo.sp_ActualizarUsuario
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


-- LISTAR USUARIOS EN LAS COLUMNAS
IF OBJECT_ID('dbo.sp_ListarUsuarios', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_ListarUsuarios;
GO

CREATE PROCEDURE dbo.sp_ListarUsuarios
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



-- CAMBIAR ESTADO ACTIVO / INACTIVO
IF OBJECT_ID('dbo.sp_CambiarEstadoUsuario', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_CambiarEstadoUsuario;
GO

CREATE PROCEDURE dbo.sp_CambiarEstadoUsuario
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