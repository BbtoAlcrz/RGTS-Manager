using MaterialSkin;

namespace RGTS.Interfaz
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Configurar MaterialSkin globalmente para toda la aplicación
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Indigo500,      // morado/azul principal
                Primary.Indigo700,      // versión oscura (para header/toolbar)
                Primary.Grey100,        // versión clara (fondo)
                Accent.LightGreen700,   // acento verde lima
                TextShade.WHITE
            );

            Application.Run(new FormIniciarSesion());
        }
    }
}