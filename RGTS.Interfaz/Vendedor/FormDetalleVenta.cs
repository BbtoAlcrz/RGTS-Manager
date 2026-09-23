using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin.Controls;
using RGTS.Entidades;

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
            if (_venta.Detalles != null && _venta.Detalles.Count > 0)
            {
                labelDetalleProductosValor.Text = string.Join(Environment.NewLine, _venta.Detalles.Select(d =>
                    $"[{d.Producto?.Codigo ?? "Sin/Cod"}] | {d.Producto?.Nombre ?? "Producto"} " +
                    $"x{d.Cantidad} unidad/es |  {d.PrecioUnitario:C2}"));
            }
            else
            {
                labelDetalleProductosValor.Text = "~ Sin productos asociados";
            }
        }

        private void btnVolver_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}