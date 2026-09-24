using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using RGTS.Entidades;
using RGTS.Interfaz.Administrador;
using RGTS.Interfaz.EncargadoDeposito;
using RGTS.Interfaz.Vendedor;

namespace RGTS.Interfaz
{
    public partial class FormPrincipal : MaterialForm
    {
        // esto mantiene la información de login del usuario y el nombre de su rol en toda la aplicación
        public static Usuario? UsuarioSesion { get; private set; }
        public static string? RolSesion { get; private set; }

        public static FormPrincipal? InstanciaActual { get; private set; }
        private Form? _formularioActivo = null;

        public FormPrincipal()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            InstanciaActual = this;
        }

        public FormPrincipal(Usuario usuario) : this()
        {
            UsuarioSesion = usuario;
            RolSesion = UsuarioSesion.Rol?.NombreRol;

            // cambia el nombre y el rol dependiendo del usuario de la sesion
            LabelNombreUsuario.Text = UsuarioSesion.NombreCompleto;
            LabelRolUsuario.Text = RolSesion;

            ConfigurarNavegacionPorRol(RolSesion);
        }

        // generico para abrir cualquier formulario dentro del panel principal
        private void AbrirFormularioEnPanel<T>() where T : Form, new()
        {
            if (_formularioActivo != null && _formularioActivo.GetType() == typeof(T))
            {
                // el formulario ya está abierto
                return;
            }

            // cerrar el formulario si existe y esta activo
            if (_formularioActivo != null)
            {
                _formularioActivo.Close();
                _formularioActivo.Dispose();
                _formularioActivo.Controls.Clear();
            }

            // crear el nuevo formulario
            _formularioActivo = new T
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            // poner el panel creado en el panel principal
            PanelContenedorVistas.Controls.Add(_formularioActivo);
            PanelContenedorVistas.Tag = _formularioActivo;
            _formularioActivo.Show();
            _formularioActivo.BringToFront();
        }

        // sobrecarga para abrir un formulario ya instanciado desde afuera de esta clase
        public void AbrirFormularioEnPanel(Form formularioHijo)
        {
            if (_formularioActivo != null)
            {
                _formularioActivo.Close();
                _formularioActivo.Dispose();
                PanelContenedorVistas.Controls.Clear();
            }

            _formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;

            PanelContenedorVistas.Controls.Add(formularioHijo);
            PanelContenedorVistas.Tag = formularioHijo;
            formularioHijo.Show();
            formularioHijo.BringToFront();
        }

        // configura la navegacion de los botones del menu para sus formularios por rol
        private void ConfigurarNavegacionPorRol(string? rolActual)
        {
            rolActual = rolActual?.Trim();
            // ocultams todos los botones primero (para resetear el panel)
            OcultarTodosLosBotones();

            // definimos que botones le corresponden a cada rol (es ampliable)
            Button[] botonesPermitidos = rolActual switch
            {
                "Administrador" => new[]
                {
                    BotonModuloUsuarios,
                    BotonModuloProductos,
                    BotonModuloProveedores,
                    BotonModuloClientes,
                    BotonModuloVentas,
                    BotonModuloCompras
                },

                "Vendedor" => new[]
                {
                    BotonModuloVentas,
                    BotonModuloClientes,
                    BotonModuloProductos
                },

                "Encargado de Deposito" => new[]
                {
                    BotonModuloProveedores,
                    BotonModuloProductos,
                    BotonModuloCompras
                },

                // un Rol no reconocido, y por ende no muestra ningun boton
                _ => Array.Empty<Button>()
            };

            // hacemos visibles unicamente los asignados al rol
            foreach (Button boton in botonesPermitidos)
            {
                boton.Visible = true;
            }
            PanelBotones.PerformLayout();
            PanelBotones.Refresh();
        }

        private void OcultarTodosLosBotones()
        {
            // Todos los botones del panel lateral vuelven a false
            foreach (Control control in PanelBotones.Controls)
            {
                if (control is Button boton)
                {
                    boton.Visible = false;
                }
            }
        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Al cerrar el FormPrincipal (con la X de la ventana), cerramos toda la aplicación.
            // No hay relogin en caliente: para volver a entrar hay que reabrir el ejecutable.
            Environment.Exit(0);
        }

        private void BotonModuloUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FormListadoUsuarios>();
        }

        private void BotonModuloProductos_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FormProductos>();
        }

        private void BotonModuloClientes_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FormListadoClientes>();
        }

        private void BotonModuloProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FormListadoProveedores>();
        }

        private void BotonModuloCompras_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FormListadoCompras>();
        }
        private void BotonModuloVentas_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FormListadoVentas>();
        }

        private void BotonCerrarSesion_Click(object sender, EventArgs e)
        {
            // Muestra la ventana emergente con botones de Sí y No, y un ícono de pregunta.
            // "Cerrar Sesión" en esta versión cierra directamente el programa completo
            // (no vuelve al login): decisión tomada para evitar los problemas de
            // relogin en caliente con MaterialSkin, priorizando estabilidad para la entrega.
            DialogResult resultado = MessageBox.Show(
                "¿Seguro que desea cerrar el programa?",
                "Confirmar Cierre",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2 // Deja el foco por defecto en la opción NO por seguridad
            );

            if (resultado == DialogResult.Yes)
            {
                // Limpiar sesión activa antes de terminar el proceso
                UsuarioSesion = null;
                RolSesion = null;
                Environment.Exit(0);
            }
            // Si presiona "No", el bloque no se ejecuta y permanece en la pantalla actual
        }

    }
}