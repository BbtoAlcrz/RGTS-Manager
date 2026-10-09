using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using RGTS.Entidades;
using System;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Resources;

namespace RGTS.LogicaNegocio.Servicios
{
    public class PdfFacturaServicio
    {
        
        static PdfFacturaServicio()
        {
            QuestPDF.Settings.License = LicenseType.Community;
        }

        public string GenerarFactura(Venta venta, string rutaDestino)
        {
            Document.Create(container => 
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(11).FontFamily("Lato"));

                    // encabezado
                    page.Header().Row(row =>
                    {
                        row.RelativeItem().Column(col =>
                        {
                            //el logo de la empresa está en RGTS-Manager\RGTS.Interfaz\Resources\logo.png
                            col.Item().Text("RetroGames Tech-Store").FontSize(20).Bold().FontColor(Colors.Indigo.Darken2);
                            col.Item().Text("Venta de Consolas y Accesorios Gamer");
                            col.Item().Text("Corrientes, Argentina");
                        });

                        row.RelativeItem().AlignRight().Column(col =>
                        {
                            col.Item().Text($"FACTURA N°: {venta.IdVenta:D5}").FontSize(14).Bold();
                            col.Item().Text($"Fecha: {venta.Fecha:dd/MM/yyyy}");
                            col.Item().Text($"Vendedor: {venta.Usuario?.NombreCompleto ?? "No se encontró al vendedor asociado"}");
                            col.Item().Text($"DNI Vendedor: {venta.DniUsuario}");
                        });
                    });

                    // cuerpo principal
                    page.Content().PaddingVertical(1, Unit.Centimetre).Column(col =>
                    {
                        //datos del cliente
                        col.Item().Border(1).BorderColor(Colors.Grey.Lighten2).Padding(10).Column(c =>
                        {
                            c.Item().Text($"DATOS DEL CLIENTE").Bold().Underline();
                            c.Item().PaddingVertical(2);
                            if (venta.Cliente != null)
                            {
                                c.Item().Text($"Nombre: {venta.Cliente.Nombre} {venta.Cliente.Apellido}");
                                c.Item().Text($"DNI: {venta.Cliente.DNI}");
                            }
                            else
                            {
                                c.Item().Text("Cliente: Consumidor Final");
                            }
                        });

                        col.Item().PaddingVertical(10);

                        // tabla de productos
                        col.Item().Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                columns.ConstantColumn(80);  // Código
                                columns.RelativeColumn();   // Producto
                                columns.ConstantColumn(60);  // Cantidad
                                columns.ConstantColumn(90);  // Precio Unit.
                                columns.ConstantColumn(90);  // Subtotal
                            });

                            // Cabecera de la tabla
                            table.Header(header =>
                            {
                                header.Cell().Background(Colors.Indigo.Lighten5).Padding(5).Text("Código").Bold();
                                header.Cell().Background(Colors.Indigo.Lighten5).Padding(5).Text("Producto").Bold();
                                header.Cell().Background(Colors.Indigo.Lighten5).Padding(5).AlignRight().Text("Cantidad").Bold();
                                header.Cell().Background(Colors.Indigo.Lighten5).Padding(5).AlignRight().Text("Precio U.").Bold();
                                header.Cell().Background(Colors.Indigo.Lighten5).Padding(5).AlignRight().Text("Subtotal").Bold();
                            });

                            // Filas de productos
                            foreach (var detalle in venta.Detalles)
                            {
                                table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten3).Padding(5)
                                     .Text(detalle.Producto?.Codigo ?? "N/A");

                                table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten3).Padding(5)
                                     .Text(detalle.Producto?.Nombre ?? "Producto");

                                table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten3).Padding(5)
                                     .AlignRight().Text(detalle.Cantidad.ToString());

                                table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten3).Padding(5)
                                     .AlignRight().Text(detalle.PrecioUnitario.ToString("C2"));

                                table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten3).Padding(5)
                                     .AlignRight().Text(detalle.SubtotalDerivado.ToString("C2"));
                            }
                        });

                        col.Item().PaddingVertical(10);

                        // total
                        col.Item().AlignRight().Text($"TOTAL: {venta.TotalDerivado:C2}").FontSize(16).Bold().FontColor(Colors.Green.Darken3);
                    });

                    //footer
                    page.Footer().AlignCenter().Text(text =>
                    {
                        text.Span("Gracias por su compra!").FontSize(10).Italic();
                    });
                });
            }).GeneratePdf(rutaDestino);

            return rutaDestino;
        }
    }
}