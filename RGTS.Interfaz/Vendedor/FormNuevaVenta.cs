using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using MaterialSkin.Controls;
using RGTS.Entidades;
using RGTS.LogicaNegocio.Servicios;

namespace RGTS.Interfaz.Vendedor
{
    public partial class FormNuevaVenta : MaterialForm
    {
        private readonly Panel pnlEdicionContenedor = new();
        private readonly VentaServicio _ventaServicio;
        private readonly ClienteServicio _clienteServicio;

        private readonly BuscadorSugerencias _buscadorCliente;
        private readonly BuscadorSugerencias _buscadorProducto;

        private Cliente? _clienteSeleccionado;
        private Producto? _productoSeleccionado;
        private readonly List<DetalleVenta> _carrito = new();
        private bool _evitarReentrada = false;

        private readonly string _dniUsuarioSesion;
        private readonly Usuario? _usuarioSesion;
        private readonly System.Windows.Forms.Timer _timerReservas = new() { Interval = 60_000 };

        public FormNuevaVenta()
        {
            InitializeComponent();

            pnlEdicionContenedor.Dock = DockStyle.Fill;
            pnlEdicionContenedor.Visible = false;
            this.Controls.Add(pnlEdicionContenedor);
            pnlEdicionContenedor.BringToFront();

            _clienteServicio = new ClienteServicio();
            _ventaServicio = new VentaServicio();

            _usuarioSesion = FormPrincipal.UsuarioSesion;
            _dniUsuarioSesion = _usuarioSesion.Dni;

            _buscadorCliente = new BuscadorSugerencias(this);
            _buscadorProducto = new BuscadorSugerencias(this);

            ConfigurarControles();
            SuscribirEventos();

            try { _ventaServicio.LiberarReservasUsuario(_dniUsuarioSesion); } catch { }

            _timerReservas.Tick += (_, _) =>
            {
                if (_carrito.Count == 0) return;
                try { _ventaServicio.RenovarReservas(_dniUsuarioSesion); } catch { }
            };
            _timerReservas.Start();
        }

        private void ConfigurarControles()
        {
            ListaDetalleVenta.View = View.Details;
            ListaDetalleVenta.FullRowSelect = true;
            ListaDetalleVenta.MultiSelect = false;
            ListaDetalleVenta.GridLines = true;

            comboBoxMetodoPago.Items.Clear();
            comboBoxMetodoPago.Items.AddRange(new string[] { "Efectivo", "Tarjeta de Débito", "Tarjeta de Crédito", "Transferencia" });
            comboBoxMetodoPago.SelectedIndex = 0;

            LimpiarSeccionCliente();
            LimpiarSeccionProducto();
            ActualizarCarrito();
        }

        private void SuscribirEventos()
        {
            txtBuscarDniCliente.TextChanged += TxtBuscarDniCliente_TextChanged;
            txtBuscarDniCliente.KeyDown += (s, e) => _buscadorCliente.ProcesarTeclaNavegacion(e);

            txtBuscarProducto.TextChanged += TxtBuscarProducto_TextChanged;
            txtBuscarProducto.KeyDown += TxtBuscarProducto_KeyDown;
        }

        private void TxtBuscarDniCliente_TextChanged(object? sender, EventArgs e)
        {
            if (_evitarReentrada) return;

            string texto = txtBuscarDniCliente.Text.Trim();
            if (string.IsNullOrWhiteSpace(texto))
            {
                _buscadorCliente.Ocultar();
                return;
            }

            var coincidencias = _clienteServicio.ObtenerTodos(texto).Where(c => c.Estado).ToList();
            var textos = coincidencias.Select(c => $"{c.Nombre} {c.Apellido} - DNI {c.DNI}").ToList();

            _buscadorCliente.Mostrar(txtBuscarDniCliente, textos, indice =>
            {
                var seleccionado = coincidencias[indice];
                _evitarReentrada = true;
                txtBuscarDniCliente.Text = seleccionado.DNI;
                _evitarReentrada = false;

                BtnBuscarDniCliente_Click(this, EventArgs.Empty);
            });
        }

        private void TxtBuscarProducto_TextChanged(object? sender, EventArgs e)
        {
            if (_evitarReentrada) return;

            string texto = txtBuscarProducto.Text.Trim();
            if (string.IsNullOrWhiteSpace(texto))
            {
                _buscadorProducto.Ocultar();
                return;
            }

            var coincidencias = _ventaServicio.BuscarCoincidenciasProducto(texto);
            var textos = coincidencias.Select(p => $"{p.Nombre} ({p.Codigo}) - {p.Precio:C2}").ToList();

            _buscadorProducto.Mostrar(txtBuscarProducto, textos, indice =>
            {
                var seleccionado = coincidencias[indice];
                _evitarReentrada = true;
                txtBuscarProducto.Text = seleccionado.Codigo;
                _evitarReentrada = false;

                btnBuscarProducto_Click(this, EventArgs.Empty);
            });
        }

        private void TxtBuscarProducto_KeyDown(object? sender, KeyEventArgs e)
        {
            if (_buscadorProducto.ProcesarTeclaNavegacion(e)) return;

            if (e.KeyCode == Keys.Enter)
            {
                btnBuscarProducto_Click(sender, EventArgs.Empty);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void BtnBuscarDniCliente_Click(object? sender, EventArgs e)
        {
            string dni = txtBuscarDniCliente.Text.Trim();

            if (string.IsNullOrWhiteSpace(dni))
            {
                MessageBox.Show("Por favor, ingrese un número de DNI para realizar la búsqueda.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _clienteSeleccionado = _clienteServicio.BuscarPorDni(dni);

            if (_clienteSeleccionado != null)
            {
                labelNombreValor.Text = _clienteSeleccionado.Nombre;
                labelApellidoValor.Text = _clienteSeleccionado.Apellido;
            }
            else
            {
                DialogResult respuesta = MessageBox.Show(
                    $"El cliente con DNI {dni} no fue encontrado.\n\n¿Desea registrarlo en el sistema?",
                    "Cliente no registrado",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2
                );

                if (respuesta == DialogResult.Yes)
                {
                    var formAlta = new RGTS.Interfaz.Administrador.FormAltaEdicionClientes(null, dni);

                    MostrarSubVentana(formAlta, () =>
                    {
                        _clienteSeleccionado = _clienteServicio.BuscarPorDni(dni);

                        if (_clienteSeleccionado != null)
                        {
                            labelNombreValor.Text = _clienteSeleccionado.Nombre;
                            labelApellidoValor.Text = _clienteSeleccionado.Apellido;
                        }
                        else
                        {
                            LimpiarSeccionCliente();
                        }
                    });
                }
                else
                {
                    LimpiarSeccionCliente();
                }
            }
        }

        private void btnBuscarProducto_Click(object? sender, EventArgs e)
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
                MessageBox.Show("Producto no encontrado o inactivo en el catálogo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarSeccionProducto();
            }
        }

        private void BtnAgregarProducto_Click(object? sender, EventArgs e)
        {
            if (_productoSeleccionado == null) return;

            try
            {
                int cantidad = (int)numericCantidadProducto.Value;
                var nuevoDetalle = _ventaServicio.GenerarDetalle(_productoSeleccionado, cantidad, _carrito, _dniUsuarioSesion);

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

        private void btnCancelarAgregado_Click(object? sender, EventArgs e)
        {
            LimpiarSeccionProducto();
        }

        private void MenuEditarCantidad_Click(object? sender, EventArgs e)
        {
            if (ListaDetalleVenta.SelectedItems.Count == 0) return;

            var detalle = (DetalleVenta)ListaDetalleVenta.SelectedItems[0].Tag;

            string input = Microsoft.VisualBasic.Interaction.InputBox(
                $"Ingrese la nueva cantidad para '{detalle.Producto?.Nombre}':",
                "Modificar Cantidad",
                detalle.Cantidad.ToString()
            );

            if (string.IsNullOrWhiteSpace(input)) return;

            if (!int.TryParse(input, out int nuevaCantidad))
            {
                MessageBox.Show("Debe ingresar un valor numérico entero válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Ajusta la reserva en la BD y, si sale bien, la cantidad del carrito
                _ventaServicio.ModificarCantidadDetalle(detalle, nuevaCantidad, _dniUsuarioSesion);
                ActualizarCarrito();
                ActualizarStockVisible(detalle.IdProducto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stock / Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MenuEliminarItem_Click(object? sender, EventArgs e)
        {
            if (ListaDetalleVenta.SelectedItems.Count == 0) return;

            var detalle = (DetalleVenta)ListaDetalleVenta.SelectedItems[0].Tag;

            var confirmacion = MessageBox.Show(
                $"¿Desea quitar '{detalle.Producto?.Nombre}' del carrito?",
                "Quitar Producto",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            );

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    // Libera la reserva del producto y lo quita del carrito
                    _ventaServicio.EliminarDetalle(detalle, _carrito, _dniUsuarioSesion);
                    ActualizarCarrito();
                    ActualizarStockVisible(detalle.IdProducto);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Quitar Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void LimpiarSeccionCliente()
        {
            _clienteSeleccionado = null;
            labelNombreValor.Text = "-";
            labelApellidoValor.Text = "-";
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

        private void ActualizarStockVisible(int idProductoAfectado)
        {
            // Si no hay producto seleccionado o no coincide con el que cambió en el carrito, no hacemos nada
            if (_productoSeleccionado == null || _productoSeleccionado.IdProducto != idProductoAfectado)
                return;

            int enCarrito = _carrito.Where(d => d.IdProducto == _productoSeleccionado.IdProducto).Sum(d => d.Cantidad);
            int stockRestante = _ventaServicio.ObtenerStockDisponibleReal(_productoSeleccionado.IdProducto, enCarrito);

            labelStockDisponibleValor.Text = stockRestante.ToString();

            if (stockRestante > 0)
            {
                numericCantidadProducto.Minimum = 1;
                numericCantidadProducto.Maximum = stockRestante;
                numericCantidadProducto.Enabled = true;

                // Ajustamos el Value si el valor actual quedó desfasado respecto al nuevo máximo
                if (numericCantidadProducto.Value > stockRestante)
                {
                    numericCantidadProducto.Value = stockRestante;
                }
                else if (numericCantidadProducto.Value < 1)
                {
                    numericCantidadProducto.Value = 1;
                }

                btnAgregarProducto.Enabled = true;
            }
            else
            {
                numericCantidadProducto.Minimum = 0;
                numericCantidadProducto.Maximum = 0;
                numericCantidadProducto.Value = 0;
                numericCantidadProducto.Enabled = false;
                btnAgregarProducto.Enabled = false;
            }
        }

        private void BtnConfirmarCompra_Click(object? sender, EventArgs e)
        {
            string metodoPago = comboBoxMetodoPago.SelectedItem?.ToString() ?? "Efectivo";
            Venta ventaRegistrada;

            try
            {
                if (sender is Control boton) boton.Enabled = false;

                ventaRegistrada = _ventaServicio.RegistrarVenta(
                    _dniUsuarioSesion, _clienteSeleccionado, _carrito, metodoPago, _usuarioSesion);

                _carrito.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message + "\n\nNo se registró la venta ni se modificó el stock. Podés revisar el carrito e intentar de nuevo.",
                    "No se pudo confirmar la venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            finally
            {
                if (sender is Control boton) boton.Enabled = true;
            }

            string nombreCliente = ventaRegistrada.Cliente != null
                ? $"{ventaRegistrada.Cliente.Nombre} {ventaRegistrada.Cliente.Apellido}"
                : "Consumidor Final";

            MessageBox.Show(
                $"Venta N°: {ventaRegistrada.IdVenta:D5} confirmada exitosamente\n\n" +
                $"- Vendedor (DNI): {ventaRegistrada.DniUsuario}\n" +
                $"- Cliente: {nombreCliente}\n" +
                $"- Método: {metodoPago}\n" +
                $"- Total: {ventaRegistrada.TotalDerivado:C2}",
                "Venta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            try
            {
                if (MessageBox.Show("¿Quiere generar el comprobante en formato PDF?", "Emitir Factura PDF",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using var sfd = new SaveFileDialog
                    {
                        Filter = "Archivos PDF (*.pdf)|*.pdf",
                        FileName = $"Factura_Venta_{ventaRegistrada.IdVenta:D5}.pdf"
                    };

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        new PdfFacturaServicio().GenerarFactura(ventaRegistrada, sfd.FileName);
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                        {
                            FileName = sfd.FileName,
                            UseShellExecute = true
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"La venta se registró correctamente, pero no se pudo generar el PDF: {ex.Message}",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            txtBuscarDniCliente.Clear();
            LimpiarSeccionCliente();
            LimpiarSeccionProducto();
            ActualizarCarrito();
            FormPrincipal.InstanciaActual?.AbrirFormularioEnPanel(new FormListadoVentas());
        }

        private void BtnCancelarCompra_Click(object? sender, EventArgs e)
        {
            if (_carrito.Count > 0)
            {
                DialogResult rta = MessageBox.Show(
                    "¿Desea cancelar la venta en curso? también se vaciará el carrito",
                    "Cancelar Venta",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2
                );

                if (rta != DialogResult.Yes) return;
                LiberarReservasPendientes();
            }

            FormPrincipal.InstanciaActual?.AbrirFormularioEnPanel(new FormListadoVentas());
        }

        private void LiberarReservasPendientes()
        {
            if (_carrito.Count == 0) return;

            try { _ventaServicio.LiberarReservasUsuario(_dniUsuarioSesion); }
            catch { }
            finally { _carrito.Clear(); }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _timerReservas.Stop();
            _timerReservas.Dispose();
            LiberarReservasPendientes();
            base.OnFormClosing(e);
        }

        private void MostrarSubVentana(Form subFormulario, Action alCerrar)
        {
            pnlEdicionContenedor.Controls.Clear();
            subFormulario.TopLevel = false;
            subFormulario.FormBorderStyle = FormBorderStyle.None;
            subFormulario.Dock = DockStyle.Fill;

            subFormulario.FormClosed += (s, args) =>
            {
                pnlEdicionContenedor.Visible = false;
                pnlEdicionContenedor.Controls.Clear();
                alCerrar?.Invoke();
            };

            pnlEdicionContenedor.Controls.Add(subFormulario);
            pnlEdicionContenedor.Visible = true;
            pnlEdicionContenedor.BringToFront();
            subFormulario.Show();
        }

        private void ListaDetalleVenta_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var item = ListaDetalleVenta.GetItemAt(e.X, e.Y);
                if (item != null)
                {
                    item.Selected = true;
                    item.Focused = true;
                }
            }
        }
    }
}