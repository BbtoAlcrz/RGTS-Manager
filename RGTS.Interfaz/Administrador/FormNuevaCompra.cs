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
        private readonly BuscadorSugerencias _buscadorProveedor;
        private readonly BuscadorSugerencias _buscadorProducto;
        private Proveedor? _proveedorSeleccionado;

        private readonly List<Proveedor> _proveedores = new List<Proveedor>
        {
            new Proveedor { IdProveedor = 1, NombreComercial = "TechImport SA" },
            new Proveedor { IdProveedor = 2, NombreComercial = "Gamer Distribuidora" },
            new Proveedor { IdProveedor = 3, NombreComercial = "ElectroSur" }
        };

        private readonly List<Producto> _productos = new List<Producto>
        {
            new Producto { IdProducto = 1, Codigo = "CONS-001", Nombre = "PlayStation 5" },
            new Producto { IdProducto = 2, Codigo = "MAN-001",  Nombre = "Joystick DualSense" },
            new Producto { IdProducto = 3, Codigo = "PORT-001", Nombre = "Nintendo Switch OLED" }
        };

        private readonly List<DetalleCompra> _detalle = new List<DetalleCompra>();
        private int _correlativoDetalle = 1;

        public FormNuevaCompra()
        {
            InitializeComponent();
            Sizable = false;
            FormStyle = FormStyles.StatusAndActionBar_None;
            _compraServicio = new CompraServicio();

            _buscadorProveedor = new BuscadorSugerencias(this);
            _buscadorProducto = new BuscadorSugerencias(this);

            TxtBuscarProveedor.TextChanged += TxtBuscarProveedor_TextChanged;
            TxtBuscarCoN.TextChanged += TxtBuscarCoN_TextChanged;
        }

        private void FormNuevaCompra_Load(object sender, EventArgs e)
        {

            //  el proveedor se elige escribiendo en TxtBuscarProveedor con autocompletado
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

            var coincidencias = _proveedores
                .Where(p => p.NombreComercial.Contains(texto, StringComparison.OrdinalIgnoreCase))
                .ToList();

            var textos = coincidencias.Select(p => p.NombreComercial).ToList();

            _buscadorProveedor.Mostrar(TxtBuscarProveedor, textos, indice =>
            {
                _proveedorSeleccionado = coincidencias[indice];
                TxtBuscarProveedor.Text = coincidencias[indice].NombreComercial;
            });
        }

        // Muestra sugerencias de producto mientras se escribe (sin filtrar por proveedor todavía:
        // esa relación no existe en el modelo actual de Proveedor/Producto)
        private void TxtBuscarCoN_TextChanged(object? sender, EventArgs e)
        {
            string texto = TxtBuscarCoN.Text.Trim();
            if (string.IsNullOrWhiteSpace(texto))
            {
                _buscadorProducto.Ocultar();
                return;
            }

            var coincidencias = _productos
                .Where(p => p.Codigo.Contains(texto, StringComparison.OrdinalIgnoreCase)
                         || p.Nombre.Contains(texto, StringComparison.OrdinalIgnoreCase))
                .ToList();

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
                    throw new ArgumentException("Debe seleccionar un proveedor.");

                string busqueda = TxtBuscarCoN.Text.Trim();
                decimal.TryParse(TxtCostoUni.Text.Trim(), out decimal costoUnitario);
                int.TryParse(TxtCantidad.Text.Trim(), out int cantidad);

                Producto? producto = _productos.FirstOrDefault(p =>
                  p.Codigo.Equals(busqueda, StringComparison.OrdinalIgnoreCase) ||
                  p.Nombre.Contains(busqueda, StringComparison.OrdinalIgnoreCase));

                if (producto == null)
                    throw new ArgumentException("No se encontró ningún producto con ese código o nombre.");

                // El servicio valida y arma el ítem
                var nuevoItem = _compraServicio.ValidarYArmarItem(
                    _proveedorSeleccionado.IdProveedor, producto, busqueda, costoUnitario, cantidad, _correlativoDetalle);

                // Evita duplicar el mismo producto en el detalle; si ya está, acumula la cantidad
                var existente = _detalle.FirstOrDefault(d => d.IdProducto == producto.IdProducto);
                if (existente != null)
                {
                    existente.Cantidad += cantidad;
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
        }

        private void ActualizarGrillaDetalle()
        {
            lstClientes.Items.Clear();
            decimal total = 0;

            foreach (var item in _detalle)
            {
                var row = new ListViewItem(item.IdDetalleCompra.ToString());
                row.SubItems.Add(item.NombreProducto);
                row.SubItems.Add(item.Cantidad.ToString());
                row.SubItems.Add(item.CostoUnitario.ToString("C"));
                row.SubItems.Add(item.Subtotal.ToString("C"));
                row.Tag = item;
                lstClientes.Items.Add(row);

                total += item.Subtotal;
            }

            LTotal.Text = $"Total {total:C}";
        }

        private void LimpiarCamposProducto()
        {
            TxtBuscarCoN.Text = "";
            TxtCostoUni.Text = "";
            TxtCantidad.Text = "";
        }

        private void BtnRegistrarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                if (_proveedorSeleccionado == null)
                    throw new ArgumentException("Debe seleccionar un proveedor.");

                _compraServicio.ValidarRegistro(_proveedorSeleccionado.IdProveedor, _detalle.Count);

                MessageBox.Show("Orden de compra registrada correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCancelarCompra_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}