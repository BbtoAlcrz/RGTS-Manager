using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MaterialSkin.Controls;
using RGTS.Entidades;
using RGTS.LogicaNegocio.Servicios;

namespace RGTS.Interfaz.Administrador
{
    public partial class FormAgregarUsuario : MaterialForm
    {
        private readonly UsuarioServicio _usuarioServicio;
        private readonly Usuario? _usuarioEditar;
        private readonly bool _esEdicion;

        public FormAgregarUsuario()
        {
            InitializeComponent();
            Sizable = false;
            FormStyle = FormStyles.StatusAndActionBar_None;
            _usuarioServicio = new UsuarioServicio();
            _esEdicion = false;
            CargarComboRoles();
            ConfigurarModo();
        }

        public FormAgregarUsuario(Usuario usuario) : this()
        {
            _usuarioEditar = usuario;
            _esEdicion = true;

            ConfigurarModo();
            CargarDatos();
        }

        private void CargarComboRoles()
        {
            var roles = new[]
            {
                new { IdRol = 1, Nombre = "Administrador" },
                new { IdRol = 2, Nombre = "Vendedor" },
                new { IdRol = 3, Nombre = "Encargado de Depósito" }
            };

            ComboBoxUsuarioRol.DataSource = roles;
            ComboBoxUsuarioRol.DisplayMember = "Nombre";
            ComboBoxUsuarioRol.ValueMember = "IdRol";
            ComboBoxUsuarioRol.SelectedIndex = -1;
        }

        private void ConfigurarModo()
        {
            if (_esEdicion)
            {
                labelTitulo.Text = "Editar Usuario";
                BtnAgregarUsuarioNuevo.Text = "Guardar";
                TextBoxUsuarioDni.ReadOnly = true;
                LabelUsuarioContrasenia.Text = "Nueva Contraseña (dejar vacio para no cambiar)";
            }
            else
            {
                labelTitulo.Text = "Agregar Usuario";
                BtnAgregarUsuarioNuevo.Text = "Agregar";
                TextBoxUsuarioDni.ReadOnly = false;
            }
        }

        private void CargarDatos()
        {
            if (_usuarioEditar != null)
            {
                TextBoxUsuarioDni.Text = _usuarioEditar.Dni;
                TextBoxUsuarioNombre.Text = _usuarioEditar.Nombre;
                TextBoxUsuarioApellido.Text = _usuarioEditar.Apellido;
                TextBoxUsuarioEmail.Text = _usuarioEditar.Email;
                ComboBoxUsuarioRol.SelectedValue = _usuarioEditar.IdRol;
                TextBoxUsuarioContrasenia.Text = string.Empty;
            }
        }

        private void BtnAgregarUsuarioNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                int idRolSeleccionado = ComboBoxUsuarioRol.SelectedValue != null ? Convert.ToInt32(ComboBoxUsuarioRol.SelectedValue) : 0;

                if (_esEdicion)
                {
                    _usuarioServicio.ModificarUsuario(
                        TextBoxUsuarioDni.Text,
                        TextBoxUsuarioNombre.Text,
                        TextBoxUsuarioApellido.Text,
                        TextBoxUsuarioEmail.Text,
                        idRolSeleccionado,
                        TextBoxUsuarioContrasenia.Text
                    );

                    MessageBox.Show("El Usuario ha sido modificado Correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _usuarioServicio.RegistrarUsuario(
                        TextBoxUsuarioDni.Text,
                        TextBoxUsuarioNombre.Text,
                        TextBoxUsuarioApellido.Text,
                        TextBoxUsuarioEmail.Text,
                        idRolSeleccionado,
                        TextBoxUsuarioContrasenia.Text
                    );

                    MessageBox.Show("El Usuario se registró Correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Close(); // Oculta el panel contenedor y refresca la grilla automáticamente
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelarUsuario_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra y regresa al listado sin guardar
        }
    }
}