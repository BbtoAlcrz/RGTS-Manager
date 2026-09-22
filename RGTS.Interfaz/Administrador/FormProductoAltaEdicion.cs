using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MaterialSkin.Controls;
using RGTS.Entidades;
using RGTS.LogicaNegocio.Servicios;

namespace RGTS.Interfaz
{
    public partial class FormProductoAltaEdicion : MaterialForm
    {
        private readonly ProductoServicio _productoServicio;
        private readonly List<Categoria> _categorias;
        private readonly Producto? _productoEditar;

        // si productoEditar es null => modo alta, si tiene datos => modo edición
        public FormProductoAltaEdicion(List<Categoria> categorias, Producto? productoEditar = null)
        {
            InitializeComponent();
            Sizable = false;
            FormStyle = FormStyles.StatusAndActionBar_None;
            _productoServicio = new ProductoServicio();
            _categorias = categorias;
            _productoEditar = productoEditar;
            ConfigurarModo();
        }

        private void ConfigurarModo()
        {
            Text = _productoEditar == null ? "Agregar Producto" : "Editar Producto";
            labelTitulo.Text = Text.ToUpperInvariant();
        }

        private void FormProductoAltaEdicion_Load(object sender, EventArgs e)
        {
            CargarComboCategoria();

            if (_productoEditar != null)
            {
                // Modo edición: carga los datos del producto seleccionado
                TxtCodigo.Text = _productoEditar.Codigo;
                TxtNombre.Text = _productoEditar.Nombre;
                MltDescripcion.Text = _productoEditar.Descripcion;
                TxtPrecio.Text = _productoEditar.Precio.ToString();
                TxtExistenciasA.Text = _productoEditar.StockActual.ToString();
                TxtExistenciasMax.Text = _productoEditar.StockMaximo.ToString();
                TxtExistenciasMin.Text = _productoEditar.StockMinimo.ToString();

                // Selecciona la categoría correspondiente en el combo
                for (int i = 0; i < _categorias.Count; i++)
                {
                    if (_categorias[i].IdCategoria == _productoEditar.IdCategoria)
                    {
                        CbCategoria.SelectedIndex = i;
                        break;
                    }
                }
            }
            else
            {
                // Modo alta: formulario vacío
            }
        }

        // Carga el combo con las categorías recibidas desde FormProductos
        private void CargarComboCategoria()
        {
            CbCategoria.Items.Clear();
            foreach (var cat in _categorias)
                CbCategoria.Items.Add(cat.NombreCategoria);

            if (CbCategoria.Items.Count > 0)
                CbCategoria.SelectedIndex = 0;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtiene el idCategoria según lo seleccionado en el combo
                int idCategoria = _categorias[CbCategoria.SelectedIndex].IdCategoria;

                // Parsea los campos numéricos
                if (!decimal.TryParse(TxtPrecio.Text.Trim(), out decimal precio))
                    throw new ArgumentException("El precio debe ser un valor numérico válido.");

                if (!int.TryParse(TxtExistenciasA.Text.Trim(), out int stockActual))
                    throw new ArgumentException("Las existencias actuales deben ser un número entero.");

                if (!int.TryParse(TxtExistenciasMax.Text.Trim(), out int stockMaximo))
                    throw new ArgumentException("Las existencias máximas deben ser un número entero.");

                if (!int.TryParse(TxtExistenciasMin.Text.Trim(), out int stockMinimo))
                    throw new ArgumentException("Las existencias mínimas deben ser un número entero.");

                if (_productoEditar == null)
                {
                    // Modo alta
                    _productoServicio.RegistrarProducto(
                        TxtCodigo.Text.Trim(),
                        TxtNombre.Text.Trim(),
                        MltDescripcion.Text.Trim(),
                        idCategoria,
                        precio,
                        stockActual,
                        stockMinimo,
                        stockMaximo
                    );
                    MessageBox.Show("Producto registrado correctamente.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Modo edición
                    _productoServicio.ModificarProducto(
                        _productoEditar.IdProducto,
                        TxtCodigo.Text.Trim(),
                        TxtNombre.Text.Trim(),
                        MltDescripcion.Text.Trim(),
                        idCategoria,
                        precio,
                        stockActual,
                        stockMinimo,
                        stockMaximo
                    );
                    MessageBox.Show("Producto modificado correctamente.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al comunicarse con el servidor: {ex.Message}",
                    "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}