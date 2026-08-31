using MaterialSkin;

namespace RGTS.Interfaz
{
    public partial class Form2 : MaterialSkin.Controls.MaterialForm
    {
        public Form2()
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
            this.Shown += Form2_Shown;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void AjustarColumnas()
        {
            if (lstClientes == null)
                return;

            int colCount = lstClientes.Columns.Count;
            if (colCount == 0)
                return;

            // Ajusta cada columna según contenido si hay filas, o según el encabezado si está vacío
            for (int i = 0; i < colCount; i++)
            {
                var col = lstClientes.Columns[i];
                if (lstClientes.Items.Count > 0)
                    col.Width = -2; // ajusta al contenido
                else
                    col.Width = -1; // ajusta al encabezado
            }

            // Hacer que la última columna ocupe el espacio restante para evitar truncados
            int total = 0;
            for (int i = 0; i < colCount - 1; i++)
                total += lstClientes.Columns[i].Width;

            int remaining = lstClientes.ClientSize.Width - total - System.Windows.Forms.SystemInformation.VerticalScrollBarWidth;
            if (remaining > 50)
                lstClientes.Columns[colCount - 1].Width = remaining;
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            // Ajustar columnas al mostrar el formulario
            AjustarColumnas();
            // Reajustar cuando se cambie el tamaño del control
            lstClientes.Resize += (s, ev) => AjustarColumnas();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
