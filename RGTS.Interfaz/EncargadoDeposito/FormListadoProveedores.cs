using MaterialSkin.Controls;
using RGTS.Entidades;
using RGTS.LogicaNegocio;
using RGTS.LogicaNegocio.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
            ConfigurarPermisosPorRol();
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

        private void ConfigurarPermisosPorRol()
        {
            bool puedeGestionar = FormPrincipal.RolSesion == "Administrador";

            BtnAgregarProveedor.Visible = puedeGestionar;
            BtnEditarProveedor.Visible = puedeGestionar;
            BtnCambiarEstado.Visible = puedeGestionar;
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
            if (!haySeleccion)
            {
                BtnCambiarEstado.Text = "Estado";
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

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            if (materialListView1.SelectedItems.Count == 0) return;

            var proveedor = (Proveedor)materialListView1.SelectedItems[0].Tag;

            bool nuevoEstado = !proveedor.Activo;
            string accion = nuevoEstado ? "Habilita" : "Deshabilita";

            // Confirmación con foco predeterminado en 'No'
            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro de que desea {accion.ToLower()}r el siguiente proveedor?\n\n" +
                $" Razón Social: {proveedor.RazonSocial}\n" +
                $" Nombre Comercial: {proveedor.NombreComercial}\n",
                $"Confirmar {accion}do",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            );

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    // No hay servicio/repositorio en este formulario: se modifica directo
                    // el objeto en memoria dentro de _proveedores (misma lista que alimenta la grilla)
                    proveedor.Activo = nuevoEstado;

                    MessageBox.Show($"Proveedor {accion.ToLower()}do correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar estado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    CargarProveedores(TextBoxBuscarProveedor.Text);
                }
            }
        }
    }
}