using System;
using System.Threading;
using Microsoft.Data.SqlClient;

namespace RGTS.AccesoDatos.Repositorios
{
    // Ejecuta una operación transaccional completa y la reintenta si SQL Server la eligió como víctima
    // de un bloqueo cruzado (error 1205). Como la transacción ya se revirtió, reintentar es seguro.
    public static class ReintentoSql
    {
        public static T Ejecutar<T>(Func<T> operacion, int maxIntentos = 3)
        {
            for (int intento = 1; ; intento++)
            {
                try
                {
                    return operacion();
                }
                catch (SqlException ex) when (ex.Number == 1205 && intento < maxIntentos)
                {
                    Thread.Sleep(150 * intento);
                }
                catch (SqlException ex) when (ex.Number == 1205)
                {
                    throw new InvalidOperationException(
                        "El sistema está ocupado con otra operación. No se guardó ningún cambio; intente nuevamente.", ex);
                }
                catch (SqlException ex) when (ex.Number == -2)
                {
                    throw new InvalidOperationException(
                        "La operación tardó demasiado y se canceló. No se guardó ningún cambio; intente nuevamente.", ex);
                }
            }
        }

        public static void Ejecutar(Action operacion, int maxIntentos = 3)
            => Ejecutar<bool>(() => { operacion(); return true; }, maxIntentos);
    }
}