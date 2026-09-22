using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RGTS.Entidades;
using RGTS.LogicaNegocio.Servicios;

namespace RGTS.Interfaz.EncargadoDeposito
{
    public partial class FormAgregarProveedor : MaterialForm
    {
        private readonly ProveedorServicio _proveedorServicio;
        private readonly Proveedor? _proveedorEditar;
        
        private readonly bool _esEdicion;

        public FormAgregarProveedor()
        {
            InitializeComponent();
            Sizable = false;
            FormStyle = FormStyles.StatusAndActionBar_None;
            _proveedorServicio = new ProveedorServicio();
            _esEdicion = false;
            CargarComboTipoProveedor();
            ConfigurarModo();
        }

        public FormAgregarProveedor(Proveedor proveedor) : this()
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
                new {Nombre = "Consolas de Mesa"},
                new {Nombre = "Consolas Portátiles"},
                new {Nombre = "Mandos"},
                new {Nombre = "Accesorios"},
                new {Nombre = "Otros"},
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
                this.Text = "Editar Proveedor";
                BtnGuardarProveedor.Text = "Guardar";
            }
            else
            {
            this.Text = "Agregar Proveedor";
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
                // lógica para guardar o actualizar datos de proveedor
                string? tipoProveedorSeleccionado = ComboBoxTipoProveedor.SelectedValue?.ToString();

                if (_esEdicion)
                {
                    //logica de edicion
                    _proveedorServicio.ModificarProveedor(
                        TextBoxProveedorRazonSocial.Text,
                        TextBoxProveedorNombreComercial.Text,
                        ComboBoxTipoProveedor.Text,
                        TextBoxProveedorTelefono.Text,
                        TextBoxEmailProveedor.Text,
                        TextBoxProveedorNombre.Text,
                        TextBoxProveedorApellido.Text,
                        TextBoxProveedorDireccion.Text
                    );
                    MessageBox.Show("El Proveedor ha sido actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _proveedorServicio.RegistrarProveedor(
                        TextBoxProveedorRazonSocial.Text,
                        TextBoxProveedorNombreComercial.Text,
                        ComboBoxTipoProveedor.Text,
                        TextBoxProveedorTelefono.Text,
                        TextBoxEmailProveedor.Text,
                        TextBoxProveedorNombre.Text,
                        TextBoxProveedorApellido.Text,
                        TextBoxProveedorDireccion.Text
                    );

                    MessageBox.Show("El Proveedor se registró correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnProveedorCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
