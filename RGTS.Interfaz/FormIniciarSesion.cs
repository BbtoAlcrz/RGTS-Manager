using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using RGTS.Entidades;
using RGTS.LogicaNegocio.Servicios;
namespace RGTS.Interfaz
{
    public partial class FormIniciarSesion : MaterialForm
    {
        private readonly AutenticacionServicio _autenticacionServicio;

        public FormIniciarSesion()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Indigo500,      // morado/azul principal
                Primary.Indigo700,      // versión oscura (para header/toolbar)
                Primary.Grey100,        // versión clara (fondo)
                Accent.LightGreen100,   // acento verde lima
                TextShade.WHITE
            );

            _autenticacionServicio = new AutenticacionServicio();
        }

        private void BIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                // Reemplaza txtEmail y txtContrasena por los nombres de tus campos de texto
                string email = TextboxEmail.Text;
                string contrasena = TextboxContraseña.Text;

                // Llamamos a la lógica de negocio
                Usuario usuarioAutenticado = _autenticacionServicio.IniciarSesion(email, contrasena);

                // Si no arrojó excepciones, las credenciales son válidas
                MessageBox.Show(
                    $"¡Bienvenido, {usuarioAutenticado.NombreCompleto}!\nRol: {usuarioAutenticado.Rol?.NombreRol}",
                    "Inicio de Sesión Exitoso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Ocultamos el login
                this.Hide();

                // Abrimos el formulario principal pasándole el usuario logueado
                FormPrincipal formPrincipal = new FormPrincipal(usuarioAutenticado);

                // Si cierran el FormPrincipal, se cierra la aplicación por completo
                formPrincipal.FormClosed += (s, args) => this.Close();
                formPrincipal.Show();
            }
            catch (ArgumentException ex)
            {
                // Validaciones de campos vacíos
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (UnauthorizedAccessException ex)
            {
                // Error de credenciales o usuario inactivo
                MessageBox.Show(ex.Message, "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Errores no controlados o de conexión SQL (RNF#11)
                MessageBox.Show($"Ocurrió un error al comunicarse con el servidor: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    } 
}
