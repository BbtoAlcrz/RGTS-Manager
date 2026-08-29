using MaterialSkin;

namespace RGTS.Interfaz
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
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
        }
    }
}
