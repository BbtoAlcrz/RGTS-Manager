using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin.Controls;
using RGTS.Entidades;
using RGTS.LogicaNegocio.Servicios;

namespace RGTS.Interfaz.Vendedor
{
    public partial class FormListadoVentas : MaterialForm
    {
        private readonly VentaServicio _ventaServicio;
        private readonly string? _rolActual;
        private readonly string? _dniUsuarioActual;

        private readonly Panel pnlEdicionContenedor = new();

        // Auxiliar para el filtro de vendedores
        private class VendedorFiltro
        {
            public string Texto { get; set; } = string.Empty;
            public string? Dni { get; set; }
        }

        public FormListadoVentas()
        {
            InitializeComponent();
            pnlEdicionContenedor.Dock = DockStyle.Fill;
            pnlEdicionContenedor.Visible = false;
            this.Controls.Add(pnlEdicionContenedor);
            pnlEdicionContenedor.BringToFront();

            _ventaServicio = new VentaServicio();
            _rolActual = FormPrincipal.RolSesion ?? "Administrador";
            _dniUsuarioActual = FormPrincipal.UsuarioSesion?.Dni;

            ConfigurarVistaPorRol();
            ConfigurarControles();
            CargarFiltroVendedores();
            RefrescarVentas();
        }

        private void ConfigurarVistaPorRol()
        {
            // Si es Vendedor, no debe poder seleccionar otros vendedores
            if (_rolActual == "Vendedor")
            {
                ComboBoxVendedor.Visible = false;
            }
            else
            {
                ComboBoxVendedor.Visible = true;
            }
        }

        private void ConfigurarControles()
        {
            listaVentas.View = View.Details;
            listaVentas.FullRowSelect = true;
            listaVentas.MultiSelect = false;
            listaVentas.GridLines = true;

            BtnDetalleVenta.Enabled = false;

            // Por defecto: último mes hasta hoy
            DtpDesde.Value = DateTime.Today.AddMonths(-1);
            DtpHasta.Value = DateTime.Today;
        }

        private void CargarFiltroVendedores()
        {
            ComboBoxVendedor.SelectedIndexChanged -= ComboBoxVendedor_SelectedIndexChanged;

            var lista = new List<VendedorFiltro>
            {
                new VendedorFiltro { Texto = "Todos los Vendedores", Dni = null },
                new VendedorFiltro { Texto = "Fausto Avalos (41234567)", Dni = "41234567" },
                new VendedorFiltro { Texto = "Benito Alcaraz (45020546)", Dni = "45020546" }
            };

            ComboBoxVendedor.DataSource = lista;
            ComboBoxVendedor.DisplayMember = "Texto";
            ComboBoxVendedor.ValueMember = "Dni";
            ComboBoxVendedor.SelectedIndex = 0;

            ComboBoxVendedor.SelectedIndexChanged += ComboBoxVendedor_SelectedIndexChanged;
        }

        private void RefrescarVentas()
        {
            listaVentas.BeginUpdate();
            listaVentas.Items.Clear();
            BtnDetalleVenta.Enabled = false;

            string? dniVendedorFiltro = null;

            if (_rolActual == "Vendedor")
            {
                dniVendedorFiltro = _dniUsuarioActual ?? "41234567";
            }
            else if (ComboBoxVendedor.SelectedItem is VendedorFiltro vFiltro)
            {
                dniVendedorFiltro = vFiltro.Dni;
            }

            string filtroCliente = TextBoxBuscarCliente.Text;
            DateTime fechaDesde = DtpDesde.Value.Date;
            DateTime fechaHasta = DtpHasta.Value.Date;

            List<Venta> ventas = _ventaServicio.ObtenerHistorialVentas(
                dniVendedorFiltro,
                filtroCliente,
                fechaDesde,
                fechaHasta
            );

            foreach (var venta in ventas)
            {
                var item = new ListViewItem(venta.IdVenta.ToString("D5"));
                item.SubItems.Add(venta.Fecha.ToString("dd/MM/yyyy HH:mm"));
                item.SubItems.Add(venta.DniUsuario);
                item.SubItems.Add(venta.Cliente != null ? $"{venta.Cliente.DNI} ({venta.Cliente.Nombre})" : "Consumidor Final");
                item.SubItems.Add(venta.TotalDerivado.ToString("C2"));

                item.Tag = venta;
                listaVentas.Items.Add(item);
            }

            listaVentas.EndUpdate();
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
                RefrescarVentas();
            };

            pnlEdicionContenedor.Controls.Add(subFormulario);
            pnlEdicionContenedor.Visible = true;
            pnlEdicionContenedor.BringToFront();
            subFormulario.Show();
        }

        private void ListaVentas_SelectedIndexChanged(object? sender, EventArgs e)
        {
            BtnDetalleVenta.Enabled = listaVentas.SelectedItems.Count > 0;
        }

        private void ComboBoxVendedor_SelectedIndexChanged(object? sender, EventArgs e)
        {
            RefrescarVentas();
        }

        private void BtnLimpiar_Click(object? sender, EventArgs e)
        {
            TextBoxBuscarCliente.Clear();
            DtpDesde.Value = DateTime.Today.AddMonths(-1);
            DtpHasta.Value = DateTime.Today;

            if (ComboBoxVendedor.Items.Count > 0)
            {
                ComboBoxVendedor.SelectedIndex = 0;
            }

            RefrescarVentas();
        }

        private void BtnDetalleVenta_Click(object? sender, EventArgs e)
        {
            if (listaVentas.SelectedItems.Count == 0) return;

            var ventaSeleccionada = (Venta)listaVentas.SelectedItems[0].Tag;

            // Se abre FormDetalleVenta incrustado en el panel
            MostrarSubVentana(new FormDetalleVenta(ventaSeleccionada));
        }

        private void BtnNuevaVenta_Click(object? sender, EventArgs e)
        {
            var formNueva = new FormNuevaVenta();
            FormPrincipal.InstanciaActual?.AbrirFormularioEnPanel(formNueva);
        }

        private void TextBoxBuscarCliente_TextChanged(object? sender, EventArgs e)
        {
            RefrescarVentas();
        }

        private void DtpDesde_ValueChanged(object? sender, EventArgs e)
        {
            RefrescarVentas();
        }

        private void DtpHasta_ValueChanged(object? sender, EventArgs e)
        {
            RefrescarVentas();
        }
    }
}