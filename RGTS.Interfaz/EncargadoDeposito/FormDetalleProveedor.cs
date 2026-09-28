using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;
using RGTS.Entidades;

namespace RGTS.Interfaz.EncargadoDeposito
{
    public partial class FormDetalleProveedor : MaterialForm
    {
        private readonly Proveedor _proveedor;

        public FormDetalleProveedor(Proveedor proveedor)
        {
            InitializeComponent();

            _proveedor = proveedor ?? throw new ArgumentNullException(nameof(proveedor));

            ConfigurarControles();
            CargarDatos();
        }

        private void ConfigurarControles()
        {
            btnVolver.Click -= BtnVolver_Click;
            btnVolver.Click += BtnVolver_Click;
        }

        private void CargarDatos()
        {
            labelIdValor.Text = _proveedor.IdProveedor.ToString();
            labelEstadoValor.Text = _proveedor.Activo ? "Habilitado" : "Deshabilitado";

            labelRazonSocialValor.Text = !string.IsNullOrWhiteSpace(_proveedor.RazonSocial)
                ? _proveedor.RazonSocial
                : "No especificada";

            labelNombreComercialValor.Text = !string.IsNullOrWhiteSpace(_proveedor.NombreComercial)
                ? _proveedor.NombreComercial
                : "No especificado";

            labelTipoProveedorValor.Text = !string.IsNullOrWhiteSpace(_proveedor.TipoProveedor)
                ? _proveedor.TipoProveedor
                : "No asignado";

            bool tieneContacto = !string.IsNullOrWhiteSpace(_proveedor.NombreContacto) || !string.IsNullOrWhiteSpace(_proveedor.ApellidoContacto);
            labelContactoValor.Text = tieneContacto
                ? $"{_proveedor.NombreContacto} {_proveedor.ApellidoContacto}".Trim()
                : "No especificado";

            labelTelefonoValor.Text = !string.IsNullOrWhiteSpace(_proveedor.Telefono) ? _proveedor.Telefono : "Sin registrar";
            labelEmailValor.Text = !string.IsNullOrWhiteSpace(_proveedor.Email) ? _proveedor.Email : "Sin registrar";
            labelDireccionValor.Text = !string.IsNullOrWhiteSpace(_proveedor.Direccion) ? _proveedor.Direccion : "Sin registrar";
        }

        private void BtnVolver_Click(object? sender, EventArgs e)
        {
            // Cierra la subventana, regresa a la grilla
            this.Close();
        }
    }
}