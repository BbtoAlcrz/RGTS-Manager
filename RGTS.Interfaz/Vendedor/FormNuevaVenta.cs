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
        private Cliente? _clienteSeleccionado;
        private readonly List<DetalleVenta> _carrito = new();
        private Producto? _productoSeleccionado;

        // Controles para sugerencias flotantes
        private ListBox? _listaSugerencias;
        private EventHandler? _listaClickHandler;
        private KeyEventHandler? _listaKeyHandler;
        private EventHandler? _listaLostFocusHandler;
        private bool _evitarReentrada = false;
        private Action<int>? _callbackSeleccionActual;

        // Datos del usuario logueado tomados de la sesión central
        private readonly string _dniUsuarioSesion;
        private readonly Usuario? _usuarioSesion;

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
            _dniUsuarioSesion = _usuarioSesion?.Dni ?? "41234567";

            ConfigurarControles();
        }

        private void ConfigurarControles()
        {
            ListaDetalleVenta.View = View.Details;
            ListaDetalleVenta.FullRowSelect = true;
            ListaDetalleVenta.MultiSelect = false;
            ListaDetalleVenta.GridLines = true;

            // Métodos de pago disponibles
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
                    // Abre FormAltaEdicionClientes incrustado en el panel, pasándole el DNI
                    var formAlta = new RGTS.Interfaz.Administrador.FormAltaEdicionClientes(null, dni);

                    MostrarSubVentana(formAlta, () =>
                    {
                        // Al volver, se busca si se completó el registro
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

        private void LimpiarSeccionCliente()
        {
            _clienteSeleccionado = null;
            labelNombreValor.Text = "-";
            labelApellidoValor.Text = "-";
        }

       
        private void TxtBuscarProducto_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscarProducto_Click(sender, EventArgs.Empty);
                e.Handled = true;
                e.SuppressKeyPress = true;
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

        private void btnCancelarAgregado_Click(object? sender, EventArgs e)
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
                string metodoPago = comboBoxMetodoPago.SelectedItem?.ToString() ?? "Efectivo";

                // Registra la venta asociada al vendedor en sesión y su DNI
                Venta ventaRegistrada = _ventaServicio.RegistrarVenta(
                    _dniUsuarioSesion,
                    _clienteSeleccionado,
                    _carrito,
                    metodoPago,
                    _usuarioSesion
                );

                string nombreCliente = ventaRegistrada.Cliente != null
                    ? $"{ventaRegistrada.Cliente.Nombre} {ventaRegistrada.Cliente.Apellido}"
                    : "Consumidor Final";

                MessageBox.Show(
                    $"Venta N°: {ventaRegistrada.IdVenta:D5} confirmada exitosamente\n\n" +
                    $"- Vendedor (DNI): {ventaRegistrada.DniUsuario}\n" +
                    $"- Cliente: {nombreCliente}\n" +
                    $"- Método: {metodoPago}\n" +
                    $"- Total: {ventaRegistrada.TotalDerivado:C2}",
                    "Venta Exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                DialogResult respuesta = MessageBox.Show(
                    "¿Quiere generar el comprobante en formato PDF?",
                    "Emitir Factura PDF",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (respuesta == DialogResult.Yes)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    {
                        sfd.Filter = "Archivos PDF (*.pdf)|*.pdf";
                        sfd.FileName = $"Factura_Venta_{ventaRegistrada.IdVenta:D5}.pdf";

                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            var pdfService = new PdfFacturaServicio();
                            pdfService.GenerarFactura(ventaRegistrada, sfd.FileName);

                            // Abre el PDF generado con el visor predeterminado del sistema
                            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                            {
                                FileName = sfd.FileName,
                                UseShellExecute = true
                            });
                        }
                    }
                }

                // limpia la ventana
                _carrito.Clear();
                txtBuscarDniCliente.Clear();
                LimpiarSeccionCliente();
                LimpiarSeccionProducto();
                ActualizarCarrito();

                // Regresa al listado principal de ventas actualizado
                FormPrincipal.InstanciaActual?.AbrirFormularioEnPanel(new FormListadoVentas());
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
                    "¿Desea cancelar la venta en curso? también se vaciará el carrito",
                    "Cancelar Venta",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2
                );

                if (rta != DialogResult.Yes) return;
                _ventaServicio.CancelarReservasCarrito(_carrito); 
            }

            FormPrincipal.InstanciaActual?.AbrirFormularioEnPanel(new FormListadoVentas());
        }


        private void TxtBuscarDniCliente_TextChanged(object? sender, EventArgs e)
        {
            if (_evitarReentrada) return;

            string texto = txtBuscarDniCliente.Text.Trim();
            if (string.IsNullOrWhiteSpace(texto))
            {
                OcultarSugerenciasFlotantes();
                return;
            }

            var coincidencias = _clienteServicio.ObtenerTodos(texto).Where(c => c.Estado).ToList();
            var textos = coincidencias.Select(c => $"{c.Nombre} {c.Apellido} - DNI {c.DNI}").ToList();

            MostrarSugerencias(txtBuscarDniCliente, textos, indice =>
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
                OcultarSugerenciasFlotantes();
                return;
            }

            var coincidencias = _ventaServicio.BuscarCoincidenciasProducto(texto);
            var textos = coincidencias.Select(p => $"{p.Nombre} ({p.Codigo}) - {p.Precio:C2}").ToList();

            MostrarSugerencias(txtBuscarProducto, textos, indice =>
            {
                var seleccionado = coincidencias[indice];
                _evitarReentrada = true;
                txtBuscarProducto.Text = seleccionado.Codigo;
                _evitarReentrada = false;

                btnBuscarProducto_Click(this, EventArgs.Empty);
            });
        }

        private void MostrarSugerencias(MaterialTextBox2 buscador, List<string> itemsCoincidentes, Action<int> alSeleccionarItem)
        {
            if (itemsCoincidentes == null || itemsCoincidentes.Count == 0 || string.IsNullOrWhiteSpace(buscador.Text))
            {
                OcultarSugerenciasFlotantes();
                return;
            }

            _callbackSeleccionActual = alSeleccionarItem;

            if (_listaSugerencias == null)
            {
                _listaSugerencias = new ListBox
                {
                    BorderStyle = BorderStyle.None,
                    Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point),
                    BackColor = Color.FromArgb(242, 242, 242),
                    ForeColor = Color.FromArgb(33, 33, 33),
                    SelectionMode = SelectionMode.One,
                    IntegralHeight = false,
                    TabStop = false
                };

                _listaClickHandler = (s, e) =>
                {
                    if (_listaSugerencias?.SelectedIndex >= 0)
                    {
                        _callbackSeleccionActual?.Invoke(_listaSugerencias.SelectedIndex);
                        OcultarSugerenciasFlotantes();
                    }
                };

                _listaKeyHandler = (s, ke) =>
                {
                    if (_listaSugerencias == null) return;
                    if (ke.KeyCode == Keys.Down)
                    {
                        if (_listaSugerencias.SelectedIndex < _listaSugerencias.Items.Count - 1)
                            _listaSugerencias.SelectedIndex++;
                        ke.Handled = true;
                    }
                    else if (ke.KeyCode == Keys.Up)
                    {
                        if (_listaSugerencias.SelectedIndex > 0)
                            _listaSugerencias.SelectedIndex--;
                        ke.Handled = true;
                    }
                    else if (ke.KeyCode == Keys.Enter)
                    {
                        if (_listaSugerencias.SelectedIndex >= 0)
                        {
                            _callbackSeleccionActual?.Invoke(_listaSugerencias.SelectedIndex);
                            OcultarSugerenciasFlotantes();
                        }
                        ke.Handled = true;
                    }
                    else if (ke.KeyCode == Keys.Escape)
                    {
                        OcultarSugerenciasFlotantes();
                        ke.Handled = true;
                    }
                };

                _listaLostFocusHandler = (s, e) =>
                {
                    OcultarSugerenciasFlotantes();
                };
            }

            _listaSugerencias.Items.Clear();
            _listaSugerencias.Items.AddRange(itemsCoincidentes.ToArray());

            Control parent = buscador.Parent ?? this;
            if (_listaSugerencias.Parent != parent)
            {
                _listaSugerencias.Parent?.Controls.Remove(_listaSugerencias);
                parent.Controls.Add(_listaSugerencias);
            }

            var screenPt = buscador.PointToScreen(Point.Empty);
            var clientPt = parent.PointToClient(screenPt);
            _listaSugerencias.Location = new Point(clientPt.X, clientPt.Y + buscador.Height);

            int altoFila = 26;
            _listaSugerencias.Height = Math.Min(itemsCoincidentes.Count, 3) * altoFila + 2;
            _listaSugerencias.Width = buscador.Width;

            try { if (_listaClickHandler != null) _listaSugerencias.Click -= _listaClickHandler; } catch { }
            try { if (_listaKeyHandler != null) _listaSugerencias.KeyDown -= _listaKeyHandler; } catch { }
            try { if (_listaLostFocusHandler != null) _listaSugerencias.LostFocus -= _listaLostFocusHandler; } catch { }

            if (_listaClickHandler != null) _listaSugerencias.Click += _listaClickHandler;
            if (_listaKeyHandler != null) _listaSugerencias.KeyDown += _listaKeyHandler;
            if (_listaLostFocusHandler != null) _listaSugerencias.LostFocus += _listaLostFocusHandler;

            _listaSugerencias.BringToFront();
            _listaSugerencias.Visible = true;
        }

        private void OcultarSugerenciasFlotantes()
        {
            if (_listaSugerencias != null)
            {
                try
                {
                    _listaSugerencias.Visible = false;
                    _listaSugerencias.Items.Clear();
                    if (_listaKeyHandler != null) _listaSugerencias.KeyDown -= _listaKeyHandler;
                    if (_listaClickHandler != null) _listaSugerencias.Click -= _listaClickHandler;
                    if (_listaLostFocusHandler != null) _listaSugerencias.LostFocus -= _listaLostFocusHandler;
                }
                catch { }
            }
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
    }
}