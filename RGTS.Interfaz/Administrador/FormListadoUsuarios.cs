using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;
using RGTS.Entidades;
using RGTS.LogicaNegocio.Servicios;

namespace RGTS.Interfaz.Administrador
{
    public partial class FormListadoUsuarios : MaterialForm
    {
        private readonly UsuarioServicio _usuarioServicio;

        // Clase auxiliar solo para los estados (no existe en Entidades)
        private class EstadoFiltro
        {
            public string? Texto { get; set; }
            public bool? Valor { get; set; }
        }

        public FormListadoUsuarios()
        {
            InitializeComponent();
            _usuarioServicio = new UsuarioServicio();
        }

        private void FormListadoUsuarios_Load(object sender, EventArgs e)
        {
            ConfigurarLista();
            CargarFiltros();
            Refrescar();

            BtnEditarUsuario.Enabled = false;
            BtnCambiarEstadoUsuario.Enabled = false;
        }

        private void ConfigurarLista()
        {
            ListaUsuarios.View = View.Details;
            ListaUsuarios.FullRowSelect = true;
            ListaUsuarios.MultiSelect = false;
            ListaUsuarios.GridLines = true;
        }

        private void CargarFiltros()
        {
            // Evitamos que se refresque la lista mientras se cargan los filtros
            ComboBoxListarRol.SelectedValueChanged -= ComboBoxListarRol_SelectedIndexChanged;
            ComboBoxListarEstado.SelectedValueChanged -= ComboBoxListarEstado_SelectedIndexChanged;

            var roles = new[]
            {
                new Rol { IdRol = 0, NombreRol = "Todos los roles" },
                new Rol { IdRol = 1, NombreRol = "Administrador" },
                new Rol { IdRol = 2, NombreRol = "Vendedor" },
                new Rol { IdRol = 3, NombreRol = "Encargado de Depósito" }
            };

            ComboBoxListarRol.DataSource = roles;
            ComboBoxListarRol.DisplayMember = "NombreRol";
            ComboBoxListarRol.ValueMember = "IdRol";
            ComboBoxListarRol.SelectedIndex = 0;

            var estados = new[]
            {
                new EstadoFiltro { Texto = "Todos los estados", Valor = (bool?)null },
                new EstadoFiltro { Texto = "Habilitado", Valor = (bool?)true },
                new EstadoFiltro { Texto = "Deshabilitado", Valor = (bool?)false }
            };

            ComboBoxListarEstado.DataSource = estados;
            ComboBoxListarEstado.DisplayMember = "Texto";
            ComboBoxListarEstado.ValueMember = "Valor";
            ComboBoxListarEstado.SelectedIndex = 0;

            // Reconectamos los eventos tras poblar el DataSource
            ComboBoxListarRol.SelectedValueChanged += ComboBoxListarRol_SelectedIndexChanged;
            ComboBoxListarEstado.SelectedValueChanged += ComboBoxListarEstado_SelectedIndexChanged;
        }

        private void Refrescar()
        {
            ListaUsuarios.BeginUpdate();
            ListaUsuarios.Items.Clear();

            BtnEditarUsuario.Enabled = false;
            BtnCambiarEstadoUsuario.Enabled = false;
            BtnCambiarEstadoUsuario.Text = "Deshabilitar";

            string filtroTexto = TxtBuscarUsuario.Text;
            int idRol = (ComboBoxListarRol.SelectedItem as Rol)?.IdRol ?? 0;
            bool? estado = (ComboBoxListarEstado.SelectedItem as EstadoFiltro)?.Valor;

            List<Usuario> lista = _usuarioServicio.ListarUsuarios(filtroTexto, idRol, estado);

            foreach (var usuario in lista)
            {
                ListViewItem item = new ListViewItem(usuario.Dni);
                item.SubItems.Add(usuario.Nombre);
                item.SubItems.Add(usuario.Apellido);
                item.SubItems.Add(usuario.Email);
                item.SubItems.Add(usuario.Rol?.NombreRol ?? "Sin Rol");
                item.SubItems.Add(usuario.Activo ? "Habilitado" : "Deshabilitado");

                item.Tag = usuario;
                ListaUsuarios.Items.Add(item);
            }

            ListaUsuarios.EndUpdate();
        }

        // Método que incrusta el formulario secundario en el panel superpuesto
        private void MostrarSubVentana(Form subFormulario)
        {
            pnlEdicionContenedor.Controls.Clear();

            subFormulario.TopLevel = false;
            subFormulario.FormBorderStyle = FormBorderStyle.None;
            subFormulario.Dock = DockStyle.Fill;

            // Al cerrarse el formulario secundario, se oculta el panel y se recarga la tabla
            subFormulario.FormClosed += (s, args) =>
            {
                pnlEdicionContenedor.Visible = false;
                pnlEdicionContenedor.Controls.Clear();
                Refrescar();
            };

            pnlEdicionContenedor.Controls.Add(subFormulario);
            pnlEdicionContenedor.Visible = true;
            pnlEdicionContenedor.BringToFront();
            subFormulario.Show();
        }

        private void ListaUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaUsuarios.SelectedItems.Count > 0)
            {
                ListViewItem usuarioSeleccionado = ListaUsuarios.SelectedItems[0];
                Usuario usuario = (Usuario)usuarioSeleccionado.Tag;

                BtnEditarUsuario.Enabled = true;
                BtnCambiarEstadoUsuario.Enabled = true;
                BtnCambiarEstadoUsuario.Text = usuario.Activo ? "Deshabilitar" : "Habilitar";
            }
            else
            {
                BtnEditarUsuario.Enabled = false;
                BtnCambiarEstadoUsuario.Enabled = false;
                BtnCambiarEstadoUsuario.Text = "Deshabilitar";
            }
        }

        private void BtnAgregarUsuario_Click(object sender, EventArgs e)
        {
            MostrarSubVentana(new FormAgregarUsuario());
        }

        private void BtnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (ListaUsuarios.SelectedItems.Count > 0)
            {
                ListViewItem usuarioSeleccionado = ListaUsuarios.SelectedItems[0];
                Usuario usuario = (Usuario)usuarioSeleccionado.Tag;

                MostrarSubVentana(new FormAgregarUsuario(usuario));
            }
        }

        private void BtnCambiarEstadoUsuario_Click(object sender, EventArgs e)
        {
            if (ListaUsuarios.SelectedItems.Count == 0) return;

            ListViewItem usuarioSeleccionado = ListaUsuarios.SelectedItems[0];
            Usuario usuario = (Usuario)usuarioSeleccionado.Tag;

            bool nuevoEstado = !usuario.Activo;
            string accion = nuevoEstado ? "Habilitar" : "Deshabilitar";

            DialogResult respuesta = MessageBox.Show(
                $"¿Está seguro de que desea {accion} al siguiente usuario?\n\n" +
                $"DNI: {usuario.Dni}\n" +
                $"Nombre: {usuario.NombreCompleto}\n" +
                $"Rol: {usuario.Rol?.NombreRol}",
                $"Confirmar {accion.ToUpper()}",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            );

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    string dniActual = FormPrincipal.UsuarioSesion?.Dni ?? string.Empty;
                    _usuarioServicio.CambiarEstadoUsuario(usuario.Dni, nuevoEstado, dniActual);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar estado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Refrescar();
                }
            }
        }

        private void TxtBuscarUsuario_TextChanged(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void ComboBoxListarRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void ComboBoxListarEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refrescar();
        }
    }
}