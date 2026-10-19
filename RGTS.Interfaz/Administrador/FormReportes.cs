using System;
using System.Drawing;
using System.IO;
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
        private readonly BackupServicio _backupServicio = new();

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

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            using var dialogo = new SaveFileDialog
            {
                Filter = "Backup de SQL Server (*.bak)|*.bak",
                FileName = _backupServicio.NombreSugerido()
            };

            if (dialogo.ShowDialog() != DialogResult.OK) return;

            try
            {
                Cursor = Cursors.WaitCursor;
                _backupServicio.ExportarBackup(FormPrincipal.UsuarioSesion, dialogo.FileName);
                MessageBox.Show("Backup generado correctamente.", "Copia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo generar el backup: {ex.Message}", "Error de Backup", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            using var dialogo = new OpenFileDialog { Filter = "Backup de SQL Server (*.bak)|*.bak" };
            if (dialogo.ShowDialog() != DialogResult.OK) return;

            try
            {
                // Valida el archivo y extrae la fecha
                Cursor = Cursors.WaitCursor;
                DateTime fecha = _backupServicio.ValidarArchivoParaRestaurar(FormPrincipal.UsuarioSesion, dialogo.FileName);
                Cursor = Cursors.Default;

                // Cuadro modal de confirmación con contraseña
                string? contrasena = null;
                using (var form = new Form
                {
                    Text = "Confirmar Restauración de Base de Datos",
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    StartPosition = FormStartPosition.CenterParent,
                    MaximizeBox = false,
                    MinimizeBox = false,
                    ClientSize = new Size(420, 210)
                })
                {
                    var lblAviso = new Label
                    {
                        Text = $"Backup seleccionado: {Path.GetFileName(dialogo.FileName)}\n" +
                               $"Fecha de creación: {fecha:dd/MM/yyyy HH:mm}\n\n" +
                               "ATENCIÓN: Se reemplazarán TODOS los datos actuales. Los cambios posteriores a este backup se perderán de forma permanente.",
                        Left = 15,
                        Top = 15,
                        Width = 390,
                        Height = 90,
                        ForeColor = Color.DarkRed
                    };
                    var lblClave = new Label { Text = "Ingrese su contraseña de Administrador para confirmar:", Left = 15, Top = 115, Width = 390 };
                    var txtClave = new TextBox { Left = 15, Top = 138, Width = 390, UseSystemPasswordChar = true };
                    var btnOk = new Button { Text = "Restaurar", Left = 225, Top = 170, Width = 85, Enabled = false, DialogResult = DialogResult.OK };
                    var btnCancelar = new Button { Text = "Cancelar", Left = 320, Top = 170, Width = 85, DialogResult = DialogResult.Cancel };

                    txtClave.TextChanged += (_, _) => btnOk.Enabled = txtClave.Text.Trim().Length > 0;

                    form.Controls.AddRange(new Control[] { lblAviso, lblClave, txtClave, btnOk, btnCancelar });
                    form.AcceptButton = btnOk;
                    form.CancelButton = btnCancelar;

                    if (form.ShowDialog(this) == DialogResult.OK)
                        contrasena = txtClave.Text;
                }

                if (string.IsNullOrWhiteSpace(contrasena)) return; // Operación cancelada por el usuario

                // Ejecución de la restauración de la BD
                Cursor = Cursors.WaitCursor;
                string respaldoSeguridad = _backupServicio.RestaurarBackup(FormPrincipal.UsuarioSesion, dialogo.FileName, contrasena);

                MessageBox.Show($"Base de datos restaurada correctamente.\nSe generó un respaldo previo de seguridad en:\n{respaldoSeguridad}\n\nLa aplicación se reiniciará automáticamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Application.Restart();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al Restaurar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}
