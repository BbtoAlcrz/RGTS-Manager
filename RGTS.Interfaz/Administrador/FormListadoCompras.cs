using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin.Controls;
using RGTS.Entidades;

namespace RGTS.Interfaz.Administrador
{
    public partial class FormListadoCompras : MaterialForm
    {
        // Proveedores hardcodeados (mismos que en FormNuevaCompra, para esta entrega)
        private readonly List<Proveedor> _proveedores = new List<Proveedor>
        {
            new Proveedor { IdProveedor = 1, NombreComercial = "TechImport SA" },
            new Proveedor { IdProveedor = 2, NombreComercial = "Gamer Distribuidora" },
            new Proveedor { IdProveedor = 3, NombreComercial = "ElectroSur" }
        };

        // Compras hardcodeadas para esta entrega
        private readonly List<Compra> _compras = new List<Compra>
        {
            new Compra { IdCompra = 1, IdProveedor = 1, NombreProveedor = "TechImport SA", Fecha = DateTime.Today.AddDays(-5), Total = 450000, Estado = "Pendiente" },
            new Compra { IdCompra = 2, IdProveedor = 2, NombreProveedor = "Gamer Distribuidora", Fecha = DateTime.Today.AddDays(-2), Total = 120000, Estado = "Recibida" },
            new Compra { IdCompra = 3, IdProveedor = 3, NombreProveedor = "ElectroSur", Fecha = DateTime.Today, Total = 89000, Estado = "Cancelada" }
        };

        // Detalle de cada compra, indexado por IdCompra (hardcodeado para esta entrega)
        private readonly Dictionary<int, List<DetalleCompra>> _detallesPorCompra = new Dictionary<int, List<DetalleCompra>>
        {
            { 1, new List<DetalleCompra> {
                new DetalleCompra { IdDetalleCompra = 1, IdProducto = 1, CodigoProducto = "CONS-001", NombreProducto = "PlayStation 5", Cantidad = 3, CostoUnitario = 150000 }
            }},
            { 2, new List<DetalleCompra> {
                new DetalleCompra { IdDetalleCompra = 2, IdProducto = 2, CodigoProducto = "MAN-001", NombreProducto = "Joystick DualSense", Cantidad = 6, CostoUnitario = 20000 }
            }},
            { 3, new List<DetalleCompra> {
                new DetalleCompra { IdDetalleCompra = 3, IdProducto = 3, CodigoProducto = "PORT-001", NombreProducto = "Nintendo Switch OLED", Cantidad = 1, CostoUnitario = 89000 }
            }}
        };

        public FormListadoCompras()
        {
            InitializeComponent();
        }

        private void FormListadoCompras_Load(object sender, EventArgs e)
        {
            CargarComboProveedor();
            CargarGrilla();
        }

        private void CargarComboProveedor()
        {
            CmbFiltroProvee.Items.Clear();
            CmbFiltroProvee.Items.Add("Todos los proveedores");
            foreach (var prov in _proveedores)
                CmbFiltroProvee.Items.Add(prov.NombreComercial);
            CmbFiltroProvee.SelectedIndex = 0;
        }

        // Carga la grilla aplicando los filtros de fecha y proveedor actuales
        private void CargarGrilla()
        {
            lstClientes.Items.Clear();

            var filtradas = _compras.Where(c =>
                c.Fecha.Date >= DtpDesde.Value.Date &&
                c.Fecha.Date <= DtpHasta.Value.Date &&
                (CmbFiltroProvee.SelectedIndex <= 0 ||
                 c.NombreProveedor == _proveedores[CmbFiltroProvee.SelectedIndex - 1].NombreComercial)
            );

            foreach (var compra in filtradas)
            {
                var row = new ListViewItem(compra.IdCompra.ToString());
                row.SubItems.Add(compra.NombreProveedor);
                row.SubItems.Add(compra.Estado);
                row.SubItems.Add("—"); // usuario: sin datos reales para esta entrega
                row.SubItems.Add(compra.Fecha.ToString("dd/MM/yyyy"));
                row.SubItems.Add(compra.Total.ToString("C"));
                row.Tag = compra;
                lstClientes.Items.Add(row);
            }
        }

        // Abre el formulario de nueva compra
        private void BtnNuevaCompra_Click(object sender, EventArgs e)
        {
            var form = new FormNuevaCompra();
            form.ShowDialog();
            CargarGrilla();
        }

        // Abre el detalle de solo lectura de la compra seleccionada
        private void BtnDetalleComp_Click(object sender, EventArgs e)
        {
            Compra? seleccionada = ObtenerCompraSeleccionada();
            if (seleccionada == null) return;

            var detalle = _detallesPorCompra.ContainsKey(seleccionada.IdCompra)
                ? _detallesPorCompra[seleccionada.IdCompra]
                : new List<DetalleCompra>();

            var form = new FormDetalleCompra(seleccionada, detalle);
            form.ShowDialog();
        }

        // Cambia el estado de la compra seleccionada a "Recibida"
        private void BtnRecibido_Click(object sender, EventArgs e)
        {
            Compra? seleccionada = ObtenerCompraSeleccionada();
            if (seleccionada == null) return;

            if (seleccionada.Estado == "Cancelada")
            {
                MessageBox.Show("No se puede marcar como recibida una compra cancelada.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            seleccionada.Estado = "Recibida";
            MessageBox.Show("Compra marcada como recibida.",
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarGrilla();
        }

        // Cambia el estado de la compra seleccionada a "Cancelada"
        private void BtnCancelarC_Click(object sender, EventArgs e)
        {
            Compra? seleccionada = ObtenerCompraSeleccionada();
            if (seleccionada == null) return;

            if (seleccionada.Estado == "Recibida")
            {
                MessageBox.Show("No se puede cancelar una compra que ya fue recibida.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show(
                $"¿Estás seguro de que querés cancelar la compra #{seleccionada.IdCompra}?",
                "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                seleccionada.Estado = "Cancelada";
                MessageBox.Show("Compra cancelada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla();
            }
        }

        // Restablece los filtros de fecha y proveedor
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            DtpDesde.Value = DateTime.Today.AddMonths(-1);
            DtpHasta.Value = DateTime.Today;
            CmbFiltroProvee.SelectedIndex = 0;
            CargarGrilla();
        }

        // Devuelve la compra seleccionada en la grilla, o null si no hay ninguna
        private Compra? ObtenerCompraSeleccionada()
        {
            if (lstClientes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccioná una compra.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            return lstClientes.SelectedItems[0].Tag as Compra;
        }
    }
}