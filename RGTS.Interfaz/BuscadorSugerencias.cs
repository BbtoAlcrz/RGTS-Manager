using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RGTS.Interfaz
{
    // Componente reutilizable: ListBox flotante de sugerencias
    public class BuscadorSugerencias
    {
        private readonly ListBox _lista;
        private Action<int>? _callbackActual;
        private Control? _controlBusquedaActual;

        public BuscadorSugerencias(Control formularioContenedor)
        {
            _lista = new ListBox
            {
                BorderStyle = BorderStyle.None,
                Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point),
                BackColor = Color.FromArgb(242, 242, 242),
                ForeColor = Color.FromArgb(33, 33, 33),
                SelectionMode = SelectionMode.One,
                IntegralHeight = false,
                TabStop = false,
                Visible = false
            };

            _lista.Click += (s, e) => SeleccionarActual();
            _lista.KeyDown += Lista_KeyDown;
            _lista.LostFocus += Lista_LostFocus;

            formularioContenedor.Controls.Add(_lista);
        }

        public bool EsVisible => _lista.Visible;

        public void Mostrar(Control controlBusqueda, List<string> items, Action<int> alSeleccionar)
        {
            if (items == null || items.Count == 0)
            {
                Ocultar();
                return;
            }

            _controlBusquedaActual = controlBusqueda;
            _callbackActual = alSeleccionar;

            _lista.Items.Clear();
            _lista.Items.AddRange(items.ToArray());

            Control parent = _lista.Parent!;
            var screenPt = controlBusqueda.PointToScreen(Point.Empty);
            var clientPt = parent.PointToClient(screenPt);
            _lista.Location = new Point(clientPt.X, clientPt.Y + controlBusqueda.Height);

            int altoFila = 24;
            _lista.Height = Math.Min(items.Count, 3) * altoFila + 4;
            _lista.Width = controlBusqueda.Width;

            _lista.BringToFront();
            _lista.Visible = true;
        }

        public void Ocultar()
        {
            _lista.Visible = false;
            _lista.Items.Clear();
            _callbackActual = null;
        }

        // Permite interceptar la navegación desde el evento KeyDown / PreviewKeyDown del TextBox de búsqueda
        public bool ProcesarTeclaNavegacion(KeyEventArgs ke)
        {
            if (!EsVisible || _lista.Items.Count == 0) return false;

            if (ke.KeyCode == Keys.Down)
            {
                _lista.Focus();
                _lista.SelectedIndex = 0;
                ke.Handled = true;
                ke.SuppressKeyPress = true;
                return true;
            }
            else if (ke.KeyCode == Keys.Escape)
            {
                Ocultar();
                ke.Handled = true;
                ke.SuppressKeyPress = true;
                return true;
            }

            return false;
        }

        private void SeleccionarActual()
        {
            if (_lista.SelectedIndex >= 0)
            {
                int indice = _lista.SelectedIndex;
                var callback = _callbackActual;
                Ocultar();
                callback?.Invoke(indice);
            }
        }

        private void Lista_KeyDown(object? sender, KeyEventArgs ke)
        {
            if (ke.KeyCode == Keys.Down)
            {
                if (_lista.SelectedIndex < _lista.Items.Count - 1)
                    _lista.SelectedIndex++;
                ke.Handled = true;
            }
            else if (ke.KeyCode == Keys.Up)
            {
                if (_lista.SelectedIndex > 0)
                {
                    _lista.SelectedIndex--;
                }
                else if (_lista.SelectedIndex == 0 && _controlBusquedaActual != null)
                {
                    // Al subir desde el primer ítem, devuelve el foco al campo de búsqueda
                    _controlBusquedaActual.Focus();
                }
                ke.Handled = true;
            }
            else if (ke.KeyCode == Keys.Enter)
            {
                SeleccionarActual();
                ke.Handled = true;
                ke.SuppressKeyPress = true;
            }
            else if (ke.KeyCode == Keys.Escape)
            {
                Ocultar();
                _controlBusquedaActual?.Focus();
                ke.Handled = true;
                ke.SuppressKeyPress = true;
            }
        }

        private void Lista_LostFocus(object? sender, EventArgs e)
        {
            // Oculta la lista únicamente si el foco no volvió al campo de texto original
            if (_controlBusquedaActual != null && !_controlBusquedaActual.Focused)
            {
                Ocultar();
            }
        }
    }
}