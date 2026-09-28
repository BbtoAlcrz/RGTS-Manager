using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MaterialSkin.Controls;
using RGTS.Entidades;
using RGTS.LogicaNegocio.Servicios;

namespace RGTS.Interfaz.EncargadoDeposito
{
    public partial class FormListadoProveedores : MaterialForm
    {
        private readonly ProveedorServicio _proveedorServicio;
        private readonly Panel pnlEdicionContenedor = new();

        public FormListadoProveedores()
        {
            InitializeComponent();

            _proveedorServicio = new ProveedorServicio();

            // Configurar contenedor de subformularios
            pnlEdicionContenedor.Dock = DockStyle.Fill;
            pnlEdicionContenedor.Visible = false;
            Controls.Add(pnlEdicionContenedor);
            pnlEdicionContenedor.BringToFront();

            ConfigurarControles();
            ConfigurarPermisosPorRol();
            CargarProveedores();
        }

        private void ConfigurarControles()
        {
            materialListView1.View = View.Details;
            materialListView1.FullRowSelect = true;
            materialListView1.MultiSelect = false;
            materialListView1.GridLines = true;
            materialListView1.HideSelection = false;

            BtnEditarProveedor.Enabled = false;
            BtnVerDetalleProveedor.Enabled = false;
            BtnCambiarEstado.Enabled = false;
            BtnCambiarEstado.Text = "Deshabilitar";
        }

        private void ConfigurarPermisosPorRol()
        {
            bool puedeGestionar = FormPrincipal.RolSesion == "Administrador"
                               || FormPrincipal.RolSesion == "Encargado de Deposito";

            BtnAgregarProveedor.Visible = puedeGestionar;
            BtnEditarProveedor.Visible = puedeGestionar;
            BtnCambiarEstado.Visible = puedeGestionar;
        }

        private void CargarProveedores(string? criterioBusqueda = null)
        {
            materialListView1.BeginUpdate();
            materialListView1.Items.Clear();

            BtnEditarProveedor.Enabled = false;
            BtnVerDetalleProveedor.Enabled = false;
            BtnCambiarEstado.Enabled = false;
            BtnCambiarEstado.Text = "Deshabilitar";

            List<Proveedor> listaProveedores = _proveedorServicio.ObtenerTodos(criterioBusqueda);

            foreach (var prov in listaProveedores)
            {
                var item = new ListViewItem(prov.IdProveedor.ToString());
                item.SubItems.Add(prov.RazonSocial);
                item.SubItems.Add(prov.NombreComercial);
                item.SubItems.Add(prov.Telefono ?? string.Empty);
                item.SubItems.Add(prov.Email ?? string.Empty);
                item.SubItems.Add(prov.Activo ? "Habilitado" : "Deshabilitado");
                item.Tag = prov;

                materialListView1.Items.Add(item);
            }

            materialListView1.EndUpdate();
        }

        private void TextBoxBuscarProveedor_TextChanged(object? sender, EventArgs e)
        {
            CargarProveedores(TextBoxBuscarProveedor.Text);
        }

        private void MaterialListView1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            bool haySeleccion = materialListView1.SelectedItems.Count > 0;
            BtnEditarProveedor.Enabled = haySeleccion;
            BtnVerDetalleProveedor.Enabled = haySeleccion;
            BtnCambiarEstado.Enabled = haySeleccion;

            if (!haySeleccion)
            {
                BtnCambiarEstado.Text = "Deshabilitar";
                return;
            }

            var proveedor = (Proveedor)materialListView1.SelectedItems[0].Tag;
            BtnCambiarEstado.Text = proveedor.Activo ? "Deshabilitar" : "Habilitar";
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
                CargarProveedores(TextBoxBuscarProveedor.Text);
            };

            pnlEdicionContenedor.Controls.Add(subFormulario);
            pnlEdicionContenedor.Visible = true;
            pnlEdicionContenedor.BringToFront();
            subFormulario.Show();
        }

        private void BtnAgregarProveedor_Click(object? sender, EventArgs e)
        {
            MostrarSubVentana(new FormAltaEdicionProveedor());
        }

        private void BtnEditarProveedor_Click(object? sender, EventArgs e)
        {
            if (materialListView1.SelectedItems.Count == 0) return;

            var provSeleccionado = (Proveedor)materialListView1.SelectedItems[0].Tag;
            MostrarSubVentana(new FormAltaEdicionProveedor(provSeleccionado));
        }

        private void BtnVerDetalleProveedor_Click(object? sender, EventArgs e)
        {
            if (materialListView1.SelectedItems.Count == 0) return;

            var provSeleccionado = (Proveedor)materialListView1.SelectedItems[0].Tag;
            MostrarSubVentana(new FormDetalleProveedor(provSeleccionado));
        }

        private void btnCambiarEstado_Click(object? sender, EventArgs e)
        {
            if (materialListView1.SelectedItems.Count == 0) return;

            var proveedor = (Proveedor)materialListView1.SelectedItems[0].Tag;
            bool nuevoEstado = !proveedor.Activo;
            string accion = nuevoEstado ? "Habilita" : "Deshabilita";

            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro de que desea {accion.ToLower()}r al siguiente proveedor?\n\n" +
                $"- Razón Social: {proveedor.RazonSocial}\n" +
                $"- Nombre Comercial: {proveedor.NombreComercial}\n",
                $"Confirmar {accion}",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            );

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    _proveedorServicio.CambiarEstadoProveedor(proveedor.IdProveedor, nuevoEstado);
                    MessageBox.Show($"Proveedor {accion.ToLower()}do correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar estado: {ex.Message}r", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    CargarProveedores(TextBoxBuscarProveedor.Text);
                }
            }
        }
    }
}