using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin.Controls;
using RGTS.Entidades;
using RGTS.LogicaNegocio.Servicios;

namespace RGTS.Interfaz.Administrador
{
    public partial class FormReportes : MaterialForm
    {
        private readonly ReporteVentaServicio _reporteVentaServicio = new();
        private readonly ReporteClienteServicio _reporteClienteServicio = new();
        private readonly ReporteProductoServicio _reporteProductoServicio = new();
        private readonly ReportePdfServicio _reportePdfServicio = new();

        private List<VentaReporteDto> _reporteVentaActual = new();
        private List<ClienteReporteDto> _reporteClienteActual = new();
        private List<ProductoReporteDto> _reporteProductoActual = new();

        private bool _actualizandoFechas;

        public FormReportes()
        {
            InitializeComponent();
            ConfigurarEventosReportes();
        }

        private void ConfigurarEventosReportes()
        {
            // inicio del mes actual a la fecha
            DtpDesde.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            DtpHasta.Value = DateTime.Today;

            DtpDesde.ValueChanged += RangoFechasCambiado;
            DtpHasta.ValueChanged += RangoFechasCambiado;
            // actualiza estado del botn al cambiar de pestaña
            materialTabControl1.SelectedIndexChanged += (s, e) => ActualizarEstadoBotonReporte();

            RecargarTodosLosReportes();
        }

        private void RecargarTodosLosReportes()
        {
            DateTime desde = DtpDesde.Value.Date;
            DateTime hasta = DtpHasta.Value.Date.AddDays(1).AddTicks(-1);

            try
            {
                Cursor = Cursors.WaitCursor;
                UseWaitCursor = true;

                SuspendLayout();
                chartVentas.SuspendLayout();
                chartClientes.SuspendLayout();
                chartProductos.SuspendLayout();

                CargarReporteVentas(desde, hasta);
                CargarReporteClientes(desde, hasta);
                CargarReporteProductos(desde, hasta);

                ActualizarEstadoBotonReporte();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar los reportes: {ex.Message}", "Error de Carga",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                chartVentas.ResumeLayout();
                chartClientes.ResumeLayout();
                chartProductos.ResumeLayout();
                ResumeLayout(true);

                UseWaitCursor = false;
                Cursor = Cursors.Default;
            }
        }

        private void RangoFechasCambiado(object? sender, EventArgs e)
        {
            if (_actualizandoFechas) return;

            if (DtpDesde.Value.Date > DtpHasta.Value.Date)
            {
                _actualizandoFechas = true;
                try
                {
                    MessageBox.Show("La fecha 'Desde' no puede ser posterior a la fecha 'Hasta'.",
                                    "Rango de Fechas Inválido",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                    DtpDesde.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                    DtpHasta.Value = DateTime.Today;
                }
                finally
                {
                    _actualizandoFechas = false;
                }
            }

            RecargarTodosLosReportes();

            if (!PestanaActivaTieneDatos())
            {
                MessageBox.Show("No hay datos disponibles para el rango de fechas seleccionado.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool PestanaActivaTieneDatos()
        {
            string nombre = materialTabControl1.SelectedTab?.Name ?? "";
            return nombre switch
            {
                "ReporteVentas" => _reporteVentaActual.Count > 0,
                "ReporteClientes" => _reporteClienteActual.Any(c => c.ComprasEnPeriodo > 0),
                "ReporteProductos" => _reporteProductoActual.Any(p => p.UnidadesVendidasEnPeriodo > 0),
                _ => false
            };
        }

        private void ActualizarEstadoBotonReporte()
        {
            BtnGenerarReporte.Enabled = PestanaActivaTieneDatos();
        }


        // SECCIÓN VENTAS
        private void CargarReporteVentas(DateTime desde, DateTime hasta)
        {
            _reporteVentaActual = _reporteVentaServicio.ObtenerReporteVentas(desde, hasta, null);
            CargarMetricasVentas(_reporteVentaActual);
            CargarGraficoVentasPorVendedor(_reporteVentaActual);
        }

        private void CargarMetricasVentas(List<VentaReporteDto> ventas)
        {
            VentasMetricasDto metricas = _reporteVentaServicio.CalcularMetricas(ventas);

            // Desempeño Financiero
            LabelCantidadVentasValor.Text = metricas.CantidadVentas.ToString();
            LabelTotalFacturadoValor.Text = metricas.TotalFacturado.ToString("C2");
            LabelFacturaPromedioValor.Text = metricas.PromedioFacturadoPorVendedor.ToString("C2");
            LabelMargenGanaciasValor.Text = metricas.MargenGananciasTotal.ToString("C2");

            // Rendimiento de Vendedores
            LabelVendedorEstrellaValor.Text = metricas.VendedorEstrella;
            LabelMasOperacionesValor.Text = metricas.VendedorConMasOperaciones;

            // Desempeño Temporal
            LabelFechaPicoValor.Text = metricas.FechaPicoVentas;
            LabelDiaMasVentasValor.Text = metricas.DiaConMasVentas;
            LabelHoraPicoValor.Text = metricas.HoraPicoVentas;
        }

        private void CargarGraficoVentasPorVendedor(List<VentaReporteDto> ventas)
        {
            var serie = chartVentas.Series["VentasDiarias"];
            serie.Points.Clear();

            // si no hay ventas en el periodo, el grafico se limpia 
            if (ventas == null || ventas.Count == 0) return;

            var ventasPorVendedor = ventas
                .GroupBy(v => v.NombreVendedor)
                .Select(g => new
                {
                    Vendedor = string.IsNullOrWhiteSpace(g.Key) ? "Sin Vendedor" : g.Key,
                    TotalFacturado = g.GroupBy(v => v.IdVenta).Sum(x => x.First().TotalVenta)
                })
                .OrderByDescending(x => x.TotalFacturado);

            foreach (var item in ventasPorVendedor)
            {
                serie.Points.AddXY(item.Vendedor, item.TotalFacturado);
            }
        }

         
        // SECCIÓN CLIENTES
        private void CargarReporteClientes(DateTime desde, DateTime hasta)
        {
            _reporteClienteActual = _reporteClienteServicio.ObtenerReporteClientes(desde, hasta);
            ClientesMetricasDto metricas = _reporteClienteServicio.CalcularMetricas(_reporteClienteActual);

            // Desempeño de Clientes
            LabelClientesActivosValor.Text = metricas.TotalClientesActivos.ToString();
            LabelClientesNuevosValor.Text = metricas.ClientesNuevos.ToString();

            // Métricas de Recurrencia
            LabelClienteEstrellaValor.Text = metricas.ClienteEstrella;
            LabelClientesRecurrentesValor.Text = metricas.CantidadClientesRecurrentes.ToString();
            LabelPorcentajeRecurrenciaValor.Text = $"{metricas.PorcentajeRecurrencia:F1}%";

            // Promedio Comercial
            LabelPromGastoClienteValor.Text = metricas.FacturacionClientesRegistrados.ToString("C2");
            LabelPromedioComprasClientesValor.Text = metricas.PromedioComprasPorCliente.ToString("N1");
            LabelClientesUnicosValor.Text = metricas.ClientesCompradoresUnicos.ToString();

            CargarGraficoClientes(metricas);
        }

        private void CargarGraficoClientes(ClientesMetricasDto metricas)
        {
            var serie = chartClientes.Series["DistribucionClientes"];
            serie.Points.Clear();

            if (metricas == null) return;

            // Solo se dibuja el gráfico si hubo compras en el período seleccionado!!!
            if (metricas.ClientesCompradoresUnicos == 0) return;

            serie.IsValueShownAsLabel = true;
            serie.Label = "#PERCENT{0.00%}";
            serie["PieLabelStyle"] = "Inside";

            if (metricas.CantidadNuncaCompraron > 0)
            {
                int idx = serie.Points.AddXY("Nunca Compraron", metricas.CantidadNuncaCompraron);
                serie.Points[idx].LegendText = "Nunca Compraron";
            }

            if (metricas.CantidadCompraronUnaVez > 0)
            {
                int idx = serie.Points.AddXY("Compraron 1 vez", metricas.CantidadCompraronUnaVez);
                serie.Points[idx].LegendText = "Compraron 1 vez";
            }

            if (metricas.CantidadCompraronMultiple > 0)
            {
                int idx = serie.Points.AddXY("Varias Compras", metricas.CantidadCompraronMultiple);
                serie.Points[idx].LegendText = "Varias Compras";
            }
        }
        

        // SECCIÓN PRODUCTOS
        private void CargarReporteProductos(DateTime desde, DateTime hasta)
        {
            try
            {
                _reporteProductoActual = _reporteProductoServicio.ObtenerReporteProductos(desde, hasta);
                ProductosMetricasDto metricas = _reporteProductoServicio.CalcularMetricas(_reporteProductoActual);

                // Valorización de Inventario
                LabelValorInventarioValor.Text = metricas.ValorTotalInventario.ToString("C2");
                LabelProductosActivosValor.Text = metricas.TotalProductosActivos.ToString();

                // Control de Stock
                LabelStockCriticoValor.Text = metricas.ProductosStockCritico.ToString();
                LabelPorductosAgotadosValor.Text = metricas.ProductosAgotados.ToString();
                LabelStockOptimoValor.Text = $"{metricas.PorcentajeStockOptimo:F1}%";

                // Rendimiento y Rotación
                LabelProductoEstrellaValor.Text = metricas.ProductoEstrella;
                LabelCategoriaEstrellaValor.Text = metricas.CategoriaEstrella;
                LabelPromedioVendidoValor.Text = metricas.PromedioUnidadesVendidas.ToString("N1");

                CargarGraficoProductos(metricas);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el reporte de productos: {ex.Message}", "Error de Carga",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarGraficoProductos(ProductosMetricasDto metricas)
        {
            var serie = chartProductos.Series["TopProductos"];
            serie.Points.Clear();

            if (metricas?.Top5MasVendidos == null || metricas.Top5MasVendidos.Count == 0)
            {
                chartProductos.ChartAreas[0].RecalculateAxesScale();
                chartProductos.Invalidate();
                chartProductos.Update();
                return;
            }

            // solo los productos que vendieron unidades en el rango filtrado
            var top5Invertido = metricas.Top5MasVendidos.OrderBy(p => p.UnidadesVendidasEnPeriodo).ToList();

            foreach (var prod in top5Invertido)
            {
                serie.Points.AddXY(prod.NombreProducto, prod.UnidadesVendidasEnPeriodo);
            }

            chartProductos.ChartAreas[0].RecalculateAxesScale();
            chartProductos.Invalidate();
            chartProductos.Update();
        }


        // SECCIÓN PDF
        private void BtnGenerarReporte_Click(object sender, EventArgs e)
        {
            TabPage pestanaActiva = materialTabControl1.SelectedTab;
            if (pestanaActiva == null) return;

            try
            {
                switch (pestanaActiva.Name)
                {
                    case "ReporteVentas":
                        GenerarPdfVentas();
                        break;
                    case "ReporteClientes":
                        GenerarPdfClientes();
                        break;
                    case "ReporteProductos":
                        GenerarPdfProductos();
                        break;
                    default:
                        MessageBox.Show("No hay un reporte configurado para esta pestaña.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al generar el reporte: {ex.Message}",
                    "Error de Exportación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private byte[] ObtenerImagenGrafico(System.Windows.Forms.DataVisualization.Charting.Chart chart)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                chart.SaveImage(ms, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void GenerarPdfVentas()
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Archivos PDF (*.pdf)|*.pdf";
                sfd.FileName = $"Reporte_Ventas_{DateTime.Now:yyyyMMdd_HHmm}.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    byte[] imagenGrafico = ObtenerImagenGrafico(chartVentas);
                    VentasMetricasDto metricas = _reporteVentaServicio.CalcularMetricas(_reporteVentaActual);

                    _reportePdfServicio.GenerarReporteVentasPdf(sfd.FileName, DtpDesde.Value.Date, DtpHasta.Value.Date, metricas, imagenGrafico);

                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = sfd.FileName,
                        UseShellExecute = true
                    });
                }
            }
        }

        private void GenerarPdfClientes()
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Archivos PDF (*.pdf)|*.pdf";
                sfd.FileName = $"Reporte_Clientes_{DateTime.Now:yyyyMMdd_HHmm}.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    byte[] imagenGrafico = ObtenerImagenGrafico(chartClientes);

                    ClientesMetricasDto metricas = _reporteClienteServicio.CalcularMetricas(_reporteClienteActual);

                    _reportePdfServicio.GenerarReporteClientesPdf(sfd.FileName,DtpDesde.Value.Date,DtpHasta.Value.Date,metricas,imagenGrafico);

                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = sfd.FileName,
                        UseShellExecute = true
                    });
                }
            }
        }

        private void GenerarPdfProductos()
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Archivos PDF (*.pdf)|*.pdf";
                sfd.FileName = $"Reporte_Productos_{DateTime.Now:yyyyMMdd_HHmm}.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    byte[] imagenGrafico = ObtenerImagenGrafico(chartProductos);

                    ProductosMetricasDto metricas = _reporteProductoServicio.CalcularMetricas(_reporteProductoActual);

                    _reportePdfServicio.GenerarReporteProductosPdf(
                        sfd.FileName,
                        DtpDesde.Value.Date,
                        DtpHasta.Value.Date,
                        metricas,
                        imagenGrafico
                    );

                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = sfd.FileName,
                        UseShellExecute = true
                    });
                }
            }
        }
    }
}