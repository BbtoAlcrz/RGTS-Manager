using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using RGTS.Entidades;
using RGTS.LogicaNegocio.Servicios;

namespace RGTS.Interfaz.EncargadoDeposito
{
    public partial class FormAltaEdicionProveedor : MaterialForm
    {
        private readonly ProveedorServicio _proveedorServicio;
        private readonly Proveedor? _proveedorEditar;
        private readonly bool _esEdicion;

        public FormAltaEdicionProveedor()
        {
            InitializeComponent();

            _proveedorServicio = new ProveedorServicio();
            _esEdicion = false;

            CargarComboTipoProveedor();
            ConfigurarModo();
        }

        public FormAltaEdicionProveedor(Proveedor proveedor) : this()
        {
            _proveedorEditar = proveedor;
            _esEdicion = true;

            ConfigurarModo();
            CargarDatos();
        }

        private void CargarComboTipoProveedor()
        {
            var tiposProveedor = new[]
            {
                new { Nombre = "Consolas de Mesa" },
                new { Nombre = "Consolas Portátiles" },
                new { Nombre = "Mandos" },
                new { Nombre = "Accesorios" },
                new { Nombre = "Otros" }
            };

            ComboBoxTipoProveedor.DataSource = tiposProveedor;
            ComboBoxTipoProveedor.DisplayMember = "Nombre";
            ComboBoxTipoProveedor.ValueMember = "Nombre";
            ComboBoxTipoProveedor.SelectedIndex = -1;
        }

        private void ConfigurarModo()
        {
            if (_esEdicion)
            {
                labelTitulo.Text = "Editar Proveedor";
                BtnGuardarProveedor.Text = "Guardar";
            }
            else
            {
                labelTitulo.Text = "Agregar Proveedor";
                BtnGuardarProveedor.Text = "Agregar";
            }
        }

        private void CargarDatos()
        {
            if (_proveedorEditar != null)
            {
                TextBoxProveedorRazonSocial.Text = _proveedorEditar.RazonSocial;
                TextBoxProveedorNombreComercial.Text = _proveedorEditar.NombreComercial;
                ComboBoxTipoProveedor.SelectedValue = _proveedorEditar.TipoProveedor;
                TextBoxProveedorTelefono.Text = _proveedorEditar.Telefono;
                TextBoxEmailProveedor.Text = _proveedorEditar.Email ?? string.Empty;
                TextBoxProveedorNombre.Text = _proveedorEditar.NombreContacto ?? string.Empty;
                TextBoxProveedorApellido.Text = _proveedorEditar.ApellidoContacto ?? string.Empty;
                TextBoxProveedorDireccion.Text = _proveedorEditar.Direccion;
            }
        }

        private void BtnGuardarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                string tipoProveedor = ComboBoxTipoProveedor.SelectedValue?.ToString()
                                       ?? ComboBoxTipoProveedor.Text.Trim();

                if (string.IsNullOrWhiteSpace(tipoProveedor))
                {
                    throw new ArgumentException("Debe seleccionar un rubro o tipo de proveedor.");
                }

                if (_esEdicion && _proveedorEditar != null)
                {
                    _proveedorServicio.ModificarProveedor(
                        _proveedorEditar.IdProveedor,
                        TextBoxProveedorRazonSocial.Text,
                        TextBoxProveedorNombreComercial.Text,
                        tipoProveedor,
                        TextBoxProveedorTelefono.Text,
                        TextBoxEmailProveedor.Text,
                        TextBoxProveedorNombre.Text,
                        TextBoxProveedorApellido.Text,
                        TextBoxProveedorDireccion.Text
                    );

                    MessageBox.Show("El proveedor ha sido actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _proveedorServicio.RegistrarProveedor(
                        TextBoxProveedorRazonSocial.Text,
                        TextBoxProveedorNombreComercial.Text,
                        tipoProveedor,
                        TextBoxProveedorTelefono.Text,
                        TextBoxEmailProveedor.Text,
                        TextBoxProveedorNombre.Text,
                        TextBoxProveedorApellido.Text,
                        TextBoxProveedorDireccion.Text
                    );

                    MessageBox.Show("El proveedor se registró correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Cierra la subventana, refresca la grilla
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
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnProveedorCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}