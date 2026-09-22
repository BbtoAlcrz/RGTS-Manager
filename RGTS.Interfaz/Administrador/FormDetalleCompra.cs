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
            _compra = compra;
            _detalle = detalle;
        }

        private void FormDetalleCompra_Load(object sender, EventArgs e)
        {
            CargarCabecera();
            CargarGrillaDetalle();
        }

        // Muestra los datos generales de la compra en las tarjetas superiores
        private void CargarCabecera()
        {
            LProveedor.Text = _compra.NombreProveedor;
            LFecha.Text = _compra.Fecha.ToString("dd/MM/yyyy");
            LEstado.Text = _compra.Estado;
            LTotal.Text = $"Total: {_compra.Total:C}";
        }

        // Carga el detalle de productos comprados en la grilla
        private void CargarGrillaDetalle()
        {
            LstProductos.Items.Clear();

            foreach (var item in _detalle)
            {
                var row = new ListViewItem(item.CodigoProducto);
                row.SubItems.Add(item.NombreProducto);
                row.SubItems.Add(item.Cantidad.ToString());
                row.SubItems.Add(item.CostoUnitario.ToString("C"));
                row.SubItems.Add(item.Subtotal.ToString("C"));
                LstProductos.Items.Add(row);
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}