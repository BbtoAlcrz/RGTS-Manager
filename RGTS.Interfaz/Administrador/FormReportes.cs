using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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

        private List<VentaReporteDto> _reporteVentaActual = new();
        private List<ClienteReporteDto> _reporteClienteActual = new();
        private List<ProductoReporteDto> _reporteProductoActual = new();

        public FormReportes()
        {
            InitializeComponent();
            ConfigurarEventosReportes();
        }

        private void ConfigurarEventosReportes()
        {
            // Rango de fecha por defecto: inicio del mes actual a la fecha
            DtpDesde.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            DtpHasta.Value = DateTime.Today;

            DtpDesde.ValueChanged += (s, e) => RecargarTodosLosReportes();
            DtpHasta.ValueChanged += (s, e) => RecargarTodosLosReportes();

            RecargarTodosLosReportes();
        }

        private void RecargarTodosLosReportes()
        {
            DateTime desde = DtpDesde.Value.Date;
            DateTime hasta = DtpHasta.Value.Date;

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


        // SECCION VENTAS
        private void CargarReporteVentas(DateTime desde, DateTime hasta)
        {
            try
            {
                _reporteVentaActual = _reporteVentaServicio.ObtenerReporteVentas(desde, hasta, null);

                CargarMetricasVentas(_reporteVentaActual);
                CargarGraficoVentasPorVendedor(_reporteVentaActual);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar reporte de ventas: {ex.Message}", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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


        // SECCION CLIENTES
        private void CargarReporteClientes(DateTime desde, DateTime hasta)
        {
            try
            {
                _reporteClienteActual = _reporteClienteServicio.ObtenerReporteClientes(desde, hasta);
                ClientesMetricasDto metricas = _reporteClienteServicio.CalcularMetricas(_reporteClienteActual);

                // Desempeño de CLientes
                LabelClientesActivosValor.Text = metricas.TotalClientesActivos.ToString();
                LabelClientesNuevosValor.Text = metricas.ClientesNuevos.ToString();
                LabelAporteRegistradosValor.Text = $"{metricas.AporteClientesRegistradosPorcentaje:F1}%";

                // Metricas de Recurrencia
                LabelClienteEstrellaValor.Text = metricas.ClienteEstrella;
                LabelClientesRecurrentesValor.Text = metricas.CantidadClientesRecurrentes.ToString();
                LabelPorcentajeRecurrenciaValor.Text = $"{metricas.PorcentajeRecurrencia:F1}%";

                // Promedio Comercial
                LabelPromGastoClienteValor.Text = metricas.FacturacionClientesRegistrados.ToString("C2");
                LabelPromedioComprasClientesValor.Text = metricas.PromedioComprasPorCliente.ToString("N1");
                LabelClientesUnicosValor.Text = metricas.ClientesCompradoresUnicos.ToString();

                CargarGraficoClientes(metricas);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el reporte de clientes: {ex.Message}", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarGraficoClientes(ClientesMetricasDto metricas)
        {
            var serie = chartClientes.Series["DistribucionClientes"];
            serie.Points.Clear();

            if (metricas == null) return;

            int totalClientes = metricas.CantidadNuncaCompraron + metricas.CantidadCompraronUnaVez + metricas.CantidadCompraronMultiple;
            if (totalClientes == 0) return;

            // Muestra porcentaje sobre las porciones
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


        // SECCION PRODUCTOS
        private void CargarReporteProductos(DateTime desde, DateTime hasta)
        {
            try
            {
                _reporteProductoActual = _reporteProductoServicio.ObtenerReporteProductos(desde, hasta);
                ProductosMetricasDto metricas = _reporteProductoServicio.CalcularMetricas(_reporteProductoActual);

                // Valorizacion de Inventario
                LabelValorInventarioValor.Text = metricas.ValorTotalInventario.ToString("C2");
                LabelProductosActivosValor.Text = metricas.TotalProductosActivos.ToString();
                LabelProductosInactivosValor.Text = metricas.TotalProductosInactivos.ToString();

                // Control de Stock
                LabelStockCriticoValor.Text = metricas.ProductosStockCritico.ToString();
                LabelPorductosAgotadosValor.Text = metricas.ProductosAgotados.ToString();
                LabelStockOptimoValor.Text = $"{metricas.PorcentajeStockOptimo:F1}%";

                // Rendimiento y Rotacion 
                LabelProductoEstrellaValor.Text = metricas.ProductoEstrella;
                LabelCategoriaEstrellaValor.Text = metricas.CategoriaEstrella;
                LabelPromedioVendidoValor.Text = metricas.PromedioUnidadesVendidas.ToString("N1");

                CargarGraficoProductos(metricas);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el reporte de productos: {ex.Message}", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarGraficoProductos(ProductosMetricasDto metricas)
        {
            var serie = chartProductos.Series["TopProductos"];
            serie.Points.Clear();

            if (metricas?.Top5MasVendidos == null || metricas.Top5MasVendidos.Count == 0) return;

            var top5Invertido = metricas.Top5MasVendidos
                .OrderBy(p => p.UnidadesVendidasEnPeriodo)
                .ToList();

            foreach (var prod in top5Invertido)
            {
                serie.Points.AddXY(prod.NombreProducto, prod.UnidadesVendidasEnPeriodo);
            }
        }
    }
}