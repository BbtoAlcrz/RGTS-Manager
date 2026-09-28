using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MaterialSkin.Controls;
using RGTS.Entidades;
using RGTS.Interfaz.Administrador;
using RGTS.LogicaNegocio.Servicios;

namespace RGTS.Interfaz
{
    public partial class FormListadoProductos : MaterialForm
    {
        private readonly ProductoServicio _productoServicio;
        private readonly Panel pnlEdicionContenedor = new();

        // MOVER A CATEGORIAS SERVICIO
        private readonly List<Categoria> _categorias = new List<Categoria>
        {
            new Categoria { IdCategoria = 1, NombreCategoria = "Consolas" },
            new Categoria { IdCategoria = 2, NombreCategoria = "Mandos" },
            new Categoria { IdCategoria = 3, NombreCategoria = "Portátiles" },
            new Categoria { IdCategoria = 4, NombreCategoria = "Accesorios" }
        };

        public FormListadoProductos()
        {
            InitializeComponent();
            _productoServicio = new ProductoServicio();

            pnlEdicionContenedor.Dock = DockStyle.Fill;
            pnlEdicionContenedor.Visible = false;
            Controls.Add(pnlEdicionContenedor);
            pnlEdicionContenedor.BringToFront();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            ConfigurarListView();
            CargarComboCategoria();
            ConfigurarPermisosPorRol();
            RefrescarGrilla();
        }

        private void ConfigurarListView()
        {
            LstProductos.View = View.Details;
            LstProductos.FullRowSelect = true;
            LstProductos.MultiSelect = false;
            LstProductos.GridLines = true;
        }

        // Carga el combo con "Todas las categorías" como primer ítem y las categorías hardcodeadas
        private void CargarComboCategoria()
        {
            CmbFiltroCat.SelectedIndexChanged -= CmbFiltroCat_SelectedIndexChanged;

            CmbFiltroCat.Items.Clear();
            CmbFiltroCat.Items.Add("Todas las categorías");

            foreach (var cat in _categorias)
                CmbFiltroCat.Items.Add(cat.NombreCategoria);

            CmbFiltroCat.SelectedIndex = 0;
            CmbFiltroCat.SelectedIndexChanged += CmbFiltroCat_SelectedIndexChanged;
        }

        private int ObtenerIdCategoriaSeleccionada()
        {
            if (CmbFiltroCat.SelectedIndex > 0 && (CmbFiltroCat.SelectedIndex - 1) < _categorias.Count)
            {
                return _categorias[CmbFiltroCat.SelectedIndex - 1].IdCategoria;
            }
            return 0;
        }


        // Carga la grilla con todos los productos o con los filtros aplicados
        private void RefrescarGrilla()
        {
            LstProductos.BeginUpdate();
            LstProductos.Items.Clear();

            // Resetear botones y etiquetas por defecto
            BtnEditar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnEliminar.Text = "Deshabilitar";

            string filtroTexto = TxtBuscar.Text;
            int idCategoria = ObtenerIdCategoriaSeleccionada();

            List<Producto> productos = _productoServicio.ObtenerTodos(filtroTexto, idCategoria);

            foreach (var p in productos)
            {
                var item = new ListViewItem(p.Codigo);
                item.SubItems.Add(p.Nombre);
                item.SubItems.Add(p.NombreCategoria);
                item.SubItems.Add(p.Precio.ToString("C2"));
                item.SubItems.Add(p.StockActual.ToString());
                item.SubItems.Add(p.Activo ? "Habilitado" : "Deshabilitado");
                item.Tag = p;

                LstProductos.Items.Add(item);
            }

            LstProductos.EndUpdate();
        }

        // Vendedor solo puede ver y buscar productos; Administrador y Encargado de Depósito
        // pueden gestionarlos por completo (alta, edición, habilitar/deshabilitar)
        private void ConfigurarPermisosPorRol()
        {
            bool puedeGestionar = FormPrincipal.RolSesion == "Administrador"
                                || FormPrincipal.RolSesion == "Encargado de Deposito";

            BtnNuevo.Visible = puedeGestionar;
            BtnEditar.Visible = puedeGestionar;
            BtnEliminar.Visible = puedeGestionar;
            BtnGestionarCat.Visible = puedeGestionar;
        }

        // Filtra al escribir en el buscador
        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            RefrescarGrilla();
        }

        // Filtra al cambiar la categoría en el combo
        private void CmbFiltroCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefrescarGrilla();
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
                RefrescarGrilla();
            };
            pnlEdicionContenedor.Controls.Add(subFormulario);
            pnlEdicionContenedor.Visible = true;
            pnlEdicionContenedor.BringToFront();
            subFormulario.Show();
        }

        // Abre el formulario de alta de producto
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            MostrarSubVentana(new FormAltaEdicionProducto(_categorias));
        }

        // Abre el formulario de edición con los datos del producto seleccionado
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (LstProductos.SelectedItems.Count == 0) return;

            var producto = (Producto)LstProductos.SelectedItems[0].Tag;
            MostrarSubVentana(new FormAltaEdicionProducto(_categorias, producto));
        }

        // Alterna el estado del producto seleccionado: Habilitar si está inactivo, Deshabilitar si está activo
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (LstProductos.SelectedItems.Count == 0) return;

            var producto = (Producto)LstProductos.SelectedItems[0].Tag;

            bool nuevoEstado = !producto.Activo;
            string accion = nuevoEstado ? "Habilita" : "Deshabilita";

            // Confirmación con foco predeterminado en 'No'
            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro de que desea {accion.ToLower()}r el siguiente producto?\n\n" +
                $"Código: {producto.Codigo}\n" +
                $"Nombre: {producto.Nombre}\n",
                $"Confirmar {accion}do",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            );

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    _productoServicio.CambiarEstadoProducto(producto.IdProducto, nuevoEstado);

                    MessageBox.Show($"Producto {accion.ToLower()}do correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar estado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    RefrescarGrilla();
                }
            }
        }

        // Abre el formulario de gestión de categorías
        private void BtnGestionarCat_Click(object sender, EventArgs e)
        {
            MostrarSubVentana(new FormListadoCategoria());
        }


        // Actualiza el texto del botón según el estado del producto seleccionado
        private void LstProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstProductos.SelectedItems.Count > 0)
            {
                var producto = (Producto)LstProductos.SelectedItems[0].Tag;

                BtnEditar.Enabled = true;
                BtnEliminar.Enabled = true;
                BtnEliminar.Text = producto.Activo ? "Deshabilitar" : "Habilitar";
            }
            else
            {
                BtnEditar.Enabled = false;
                BtnEliminar.Enabled = false;
                BtnEliminar.Text = "Deshabilitar";
            }
        }

        
    }
}