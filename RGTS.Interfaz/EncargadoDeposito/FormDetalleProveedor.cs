using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using RGTS.Entidades;

namespace RGTS.Interfaz.EncargadoDeposito
{
    public partial class FormDetalleProveedor : MaterialForm
    {
        private readonly Proveedor _proveedor;

        public FormDetalleProveedor(Proveedor proveedor)
        {
            _proveedor = proveedor ?? throw new ArgumentNullException(nameof(proveedor));
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            labelIdValor.Text = _proveedor.IdProveedor.ToString();
            labelEstadoValor.Text = _proveedor.Activo ? "Habilitado" : "Deshabilitado";
            labelEstadoValor.ForeColor = _proveedor.Activo ? Color.Green : Color.Red;

            labelRazonSocialValor.Text = _proveedor.RazonSocial;
            labelNombreComercialValor.Text = _proveedor.NombreComercial;
            labelTipoProveedorValor.Text = !string.IsNullOrWhiteSpace(_proveedor.TipoProveedor) ? _proveedor.TipoProveedor : "No asignado";

            labelContactoValor.Text = (!string.IsNullOrWhiteSpace(_proveedor.NombreContacto) || !string.IsNullOrWhiteSpace(_proveedor.ApellidoContacto))
                ? $"{_proveedor.NombreContacto} {_proveedor.ApellidoContacto}".Trim()
                : "No especificado";

            labelTelefonoValor.Text = !string.IsNullOrWhiteSpace(_proveedor.Telefono) ? _proveedor.Telefono : "Sin registrar";
            labelEmailValor.Text = !string.IsNullOrWhiteSpace(_proveedor.Email) ? _proveedor.Email : "Sin registrar";
            labelDireccionValor.Text = !string.IsNullOrWhiteSpace(_proveedor.Direccion) ? _proveedor.Direccion : "Sin registrar";
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}