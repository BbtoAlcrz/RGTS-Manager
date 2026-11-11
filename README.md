# RGTS-Manager

RGTS-Manager es un sistema de escritorio independiente para la gestión interna del personal de la tienda Retro Gaming Tech Store.

---

## 📥 Descarga de la Aplicación

Puedes descargar la versión ejecutable lista para usar desde la sección de **Releases**:

👉 **[Descargar la última versión de RGTS Manager (.zip)](https://github.com/BbtoAlcrz/RGTS-Manager/releases/latest)**

**Nota:** Para ejecutar la aplicación es **necesario** contar con una instancia local de SQL Server (`localhost\SQLEXPRESS`) y haber corrido **los scripts de la base de datos** que se detallan a continuación.


## 🗄️ Base de datos

Los scripts de creación e inicialización se encuentran en la carpeta `BD/` del repositorio y deben ejecutarse en **SQL Server Management Studio (SSMS)** en el siguiente orden estricto:

1. [01_esquema_rgts.sql](https://github.com/BbtoAlcrz/RGTS-Manager/blob/main/BD/01_esquema_rgts.sql): Crea la base de datos `RGTS_Manager_BD`, sus 11 tablas y los 49 procedimientos almacenados. No carga datos. Si la base ya tiene el esquema, se detiene sin modificar nada.
2. [02_datos_precargados.sql](https://github.com/BbtoAlcrz/RGTS-Manager/blob/main/BD/02_datos_precargados.sql): Carga roles, usuarios, categorías, proveedores, clientes y productos de ejemplo. Se puede ejecutar más de una vez (solo inserta en tablas vacías).

> Cada script finaliza con una consulta de verificación automática (11 tablas, 49 procedimientos y conteo de filas cargadas).

La aplicación se conecta por defecto a `localhost\SQLEXPRESS`. Si tu instancia de SQL Server tiene otro nombre, debes ajustar la cadena de conexión.


## 🔑 Usuarios de prueba

El sistema cuenta con las siguientes cuentas de prueba precargadas:

| Rol | Email | Contraseña |
|---|---|---|
| Administrador | `admin@a.com` | `admin123` |
| Vendedor | `vendedor@v.com` | `vendedor123` |
| Encargado de Depósito | `deposito@d.com` | `deposito123` |

> las contraseñas se almacenan cifradas mediante **BCrypt**
