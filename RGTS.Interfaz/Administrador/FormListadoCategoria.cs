using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin.Controls;
using RGTS.Entidades;

namespace RGTS.Interfaz.Administrador
{
    public partial class FormListadoCategoria : MaterialForm
    {
        private readonly Panel pnlEdicionContenedor = new();

        // Lista hardcodeada para esta entrega
        private List<Categoria> _categorias = new List<Categoria>
        {
            new Categoria { IdCategoria = 1, NombreCategoria = "Consolas",  Descripcion = "Consolas de videojuegos", Activo = true },
            new Categoria { IdCategoria = 2, NombreCategoria = "Mandos",    Descripcion = "Mandos y controles", Activo = true },
            new Categoria { IdCategoria = 3, NombreCategoria = "Portátiles", Descripcion = "Consolas portátiles", Activo = true },
            new Categoria { IdCategoria = 4, NombreCategoria = "Accesorios", Descripcion = "Accesorios varios", Activo = true }
        };

        public FormListadoCategoria()
        {
            InitializeComponent();
            pnlEdicionContenedor.Dock = DockStyle.Fill;
            pnlEdicionContenedor.Visible = false;
            Controls.Add(pnlEdicionContenedor);
            pnlEdicionContenedor.BringToFront();

            TxtBuscarNombre.TextChanged += TxtBuscarNombre_TextChanged;
            lstClientes.SelectedIndexChanged += LstClientes_SelectedIndexChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        // Carga la grilla, opcionalmente filtrada por nombre
        private void CargarGrilla(string filtroNombre = "")
        {
            lstClientes.Items.Clear();

            var filtradas = string.IsNullOrWhiteSpace(filtroNombre)
                ? _categorias
                : _categorias.Where(c => c.NombreCategoria.Contains(filtroNombre, StringComparison.OrdinalIgnoreCase)).ToList();

            foreach (var cat in filtradas)
            {
                var item = new ListViewItem(cat.IdCategoria.ToString());
                item.SubItems.Add(cat.NombreCategoria);
                item.SubItems.Add(cat.Descripcion);
                item.SubItems.Add(cat.Activo ? "Activo" : "Inactivo");
                item.Tag = cat;
                lstClientes.Items.Add(item);
            }

            BtnCambiarEstado.Text = "Estado";
        }

        // Filtra la grilla mientras se escribe
        private void TxtBuscarNombre_TextChanged(object? sender, EventArgs e)
        {
            CargarGrilla(TxtBuscarNombre.Text.Trim());
        }

        // Actualiza el texto del botón según el estado de la categoría seleccionada
        private void LstClientes_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (lstClientes.SelectedItems.Count == 0)
            {
                BtnCambiarEstado.Text = "Estado";
                return;
            }

            var seleccionada = lstClientes.SelectedItems[0].Tag as Categoria;
            if (seleccionada == null) return;

            BtnCambiarEstado.Text = seleccionada.Activo ? "Deshabilitar" : "Habilitar";
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
            MostrarSubVentana(new FormAgregarCategoria());
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (lstClientes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccioná una categoría para editar.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Categoria? seleccionada = lstClientes.SelectedItems[0].Tag as Categoria;
            if (seleccionada == null) return;

            MostrarSubVentana(new FormAgregarCategoria(seleccionada));
        }

        // Toggle: alterna el estado activo/inactivo de la categoría seleccionada
        private void BtnCambiarEstado_Click(object sender, EventArgs e)
        {
            if (lstClientes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccioná una categoría para cambiar su estado.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var seleccionada = lstClientes.SelectedItems[0].Tag as Categoria;
            if (seleccionada == null) return;
            bool nuevoEstado = !seleccionada.Activo;
            string accion = nuevoEstado ? "Habilita" : "Deshabilita";

            DialogResult confirmacion = MessageBox.Show(
                $"¿Estás seguro de que querés {accion.ToLower()}r la categoría '{seleccionada.NombreCategoria}'?",
                $"Confirmar {accion}do",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
            );

            if (confirmacion == DialogResult.Yes)
            {
                seleccionada.Activo = nuevoEstado;
                MessageBox.Show($"Categoría {(nuevoEstado ? "habilitada" : "deshabilitada")} correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla(TxtBuscarNombre.Text.Trim());
            }
        }
    }
}