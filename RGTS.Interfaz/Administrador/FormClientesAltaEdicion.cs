using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using RGTS.Entidades;
using RGTS.LogicaNegocio.Servicios;

namespace RGTS.Interfaz.Administrador
{
    public partial class FormClientesAltaEdicion : MaterialForm
    {
        private readonly ClienteServicio _clienteServicio;
        private readonly Cliente? _clienteEditar;

        // si clienteEditar es null => modo alta, si tiene datos => modo edición
        public FormClientesAltaEdicion(Cliente? clienteEditar = null)
        {
            InitializeComponent();
            _clienteServicio = new ClienteServicio();
            _clienteEditar = clienteEditar;
        }

        private void FormClientesListado_Load(object sender, EventArgs e)
        {
            if (_clienteEditar != null)
            {
                Text = "Editar Cliente";
                txtNombre.Text = _clienteEditar.Nombre;
                txtApellido.Text = _clienteEditar.Apellido;
                txtDni.Text = _clienteEditar.DNI;
                txtTelefono.Text = _clienteEditar.Telefono;
                txtEmail.Text = _clienteEditar.Email;
            }
            else
            {
                Text = "Nuevo Cliente";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = _clienteEditar?.IdCliente ?? 0;
                bool estado = _clienteEditar?.Estado ?? true;

                Cliente cliente = _clienteServicio.ValidarYArmarCliente(
                    id, txtNombre.Text, txtApellido.Text, txtDni.Text, txtTelefono.Text, txtEmail.Text, estado);

                if (_clienteEditar == null)
                    MessageBox.Show("Cliente registrado correctamente.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Cliente modificado correctamente.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (ArgumentException ex)
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