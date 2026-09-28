using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MaterialSkin.Controls;
using RGTS.Entidades;

namespace RGTS.Interfaz.Administrador
{
    public partial class FormDetalleCompra : MaterialForm
    {
        private readonly Compra _compra;
        private readonly List<DetalleCompra> _detalle;

        // Recibe la compra y su detalle ya armados desde el listado de compras
        public FormDetalleCompra(Compra compra, List<DetalleCompra> detalle)
        {
            InitializeComponent();
            Sizable = false;
            FormStyle = FormStyles.StatusAndActionBar_None;

            _compra = compra ?? throw new ArgumentNullException(nameof(compra));
            _detalle = detalle ?? new List<DetalleCompra>();
        }

        private void FormDetalleCompra_Load(object sender, EventArgs e)
        {
            ConfigurarListView();
            CargarCabecera();
            CargarGrillaDetalle();
        }

        private void ConfigurarListView()
        {
            LstProductos.View = View.Details;
            LstProductos.FullRowSelect = true;
            LstProductos.MultiSelect = false;
            LstProductos.GridLines = true;
        }

        // Muestra los datos generales de la compra en las tarjetas superiores
        private void CargarCabecera()
        {
            LProveedor.Text = !string.IsNullOrWhiteSpace(_compra.NombreProveedor)
                ? _compra.NombreProveedor
                : "Proveedor sin nombre";

            LFecha.Text = _compra.Fecha.ToString("dd/MM/yyyy");
            LEstado.Text = _compra.Estado;
            LTotal.Text = $"Total: {_compra.Total:C2}";
        }

        // Carga el detalle de productos comprados en la grilla
        private void CargarGrillaDetalle()
        {
            LstProductos.BeginUpdate();
            LstProductos.Items.Clear();

            foreach (var item in _detalle)
            {
                var row = new ListViewItem(item.CodigoProducto ?? "S/C");
                row.SubItems.Add(item.NombreProducto ?? "Sin Nombre");
                row.SubItems.Add(item.Cantidad.ToString());
                row.SubItems.Add(item.CostoUnitario.ToString("C2"));
                row.SubItems.Add(item.Subtotal.ToString("C2"));
                row.Tag = item;

                LstProductos.Items.Add(row);
            }

            LstProductos.EndUpdate();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            FormPrincipal.InstanciaActual?.AbrirFormularioEnPanel(new FormListadoCompras());
        }
    }
}