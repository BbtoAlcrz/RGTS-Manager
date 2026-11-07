using System;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using RGTS.Entidades;

namespace RGTS.LogicaNegocio.Servicios
{
    public class ReportePdfServicio
    {
        static ReportePdfServicio()
        {
            QuestPDF.Settings.License = LicenseType.Community;
        }

        // REPORTE DE VENTAS
        public void GenerarReporteVentasPdf(
            string rutaDestino,
            DateTime fechaDesde,
            DateTime fechaHasta,
            VentasMetricasDto metricas,
            byte[]? imagenGrafico)
        {
            string rutaLogo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Recursos", "logo.png");
            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(1.5f, Unit.Centimetre);
                    page.DefaultTextStyle(x => x.FontSize(10).FontFamily("Lato"));

                    // Encabezado
                    page.Header().Row(row =>
                    {
                        row.AutoItem().Column(col =>
                        {
                            if (File.Exists(rutaLogo))
                            {
                                col.Item().Height(45).Image(rutaLogo);
                            }
                        });

                        row.RelativeItem().PaddingLeft(10).Column(col =>
                        {
                            col.Item().Text("RGTS-Manager").FontSize(12).Bold().FontColor(Colors.Indigo.Darken2);
                            col.Item().Text("Reporte de Ventas").FontSize(18).Bold().FontColor(Colors.Indigo.Darken3);
                            col.Item().Text($"Período: {fechaDesde:dd/MM/yyyy} al {fechaHasta:dd/MM/yyyy}").FontSize(9.5f).Italic().FontColor(Colors.Grey.Darken2);
                        });

                        row.RelativeItem().AlignRight().Column(col =>
                        {
                            col.Item().Text($"Fecha de emisión").FontSize(8.5f);
                            col.Item().Text($"{DateTime.Now:dd/MM/yyyy HH:mm}").FontSize(8.5f);
                        });
                    });

                    // Contenido Principal
                    page.Content().PaddingVertical(0.8f, Unit.Centimetre).Column(col =>
                    {
                        // DESEMPEÑO FINANCIERO
                        col.Item().Text("Desempeño Financiero").FontSize(13).Bold().FontColor(Colors.Indigo.Darken2);
                        col.Item().PaddingBottom(4).LineHorizontal(1).LineColor(Colors.Indigo.Lighten2);

                        col.Item().PaddingBottom(8).Column(c =>
                        {
                            // Cantidad de Ventas
                            c.Item().Row(r =>
                            {
                                r.AutoItem().Text("» Cantidad de Ventas: ").Bold();
                                r.AutoItem().Text($" {metricas.CantidadVentas}").Bold();
                            });
                            c.Item().PaddingLeft(10)
                             .Text("Representa el número total de transacciones de venta concretadas durante el periodo.")
                             .FontSize(8).FontColor(Colors.Grey.Darken2);

                            c.Item().PaddingVertical(3);

                            // Total Facturado
                            c.Item().Row(r =>
                            {
                                r.AutoItem().Text("» Total Facturado: ").Bold();
                                r.AutoItem().Text($" {metricas.TotalFacturado:C2}").Bold();
                            });
                            c.Item().PaddingLeft(10)
                             .Text("Suma bruta global de todos los ingresos monetarios generados por ventas en el periodo seleccionado.")
                             .FontSize(8).FontColor(Colors.Grey.Darken2);

                            c.Item().PaddingVertical(3);

                            // Promedio Facturado por Vendedor
                            c.Item().Row(r =>
                            {
                                r.AutoItem().Text("» Promedio Facturado por vendedor: ").Bold();
                                r.AutoItem().Text($" {metricas.PromedioFacturadoPorVendedor:C2}").Bold();
                            });
                            c.Item().PaddingLeft(10)
                             .Text("Indicador de rendimiento económico promedio aportado por cada integrante del equipo de ventas con actividad.")
                             .FontSize(8).FontColor(Colors.Grey.Darken2);

                            c.Item().PaddingVertical(3);

                            // Margen de Ganancias Total
                            c.Item().Row(r =>
                            {
                                r.AutoItem().Text("» Margen de Ganancias total: ").Bold();
                                r.AutoItem().Text($" {metricas.MargenGananciasTotal:C2}").Bold();
                            });
                            c.Item().PaddingLeft(10)
                             .Text("Estimación de las ganancias obtenidas (descontando el costo de reposición) de los productos vendidos.")
                             .FontSize(8).FontColor(Colors.Grey.Darken2);
                        });

                        col.Item().PaddingVertical(4);


                        // RENDIMIENTO DE VENDEDORES
                        col.Item().Text("Rendimiento de Vendedores").FontSize(13).Bold().FontColor(Colors.Indigo.Darken2);
                        col.Item().PaddingBottom(4).LineHorizontal(1).LineColor(Colors.Indigo.Lighten2);

                        col.Item().PaddingBottom(8).Column(c =>
                        {
                            // Vendedor Estrella
                            c.Item().Row(r =>
                            {
                                r.AutoItem().Text("» Vendedor Estrella: ").Bold();
                                r.AutoItem().Text($" {metricas.VendedorEstrella}").Bold();
                            });
                            c.Item().PaddingLeft(10)
                             .Text("Vendedor del equipo que alcanzó el mayor volumen de dinero facturado ($) en el rango analizado.")
                             .FontSize(8).FontColor(Colors.Grey.Darken2);

                            c.Item().PaddingVertical(3);

                            // Vendedor con más operaciones
                            c.Item().Row(r =>
                            {
                                r.AutoItem().Text("» Vendedor con más operaciones: ").Bold();
                                r.AutoItem().Text($" {metricas.VendedorConMasOperaciones}").Bold();
                            });
                            c.Item().PaddingLeft(10)
                             .Text("Vendedor del equipo que concretó la mayor cantidad operaciones transaccionales.")
                             .FontSize(8).FontColor(Colors.Grey.Darken2);
                        });

                        col.Item().PaddingVertical(4);


                        // DESEMPEÑO TEMPORAL
                        col.Item().Text("Desempeño Temporal").FontSize(13).Bold().FontColor(Colors.Indigo.Darken2);
                        col.Item().PaddingBottom(4).LineHorizontal(1).LineColor(Colors.Indigo.Lighten2);

                        col.Item().PaddingBottom(8).Column(c =>
                        {
                            // Fecha pico de ventas
                            c.Item().Row(r =>
                            {
                                r.AutoItem().Text("» Fecha pico de ventas: ").Bold();
                                r.AutoItem().Text($" {metricas.FechaPicoVentas}").Bold();
                            });
                            c.Item().PaddingLeft(10)
                             .Text("Fecha puntual que registró la mayor recaudación comercial en el periodo analizado.")
                             .FontSize(8).FontColor(Colors.Grey.Darken2);

                            c.Item().PaddingVertical(3);

                            // Día con más ventas
                            c.Item().Row(r =>
                            {
                                r.AutoItem().Text("» Día con más ventas: ").Bold();
                                r.AutoItem().Text($" {metricas.DiaConMasVentas}").Bold();
                            });
                            c.Item().PaddingLeft(10)
                             .Text("Día que concentra de forma recurrente el mayor promedio de transacciones.")
                             .FontSize(8).FontColor(Colors.Grey.Darken2);

                            c.Item().PaddingVertical(3);

                            // Hora pico de ventas
                            c.Item().Row(r =>
                            {
                                r.AutoItem().Text("» Hora pico de ventas: ").Bold();
                                r.AutoItem().Text($" {metricas.HoraPicoVentas}").Bold();
                            });
                            c.Item().PaddingLeft(10)
                             .Text("Franja horaria con mayor flujo comercial y concentración de compras en el local.")
                             .FontSize(8).FontColor(Colors.Grey.Darken2);
                        });

                        // Gráfico opcional
                        if (imagenGrafico != null && imagenGrafico.Length > 0)
                        {
                            col.Item().PaddingTop(6).Text("Comparativa Visual de Ventas").FontSize(11).Bold().FontColor(Colors.Indigo.Darken2);
                            col.Item().Height(250).Image(imagenGrafico);
                        }
                    });

                    // PIE DE PÁGINA
                    page.Footer().AlignCenter()
                        .Text("Documento generado automáticamente")
                        .FontSize(8).Italic().FontColor(Colors.Grey.Medium);
                });
            }).GeneratePdf(rutaDestino);
        }



        // REPORTE DE CLIENTES
        public void GenerarReporteClientesPdf(
            string rutaDestino,
            DateTime fechaDesde,
            DateTime fechaHasta,
            ClientesMetricasDto metricas,
            byte[]? imagenGrafico)
        {
            string rutaLogo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Recursos", "logo.png");

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(1.5f, Unit.Centimetre);
                    page.DefaultTextStyle(x => x.FontSize(10).FontFamily("Lato"));

                    // Encabezado
                    page.Header().Row(row =>
                    {
                        row.AutoItem().Column(col =>
                        {
                            if (File.Exists(rutaLogo))
                            {
                                col.Item().Height(45).Image(rutaLogo);
                            }
                        });

                        row.RelativeItem().PaddingLeft(10).Column(col =>
                        {
                            col.Item().Text("RGTS-Manager").FontSize(12).Bold().FontColor(Colors.Indigo.Darken2);
                            col.Item().Text("Reporte de Clientes").FontSize(18).Bold().FontColor(Colors.Indigo.Darken3);
                            col.Item().Text($"Período: {fechaDesde:dd/MM/yyyy} al {fechaHasta:dd/MM/yyyy}").FontSize(9.5f).Italic().FontColor(Colors.Grey.Darken2);
                        });

                        row.RelativeItem().AlignRight().Column(col =>
                        {
                            col.Item().Text("Fecha de emisión").FontSize(8.5f);
                            col.Item().Text($"{DateTime.Now:dd/MM/yyyy HH:mm}").FontSize(8.5f);
                        });
                    });

                    // Contenido Principal
                    page.Content().PaddingVertical(0.8f, Unit.Centimetre).Column(col =>
                    {
                        // DESEMPEÑO DE CLIENTES
                        col.Item().Text("Desempeño de Clientes").FontSize(13).Bold().FontColor(Colors.Indigo.Darken2);
                        col.Item().PaddingBottom(4).LineHorizontal(1).LineColor(Colors.Indigo.Lighten2);

                        col.Item().PaddingBottom(8).Column(c =>
                        {
                            // Clientes Activos
                            c.Item().Row(r =>
                            {
                                r.AutoItem().Text("» Total Clientes Activos: ").Bold();
                                r.AutoItem().Text($" {metricas.TotalClientesActivos}").Bold();
                            });
                            c.Item().PaddingLeft(10)
                             .Text("Cantidad total de clientes registrados en el sistema hasta la actualidad (no cuenta el periodo).")
                             .FontSize(8).FontColor(Colors.Grey.Darken2);

                            c.Item().PaddingVertical(3);

                            // Clientes Nuevos
                            c.Item().Row(r =>
                            {
                                r.AutoItem().Text("» Clientes Nuevos: ").Bold();
                                r.AutoItem().Text($" {metricas.ClientesNuevos}").Bold();
                            });
                            c.Item().PaddingLeft(10)
                             .Text("Número de clientes dados de alta durante el período analizado.")
                             .FontSize(8).FontColor(Colors.Grey.Darken2);

                            c.Item().PaddingVertical(3);
                        });

                        col.Item().PaddingVertical(4);

                        // MÉTRICAS DE RECURRENCIA
                        col.Item().Text("Métricas de Recurrencia").FontSize(13).Bold().FontColor(Colors.Indigo.Darken2);
                        col.Item().PaddingBottom(4).LineHorizontal(1).LineColor(Colors.Indigo.Lighten2);

                        col.Item().PaddingBottom(8).Column(c =>
                        {
                            // Cliente Estrella
                            c.Item().Row(r =>
                            {
                                r.AutoItem().Text("» Cliente Estrella: ").Bold();
                                r.AutoItem().Text($" {metricas.ClienteEstrella}").Bold();
                            });
                            c.Item().PaddingLeft(10)
                             .Text("Cliente que representó el mayor volumen monetario($) acumulado en compras.")
                             .FontSize(8).FontColor(Colors.Grey.Darken2);

                            c.Item().PaddingVertical(3);

                            // Clientes Recurrentes
                            c.Item().Row(r =>
                            {
                                r.AutoItem().Text("» Clientes Recurrentes: ").Bold();
                                r.AutoItem().Text($" {metricas.CantidadClientesRecurrentes}").Bold();
                            });
                            c.Item().PaddingLeft(10)
                             .Text("Cantidad de clientes que realizaron 2 o más transacciones comerciales en el período analizado.")
                             .FontSize(8).FontColor(Colors.Grey.Darken2);

                            c.Item().PaddingVertical(3);

                            // Porcentaje de Recurrencia
                            c.Item().Row(r =>
                            {
                                r.AutoItem().Text("» Porcentaje de Recurrencia: ").Bold();
                                r.AutoItem().Text($" {metricas.PorcentajeRecurrencia:F1}%").Bold();
                            });
                            c.Item().PaddingLeft(10)
                             .Text("Proporción de clientes que volvieron a realizar al menos una compra dentro del rango seleccionado.")
                             .FontSize(8).FontColor(Colors.Grey.Darken2);
                        });

                        col.Item().PaddingVertical(4);

                        // PROMEDIO COMERCIAL
                        col.Item().Text("Promedio Comercial").FontSize(13).Bold().FontColor(Colors.Indigo.Darken2);
                        col.Item().PaddingBottom(4).LineHorizontal(1).LineColor(Colors.Indigo.Lighten2);

                        col.Item().PaddingBottom(8).Column(c =>
                        {
                            // Facturación de Clientes Registrados
                            c.Item().Row(r =>
                            {
                                r.AutoItem().Text("» Total Gastado por clientes: ").Bold();
                                r.AutoItem().Text($" {metricas.FacturacionClientesRegistrados:C2}").Bold();
                            });
                            c.Item().PaddingLeft(10)
                             .Text("Monto global facturado proveniente exclusivamente de compras vinculadas a clientes identificados (sin 'Consumidor Final'').")
                             .FontSize(8).FontColor(Colors.Grey.Darken2);

                            c.Item().PaddingVertical(3);

                            // Promedio de Compras por Cliente
                            c.Item().Row(r =>
                            {
                                r.AutoItem().Text("» Promedio de Compras por cliente: ").Bold();
                                r.AutoItem().Text($" {metricas.PromedioComprasPorCliente:N1} operaciones.").Bold();
                            });
                            c.Item().PaddingLeft(10)
                             .Text("Frecuencia promedio de transacciones efectivas que fueron efectuadas por cada comprador.")
                             .FontSize(8).FontColor(Colors.Grey.Darken2);

                            c.Item().PaddingVertical(3);

                            // Clientes Compradores Únicos
                            c.Item().Row(r =>
                            {
                                r.AutoItem().Text("» Compradores Únicos: ").Bold();
                                r.AutoItem().Text($" {metricas.ClientesCompradoresUnicos}").Bold();
                            });
                            c.Item().PaddingLeft(10)
                             .Text("Total de clientes distintos (identificados o no) que registraron actividad comercial en el local.")
                             .FontSize(8).FontColor(Colors.Grey.Darken2);
                        });

                        // Gráfico opcional de Distribución
                        if (imagenGrafico != null && imagenGrafico.Length > 0)
                        {
                            col.Item().PaddingTop(6).Text("Comparativa visual de comportamiento de clientes").FontSize(11).Bold().FontColor(Colors.Indigo.Darken2);
                            col.Item().Height(250).Image(imagenGrafico);
                        }
                    });

                    // Pie de página
                    page.Footer().AlignCenter()
                        .Text("Documento generado automáticamente")
                        .FontSize(8).Italic().FontColor(Colors.Grey.Medium);
                });
            }).GeneratePdf(rutaDestino);
        }



        //
        public void GenerarReporteProductosPdf(
    string rutaDestino,
    DateTime fechaDesde,
    DateTime fechaHasta,
    ProductosMetricasDto metricas,
    byte[]? imagenGrafico)
        {
            string rutaLogo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Recursos", "logo.png");

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(1.5f, Unit.Centimetre);
                    page.DefaultTextStyle(x => x.FontSize(10).FontFamily("Lato"));

                    // Encabezado
                    page.Header().Row(row =>
                    {
                        row.AutoItem().Column(col =>
                        {
                            if (File.Exists(rutaLogo))
                            {
                                col.Item().Height(45).Image(rutaLogo);
                            }
                        });

                        row.RelativeItem().PaddingLeft(10).Column(col =>
                        {
                            col.Item().Text("RGTS-Manager").FontSize(12).Bold().FontColor(Colors.Indigo.Darken2);
                            col.Item().Text("Reporte de Productos").FontSize(18).Bold().FontColor(Colors.Indigo.Darken3);
                            col.Item().Text($"Período: {fechaDesde:dd/MM/yyyy} al {fechaHasta:dd/MM/yyyy}").FontSize(9.5f).Italic().FontColor(Colors.Grey.Darken2);
                        });

                        row.RelativeItem().AlignRight().Column(col =>
                        {
                            col.Item().Text("Fecha de emisión").FontSize(8.5f);
                            col.Item().Text($"{DateTime.Now:dd/MM/yyyy HH:mm}").FontSize(8.5f);
                        });
                    });

                    // Contenido Principal
                    page.Content().PaddingVertical(0.8f, Unit.Centimetre).Column(col =>
                    {
                        // VALORIZACIÓN DE INVENTARIO
                        col.Item().Text("Valorización de Inventario").FontSize(13).Bold().FontColor(Colors.Indigo.Darken2);
                        col.Item().PaddingBottom(4).LineHorizontal(1).LineColor(Colors.Indigo.Lighten2);

                        col.Item().PaddingBottom(8).Column(c =>
                        {
                            // Valor Total del Inventario
                            c.Item().Row(r =>
                            {
                                r.AutoItem().Text("» Valor Total del Inventario: ").Bold();
                                r.AutoItem().Text($" {metricas.ValorTotalInventario:C2}").Bold();
                            });
                            c.Item().PaddingLeft(10)
                             .Text("Valorizacion total del capital de acuerdo al stock y al precio de venta actual.")
                             .FontSize(8).FontColor(Colors.Grey.Darken2);

                            c.Item().PaddingVertical(3);

                            // Productos Activos
                            c.Item().Row(r =>
                            {
                                r.AutoItem().Text("» Productos Activos: ").Bold();
                                r.AutoItem().Text($" {metricas.TotalProductosActivos}").Bold();
                            });
                            c.Item().PaddingLeft(10)
                             .Text("Cantidad de artículos habilitados comercialmente dentro del catálogo del sistema.")
                             .FontSize(8).FontColor(Colors.Grey.Darken2);
                        });

                        col.Item().PaddingVertical(4);

                        // CONTROL DE STOCK
                        col.Item().Text("Control de Stock").FontSize(13).Bold().FontColor(Colors.Indigo.Darken2);
                        col.Item().PaddingBottom(4).LineHorizontal(1).LineColor(Colors.Indigo.Lighten2);

                        col.Item().PaddingBottom(8).Column(c =>
                        {
                            // Stock Crítico
                            c.Item().Row(r =>
                            {
                                r.AutoItem().Text("» Productos en Stock Crítico: ").Bold();
                                r.AutoItem().Text($" {metricas.ProductosStockCritico}").Bold();
                            });
                            c.Item().PaddingLeft(10)
                             .Text("Artículos cuyo stock actual se encuentra por debajo o igual al límite mínimo establecido.")
                             .FontSize(8).FontColor(Colors.Grey.Darken2);

                            c.Item().PaddingVertical(3);

                            // Agotados
                            c.Item().Row(r =>
                            {
                                r.AutoItem().Text("» Productos Agotados: ").Bold();
                                r.AutoItem().Text($" {metricas.ProductosAgotados}").Bold();
                            });
                            c.Item().PaddingLeft(10)
                             .Text("Artículos en el catálogo que no cuentan con unidades disponibles para la venta.")
                             .FontSize(8).FontColor(Colors.Grey.Darken2);

                            c.Item().PaddingVertical(3);

                            // Salud / Stock Óptimo
                            c.Item().Row(r =>
                            {
                                r.AutoItem().Text("» Porcentaje del Stock en óptimo estado: ").Bold();
                                r.AutoItem().Text($" {metricas.PorcentajeStockOptimo:F1}%").Bold();
                            });
                            c.Item().PaddingLeft(10)
                             .Text("Porcentaje de productos del catálogo que mantienen niveles óptimos de stock.")
                             .FontSize(8).FontColor(Colors.Grey.Darken2);
                        });

                        col.Item().PaddingVertical(4);

                        // RENDIMIENTO Y ROTACIÓN
                        col.Item().Text("Rendimiento y Rotación en el Período").FontSize(13).Bold().FontColor(Colors.Indigo.Darken2);
                        col.Item().PaddingBottom(4).LineHorizontal(1).LineColor(Colors.Indigo.Lighten2);

                        col.Item().PaddingBottom(8).Column(c =>
                        {
                            // Producto Estrella
                            c.Item().Row(r =>
                            {
                                r.AutoItem().Text("» Producto Estrella: ").Bold();
                                r.AutoItem().Text($" {metricas.ProductoEstrella}").Bold();
                            });
                            c.Item().PaddingLeft(10)
                             .Text("Artículo que acumuló el mayor número de unidades vendidas en el lapso seleccionado.")
                             .FontSize(8).FontColor(Colors.Grey.Darken2);

                            c.Item().PaddingVertical(3);

                            // Categoría Estrella
                            c.Item().Row(r =>
                            {
                                r.AutoItem().Text("» Categoría Estrella: ").Bold();
                                r.AutoItem().Text($" {metricas.CategoriaEstrella}").Bold();
                            });
                            c.Item().PaddingLeft(10)
                             .Text("Rubro o categoría comercial con el mayor monto($) global de facturación generada.")
                             .FontSize(8).FontColor(Colors.Grey.Darken2);

                            c.Item().PaddingVertical(3);

                            // Promedio de Ventas
                            c.Item().Row(r =>
                            {
                                r.AutoItem().Text("» Promedio de unidades vendidas por producto: ").Bold();
                                r.AutoItem().Text($" {metricas.PromedioUnidadesVendidas:N1} unidades.").Bold();
                            });
                            c.Item().PaddingLeft(10)
                             .Text("Promedio de unidades comercializadas en el rango seleccionado, considerando productos activos.")
                             .FontSize(8).FontColor(Colors.Grey.Darken2);
                        });

                        // Gráfico opcional del Top Productos
                        if (imagenGrafico != null && imagenGrafico.Length > 0)
                        {
                            col.Item().PaddingTop(6).Text("Comparacion visual de los 5 Productos más vendidos").FontSize(11).Bold().FontColor(Colors.Indigo.Darken2);
                            col.Item().Height(250).Image(imagenGrafico);
                        }
                    });

                    // Pie de página
                    page.Footer().AlignCenter()
                        .Text("Documento generado automáticamente")
                        .FontSize(8).Italic().FontColor(Colors.Grey.Medium);
                });
            }).GeneratePdf(rutaDestino);
        }
    }
}