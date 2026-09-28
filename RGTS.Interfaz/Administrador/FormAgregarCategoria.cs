using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using RGTS.Entidades;
using RGTS.LogicaNegocio.Servicios;

namespace RGTS.Interfaz.Administrador
{
    public partial class FormAgregarCategoria : MaterialForm
    {
        private readonly CategoriaServicio _categoriaServicio;
        private readonly Categoria? _categoriaEditar;

        public FormAgregarCategoria(Categoria? categoriaEditar = null)
        {
            InitializeComponent();
            Sizable = false;
            FormStyle = FormStyles.StatusAndActionBar_None;
            _categoriaServicio = new CategoriaServicio();
            _categoriaEditar = categoriaEditar;
            ConfigurarModo();
        }

        private void ConfigurarModo()
        {
            labelTitulo.Text = _categoriaEditar == null ? "Agregar Categoría" : "Editar Categoría";
        }

        private void FormAgregarCategoria_Load(object sender, EventArgs e)
        {
            if (_categoriaEditar != null)
            {
                txtNombre.Text = _categoriaEditar.NombreCategoria;
                MltDescripcion.Text = _categoriaEditar.Descripcion;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_categoriaEditar == null)
                {
                    _categoriaServicio.RegistrarCategoria(txtNombre.Text, MltDescripcion.Text);
                    MessageBox.Show("Categoría registrada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _categoriaServicio.ModificarCategoria(_categoriaEditar.IdCategoria, txtNombre.Text, MltDescripcion.Text);
                    MessageBox.Show("Categoría modificada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Close(); // Dispara FormClosed en el listado y refresca automáticamente
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Datos Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}