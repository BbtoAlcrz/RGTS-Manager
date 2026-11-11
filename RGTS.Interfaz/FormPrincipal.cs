using MaterialSkin;
using MaterialSkin.Controls;
using RGTS.AccesoDatos;
using RGTS.Entidades;
using RGTS.Interfaz.Administrador;
using RGTS.Interfaz.EncargadoDeposito;
using RGTS.Interfaz.Vendedor;
using RGTS.LogicaNegocio.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static RGTS.LogicaNegocio.Servicios.UsuarioServicio;

namespace RGTS.Interfaz
{
    public partial class FormPrincipal : MaterialForm
    {
        // esto mantiene la información de login del usuario y el nombre de su rol en toda la aplicación
        private readonly UsuarioServicio _usuarioServicio = new UsuarioServicio();
        public static Usuario? UsuarioSesion { get; private set; }
        public static string? RolSesion { get; private set; }
        public static FormPrincipal? InstanciaActual { get; private set; }
        private Form? _formularioActivo = null;
        private readonly ManualUsuarioServicio _manualUsuarioServicio;

        public FormPrincipal()
        {
            InitializeComponent();

            _manualUsuarioServicio = new ManualUsuarioServicio();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            InstanciaActual = this;
        }

        public FormPrincipal(Usuario usuario) : this()
        {
            UsuarioSesion = usuario;
            RolSesion = UsuarioSesion.Rol?.NombreRol;

            // cambia el nombre y el rol dependiendo del usuario de la sesion
            labelBienvenida.Text = _usuarioServicio.ObtenerSaludoBienvenida(UsuarioSesion);

            LabelNombreUsuario.Text = UsuarioSesion.NombreCompleto;
            LabelRolUsuario.Text = RolSesion;

            ConfigurarNavegacionPorRol(RolSesion);
        }


        // la lógica de preparación e incrustación
        public void AbrirFormularioEnPanel(Form formularioHijo)
        {
            if (_formularioActivo != null)
            {
                // si el formulario que se intenta abrir ya está activo, no hace nada
                if (_formularioActivo.GetType() == formularioHijo.GetType())
                {
                    return;
                }

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

        // Sobrecarga que evita instanciar new T() si ya esta abierto y delega al metodo principal
        private void AbrirFormularioEnPanel<T>() where T : Form, new()
        {
            if (_formularioActivo != null && _formularioActivo.GetType() == typeof(T))
            {
                return;
            }

            AbrirFormularioEnPanel(new T());
        }


        // configura la navegacion de los botones del menu para sus formularios por rol
        private void ConfigurarNavegacionPorRol(string? rolActual)
        {
            OcultarTodosLosBotones();

            // Obtiene los modulos que el rol actual tiene permitido ver y habilita sus botones
            var modulosPermitidos = _usuarioServicio.ObtenerModulosPermitidos(rolActual);

            BotonModuloUsuarios.Visible = modulosPermitidos.Contains(ModuloSistema.Usuarios);
            BotonModuloProductos.Visible = modulosPermitidos.Contains(ModuloSistema.Productos);
            BotonModuloProveedores.Visible = modulosPermitidos.Contains(ModuloSistema.Proveedores);
            BotonModuloClientes.Visible = modulosPermitidos.Contains(ModuloSistema.Clientes);
            BotonModuloVentas.Visible = modulosPermitidos.Contains(ModuloSistema.Ventas);
            BotonModuloCompras.Visible = modulosPermitidos.Contains(ModuloSistema.Compras);
            BotonModuloReportes.Visible = modulosPermitidos.Contains(ModuloSistema.Reportes);
            BotonModuloRespaldo.Visible = modulosPermitidos.Contains(ModuloSistema.Respaldo);

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


        private void BotonAyuda_Click(object? sender, EventArgs e)
        {
            // Obtiene la vista alojada en el contenedor del FormPrincipal
            Control? vistaActiva = PanelContenedorVistas.Controls.Count > 0
                ? PanelContenedorVistas.Controls[0]
                : null;

            try
            {
                // Se realiza la apertura del PDF
                _manualUsuarioServicio.AbrirManualPorVistaActiva(vistaActiva);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Manual de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static void CerrarSesion()
        {
            UsuarioSesion = null;
            RolSesion = null;

            if (InstanciaActual != null)
            {
                var formPrincipal = InstanciaActual;
                InstanciaActual = null; // Se setea en null para que FormClosed no ejecute Environment.Exit
                formPrincipal._formularioActivo?.Close();
                formPrincipal.Hide();
                formPrincipal.Dispose();
            }

            // Instancia y apertura del Login
            FormIniciarSesion formLogin = new FormIniciarSesion();
            formLogin.Show();
        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Si la InstanciaActual NO era null, significa que el usuario apretó la 'X' para salir
            if (InstanciaActual != null)
            {
                InstanciaActual = null;
                UsuarioSesion = null;
                RolSesion = null;

                Environment.Exit(0);
            }
        }

        private void BotonModuloUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FormListadoUsuarios>();
        }

        private void BotonModuloProductos_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FormListadoProductos>();
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

        private void BotonModuloReportes_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FormReportes>();
        }
        private void BotonModuloRespaldo_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FormRespaldo>();
        }
        private void BotonCerrarSesion_Click(object sender, EventArgs e)
        {
            // Muestra la ventana emergente con botones de Sí y No, y un ícono de pregunta.
            // "Cerrar Sesión" en esta versión cierra directamente el programa completo
            // (no vuelve al login): decisión tomada para evitar los problemas de
            // relogin en caliente con MaterialSkin,
            DialogResult resultado = MessageBox.Show(
                "¿Seguro que desea cerrar Sesión?",
                "Confirmar Cierre de sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2 // Deja el foco por defecto en la opción NO por seguridad
            );

            if (resultado == DialogResult.Yes)
            {
                CerrarSesion();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Cierra el módulo abierto para que libere lo pendiente (ej: reservas de una venta sin confirmar)
            _formularioActivo?.Close();
            base.OnFormClosing(e);
        }

    }
}