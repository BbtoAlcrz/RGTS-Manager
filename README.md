# RGTS-Manager
RGTS-Manager es un sistema de escritorio independiente para la gestión interna del personal de la tienda Retro Gaming Tech Store.

## Base de datos

Los scripts están en la carpeta `BD/` y se ejecutan en SQL Server Management Studio, en este orden:

1. `01_esquema_rgts.sql`: crea la base `RGTS_Manager_BD`, sus 11 tablas y los 49 procedimientos almacenados. No carga datos. Si la base ya tiene el esquema, se detiene sin modificar nada.
2. `02_datos_precargados.sql`: carga roles, usuarios, categorías, proveedores, clientes y productos de ejemplo. Se puede ejecutar más de una vez (solo inserta en tablas vacías).

Cada script termina con una consulta de verificación (11 tablas y 49 procedimientos; y la cantidad de filas cargadas).

La aplicación se conecta a `localhost\SQLEXPRESS`. Si la instancia tiene otro nombre, hay que ajustar la cadena de conexión.

## Usuarios de prueba

| Rol | Email | Contraseña |
|---|---|---|
| Administrador | admin@a.com | admin123 |
| Vendedor | vendedor@v.com | vendedor123 |
| Encargado de Depósito | deposito@d.com | deposito123 |

Las contraseñas se guardan cifradas con BCrypt.
