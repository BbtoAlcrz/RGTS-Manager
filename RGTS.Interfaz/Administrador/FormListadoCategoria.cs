using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MaterialSkin.Controls;
using RGTS.Entidades;
using RGTS.LogicaNegocio.Servicios;

namespace RGTS.Interfaz.Administrador
{
    public partial class FormListadoCategoria : MaterialForm
    {
        private readonly CategoriaServicio _categoriaServicio;
        private readonly Panel pnlEdicionContenedor = new();

        public FormListadoCategoria()
        {
            InitializeComponent();
            _categoriaServicio = new CategoriaServicio();

            pnlEdicionContenedor.Dock = DockStyle.Fill;
            pnlEdicionContenedor.Visible = false;
            Controls.Add(pnlEdicionContenedor);
            pnlEdicionContenedor.BringToFront();

            TxtBuscarNombre.TextChanged += TxtBuscarNombre_TextChanged;
            lstClientes.SelectedIndexChanged += LstClientes_SelectedIndexChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConfigurarListView();
            CargarGrilla();
        }

        private void ConfigurarListView()
        {
            lstClientes.View = View.Details;
            lstClientes.FullRowSelect = true;
            lstClientes.MultiSelect = false;
            lstClientes.GridLines = true;
        }

        // Carga la grilla delegando la obtención y el filtro en CategoriaServicio
        private void CargarGrilla(string filtroNombre = "")
        {
            lstClientes.BeginUpdate();
            lstClientes.Items.Clear();

            // Bloquear botones dependientes de fila hasta que haya selección
            BtnEditar.Enabled = false;
            BtnCambiarEstado.Enabled = false;
            BtnCambiarEstado.Text = "Deshabilitar";

            List<Categoria> categorias = _categoriaServicio.ObtenerTodas(filtroNombre);

            foreach (var cat in categorias)
            {
                var item = new ListViewItem(cat.IdCategoria.ToString());
                item.SubItems.Add(cat.NombreCategoria);
                item.SubItems.Add(cat.Descripcion);
                item.SubItems.Add(cat.Activo ? "Habilitado" : "Deshabilitado");
                item.Tag = cat;
                lstClientes.Items.Add(item);
            }

            lstClientes.EndUpdate();
        }

        // Filtra la grilla mientras se escribe
        private void TxtBuscarNombre_TextChanged(object? sender, EventArgs e)
        {
            CargarGrilla(TxtBuscarNombre.Text.Trim());
        }

        // Habilita botones y actualiza el texto según el estado de la selección
        private void LstClientes_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (lstClientes.SelectedItems.Count > 0)
            {
                var seleccionada = (Categoria)lstClientes.SelectedItems[0].Tag;

                BtnEditar.Enabled = true;
                BtnCambiarEstado.Enabled = true;
                BtnCambiarEstado.Text = seleccionada.Activo ? "Deshabilitar" : "Habilitar";
            }
            else
            {
                BtnEditar.Enabled = false;
                BtnCambiarEstado.Enabled = false;
                BtnCambiarEstado.Text = "Deshabilitar";
            }
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
                CargarGrilla(TxtBuscarNombre.Text.Trim());
            };
            pnlEdicionContenedor.Controls.Add(subFormulario);
            pnlEdicionContenedor.Visible = true;
            pnlEdicionContenedor.BringToFront();
            subFormulario.Show();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            MostrarSubVentana(new FormAltaEdicionCategoria());
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (lstClientes.SelectedItems.Count == 0) return;

            var seleccionada = (Categoria)lstClientes.SelectedItems[0].Tag;
            MostrarSubVentana(new FormAltaEdicionCategoria(seleccionada));
        }

        // Alterna el estado activo/inactivo a través de CategoriaServicio
        private void BtnCambiarEstado_Click(object sender, EventArgs e)
        {
            if (lstClientes.SelectedItems.Count == 0) return;

            var seleccionada = (Categoria)lstClientes.SelectedItems[0].Tag;
            bool nuevoEstado = !seleccionada.Activo;
            string accion = nuevoEstado ? "Habilita" : "Deshabilita";

            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro de que desea {accion.ToLower()}r la categoría '{seleccionada.NombreCategoria}'?",
                $"Confirmar {accion}",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            );

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    _categoriaServicio.CambiarEstadoCategoria(seleccionada.IdCategoria, nuevoEstado);
                    MessageBox.Show($"Categoría {accion.ToLower()}da correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    CargarGrilla(TxtBuscarNombre.Text.Trim());
                }
            }
        }
    }
}