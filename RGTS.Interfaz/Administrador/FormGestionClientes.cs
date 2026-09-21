using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin.Controls;
using RGTS.Entidades;
using RGTS.Interfaz.Administrador;

namespace RGTS.Interfaz
{
    public partial class FormGestionClientes : MaterialForm
    {
        // Clientes hardcodeados para esta entrega
        private readonly List<Cliente> _clientes = new List<Cliente>
        {
            new Cliente { IdCliente = 1, Nombre = "Juan", Apellido = "Pérez", DNI = "30111222", Telefono = "3624123456", Email = "juan.perez@mail.com", Estado = true },
            new Cliente { IdCliente = 2, Nombre = "María", Apellido = "Gómez", DNI = "28555666", Telefono = "3624987654", Email = "maria.gomez@mail.com", Estado = true },
            new Cliente { IdCliente = 3, Nombre = "Carlos", Apellido = "Ruiz", DNI = "35999888", Telefono = "", Email = "", Estado = false }
        };

        public FormGestionClientes()
        {
            InitializeComponent();
        }

        private void AdminGestionCliente_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        // Carga la grilla, opcionalmente filtrada por DNI
        private void CargarGrilla(string filtroDni = "")
        {
            lstClientes.Items.Clear();

            var filtrados = string.IsNullOrWhiteSpace(filtroDni)
                ? _clientes
                : _clientes.Where(c => c.DNI.Contains(filtroDni.Trim())).ToList();

            foreach (var c in filtrados)
            {
                var item = new ListViewItem(c.IdCliente.ToString());
                item.SubItems.Add(c.DNI);
                item.SubItems.Add(c.Apellido);
                item.SubItems.Add(c.Nombre);
                item.SubItems.Add(c.Telefono);
                item.SubItems.Add(c.Email);
                item.SubItems.Add(c.Estado ? "Activo" : "Inactivo");
                item.Tag = c;
                lstClientes.Items.Add(item);
            }
        }

        // Filtra por DNI a medida que se escribe
        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla(TxtBuscar.Text);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            var form = new FormClientesAltaEdicion();
            form.ShowDialog();
            CargarGrilla();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Cliente? seleccionado = ObtenerClienteSeleccionado();
            if (seleccionado == null) return;

            var form = new FormClientesAltaEdicion(seleccionado);
            form.ShowDialog();
            CargarGrilla();
        }

        // Baja lógica: marca el cliente como inactivo
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente? seleccionado = ObtenerClienteSeleccionado();
            if (seleccionado == null) return;

            if (!seleccionado.Estado)
            {
                MessageBox.Show("El cliente ya se encuentra inactivo.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show(
                $"¿Estás seguro de que querés dar de baja a '{seleccionado.Nombre} {seleccionado.Apellido}'?",
                "Confirmar baja", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                seleccionado.Estado = false;
                MessageBox.Show("Cliente dado de baja correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla();
            }
        }

        // Alta: reactiva un cliente inactivo
        private void BtnAlta_Click(object sender, EventArgs e)
        {
            Cliente? seleccionado = ObtenerClienteSeleccionado();
            if (seleccionado == null) return;

            if (seleccionado.Estado)
            {
                MessageBox.Show("El cliente ya se encuentra activo.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            seleccionado.Estado = true;
            MessageBox.Show("Cliente dado de alta correctamente.",
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarGrilla();
        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Sin lógica adicional por ahora
        }

        private Cliente? ObtenerClienteSeleccionado()
        {
            if (lstClientes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccioná un cliente.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            return lstClientes.SelectedItems[0].Tag as Cliente;
        }
    }
}