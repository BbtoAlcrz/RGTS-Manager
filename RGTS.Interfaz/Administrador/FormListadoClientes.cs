using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MaterialSkin.Controls;
using RGTS.Entidades;
using RGTS.Interfaz.Administrador;
using RGTS.LogicaNegocio.Servicios;

namespace RGTS.Interfaz
{
    public partial class FormListadoClientes : MaterialForm
    {
        private readonly ClienteServicio _clienteServicio;
        private readonly Panel pnlEdicionContenedor = new();

        public FormListadoClientes()
        {
            InitializeComponent();
            _clienteServicio = new ClienteServicio();

            pnlEdicionContenedor.Dock = DockStyle.Fill;
            pnlEdicionContenedor.Visible = false;
            Controls.Add(pnlEdicionContenedor);
            pnlEdicionContenedor.BringToFront();
        }

        private void FormListadoClientes_Load(object sender, EventArgs e)
        {
            ConfigurarListView();
            RefrescarGrilla();
        }

        //hace que se pueda sseleccionar una sola fila basicamente
        private void ConfigurarListView()
        {
            lstClientes.View = View.Details;
            lstClientes.FullRowSelect = true;
            lstClientes.MultiSelect = false;
            lstClientes.GridLines = true;
        }

        // Carga la grilla delegando la obtención y el filtro en ClienteServicio
        private void RefrescarGrilla(string filtro = "")
        {
            lstClientes.BeginUpdate();
            lstClientes.Items.Clear();

            //Deshabilita los botones siempre por defecto
            btnEditar.Enabled = false;
            btnCambiarEstado.Enabled = false;
            btnCambiarEstado.Text = "Deshabilitar";


            List<Cliente> clientes = _clienteServicio.ObtenerTodos(filtro);

            foreach (var c in clientes)
            {
                var item = new ListViewItem(c.IdCliente.ToString());
                item.SubItems.Add(c.DNI);
                item.SubItems.Add(c.Apellido);
                item.SubItems.Add(c.Nombre);
                item.SubItems.Add(c.Telefono ?? string.Empty);
                item.SubItems.Add(c.Email ?? string.Empty);
                item.SubItems.Add(c.Estado ? "Activo" : "Inactivo");
                item.Tag = c;

                lstClientes.Items.Add(item);
            }

            lstClientes.EndUpdate();
        }

        // Filtro de busqueda en tiempo real al escribir
        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            RefrescarGrilla(TxtBuscar.Text);
        }


        // maneja dinamicamente al boton según el estado del item seleccionado
        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstClientes.SelectedItems.Count > 0)
            {
                var cliente = (Cliente)lstClientes.SelectedItems[0].Tag;

                btnEditar.Enabled = true;
                btnCambiarEstado.Enabled = true;

                // Si está activo (true) ofrece deshabilitarlo; si está inactivo ofrece habilitarlo
                btnCambiarEstado.Text = cliente.Estado ? "Deshabilitar" : "Habilitar";
            }
            else
            {
                btnEditar.Enabled = false;
                btnCambiarEstado.Enabled = false;
                btnCambiarEstado.Text = "Deshabilitar";
            }
        }


        // Baja lógica
        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            if (lstClientes.SelectedItems.Count == 0) return;

            var cliente = (Cliente)lstClientes.SelectedItems[0].Tag;

            bool nuevoEstado = !cliente.Estado;
            string accion = nuevoEstado ? "Habilita" : "Deshabilita";

            // Confirmación con foco predeterminado en 'No'
            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro de que desea {accion.ToLower()}r al siguiente cliente?\n\n" +
                $" DNI: {cliente.DNI}\n" +
                $" Nombre: {cliente.Nombre} {cliente.Apellido}\n",
                $"Confirmar {accion}do",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            );

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    _clienteServicio.CambiarEstadoCliente(cliente.IdCliente, nuevoEstado);

                    MessageBox.Show($"Cliente {accion.ToLower()}do correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar estado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    RefrescarGrilla(TxtBuscar.Text);
                }
            }
        }



        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            MostrarSubVentana(new FormAltaEdicionClientes());
        }


        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (lstClientes.SelectedItems.Count == 0) return;

            var clienteSeleccionado = (Cliente)lstClientes.SelectedItems[0].Tag;
            MostrarSubVentana(new FormAltaEdicionClientes(clienteSeleccionado));
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
                RefrescarGrilla(TxtBuscar.Text);
            };
            pnlEdicionContenedor.Controls.Add(subFormulario);
            pnlEdicionContenedor.Visible = true;
            pnlEdicionContenedor.BringToFront();
            subFormulario.Show();
        }
    }
}