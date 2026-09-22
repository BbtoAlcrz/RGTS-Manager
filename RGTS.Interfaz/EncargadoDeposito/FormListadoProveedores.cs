using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RGTS.Entidades;
using RGTS.LogicaNegocio;

namespace RGTS.Interfaz.EncargadoDeposito
{
    public partial class FormListadoProveedores : MaterialForm
    {
        private readonly Panel pnlEdicionContenedor = new();

        // Lista de proveedores fijo
        private readonly List<Proveedor> _proveedores = new List<Proveedor>
        {
            new Proveedor
            {
                IdProveedor = 1,
                RazonSocial = "TechImport S.A.",
                NombreComercial = "TechImport SA",
                TipoProveedor = "Consolas de Mesa",
                Telefono = "11-4567-8901",
                Email = "contacto@techimport.com",
                NombreContacto = "Martín",
                ApellidoContacto = "Pérez",
                Direccion = "Av. Corrientes 1234, CABA",
                Activo = true
            },
            new Proveedor
            {
                IdProveedor = 2,
                RazonSocial = "Distribuidora Gamer S.R.L.",
                NombreComercial = "Gamer Distribuidora",
                TipoProveedor = "Mandos",
                Telefono = "11-9876-5432",
                Email = "ventas@gamerdist.com",
                NombreContacto = "Gonzalo",
                ApellidoContacto = "Rodríguez",
                Direccion = "Belgrano 456, Rosario",
                Activo = true
            },
            new Proveedor
            {
                IdProveedor = 3,
                RazonSocial = "ElectroSur Argentina S.A.",
                NombreComercial = "ElectroSur",
                TipoProveedor = "Accesorios",
                Telefono = "379-412-3456",
                Email = "info@electrosur.com",
                NombreContacto = "Claudia",
                ApellidoContacto = "Fernández",
                Direccion = "Junín 789, Corrientes",
                Activo = true
            }
        };

        public FormListadoProveedores()
        {
            InitializeComponent();
            pnlEdicionContenedor.Dock = DockStyle.Fill;
            pnlEdicionContenedor.Visible = false;
            Controls.Add(pnlEdicionContenedor);
            pnlEdicionContenedor.BringToFront();

            // Estado inicial de botones que dependen de selección
            BtnEditarProveedor.Enabled = false;
            BtnVerDetalleProveedor.Enabled = false;

            // Eventos
            TextBoxBuscarProveedor.TextChanged += TextBoxBuscarProveedor_TextChanged;
            materialListView1.SelectedIndexChanged += MaterialListView1_SelectedIndexChanged;
            BtnVerDetalleProveedor.Click += BtnVerDetalleProveedor_Click;

            CargarProveedores();
        }

        private void CargarProveedores(string? criterioBusqueda = null)
        {
            materialListView1.BeginUpdate();
            materialListView1.Items.Clear();

            // Deshabilitar botones de acción al recargar/filtrar
            BtnEditarProveedor.Enabled = false;
            BtnVerDetalleProveedor.Enabled = false;

            IEnumerable<Proveedor> listaFiltrada = _proveedores;

            if (!string.IsNullOrWhiteSpace(criterioBusqueda))
            {
                string filtro = criterioBusqueda.Trim().ToLower();
                listaFiltrada = _proveedores.Where(p =>
                    (!string.IsNullOrEmpty(p.RazonSocial) && p.RazonSocial.ToLower().Contains(filtro)) ||
                    (!string.IsNullOrEmpty(p.NombreComercial) && p.NombreComercial.ToLower().Contains(filtro))
                );
            }

            foreach (var prov in listaFiltrada)
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

        private void BtnAgregarProveedor_Click(object sender, EventArgs e)
        {
            MostrarSubVentana(new FormAgregarProveedor());
        }

        private void BtnEditarProveedor_Click(object sender, EventArgs e)
        {
            if (materialListView1.SelectedItems.Count > 0)
            {
                var provSeleccionado = (Proveedor)materialListView1.SelectedItems[0].Tag;
                MostrarSubVentana(new FormAgregarProveedor(provSeleccionado));
            }
        }

        private void BtnVerDetalleProveedor_Click(object? sender, EventArgs e)
        {
            if (materialListView1.SelectedItems.Count > 0)
            {
                var provSeleccionado = (Proveedor)materialListView1.SelectedItems[0].Tag;
                MostrarSubVentana(new FormDetalleProveedor(provSeleccionado));
            }
        }
    }
}