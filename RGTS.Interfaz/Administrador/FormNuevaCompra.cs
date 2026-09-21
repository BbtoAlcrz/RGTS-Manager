using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin.Controls;
using RGTS.Entidades;
using RGTS.LogicaNegocio.Servicios;

namespace RGTS.Interfaz.Administrador
{
    public partial class FormNuevaCompra : MaterialForm
    {
        private readonly CompraServicio _compraServicio;

        private readonly List<Proveedor> _proveedores = new List<Proveedor>
        {
            new Proveedor { IdProveedor = 1, NombreComercial = "TechImport SA" },
            new Proveedor { IdProveedor = 2, NombreComercial = "Gamer Distribuidora" },
            new Proveedor { IdProveedor = 3, NombreComercial = "ElectroSur" }
        };

        private readonly List<Producto> _productos = new List<Producto>
        {
            new Producto { IdProducto = 1, Codigo = "CONS-001", Nombre = "PlayStation 5" },
            new Producto { IdProducto = 2, Codigo = "MAN-001",  Nombre = "Joystick DualSense" },
            new Producto { IdProducto = 3, Codigo = "PORT-001", Nombre = "Nintendo Switch OLED" }
        };

        private readonly List<DetalleCompra> _detalle = new List<DetalleCompra>();
        private int _correlativoDetalle = 1;

        public FormNuevaCompra()
        {
            InitializeComponent();
            _compraServicio = new CompraServicio();
        }

        private void FormNuevaCompra_Load(object sender, EventArgs e)
        {
            CargarComboProveedor();
        }

        private void CargarComboProveedor()
        {
            CmbFiltroProvee.Items.Clear();
            foreach (var prov in _proveedores)
                CmbFiltroProvee.Items.Add(prov.NombreComercial);
        }

        private void BtnRecibido_Click(object sender, EventArgs e)
        {
            try
            {
                string busqueda = TxtBuscarCoN.Text.Trim();

                // Parseo previo: si no son numéricos, quedan en 0 para que la validación los rechace con mensaje claro
                decimal.TryParse(TxtCostoUni.Text.Trim(), out decimal costoUnitario);
                int.TryParse(TxtCantidad.Text.Trim(), out int cantidad);

                Producto? producto = _productos.FirstOrDefault(p =>
                    p.Codigo.Equals(busqueda, StringComparison.OrdinalIgnoreCase) ||
                    p.Nombre.Contains(busqueda, StringComparison.OrdinalIgnoreCase));

                if (producto == null)
                    throw new ArgumentException("No se encontró ningún producto con ese código o nombre.");

                // El servicio valida y arma el ítem
                var nuevoItem = _compraServicio.ValidarYArmarItem(
                    CmbFiltroProvee.SelectedIndex, producto, busqueda, costoUnitario, cantidad, _correlativoDetalle);

                // Evita duplicar el mismo producto en el detalle; si ya está, acumula la cantidad
                var existente = _detalle.FirstOrDefault(d => d.IdProducto == producto.IdProducto);
                if (existente != null)
                {
                    existente.Cantidad += cantidad;
                }
                else
                {
                    _detalle.Add(nuevoItem);
                    _correlativoDetalle++;
                }

                ActualizarGrillaDetalle();
                LimpiarCamposProducto();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ActualizarGrillaDetalle()
        {
            lstClientes.Items.Clear();
            decimal total = 0;

            foreach (var item in _detalle)
            {
                var row = new ListViewItem(item.IdDetalleCompra.ToString());
                row.SubItems.Add(item.NombreProducto);
                row.SubItems.Add(item.Cantidad.ToString());
                row.SubItems.Add(item.CostoUnitario.ToString("C"));
                row.SubItems.Add(item.Subtotal.ToString("C"));
                row.Tag = item;
                lstClientes.Items.Add(row);

                total += item.Subtotal;
            }

            LTotal.Text = $"Total {total:C}";
        }

        private void LimpiarCamposProducto()
        {
            TxtBuscarCoN.Text = "";
            TxtCostoUni.Text = "";
            TxtCantidad.Text = "";
        }

        private void BtnRegistrarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                // El servicio valida que la compra esté lista para registrarse
                _compraServicio.ValidarRegistro(CmbFiltroProvee.SelectedIndex, _detalle.Count);

                MessageBox.Show("Orden de compra registrada correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCancelarCompra_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}