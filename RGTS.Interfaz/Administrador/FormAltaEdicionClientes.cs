using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using RGTS.Entidades;
using RGTS.LogicaNegocio.Servicios;

namespace RGTS.Interfaz.Administrador
{
    public partial class FormAltaEdicionClientes : MaterialForm
    {
        private readonly ClienteServicio _clienteServicio;
        private readonly Cliente? _clienteEditar;

        // si clienteEditar es null => modo alta, si tiene datos => modo edición
        public FormAltaEdicionClientes(Cliente? clienteEditar = null)
        {
            InitializeComponent();
            _clienteServicio = new ClienteServicio();
            _clienteEditar = clienteEditar;
            ConfigurarModo();
        }

        private void ConfigurarModo()
        {
            labelTitulo.Text = _clienteEditar == null ? "Agregar Nuevo Cliente" : "Editar Cliente";
        }

        private void FormClientesListado_Load(object sender, EventArgs e)
        {
            if (_clienteEditar != null)
            {
                txtNombre.Text = _clienteEditar.Nombre;
                txtApellido.Text = _clienteEditar.Apellido;
                txtDni.Text = _clienteEditar.DNI;
                txtTelefono.Text = _clienteEditar.Telefono;
                txtEmail.Text = _clienteEditar.Email;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_clienteEditar == null)
                {
                    _clienteServicio.RegistrarCliente(
                        txtNombre.Text,
                        txtApellido.Text,
                        txtDni.Text,
                        txtTelefono?.Text,
                        txtEmail?.Text
                    );
                    MessageBox.Show("Cliente registrado correctamente.","Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _clienteServicio.ModificarCliente(
                        _clienteEditar.IdCliente,
                        txtNombre.Text,
                        txtApellido.Text,
                        txtDni.Text,
                        txtTelefono?.Text,
                        txtEmail?.Text
                    );
                    MessageBox.Show("Cliente modificado correctamente.","Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Datos Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}