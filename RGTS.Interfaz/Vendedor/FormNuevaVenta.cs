using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin.Controls;
using RGTS.Entidades;
using RGTS.LogicaNegocio.Servicios;

namespace RGTS.Interfaz.Vendedor
{
    public partial class FormNuevaVenta : MaterialForm
    {
        private readonly VentaServicio _ventaServicio;
        private readonly ClienteServicio _clienteServicio;
        private Cliente? _clienteSeleccionado;
        private readonly List<DetalleVenta> _carrito = new();
        private Producto? _productoSeleccionado;


        // DNI de vendedor simulado (luego se pasa UsuarioSesion.Dni)
        private readonly string _dniUsuarioSesion = "41234567";

        public FormNuevaVenta()
        {
            InitializeComponent();
            _clienteServicio = new ClienteServicio();
            _ventaServicio = new VentaServicio();
            ConfigurarControles();
        }

        private void ConfigurarControles()
        {
            comboBoxMetodoPago.Items.Clear();
            comboBoxMetodoPago.Items.AddRange(new string[] { "Efectivo", "Tarjeta de Débito", "Tarjeta de Crédito", "Transferencia" });
            comboBoxMetodoPago.SelectedIndex = 0;

            LimpiarSeccionCliente();
            LimpiarSeccionProducto();
            ActualizarCarrito();
        }


        private void BtnBuscarDniCliente_Click(object? sender, EventArgs e)
        {
            string dni = txtBuscarDniCliente.Text.Trim();
            _clienteSeleccionado = _clienteServicio.BuscarPorDni(dni);

            if (_clienteSeleccionado != null)
            {
                labelNombreValor.Text = _clienteSeleccionado.Nombre;
                labelApellidoValor.Text = _clienteSeleccionado.Apellido;
            }
            else
            {
                MessageBox.Show("Se registrará al cliente como Comsumidor Final", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarSeccionCliente();
            }
        }

        private void LimpiarSeccionCliente()
        {
            _clienteSeleccionado = null;
            labelNombreValor.Text = "-";
            labelApellidoValor.Text = "-";
        }


        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscarProducto.Text;
            _productoSeleccionado = _ventaServicio.BuscarProducto(filtro);

            if (_productoSeleccionado != null)
            {
                labelNombreProductoValor.Text = _productoSeleccionado.Nombre;
                labelPrecioProductoValor.Text = _productoSeleccionado.Precio.ToString("C2");

                int enCarrito = _carrito.Where(d => d.IdProducto == _productoSeleccionado.IdProducto).Sum(d => d.Cantidad);
                int stockRestante = _ventaServicio.ObtenerStockDisponibleReal(_productoSeleccionado.IdProducto, enCarrito);

                labelStockDisponibleValor.Text = stockRestante.ToString();

                if (stockRestante > 0)
                {
                    numericCantidadProducto.Minimum = 1;
                    numericCantidadProducto.Maximum = stockRestante;
                    numericCantidadProducto.Value = 1;
                    numericCantidadProducto.Enabled = true;
                    btnAgregarProducto.Enabled = true;
                }
                else
                {
                    numericCantidadProducto.Minimum = 0;
                    numericCantidadProducto.Maximum = 0;
                    numericCantidadProducto.Value = 0;
                    numericCantidadProducto.Enabled = false;
                    btnAgregarProducto.Enabled = false;

                    MessageBox.Show("No queda stock disponible de este producto (agotado o cargado al carrito).", "Sin Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Producto no encontrado o inactivo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarSeccionProducto();
            }
        }

        private void BtnAgregarProducto_Click(object? sender, EventArgs e)
        {
            if (_productoSeleccionado == null) return;

            try
            {
                int cantidad = (int)numericCantidadProducto.Value;
                var nuevoDetalle = _ventaServicio.GenerarDetalle(_productoSeleccionado, cantidad, _carrito);

                var existente = _carrito.FirstOrDefault(d => d.IdProducto == nuevoDetalle.IdProducto);
                if (existente != null)
                {
                    existente.Cantidad += nuevoDetalle.Cantidad;
                    existente.SubtotalDerivado = existente.Cantidad * existente.PrecioUnitario;
                }
                else
                {
                    _carrito.Add(nuevoDetalle);
                }

                ActualizarCarrito();
                LimpiarSeccionProducto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stock Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelarAgregado_Click(object sender, EventArgs e)
        {   
            LimpiarSeccionProducto();
        }

        private void LimpiarSeccionProducto()
        {
            _productoSeleccionado = null;
            txtBuscarProducto.Clear();
            labelNombreProductoValor.Text = "-";
            labelPrecioProductoValor.Text = "$0,00";
            labelStockDisponibleValor.Text = "-";

            numericCantidadProducto.Minimum = 0;
            numericCantidadProducto.Maximum = 0;
            numericCantidadProducto.Value = 0;
            numericCantidadProducto.Enabled = false;
            btnAgregarProducto.Enabled = false;
        }



        private void ActualizarCarrito()
        {
            ListaDetalleVenta.BeginUpdate();
            ListaDetalleVenta.Items.Clear();

            foreach (var item in _carrito)
            {
                var lvi = new ListViewItem(item.Producto?.Codigo ?? "-");
                lvi.SubItems.Add(item.Producto?.Nombre ?? "Producto");
                lvi.SubItems.Add(item.Cantidad.ToString());
                lvi.SubItems.Add(item.PrecioUnitario.ToString("C2"));
                lvi.SubItems.Add(item.SubtotalDerivado.ToString("C2"));
                lvi.Tag = item;

                ListaDetalleVenta.Items.Add(lvi);
            }

            ListaDetalleVenta.EndUpdate();
            labelTotalCompraValor.Text = _carrito.Sum(d => d.SubtotalDerivado).ToString("C2");
        }



        private void BtnConfirmarCompra_Click(object? sender, EventArgs e)
        {
            try
            {
                string metodoPago = comboBoxMetodoPago.SelectedItem?.ToString() ?? string.Empty;

                Venta ventaRegistrada = _ventaServicio.RegistrarVenta(
                    _dniUsuarioSesion,
                    _clienteSeleccionado,
                    _carrito,
                    metodoPago
                );

                string nombreCliente = ventaRegistrada.Cliente != null
                    ? $"{ventaRegistrada.Cliente.Nombre} {ventaRegistrada.Cliente.Apellido}"
                    : "Consumidor Final";

                MessageBox.Show(
                    $"Venta confirmada exitosamente\n\n" +
                    $"Cliente: {nombreCliente}\n" +
                    $"Método: {metodoPago}\n" +
                    $"Total: {ventaRegistrada.TotalDerivado:C2}",
                    "Venta Exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                _carrito.Clear();
                txtBuscarDniCliente.Clear();
                LimpiarSeccionCliente();
                LimpiarSeccionProducto();
                ActualizarCarrito();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al confirmar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCancelarCompra_Click(object? sender, EventArgs e)
        {
            if (_carrito.Count > 0)
            {
                DialogResult rta = MessageBox.Show(
                    "¿Desea cancelar la venta en curso? Se vaciará el carrito.",
                    "Cancelar Venta",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2
                );

                if (rta != DialogResult.Yes) return;
            }

            FormPrincipal.InstanciaActual?.AbrirFormularioEnPanel(new FormListadoVentas());
        }

    }
}