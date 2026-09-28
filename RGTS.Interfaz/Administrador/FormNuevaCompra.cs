using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin.Controls;
using RGTS.Entidades;
using RGTS.LogicaNegocio.Servicios;

namespace RGTS.Interfaz.Administrador
{
    public partial class FormNuevaCompra : MaterialForm
    {
        private readonly CompraServicio _compraServicio;
        private readonly ProductoServicio _productoServicio;
        private readonly ProveedorServicio _proveedorServicio;
        private readonly BuscadorSugerencias _buscadorProveedor;
        private readonly BuscadorSugerencias _buscadorProducto;

        private Proveedor? _proveedorSeleccionado;
        private readonly List<DetalleCompra> _detalle = new();
        private int _correlativoDetalle = 1;

        public FormNuevaCompra()
        {
            InitializeComponent();

            _compraServicio = new CompraServicio();
            _productoServicio = new ProductoServicio();
            _proveedorServicio = new ProveedorServicio();

            _buscadorProveedor = new BuscadorSugerencias(this);
            _buscadorProducto = new BuscadorSugerencias(this);

            TxtBuscarProveedor.TextChanged += TxtBuscarProveedor_TextChanged;
            TxtBuscarCoN.TextChanged += TxtBuscarCoN_TextChanged;
        }

        private void FormNuevaCompra_Load(object sender, EventArgs e)
        {
            lstClientes.View = View.Details;
            lstClientes.FullRowSelect = true;
            lstClientes.MultiSelect = false;
            lstClientes.GridLines = true;

            ActualizarGrillaDetalle();
        }

        private void TxtBuscarProveedor_TextChanged(object? sender, EventArgs e)
        {
            string texto = TxtBuscarProveedor.Text.Trim();
            if (string.IsNullOrWhiteSpace(texto))
            {
                _proveedorSeleccionado = null;
                _buscadorProveedor.Ocultar();
                return;
            }

            var coincidencias = _proveedorServicio.ObtenerTodos(texto)
                .Where(p => p.Activo)
                .ToList();

            var textos = coincidencias.Select(p => p.NombreComercial).ToList();

            _buscadorProveedor.Mostrar(TxtBuscarProveedor, textos, indice =>
            {
                _proveedorSeleccionado = coincidencias[indice];
                TxtBuscarProveedor.Text = coincidencias[indice].NombreComercial;
            });
        }

        private void TxtBuscarCoN_TextChanged(object? sender, EventArgs e)
        {
            string texto = TxtBuscarCoN.Text.Trim();
            if (string.IsNullOrWhiteSpace(texto))
            {
                _buscadorProducto.Ocultar();
                return;
            }

            var coincidencias = _productoServicio.ObtenerTodos(texto);
            var textos = coincidencias.Select(p => $"{p.Nombre} ({p.Codigo})").ToList();

            _buscadorProducto.Mostrar(TxtBuscarCoN, textos, indice =>
            {
                TxtBuscarCoN.Text = coincidencias[indice].Codigo;
            });
        }

        private void BtnRecibido_Click(object sender, EventArgs e)
        {
            try
            {
                if (_proveedorSeleccionado == null)
                    throw new ArgumentException("Debe seleccionar un proveedor válido.");

                string busqueda = TxtBuscarCoN.Text.Trim();
                if (!decimal.TryParse(TxtCostoUni.Text.Trim(), out decimal costoUnitario))
                    throw new ArgumentException("Ingrese un costo unitario válido.");

                if (!int.TryParse(TxtCantidad.Text.Trim(), out int cantidad))
                    throw new ArgumentException("Ingrese una cantidad numérica válida.");

                Producto? producto = _productoServicio.ObtenerTodos(busqueda)
                    .FirstOrDefault(p => p.Codigo.Equals(busqueda, StringComparison.OrdinalIgnoreCase) ||
                                         p.Nombre.Contains(busqueda, StringComparison.OrdinalIgnoreCase));

                if (producto == null)
                    throw new ArgumentException("No se encontró ningún producto con ese código o nombre.");

                var nuevoItem = _compraServicio.ValidarYArmarItem(
                    _proveedorSeleccionado.IdProveedor, producto, busqueda, costoUnitario, cantidad, _correlativoDetalle);

                var existente = _detalle.FirstOrDefault(d => d.IdProducto == producto.IdProducto);
                if (existente != null)
                {
                    existente.Cantidad += cantidad;
                    existente.CostoUnitario = costoUnitario;
                }
                else
                {
                    _detalle.Add(nuevoItem);
                    _correlativoDetalle++;
                }

                ActualizarGrillaDetalle();
                LimpiarCamposProducto();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarGrillaDetalle()
        {
            lstClientes.BeginUpdate();
            lstClientes.Items.Clear();
            decimal total = 0;

            foreach (var item in _detalle)
            {
                var row = new ListViewItem(item.IdDetalleCompra.ToString());
                row.SubItems.Add(item.NombreProducto);
                row.SubItems.Add(item.Cantidad.ToString());
                row.SubItems.Add(item.CostoUnitario.ToString("C2"));
                row.SubItems.Add(item.Subtotal.ToString("C2"));
                row.Tag = item;
                lstClientes.Items.Add(row);

                total += item.Subtotal;
            }

            lstClientes.EndUpdate();
            LTotal.Text = $"Total: {total:C2}";
        }

        private void LimpiarCamposProducto()
        {
            TxtBuscarCoN.Clear();
            TxtCostoUni.Clear();
            TxtCantidad.Clear();
        }

        private void BtnRegistrarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                if (_proveedorSeleccionado == null)
                    throw new ArgumentException("Debe seleccionar un proveedor.");

                string usuario = FormPrincipal.UsuarioSesion?.NombreCompleto ?? "Encargado Depósito";
                _compraServicio.RegistrarCompra(usuario, _proveedorSeleccionado, _detalle);

                MessageBox.Show("Orden de compra registrada correctamente en estado Pendiente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormPrincipal.InstanciaActual?.AbrirFormularioEnPanel(new FormListadoCompras());
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelarCompra_Click(object sender, EventArgs e)
        {
            if (_detalle.Count > 0)
            {
                var rta = MessageBox.Show(
                    "¿Desea cancelar el registro de la orden? Se perderán los artículos cargados.",
                    "Cancelar Orden",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2
                );

                if (rta != DialogResult.Yes) return;
            }

            FormPrincipal.InstanciaActual?.AbrirFormularioEnPanel(new FormListadoCompras());
        }
    }
}