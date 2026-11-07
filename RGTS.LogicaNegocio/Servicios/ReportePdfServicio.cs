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
                             .FontSize(8).FontColor(Colors.Grey.Darken3);

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
                        .Text("RGTS-Manager - Documento generado automáticamente.")
                        .FontSize(8).Italic().FontColor(Colors.Grey.Medium);
                });
            }).GeneratePdf(rutaDestino);
        }
    }
}