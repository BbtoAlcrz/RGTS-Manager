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
            public string Texto { get; set; }
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

        //la funcion se encarga principalmente de cargar el filtro de Rol y Estado 
        private void CargarFiltros()
        {
            // evitamos que se refresque la lista mientras se cargan los filtros
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

            // una vez cargados los filtros, la lista se puede refrescar al cambiar la selección
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

                item.Tag = usuario; // almacena el Usuario en un Tag para poder acceder a él
                ListaUsuarios.Items.Add(item);
            }

            ListaUsuarios.EndUpdate();
        }


        // funcion que se ejecuta al seleccionar o deseleccionar un usuario de la lista
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
            //cuando presione el boton y finalice de agregar un Usuario, refresca la lista
            using (var form = new FormAgregarUsuario())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Refrescar();
                }
            }
        }


        private void BtnEditarUsuario_Click(object sender, EventArgs e)
        {
            // Se extrae la entidad original almacenada en el Tag de la fila elegida
            ListViewItem usuarioSeleccionado = ListaUsuarios.SelectedItems[0];
            Usuario usuario = (Usuario)usuarioSeleccionado.Tag;

            //cuando presione el boton y actualice un Usuario, refresca la lista
            using (var form = new FormAgregarUsuario(usuario))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Refrescar();
                }
            }
        }


        private void BtnCambiarEstadoUsuario_Click(object sender, EventArgs e)
        {
            // se extrae la entidad original almacenada en el Tag de la fila elegida
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

            //cuando presione "Si" y actualice un Usuario, refresca la lista
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