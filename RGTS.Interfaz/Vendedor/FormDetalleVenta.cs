using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin.Controls;
using RGTS.Entidades;
using RGTS.LogicaNegocio.Servicios;

namespace RGTS.Interfaz.Vendedor
{
    public partial class FormDetalleVenta : MaterialForm
    {
        private readonly Venta _venta;

        public FormDetalleVenta(Venta venta)
        {
            InitializeComponent();
            _venta = venta ?? throw new ArgumentNullException(nameof(venta));
            CargarDatos();
        }

        private void CargarDatos()
        {
            if (_venta == null) return;

            labelNroVentaValor.Text = _venta.IdVenta.ToString("D5");
            labelFechaVentaValor.Text = _venta.Fecha.ToString("dd/MM/yyyy");

            // si Usuario es null o NombreCompleto viene vacío, muestra el DNI
            string nombreVendedor = !string.IsNullOrWhiteSpace(_venta.Usuario?.NombreCompleto)
                ? _venta.Usuario.NombreCompleto : (!string.IsNullOrWhiteSpace(_venta.DniUsuario) ? _venta.DniUsuario : "No especificado");

            labelVendedorValor.Text = $"{nombreVendedor} (DNI: {_venta.DniUsuario})";

            // Cliente (o Consumidor Final)
            if (_venta.Cliente != null)
            {
                labelClienteValor.Text = $"{_venta.Cliente.Nombre} {_venta.Cliente.Apellido} (DNI: {_venta.Cliente.DNI})";
            }
            else
            {
                labelClienteValor.Text = "Consumidor Final";
            }

            labelTotalVentaValor.Text = _venta.TotalDerivado.ToString("C2");

            // Artículos de la venta
            listViewProductos.BeginUpdate();
            listViewProductos.Items.Clear();

            if (_venta.Detalles.Count > 0)
            {
                foreach (var detalle in _venta.Detalles)
                {
                    var item = new ListViewItem(new[]
                    {
                        detalle.Producto?.Nombre ?? "Producto desconocido",
                        detalle.Cantidad.ToString(),
                        detalle.PrecioUnitario.ToString("C2"),
                        detalle.SubtotalCalculado.ToString("C2")
                    });
                    listViewProductos.Items.Add(item);
                }
            }
            else
            {
                labelDetalleProductosTitulo.Text = "Sin productos asociados a esta venta";
            }

            listViewProductos.EndUpdate();
        }

        private void btnVolver_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnExportarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                {
                    sfd.Filter = "Archivos PDF (*.pdf)|*.pdf";
                    sfd.FileName = $"Factura_Venta_{_venta.IdVenta:D5}.pdf";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        var pdfService = new PdfFacturaServicio();
                        pdfService.GenerarFactura(_venta, sfd.FileName);

                        MessageBox.Show("Comprobante generado correctamente.", "PDF Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                        {
                            FileName = sfd.FileName,
                            UseShellExecute = true
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}