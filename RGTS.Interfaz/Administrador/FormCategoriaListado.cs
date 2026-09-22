using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MaterialSkin.Controls;
using RGTS.Entidades;

namespace RGTS.Interfaz.Administrador
{
    public partial class FormCategoriaListado : MaterialForm
    {
        private readonly Panel pnlEdicionContenedor = new();
        // Lista hardcodeada para esta entrega
        private List<Categoria> _categorias = new List<Categoria>
        {
            new Categoria { IdCategoria = 1, NombreCategoria = "Consolas",  Descripcion = "Consolas de videojuegos" },
            new Categoria { IdCategoria = 2, NombreCategoria = "Mandos",    Descripcion = "Mandos y controles" },
            new Categoria { IdCategoria = 3, NombreCategoria = "Portátiles", Descripcion = "Consolas portátiles" },
            new Categoria { IdCategoria = 4, NombreCategoria = "Accesorios", Descripcion = "Accesorios varios" }
        };

        public FormCategoriaListado()
        {
            InitializeComponent();
            pnlEdicionContenedor.Dock = DockStyle.Fill;
            pnlEdicionContenedor.Visible = false;
            Controls.Add(pnlEdicionContenedor);
            pnlEdicionContenedor.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            lstClientes.Items.Clear();

            foreach (var cat in _categorias)
            {
                var item = new ListViewItem(cat.IdCategoria.ToString());
                item.SubItems.Add(cat.NombreCategoria);
                item.SubItems.Add(cat.Descripcion);
                item.SubItems.Add("Activo"); // hardcodeado para esta entrega
                item.Tag = cat;
                lstClientes.Items.Add(item);
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
                CargarGrilla();
            };
            pnlEdicionContenedor.Controls.Add(subFormulario);
            pnlEdicionContenedor.Visible = true;
            pnlEdicionContenedor.BringToFront();
            subFormulario.Show();
        }

        // Abre el formulario para agregar una nueva categoría
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            MostrarSubVentana(new FormAgregarCategoria());
        }

        // Abre el formulario para editar la categoría seleccionada
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

        // Baja lógica: marca la categoría como inactiva
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstClientes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccioná una categoría para dar de baja.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Categoria? seleccionada = lstClientes.SelectedItems[0].Tag as Categoria;
            if (seleccionada == null) return;

            var confirmacion = MessageBox.Show(
                $"¿Estás seguro de que querés dar de baja la categoría '{seleccionada.NombreCategoria}'?",
                "Confirmar baja", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                MessageBox.Show("Categoría dada de baja correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla();
            }
        }

        // Dar de alta una categoría dada de baja
        private void BtnAlta_Click(object sender, EventArgs e)
        {
            if (lstClientes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccioná una categoría para dar de alta.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Categoría dada de alta correctamente.",
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarGrilla();
        }
    }
}