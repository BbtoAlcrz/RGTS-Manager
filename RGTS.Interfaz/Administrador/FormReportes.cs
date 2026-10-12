using MaterialSkin.Controls;
using RGTS.Entidades;
using RGTS.LogicaNegocio.Servicios;

namespace RGTS.Interfaz.Administrador
{
    public partial class FormReportes : MaterialForm
    {
        private readonly ReporteVentaServicio _reporteVentaServicio;
        private readonly VentaServicio _ventaServicio;
        private List<VentaReporteDto> _reporteVentaActual;

        private class VendedorFiltro
        {
            public string Texto { get; set; } = string.Empty;
            public string? Dni { get; set; }
        }

        public FormReportes()
        {
            _reporteVentaServicio = new ReporteVentaServicio();
            _ventaServicio = new VentaServicio();
            _reporteVentaActual = new List<VentaReporteDto>();

            InitializeComponent();
            ConfigurarEventosReporteVenta();
            CargarFiltroVendedores();
        }


        private void ConfigurarEventosReporteVenta()
        {
            DtpDesde.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            DtpHasta.Value = DateTime.Today;

            DtpDesde.ValueChanged += (s, e) => CargarReporteVentas();
            DtpHasta.ValueChanged += (s, e) => CargarReporteVentas();
            ComboBoxVendedor.SelectedIndexChanged += ComboBoxVendedor_SelectedIndexChanged;

            CargarReporteVentas();
        }


        private void CargarMetricasVentas(List<VentaReporteDto> ventas)
        {
            VentasMetricasDto metricas = _reporteVentaServicio.CalcularMetricas(ventas);

            LabelCantidadVentasValor.Text = metricas.CantidadVentas.ToString();
            LabelTotalFacturadoValor.Text = metricas.TotalFacturado.ToString("C2");
            LabelFacturaPromedioValor.Text = metricas.PromedioFacturado.ToString("C2");
            LabelMargenGanaciasValor.Text = metricas.MargenGanancias.ToString("C2");

            LabelFechaVentasValor.Text = metricas.FechaConMasVentas;
            LabelProductoMasVendidoValor.Text = metricas.ProductoMasVendido;
            LabelCategoriaMasVendidaValor.Text = metricas.CategoriaMasVendida;
        }


        private void CargarGraficoVentas(List<VentaReporteDto> ventas)
        {
            chartVentas.Series["VentasDiarias"].Points.Clear();

            if (ventas == null || ventas.Count == 0) return;

            var ventasAgrupadasPorDia = ventas
                .GroupBy(v => v.Fecha.Date)
                .Select(g => new
                {
                    FechaTexto = g.Key.ToString("dd/MM"),
                    // Tomamos el TotalVenta de las ventas unicas de ese día
                    TotalDia = g.GroupBy(v => v.IdVenta).Sum(x => x.First().TotalVenta)
                })
                .OrderBy(x => x.FechaTexto);

            foreach (var item in ventasAgrupadasPorDia)
            {
                // Dia/Mes en X, monto total en Y
                chartVentas.Series["VentasDiarias"].Points.AddXY(item.FechaTexto, item.TotalDia);
            }
        }


        private void CargarReporteVentas()
        {
            try
            {
                DateTime desde = DtpDesde.Value.Date;
                DateTime hasta = DtpHasta.Value.Date;
                string? dniVendedor = ComboBoxVendedor.SelectedValue?.ToString();

                _reporteVentaActual = _reporteVentaServicio.ObtenerReporteVentas(desde, hasta, dniVendedor);
                CargarMetricasVentas(_reporteVentaActual);
                CargarGraficoVentas(_reporteVentaActual);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar reporte de ventas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void CargarFiltroVendedores()
        {

            ComboBoxVendedor.SelectedIndexChanged -= ComboBoxVendedor_SelectedIndexChanged;

            var lista = new List<VendedorFiltro>
            {
                new VendedorFiltro { Texto = "Todos los Vendedores", Dni = null }
            };

            var vendedores = _ventaServicio.ObtenerVendedoresConVentas();
            foreach (var v in vendedores)
            {
                lista.Add(new VendedorFiltro
                {
                    Texto = $"{v.NombreCompleto} ({v.Dni})",
                    Dni = v.Dni
                });
            }

            ComboBoxVendedor.DataSource = lista;
            ComboBoxVendedor.DisplayMember = "Texto";
            ComboBoxVendedor.ValueMember = "Dni";
            ComboBoxVendedor.SelectedIndex = 0;


            ComboBoxVendedor.SelectedIndexChanged += ComboBoxVendedor_SelectedIndexChanged;
        }

        private void ComboBoxVendedor_SelectedIndexChanged(object? sender, EventArgs e)
        {
            CargarReporteVentas();
        }


    }
}
