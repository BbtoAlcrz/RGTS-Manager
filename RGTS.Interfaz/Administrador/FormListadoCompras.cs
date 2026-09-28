using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin.Controls;
using RGTS.Entidades;
using RGTS.LogicaNegocio.Servicios;

namespace RGTS.Interfaz.Administrador
{
    public partial class FormListadoCompras : MaterialForm
    {
        private readonly CompraServicio _compraServicio;
        private readonly BuscadorSugerencias _buscadorProveedor;
        private Proveedor? _proveedorFiltroSeleccionado;
        private readonly Panel pnlEdicionContenedor = new();

        // Proveedores de prueba en memoria para el buscador de sugerencias
        private readonly List<Proveedor> _proveedores = new()
        {
            new Proveedor { IdProveedor = 1, NombreComercial = "TechImport SA" },
            new Proveedor { IdProveedor = 2, NombreComercial = "Gamer Distribuidora" },
            new Proveedor { IdProveedor = 3, NombreComercial = "ElectroSur" }
        };

        public FormListadoCompras()
        {
            InitializeComponent();

            _compraServicio = new CompraServicio();

            // Configurar panel superpuesto para subformularios integrados
            pnlEdicionContenedor.Dock = DockStyle.Fill;
            pnlEdicionContenedor.Visible = false;
            Controls.Add(pnlEdicionContenedor);
            pnlEdicionContenedor.BringToFront();

            _buscadorProveedor = new BuscadorSugerencias(this);
        }

        private void FormListadoCompras_Load(object sender, EventArgs e)
        {
            ConfigurarListView();

            // Rango de fechas por defecto: últimos 30 días
            DtpHasta.Value = DateTime.Today;
            DtpDesde.Value = DateTime.Today.AddDays(-30);

            DtpDesde.ValueChanged += (s, args) => RefrescarGrilla();
            DtpHasta.ValueChanged += (s, args) => RefrescarGrilla();

            RefrescarGrilla();
        }

        private void ConfigurarListView()
        {
            lstClientes.View = View.Details;
            lstClientes.FullRowSelect = true;
            lstClientes.MultiSelect = false;
            lstClientes.GridLines = true;
        }

        

        private void RefrescarGrilla()
        {
            lstClientes.BeginUpdate();
            lstClientes.Items.Clear();

            // Resetear botones dependientes de selección
            BtnDetalleComp.Enabled = false;
            BtnRecibido.Enabled = false;
            BtnCancelarC.Enabled = false;

            int? idProveedor = _proveedorFiltroSeleccionado?.IdProveedor;
            List<Compra> compras = _compraServicio.ObtenerCompras(DtpDesde.Value, DtpHasta.Value, idProveedor);

            foreach (var compra in compras)
            {
                var row = new ListViewItem(compra.IdCompra.ToString());
                // Subitems: Proveedor, Usuario, Fecha, Total, Estado
                row.SubItems.Add(compra.NombreProveedor);
                row.SubItems.Add(string.IsNullOrWhiteSpace(compra.DniUsuario) ? "—" : compra.DniUsuario);
                row.SubItems.Add(compra.Fecha.ToString("dd/MM/yyyy"));
                row.SubItems.Add(compra.Total.ToString("C2"));
                row.SubItems.Add(compra.Estado);
                row.Tag = compra;

                lstClientes.Items.Add(row);
            }

            lstClientes.EndUpdate();
        }

        

        private void LstClientes_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (lstClientes.SelectedItems.Count > 0)
            {
                var compraSeleccionada = (Compra)lstClientes.SelectedItems[0].Tag;

                // Ver detalle siempre habilitado si hay selección
                BtnDetalleComp.Enabled = true;

                // Solo se pueden recibir o cancelar compras en estado Pendiente
                bool esPendiente = compraSeleccionada.Estado == "Pendiente";
                BtnRecibido.Enabled = esPendiente;
                BtnCancelarC.Enabled = esPendiente;
            }
            else
            {
                BtnDetalleComp.Enabled = false;
                BtnRecibido.Enabled = false;
                BtnCancelarC.Enabled = false;
            }
        }

    

        private void TxtFiltroProveedor_TextChanged(object? sender, EventArgs e)
        {
            string texto = TxtFiltroProveedor.Text.Trim();

            if (string.IsNullOrWhiteSpace(texto))
            {
                _proveedorFiltroSeleccionado = null;
                _buscadorProveedor.Ocultar();
                RefrescarGrilla();
                return;
            }

            var coincidencias = _proveedores
                .Where(p => p.NombreComercial.Contains(texto, StringComparison.OrdinalIgnoreCase))
                .ToList();

            var textos = coincidencias.Select(p => p.NombreComercial).ToList();

            _buscadorProveedor.Mostrar(TxtFiltroProveedor, textos, indice =>
            {
                _proveedorFiltroSeleccionado = coincidencias[indice];
                TxtFiltroProveedor.Text = coincidencias[indice].NombreComercial;
                RefrescarGrilla();
            });
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            DtpDesde.Value = DateTime.Today.AddMonths(-1);
            DtpHasta.Value = DateTime.Today;
            TxtFiltroProveedor.Clear();
            _proveedorFiltroSeleccionado = null;
            RefrescarGrilla();
        }


        private void BtnNuevaCompra_Click(object sender, EventArgs e)
        {
            MostrarSubVentana(new FormNuevaCompra());
        }

        private void BtnDetalleComp_Click(object sender, EventArgs e)
        {
            if (lstClientes.SelectedItems.Count == 0) return;

            var seleccionada = (Compra)lstClientes.SelectedItems[0].Tag;
            List<DetalleCompra> detalles = _compraServicio.ObtenerDetallesPorCompra(seleccionada.IdCompra);

            MostrarSubVentana(new FormDetalleCompra(seleccionada, detalles));
        }

        private void BtnRecibido_Click(object sender, EventArgs e)
        {
            if (lstClientes.SelectedItems.Count == 0) return;

            var seleccionada = (Compra)lstClientes.SelectedItems[0].Tag;

            DialogResult confirmacion = MessageBox.Show(
                $"¿Desea marcar como recibida la compra #{seleccionada.IdCompra} del proveedor '{seleccionada.NombreProveedor}'?\n\nTotal: {seleccionada.Total:C2}",
                "Confirmar Recepción",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            );

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    _compraServicio.CambiarEstadoCompra(seleccionada.IdCompra, "Recibida");
                    MessageBox.Show("Compra marcada como recibida.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarGrilla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnCancelarC_Click(object sender, EventArgs e)
        {
            if (lstClientes.SelectedItems.Count == 0) return;

            var seleccionada = (Compra)lstClientes.SelectedItems[0].Tag;

            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro de que desea cancelar la compra #{seleccionada.IdCompra}?\n\n• Proveedor: {seleccionada.NombreProveedor}\n• Total: {seleccionada.Total:C2}",
                "Confirmar Cancelación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
            );

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    _compraServicio.CambiarEstadoCompra(seleccionada.IdCompra, "Cancelada");
                    MessageBox.Show("Compra cancelada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarGrilla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void MostrarSubVentana(Form subFormulario)
        {
            pnlEdicionContenedor.Controls.Clear();
            subFormulario.TopLevel = false;
            subFormulario.FormBorderStyle = FormBorderStyle.None;
            subFormulario.Dock = DockStyle.Fill;
            subFormulario.FormClosed += (s, args) =>
            {
                pnlEdicionContenedor.Visible = false;
                pnlEdicionContenedor.Controls.Clear();
                RefrescarGrilla();
            };
            pnlEdicionContenedor.Controls.Add(subFormulario);
            pnlEdicionContenedor.Visible = true;
            pnlEdicionContenedor.BringToFront();
            subFormulario.Show();
        }
    }
}