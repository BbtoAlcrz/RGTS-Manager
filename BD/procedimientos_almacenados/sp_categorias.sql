USE RGTS_Manager_BD;
GO

-- ===== sp_ListarCategorias =====
-- Usado por CategoriaRepositorio.ObtenerTodas()
DROP PROCEDURE IF EXISTS dbo.sp_ListarCategorias;
GO

CREATE PROCEDURE dbo.sp_ListarCategorias
AS
BEGIN
    SET NOCOUNT ON;

    SELECT id_categoria, nombre_categoria, descripcion, activo
    FROM CATEGORIA
    ORDER BY nombre_categoria;
END
GO

-- ===== sp_ObtenerCategoriaPorId =====
-- Usado por CategoriaRepositorio.ObtenerPorId(idCategoria)
DROP PROCEDURE IF EXISTS dbo.sp_ObtenerCategoriaPorId;
GO

CREATE PROCEDURE dbo.sp_ObtenerCategoriaPorId
    @IdCategoria INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT id_categoria, nombre_categoria, descripcion, activo
    FROM CATEGORIA
    WHERE id_categoria = @IdCategoria;
END
GO

-- ===== sp_InsertarCategoria =====
-- Usado por CategoriaRepositorio.Insertar(categoria)
DROP PROCEDURE IF EXISTS dbo.sp_InsertarCategoria;
GO

CREATE PROCEDURE dbo.sp_InsertarCategoria
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

-- ===== sp_ActualizarCategoria =====
-- Usado por CategoriaRepositorio.Actualizar(categoria)
DROP PROCEDURE IF EXISTS dbo.sp_ActualizarCategoria;
GO

CREATE PROCEDURE dbo.sp_ActualizarCategoria
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

-- ===== sp_CambiarEstadoCategoria =====
-- Usado por CategoriaRepositorio.CambiarEstado(idCategoria, nuevoEstado)
DROP PROCEDURE IF EXISTS dbo.sp_CambiarEstadoCategoria;
GO

CREATE PROCEDURE dbo.sp_CambiarEstadoCategoria
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
