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
        private ListBox? _listaSugerencias;
        private EventHandler? _listaClickHandler;
        private KeyEventHandler? _listaKeyHandler;
        private EventHandler? _listaLostFocusHandler;
        private bool _evitarReentrada = false;
        private Action<int>? _callbackSeleccionActual;



        // DNI de vendedor simulado (luego se pasa UsuarioSesion.Dni)
        private readonly string _dniUsuarioSesion = "41234567";

        public FormNuevaVenta()
        {
            InitializeComponent();
            _clienteServicio = new ClienteServicio();
            _ventaServicio = new VentaServicio();
            ConfigurarControles();
            txtBuscarDniCliente.TextChanged += TxtBuscarDniCliente_TextChanged;
            txtBuscarProducto.TextChanged += TxtBuscarProducto_TextChanged;
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

        private void MostrarSugerencias(MaterialTextBox2 buscador, List<string> itemsCoincidentes, Action<int> alSeleccionarItem)
        {
            // Si no hay texto o no hay coincidencias en los servicios, ocultamos la lista inmediatamente
            if (itemsCoincidentes == null || itemsCoincidentes.Count == 0 || string.IsNullOrWhiteSpace(buscador.Text))
            {
                OcultarSugerenciasFlotantes();
                return;
            }

            // Actualizamos el callback vigente en CADA llamada, sin importar si el ListBox ya existía
            _callbackSeleccionActual = alSeleccionarItem;

            // Si todavía no se creó el contenedor de coincidencias, lo instanciamos y estilizamos
            if (_listaSugerencias == null)
            {
                _listaSugerencias = new ListBox
                {
                    BorderStyle = BorderStyle.None,                // Sin bordes toscos de Windows antiguo
                    Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point),
                    BackColor = Color.FromArgb(242, 242, 242),   // Gris claro sutil integrado a MaterialSkin
                    ForeColor = Color.FromArgb(33, 33, 33),       // Alta legibilidad para el texto
                    SelectionMode = SelectionMode.One,
                    IntegralHeight = false,
                    TabStop = false
                };

                // Los handlers ahora leen SIEMPRE _callbackSeleccionActual, nunca un parámetro capturado
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


            // Limpiamos los resultados de la búsqueda anterior e inyectamos las nuevas coincidencias
            _listaSugerencias.Items.Clear();
            _listaSugerencias.Items.AddRange(itemsCoincidentes.ToArray());

            // Asegurar que la lista está en el mismo contenedor que el buscador
            Control parent = buscador.Parent ?? this;
            if (_listaSugerencias.Parent != parent)
            {
                _listaSugerencias.Parent?.Controls.Remove(_listaSugerencias);
                parent.Controls.Add(_listaSugerencias);
            }

            // Posicionar correctamente transformando coordenadas
            var screenPt = buscador.PointToScreen(Point.Empty);
            var clientPt = parent.PointToClient(screenPt);
            _listaSugerencias.Location = new Point(clientPt.X, clientPt.Y + buscador.Height);

            // Configuración de altura dinámica: tope de 3 filas visibles con scroll automático de ser necesario
            int altoFila = 26;
            _listaSugerencias.Height = Math.Min(itemsCoincidentes.Count, 3) * altoFila + 2;
            _listaSugerencias.Width = buscador.Width;

            // Suscribir handlers (aseguramos no duplicar suscripciones)
            try { if (_listaClickHandler != null) _listaSugerencias.Click -= _listaClickHandler; } catch { }
            try { if (_listaKeyHandler != null) _listaSugerencias.KeyDown -= _listaKeyHandler; } catch { }
            try { if (_listaLostFocusHandler != null) _listaSugerencias.LostFocus -= _listaLostFocusHandler; } catch { }

            if (_listaClickHandler != null) _listaSugerencias.Click += _listaClickHandler;
            if (_listaKeyHandler != null) _listaSugerencias.KeyDown += _listaKeyHandler;
            if (_listaLostFocusHandler != null) _listaSugerencias.LostFocus += _listaLostFocusHandler;

            // Forzamos que se dibuje por encima de cualquier otro control o panel del diseño
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

        // Muestra sugerencias de clientes activos que coincidan por DNI, nombre o apellido
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

                // Reutiliza la lógica ya existente de carga de datos del cliente
                BtnBuscarDniCliente_Click(this, EventArgs.Empty);
            });
        }

        // Muestra sugerencias de productos activos que coincidan por código o nombre
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

                // Reutiliza la lógica ya existente de carga de datos y stock del producto
                btnBuscarProducto_Click(this, EventArgs.Empty);
            });
        }
    }
}