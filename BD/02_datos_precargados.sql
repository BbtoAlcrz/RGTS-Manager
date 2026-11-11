/* ======================================================================
   RGTS Manager - 02_datos_precargados.sql
   Datos iniciales de RGTS_Manager_BD: roles, usuarios, categorías,
   proveedores, clientes y productos de ejemplo.

   Requisito: haber ejecutado antes 01_esquema_rgts.sql.
   Se puede ejecutar más de una vez: cada bloque solo inserta si su tabla
   está vacía. No carga ventas, compras ni reservas de stock (esas tablas
   quedan vacías a propósito: las reservas son temporales y las ventas y
   compras las genera el uso del sistema).

   Usuarios de prueba (iniciar sesión con el EMAIL):
       admin@a.com      / admin123      (Administrador)
       vendedor@v.com   / vendedor123   (Vendedor)
       deposito@d.com   / deposito123   (Encargado de Deposito)
   Las contraseñas se guardan como hash BCrypt (costo 11), igual que las que
   crea la aplicación. Nunca se guardan en texto plano.
   ====================================================================== */

USE RGTS_Manager_BD;
GO

-- ---------------------------------------------------------------- ROLES
IF NOT EXISTS (SELECT 1 FROM ROL)
BEGIN
    INSERT INTO ROL (nombre_rol, descripcion) VALUES
    ('Administrador',         'Control y administración total del sistema'),
    ('Vendedor',              'Gestion de ventas y consultas de catálogo'),
    ('Encargado de Deposito', 'Control de stock, compras y proveedores');
END
GO

-- ------------------------------------------------------------- USUARIOS
IF NOT EXISTS (SELECT 1 FROM USUARIO)
BEGIN
    INSERT INTO USUARIO (dni, id_rol, nombre, apellido, email, contrasena_hash, activo)
    SELECT '47366368', r.id_rol, 'Fausto', 'Avalos Alurralde', 'admin@a.com', '$2a$11$iRz/hFIYNKAYocqFg0oa7.DvtolhrZ8JJxCv/EQx4aXACxMtFib3.', 1
    FROM ROL r WHERE r.nombre_rol = 'Administrador'
    UNION ALL
    SELECT '45020546', r.id_rol, 'Benito', 'Alcaraz', 'vendedor@v.com', '$2a$11$yavEUysI6S7bT9HlVtSgzu3U.jt8OmxjdUjbI6RwKPsWy4ockR/Ai', 1
    FROM ROL r WHERE r.nombre_rol = 'Vendedor'
    UNION ALL
    SELECT '12345678', r.id_rol, 'Carlos', 'Deposito', 'deposito@d.com', '$2a$11$7QlfLLNJ2w.Nwhzu1pNfe.QMeOEsk2b1IDfR.a2s2TgvvdBDL/KNu', 1
    FROM ROL r WHERE r.nombre_rol = 'Encargado de Deposito';
END
GO

-- ----------------------------------------------------------- CATEGORIAS
IF NOT EXISTS (SELECT 1 FROM CATEGORIA)
BEGIN
    INSERT INTO CATEGORIA (nombre_categoria, descripcion, activo) VALUES
    ('Sobremesa',  'Conectala a la tele y disfrutá de los grandes clásicos', 1),
    ('Portátil',   'Llevá tus partidas clásicas vayas donde vayas', 1),
    ('Joystick',   'Mandos, joysticks y pads originales o alternativos', 1),
    ('Juegos',     'Discos y cartuchos originales para todas las generaciones', 1),
    ('Accesorios', 'Cables, fuentes de alimentación, memory cards y más', 1);
END
GO

-- ---------------------------------------------------------- PROVEEDORES
IF NOT EXISTS (SELECT 1 FROM PROVEEDOR)
BEGIN
    INSERT INTO PROVEEDOR (razon_social, nombre_comercial, tipo_proveedor, nombre_contacto, apellido_contacto, telefono, correo, direccion, activo) VALUES
    ('Distribuidora Gamer S.R.L', 'Gamer distribuidora', 'Mandos',               'Gonzalo',  'Montiel',  '1143-090807', 'ventas@gamerdistribuidora.com', 'Belgrano 387, Buenos Aires', 1),
    ('TechImport S.A',            'TechImport',          'Consolas de Mesa',     'Emiliano', 'Martinez', '3414-323258', 'contacto@techimport.com',       'Av. Siempre Viva 742, Rosario', 1),
    ('RetroShop S.R.L',           'Retro Shop',          'Consolas Portátiles',  'Lucía',    'Benítez',  '1117-650837', 'RetroShop@shopp.com',           '12 de Octubre 1100, Resistencia', 1),
    ('Cartuchos del Sur S.A',     'Cartuchos del Sur',   'Otros',                'Martín',   'Duarte',   '3794-445566', 'pedidos@cartuchosdelsur.com',   'Av. 9 de Julio 850, Corrientes', 1);
END
GO

-- -------------------------------------------------------------- CLIENTES
IF NOT EXISTS (SELECT 1 FROM CLIENTE)
BEGIN
    INSERT INTO CLIENTE (nombre, apellido, dni, telefono, email, activo) VALUES
    ('Hugh',   'Jackman',  '12101968', '3794-123456', 'notWolverine@gmail.com', 1),
    ('Taylor', 'Swift',    '13121989', '3795-654321', 'itsTaylor@gmail.com',    1),
    ('Ryan',   'Reynolds', '23101976', '1107-121314', NULL,                     1),
    ('Tom',    'Holland',  '01061996', NULL,          NULL,                     1),
    ('Julián', 'Alvarez',  '31012000', NULL,          NULL,                     1);
END
GO

-- ------------------------------------------------------------ PRODUCTOS
-- Reglas del sistema: stock_minimo < stock_maximo y stock_minimo <= stock_actual <= stock_maximo
IF NOT EXISTS (SELECT 1 FROM PRODUCTO)
BEGIN
    INSERT INTO PRODUCTO (id_categoria, codigo, nombre, descripcion, precio, stock_actual, stock_minimo, stock_maximo, activo)
    SELECT c.id_categoria, v.codigo, v.nombre, v.descripcion, v.precio, v.stock_actual, v.stock_minimo, v.stock_maximo, 1
    FROM (VALUES
        -- Sobremesa
        ('Sobremesa', 'SOB-001', 'Consola Retro HDMI 620 juegos',      'Consola plug and play con salida HDMI y dos mandos',      85000.00, 12,  3,  30),
        ('Sobremesa', 'SOB-002', 'Sega Genesis Mini',                  'Réplica en miniatura con 42 juegos incluidos',           210000.00,  6,  2,  15),
        ('Sobremesa', 'SOB-003', 'Super Nintendo reacondicionada',     'Consola revisada, con fuente, cables y un mando',        180000.00,  5,  2,  12),
        ('Sobremesa', 'SOB-004', 'PlayStation 1 reacondicionada',      'Modelo SCPH-7501, con mando y memory card',              150000.00,  7,  2,  15),
        ('Sobremesa', 'SOB-005', 'Atari 2600 réplica',                 'Réplica con dos joysticks y juegos precargados',         120000.00,  4,  2,  10),
        -- Portátil
        ('Portátil',  'POR-001', 'Game Boy Color reacondicionada',     'Pantalla nueva, carcasa renovada, sin juego',             95000.00,  8,  3,  20),
        ('Portátil',  'POR-002', 'Game Boy Advance SP',                'Con luz frontal y cargador original',                    140000.00,  6,  2,  15),
        ('Portátil',  'POR-003', 'PSP 3000 reacondicionada',           'Incluye batería, cargador y memoria de 8 GB',            165000.00,  5,  2,  12),
        ('Portátil',  'POR-004', 'Consola portátil retro 3.5 pulgadas', 'Más de 3000 juegos clásicos, batería recargable',        70000.00, 15,  4,  35),
        -- Joystick
        ('Joystick',  'JOY-001', 'Joystick USB estilo SNES',           'Compatible con PC y consolas retro con entrada USB',      18000.00, 25,  8,  60),
        ('Joystick',  'JOY-002', 'Joystick inalámbrico 2.4G retro',    'Dos unidades con receptor USB',                           32000.00, 18,  6,  40),
        ('Joystick',  'JOY-003', 'Control PS1 alternativo',            'Con vibración, compatible con PS1 y PS2',                 22000.00, 20,  6,  45),
        ('Joystick',  'JOY-004', 'Arcade stick USB',                   'Palanca y 8 botones, base antideslizante',                65000.00,  7,  3,  18),
        -- Juegos
        ('Juegos',    'JUE-001', 'Super Mario World (cartucho SNES)',  'Cartucho original, probado',                              45000.00, 10,  3,  25),
        ('Juegos',    'JUE-002', 'Sonic the Hedgehog (Genesis)',       'Cartucho original con caja',                              38000.00,  9,  3,  25),
        ('Juegos',    'JUE-003', 'Crash Bandicoot (PS1)',              'Disco original, carátula y manual',                       28000.00, 11,  3,  25),
        ('Juegos',    'JUE-004', 'Pokémon Rojo (Game Boy)',            'Cartucho original con batería nueva',                     52000.00,  6,  2,  15),
        ('Juegos',    'JUE-005', 'The Legend of Zelda: Ocarina of Time (N64)', 'Cartucho original, probado',                      60000.00,  5,  2,  12),
        -- Accesorios
        ('Accesorios','ACC-001', 'Cable HDMI para consola retro',      'Cable de 1.5 m, alta velocidad',                           6500.00, 40, 10, 100),
        ('Accesorios','ACC-002', 'Fuente 9V universal',                'Fuente de 9V 1A con puntas intercambiables',               9000.00, 30,  8,  80),
        ('Accesorios','ACC-003', 'Memory card PS1 1 MB',               'Tarjeta de memoria de 15 bloques',                         8500.00, 35, 10,  90),
        ('Accesorios','ACC-004', 'Cable AV compuesto',                 'Cable de audio y video RCA, 1.8 m',                        4500.00, 28,  8,  70)
    ) AS v(categoria, codigo, nombre, descripcion, precio, stock_actual, stock_minimo, stock_maximo)
    INNER JOIN CATEGORIA c ON c.nombre_categoria = v.categoria;
END
GO

-- ------------------------------------------------------- VERIFICACION
SELECT 'ROL' AS tabla, COUNT(*) AS filas FROM ROL
UNION ALL SELECT 'USUARIO',   COUNT(*) FROM USUARIO
UNION ALL SELECT 'CATEGORIA', COUNT(*) FROM CATEGORIA
UNION ALL SELECT 'PROVEEDOR', COUNT(*) FROM PROVEEDOR
UNION ALL SELECT 'CLIENTE',   COUNT(*) FROM CLIENTE
UNION ALL SELECT 'PRODUCTO',  COUNT(*) FROM PRODUCTO
UNION ALL SELECT 'RESERVA_STOCK (debe ser 0)', COUNT(*) FROM RESERVA_STOCK;
GO
