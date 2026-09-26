using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RGTS.Interfaz
{
    // Componente reutilizable: ListBox flotante de sugerencias (máx. 3 filas visibles, con scroll)
    // que se posiciona debajo de un control de búsqueda. Se instancia una vez por campo.
    public class BuscadorSugerencias
    {
        private readonly ListBox _lista;
        private Action<int>? _callbackActual;

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
            _lista.LostFocus += (s, e) => Ocultar();

            formularioContenedor.Controls.Add(_lista);
        }

        // Muestra las coincidencias debajo del control de búsqueda indicado
        public void Mostrar(Control controlBusqueda, List<string> items, Action<int> alSeleccionar)
        {
            if (items == null || items.Count == 0)
            {
                Ocultar();
                return;
            }

            _callbackActual = alSeleccionar;

            _lista.Items.Clear();
            _lista.Items.AddRange(items.ToArray());

            Control parent = _lista.Parent!;
            var screenPt = controlBusqueda.PointToScreen(Point.Empty);
            var clientPt = parent.PointToClient(screenPt);
            _lista.Location = new Point(clientPt.X, clientPt.Y + controlBusqueda.Height);

            int altoFila = 22;
            _lista.Height = Math.Min(items.Count, 3) * altoFila + 4;
            _lista.Width = controlBusqueda.Width;

            _lista.BringToFront();
            _lista.Visible = true;
        }

        public void Ocultar()
        {
            _lista.Visible = false;
            _lista.Items.Clear();
        }

        private void SeleccionarActual()
        {
            if (_lista.SelectedIndex >= 0)
            {
                _callbackActual?.Invoke(_lista.SelectedIndex);
                Ocultar();
            }
        }

        private void Lista_KeyDown(object? sender, KeyEventArgs ke)
        {
            if (ke.KeyCode == Keys.Down)
            {
                if (_lista.SelectedIndex < _lista.Items.Count - 1) _lista.SelectedIndex++;
                ke.Handled = true;
            }
            else if (ke.KeyCode == Keys.Up)
            {
                if (_lista.SelectedIndex > 0) _lista.SelectedIndex--;
                ke.Handled = true;
            }
            else if (ke.KeyCode == Keys.Enter)
            {
                SeleccionarActual();
                ke.Handled = true;
            }
            else if (ke.KeyCode == Keys.Escape)
            {
                Ocultar();
                ke.Handled = true;
            }
        }
    }
}