using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MaterialSkin.Controls;
using RGTS.Entidades;
using RGTS.LogicaNegocio.Servicios;

namespace RGTS.Interfaz
{   
    public partial class FormProductos : MaterialForm
    {
        private readonly ProductoServicio _productoServicio;

        // Lista de categorías hardcodeadas para esta entrega
        private readonly List<Categoria> _categorias = new List<Categoria>
        {
            new Categoria { IdCategoria = 1, NombreCategoria = "Consolas" },
            new Categoria { IdCategoria = 2, NombreCategoria = "Mandos" },
            new Categoria { IdCategoria = 3, NombreCategoria = "Portátiles" },
            new Categoria { IdCategoria = 4, NombreCategoria = "Accesorios" }
        };

        public FormProductos()
        {
            InitializeComponent();
            _productoServicio = new ProductoServicio();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            CargarComboCategoria();
            CargarGrilla();
        }

        // Carga el combo con "Todas las categorías" como primer ítem y las categorías hardcodeadas
        private void CargarComboCategoria()
        {
            CmbFiltroCat.Items.Clear();
            CmbFiltroCat.Items.Add("Todas las categorías");

            foreach (var cat in _categorias)
                CmbFiltroCat.Items.Add(cat.NombreCategoria);

            // Selecciona "Todas las categorías" por defecto
            CmbFiltroCat.SelectedIndex = 0;
        }

        // Carga la grilla con todos los productos o con los filtros aplicados
        private void CargarGrilla(string texto = "", int idCategoria = 0)
        {
            try
            {
                List<Producto> productos;

                if (string.IsNullOrWhiteSpace(texto) && idCategoria == 0)
                    productos = _productoServicio.ListarProductos();
                else
                    productos = _productoServicio.ListarPorFiltro(texto, idCategoria);

                LstProductos.Items.Clear();

                foreach (var p in productos)
                {
                    var item = new ListViewItem(p.Codigo);
                    item.SubItems.Add(p.Nombre);
                    item.SubItems.Add(p.NombreCategoria);
                    item.SubItems.Add(p.Precio.ToString("C"));
                    item.SubItems.Add(p.StockActual.ToString());
                    item.SubItems.Add(p.Activo ? "Activo" : "Inactivo");
                    item.Tag = p; // guardamos el objeto completo para usarlo en Editar/Eliminar
                    LstProductos.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al comunicarse con el servidor: {ex.Message}",
                    "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Filtra al presionar Enter en el buscador
        private void TxtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AplicarFiltro();
        }

        // Filtra al cambiar la categoría en el combo
        private void CmbFiltroCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        // Aplica el filtro de texto y categoría combinados
        private void AplicarFiltro()
        {
            string texto = TxtBuscar.Text.Trim();

            // índice 0 = "Todas las categorías" = sin filtro
            int idCategoria = 0;
            if (CmbFiltroCat.SelectedIndex > 0)
                idCategoria = _categorias[CmbFiltroCat.SelectedIndex - 1].IdCategoria;

            CargarGrilla(texto, idCategoria);
        }

        // Abre el formulario de alta de producto
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            var form = new FormProductoAltaEdicion(_categorias);
            form.ShowDialog();
            CargarGrilla(); // recarga la grilla al cerrar
        }

        // Abre el formulario de edición con los datos del producto seleccionado
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if(LstProductos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccioná un producto para editar.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Producto? seleccionado = LstProductos.SelectedItems[0].Tag as Producto;
            if (seleccionado == null) return;
            var form = new FormProductoAltaEdicion(_categorias, seleccionado);
            form.ShowDialog();
            CargarGrilla(); // recarga la grilla al cerrar
        }

        // Realiza la baja lógica del producto seleccionado
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (LstProductos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccioná un producto para eliminar.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Producto? seleccionado = LstProductos.SelectedItems[0].Tag as Producto;
            if (seleccionado == null) return;
            var confirmacion = MessageBox.Show(
                $"¿Estás seguro de que querés eliminar el producto '{seleccionado.Nombre}'?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    _productoServicio.EliminarProducto(seleccionado.IdProducto);
                    MessageBox.Show("Producto eliminado correctamente.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrilla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al comunicarse con el servidor: {ex.Message}",
                        "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Abre el formulario de gestión de categorías
        private void BtnGestionarCat_Click(object sender, EventArgs e)
        {
            // Por implementar en próxima entrega
            MessageBox.Show("Funcionalidad disponible en la próxima entrega.",
                "En desarrollo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}