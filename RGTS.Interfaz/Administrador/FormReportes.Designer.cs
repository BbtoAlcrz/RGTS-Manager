namespace RGTS.Interfaz.Administrador
{
    partial class FormReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            BtnGenerarReporte = new MaterialSkin.Controls.MaterialButton();
            materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            ReporteVentas = new TabPage();
            CardVentas = new MaterialSkin.Controls.MaterialCard();
            CardGraficoVentas = new MaterialSkin.Controls.MaterialCard();
            chartVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            CardDatosVenta = new MaterialSkin.Controls.MaterialCard();
            LabelCategoriaMasVendidaValor = new MaterialSkin.Controls.MaterialLabel();
            LabelProductoMasVendidoValor = new MaterialSkin.Controls.MaterialLabel();
            LabelFechaVentasValor = new MaterialSkin.Controls.MaterialLabel();
            LabelMargenGanaciasValor = new MaterialSkin.Controls.MaterialLabel();
            LabelFacturaPromedioValor = new MaterialSkin.Controls.MaterialLabel();
            LabelTotalFacturadoValor = new MaterialSkin.Controls.MaterialLabel();
            LabelCantidadVentasValor = new MaterialSkin.Controls.MaterialLabel();
            LabelMargenGanaciasTitulo = new MaterialSkin.Controls.MaterialLabel();
            LabelCategoriaMasVendidaTitulo = new MaterialSkin.Controls.MaterialLabel();
            LabelFechaVentasTitulo = new MaterialSkin.Controls.MaterialLabel();
            LabelProductoMasVendidoTitulo = new MaterialSkin.Controls.MaterialLabel();
            LabelFacturaPromedioTitulo = new MaterialSkin.Controls.MaterialLabel();
            LabelCantidadVentasTitulo = new MaterialSkin.Controls.MaterialLabel();
            LabelTotalFacturadoTitulo = new MaterialSkin.Controls.MaterialLabel();
            LblRangoFechas = new MaterialSkin.Controls.MaterialLabel();
            ComboBoxVendedor = new MaterialSkin.Controls.MaterialComboBox();
            labelHasta = new MaterialSkin.Controls.MaterialLabel();
            labelDesde = new MaterialSkin.Controls.MaterialLabel();
            DtpDesde = new DateTimePicker();
            DtpHasta = new DateTimePicker();
            ReporteClientes = new TabPage();
            CardClientes = new MaterialSkin.Controls.MaterialCard();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            DtpDesdeClientes = new DateTimePicker();
            DtpHastaClientes = new DateTimePicker();
            txtBuscarDniCliente = new MaterialSkin.Controls.MaterialTextBox2();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            CardDatosClientes = new MaterialSkin.Controls.MaterialCard();
            LabelPromComprasClientesValor = new MaterialSkin.Controls.MaterialLabel();
            LabelPromComprasClientesTitulo = new MaterialSkin.Controls.MaterialLabel();
            LabelClienteEstrellaValor = new MaterialSkin.Controls.MaterialLabel();
            LabelClienteEstrellaTitulo = new MaterialSkin.Controls.MaterialLabel();
            LabelTotalClientesActivosValor = new MaterialSkin.Controls.MaterialLabel();
            LabelTotalClientesActivosTitulo = new MaterialSkin.Controls.MaterialLabel();
            ReporteProductos = new TabPage();
            BackupRestauracion = new TabPage();
            CardBackupRestauracion = new MaterialSkin.Controls.MaterialCard();
            BtnRestaurar = new MaterialSkin.Controls.MaterialButton();
            LabelDescRestauracion = new MaterialSkin.Controls.MaterialLabel();
            LabelTituloRestauracion = new MaterialSkin.Controls.MaterialLabel();
            BtnBackup = new MaterialSkin.Controls.MaterialButton();
            LabelDescBackup = new MaterialSkin.Controls.MaterialLabel();
            LabelTituloBackup = new MaterialSkin.Controls.MaterialLabel();
            materialCard1.SuspendLayout();
            materialTabControl1.SuspendLayout();
            ReporteVentas.SuspendLayout();
            CardVentas.SuspendLayout();
            CardGraficoVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartVentas).BeginInit();
            CardDatosVenta.SuspendLayout();
            ReporteClientes.SuspendLayout();
            CardClientes.SuspendLayout();
            CardDatosClientes.SuspendLayout();
            BackupRestauracion.SuspendLayout();
            CardBackupRestauracion.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(BtnGenerarReporte);
            materialCard1.Controls.Add(materialTabSelector1);
            materialCard1.Controls.Add(materialTabControl1);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Fill;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(0, 0);
            materialCard1.Margin = new Padding(0);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(1041, 594);
            materialCard1.TabIndex = 0;
            // 
            // BtnGenerarReporte
            // 
            BtnGenerarReporte.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnGenerarReporte.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnGenerarReporte.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnGenerarReporte.Depth = 0;
            BtnGenerarReporte.HighEmphasis = true;
            BtnGenerarReporte.Icon = Properties.Resources.confirmar;
            BtnGenerarReporte.Location = new Point(30, 543);
            BtnGenerarReporte.Margin = new Padding(4, 6, 4, 6);
            BtnGenerarReporte.MouseState = MaterialSkin.MouseState.HOVER;
            BtnGenerarReporte.Name = "BtnGenerarReporte";
            BtnGenerarReporte.NoAccentTextColor = Color.Empty;
            BtnGenerarReporte.Size = new Size(235, 36);
            BtnGenerarReporte.TabIndex = 8;
            BtnGenerarReporte.Text = "Generar PDF de Reporte";
            BtnGenerarReporte.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnGenerarReporte.UseAccentColor = false;
            BtnGenerarReporte.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            materialTabSelector1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            materialTabSelector1.BaseTabControl = materialTabControl1;
            materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            materialTabSelector1.Depth = 0;
            materialTabSelector1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTabSelector1.Location = new Point(0, 0);
            materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabSelector1.Name = "materialTabSelector1";
            materialTabSelector1.Size = new Size(1041, 48);
            materialTabSelector1.TabIndex = 0;
            materialTabSelector1.TabIndicatorHeight = 3;
            materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            materialTabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            materialTabControl1.Controls.Add(ReporteVentas);
            materialTabControl1.Controls.Add(ReporteClientes);
            materialTabControl1.Controls.Add(ReporteProductos);
            materialTabControl1.Controls.Add(BackupRestauracion);
            materialTabControl1.Depth = 0;
            materialTabControl1.ItemSize = new Size(80, 25);
            materialTabControl1.Location = new Point(9, 51);
            materialTabControl1.Margin = new Padding(0);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1023, 486);
            materialTabControl1.TabIndex = 0;
            // 
            // ReporteVentas
            // 
            ReporteVentas.Controls.Add(CardVentas);
            ReporteVentas.Location = new Point(4, 29);
            ReporteVentas.Margin = new Padding(0);
            ReporteVentas.Name = "ReporteVentas";
            ReporteVentas.Size = new Size(1015, 453);
            ReporteVentas.TabIndex = 0;
            ReporteVentas.Text = "Reporte de Ventas";
            ReporteVentas.UseVisualStyleBackColor = true;
            // 
            // CardVentas
            // 
            CardVentas.BackColor = Color.FromArgb(255, 255, 255);
            CardVentas.Controls.Add(CardGraficoVentas);
            CardVentas.Controls.Add(CardDatosVenta);
            CardVentas.Controls.Add(LblRangoFechas);
            CardVentas.Controls.Add(ComboBoxVendedor);
            CardVentas.Controls.Add(labelHasta);
            CardVentas.Controls.Add(labelDesde);
            CardVentas.Controls.Add(DtpDesde);
            CardVentas.Controls.Add(DtpHasta);
            CardVentas.Depth = 0;
            CardVentas.Dock = DockStyle.Fill;
            CardVentas.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CardVentas.Location = new Point(0, 0);
            CardVentas.Margin = new Padding(14);
            CardVentas.MouseState = MaterialSkin.MouseState.HOVER;
            CardVentas.Name = "CardVentas";
            CardVentas.Padding = new Padding(14);
            CardVentas.Size = new Size(1015, 453);
            CardVentas.TabIndex = 0;
            // 
            // CardGraficoVentas
            // 
            CardGraficoVentas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            CardGraficoVentas.BackColor = Color.FromArgb(255, 255, 255);
            CardGraficoVentas.Controls.Add(chartVentas);
            CardGraficoVentas.Depth = 0;
            CardGraficoVentas.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CardGraficoVentas.Location = new Point(548, 83);
            CardGraficoVentas.Margin = new Padding(14);
            CardGraficoVentas.MouseState = MaterialSkin.MouseState.HOVER;
            CardGraficoVentas.Name = "CardGraficoVentas";
            CardGraficoVentas.Padding = new Padding(14);
            CardGraficoVentas.Size = new Size(450, 356);
            CardGraficoVentas.TabIndex = 8;
            // 
            // chartVentas
            // 
            chartVentas.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea1.BorderWidth = 10;
            chartArea1.Name = "ChartArea1";
            chartVentas.ChartAreas.Add(chartArea1);
            chartVentas.Dock = DockStyle.Fill;
            chartVentas.Location = new Point(14, 14);
            chartVentas.Name = "chartVentas";
            chartVentas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.BorderColor = Color.Transparent;
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.ChartArea = "ChartArea1";
            series1.CustomProperties = "DrawingStyle=LightToDark, EmptyPointValue=Zero, LabelStyle=TopLeft";
            series1.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.LabelBorderWidth = 3;
            series1.MarkerSize = 1;
            series1.Name = "VentasDiarias";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartVentas.Series.Add(series1);
            chartVentas.Size = new Size(422, 328);
            chartVentas.TabIndex = 0;
            chartVentas.Text = "chart1";
            chartVentas.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            title1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title1.Name = "TituloVentas";
            title1.Text = "Facturación Diaria ( $ )";
            chartVentas.Titles.Add(title1);
            // 
            // CardDatosVenta
            // 
            CardDatosVenta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CardDatosVenta.BackColor = Color.FromArgb(255, 255, 255);
            CardDatosVenta.Controls.Add(LabelCategoriaMasVendidaValor);
            CardDatosVenta.Controls.Add(LabelProductoMasVendidoValor);
            CardDatosVenta.Controls.Add(LabelFechaVentasValor);
            CardDatosVenta.Controls.Add(LabelMargenGanaciasValor);
            CardDatosVenta.Controls.Add(LabelFacturaPromedioValor);
            CardDatosVenta.Controls.Add(LabelTotalFacturadoValor);
            CardDatosVenta.Controls.Add(LabelCantidadVentasValor);
            CardDatosVenta.Controls.Add(LabelMargenGanaciasTitulo);
            CardDatosVenta.Controls.Add(LabelCategoriaMasVendidaTitulo);
            CardDatosVenta.Controls.Add(LabelFechaVentasTitulo);
            CardDatosVenta.Controls.Add(LabelProductoMasVendidoTitulo);
            CardDatosVenta.Controls.Add(LabelFacturaPromedioTitulo);
            CardDatosVenta.Controls.Add(LabelCantidadVentasTitulo);
            CardDatosVenta.Controls.Add(LabelTotalFacturadoTitulo);
            CardDatosVenta.Depth = 0;
            CardDatosVenta.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CardDatosVenta.Location = new Point(17, 83);
            CardDatosVenta.Margin = new Padding(14);
            CardDatosVenta.MouseState = MaterialSkin.MouseState.HOVER;
            CardDatosVenta.Name = "CardDatosVenta";
            CardDatosVenta.Padding = new Padding(14);
            CardDatosVenta.Size = new Size(514, 356);
            CardDatosVenta.TabIndex = 7;
            // 
            // LabelCategoriaMasVendidaValor
            // 
            LabelCategoriaMasVendidaValor.AutoSize = true;
            LabelCategoriaMasVendidaValor.Depth = 0;
            LabelCategoriaMasVendidaValor.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LabelCategoriaMasVendidaValor.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LabelCategoriaMasVendidaValor.Location = new Point(234, 262);
            LabelCategoriaMasVendidaValor.MouseState = MaterialSkin.MouseState.HOVER;
            LabelCategoriaMasVendidaValor.Name = "LabelCategoriaMasVendidaValor";
            LabelCategoriaMasVendidaValor.Size = new Size(15, 24);
            LabelCategoriaMasVendidaValor.TabIndex = 13;
            LabelCategoriaMasVendidaValor.Text = "--";
            // 
            // LabelProductoMasVendidoValor
            // 
            LabelProductoMasVendidoValor.AutoSize = true;
            LabelProductoMasVendidoValor.Depth = 0;
            LabelProductoMasVendidoValor.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LabelProductoMasVendidoValor.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LabelProductoMasVendidoValor.Location = new Point(228, 228);
            LabelProductoMasVendidoValor.MouseState = MaterialSkin.MouseState.HOVER;
            LabelProductoMasVendidoValor.Name = "LabelProductoMasVendidoValor";
            LabelProductoMasVendidoValor.Size = new Size(15, 24);
            LabelProductoMasVendidoValor.TabIndex = 12;
            LabelProductoMasVendidoValor.Text = "--";
            // 
            // LabelFechaVentasValor
            // 
            LabelFechaVentasValor.AutoSize = true;
            LabelFechaVentasValor.Depth = 0;
            LabelFechaVentasValor.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LabelFechaVentasValor.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LabelFechaVentasValor.Location = new Point(228, 194);
            LabelFechaVentasValor.MouseState = MaterialSkin.MouseState.HOVER;
            LabelFechaVentasValor.Name = "LabelFechaVentasValor";
            LabelFechaVentasValor.Size = new Size(15, 24);
            LabelFechaVentasValor.TabIndex = 11;
            LabelFechaVentasValor.Text = "--";
            // 
            // LabelMargenGanaciasValor
            // 
            LabelMargenGanaciasValor.AutoSize = true;
            LabelMargenGanaciasValor.Depth = 0;
            LabelMargenGanaciasValor.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LabelMargenGanaciasValor.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LabelMargenGanaciasValor.Location = new Point(224, 139);
            LabelMargenGanaciasValor.MouseState = MaterialSkin.MouseState.HOVER;
            LabelMargenGanaciasValor.Name = "LabelMargenGanaciasValor";
            LabelMargenGanaciasValor.Size = new Size(15, 24);
            LabelMargenGanaciasValor.TabIndex = 10;
            LabelMargenGanaciasValor.Text = "--";
            // 
            // LabelFacturaPromedioValor
            // 
            LabelFacturaPromedioValor.AutoSize = true;
            LabelFacturaPromedioValor.Depth = 0;
            LabelFacturaPromedioValor.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LabelFacturaPromedioValor.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LabelFacturaPromedioValor.Location = new Point(210, 105);
            LabelFacturaPromedioValor.MouseState = MaterialSkin.MouseState.HOVER;
            LabelFacturaPromedioValor.Name = "LabelFacturaPromedioValor";
            LabelFacturaPromedioValor.Size = new Size(15, 24);
            LabelFacturaPromedioValor.TabIndex = 9;
            LabelFacturaPromedioValor.Text = "--";
            // 
            // LabelTotalFacturadoValor
            // 
            LabelTotalFacturadoValor.AutoSize = true;
            LabelTotalFacturadoValor.Depth = 0;
            LabelTotalFacturadoValor.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LabelTotalFacturadoValor.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LabelTotalFacturadoValor.Location = new Point(170, 71);
            LabelTotalFacturadoValor.MouseState = MaterialSkin.MouseState.HOVER;
            LabelTotalFacturadoValor.Name = "LabelTotalFacturadoValor";
            LabelTotalFacturadoValor.Size = new Size(15, 24);
            LabelTotalFacturadoValor.TabIndex = 8;
            LabelTotalFacturadoValor.Text = "--";
            // 
            // LabelCantidadVentasValor
            // 
            LabelCantidadVentasValor.AutoSize = true;
            LabelCantidadVentasValor.Depth = 0;
            LabelCantidadVentasValor.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LabelCantidadVentasValor.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LabelCantidadVentasValor.Location = new Point(204, 27);
            LabelCantidadVentasValor.MouseState = MaterialSkin.MouseState.HOVER;
            LabelCantidadVentasValor.Name = "LabelCantidadVentasValor";
            LabelCantidadVentasValor.Size = new Size(15, 24);
            LabelCantidadVentasValor.TabIndex = 7;
            LabelCantidadVentasValor.Text = "--";
            // 
            // LabelMargenGanaciasTitulo
            // 
            LabelMargenGanaciasTitulo.AutoSize = true;
            LabelMargenGanaciasTitulo.Depth = 0;
            LabelMargenGanaciasTitulo.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LabelMargenGanaciasTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LabelMargenGanaciasTitulo.Location = new Point(17, 139);
            LabelMargenGanaciasTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            LabelMargenGanaciasTitulo.Name = "LabelMargenGanaciasTitulo";
            LabelMargenGanaciasTitulo.Size = new Size(201, 24);
            LabelMargenGanaciasTitulo.TabIndex = 6;
            LabelMargenGanaciasTitulo.Text = "Margen de Ganancias:";
            // 
            // LabelCategoriaMasVendidaTitulo
            // 
            LabelCategoriaMasVendidaTitulo.AutoSize = true;
            LabelCategoriaMasVendidaTitulo.Depth = 0;
            LabelCategoriaMasVendidaTitulo.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LabelCategoriaMasVendidaTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LabelCategoriaMasVendidaTitulo.Location = new Point(17, 262);
            LabelCategoriaMasVendidaTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            LabelCategoriaMasVendidaTitulo.Name = "LabelCategoriaMasVendidaTitulo";
            LabelCategoriaMasVendidaTitulo.Size = new Size(211, 24);
            LabelCategoriaMasVendidaTitulo.TabIndex = 5;
            LabelCategoriaMasVendidaTitulo.Text = "Categoría más vendida:";
            // 
            // LabelFechaVentasTitulo
            // 
            LabelFechaVentasTitulo.AutoSize = true;
            LabelFechaVentasTitulo.Depth = 0;
            LabelFechaVentasTitulo.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LabelFechaVentasTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LabelFechaVentasTitulo.Location = new Point(17, 194);
            LabelFechaVentasTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            LabelFechaVentasTitulo.Name = "LabelFechaVentasTitulo";
            LabelFechaVentasTitulo.Size = new Size(205, 24);
            LabelFechaVentasTitulo.TabIndex = 4;
            LabelFechaVentasTitulo.Text = "Fecha con más ventas:";
            // 
            // LabelProductoMasVendidoTitulo
            // 
            LabelProductoMasVendidoTitulo.AutoSize = true;
            LabelProductoMasVendidoTitulo.Depth = 0;
            LabelProductoMasVendidoTitulo.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LabelProductoMasVendidoTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LabelProductoMasVendidoTitulo.Location = new Point(17, 228);
            LabelProductoMasVendidoTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            LabelProductoMasVendidoTitulo.Name = "LabelProductoMasVendidoTitulo";
            LabelProductoMasVendidoTitulo.Size = new Size(205, 24);
            LabelProductoMasVendidoTitulo.TabIndex = 3;
            LabelProductoMasVendidoTitulo.Text = "Producto más vendido:";
            // 
            // LabelFacturaPromedioTitulo
            // 
            LabelFacturaPromedioTitulo.AutoSize = true;
            LabelFacturaPromedioTitulo.Depth = 0;
            LabelFacturaPromedioTitulo.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LabelFacturaPromedioTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LabelFacturaPromedioTitulo.Location = new Point(17, 105);
            LabelFacturaPromedioTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            LabelFacturaPromedioTitulo.Name = "LabelFacturaPromedioTitulo";
            LabelFacturaPromedioTitulo.Size = new Size(187, 24);
            LabelFacturaPromedioTitulo.TabIndex = 2;
            LabelFacturaPromedioTitulo.Text = "Promedio Facturado:";
            // 
            // LabelCantidadVentasTitulo
            // 
            LabelCantidadVentasTitulo.AutoSize = true;
            LabelCantidadVentasTitulo.Depth = 0;
            LabelCantidadVentasTitulo.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LabelCantidadVentasTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LabelCantidadVentasTitulo.Location = new Point(17, 27);
            LabelCantidadVentasTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            LabelCantidadVentasTitulo.Name = "LabelCantidadVentasTitulo";
            LabelCantidadVentasTitulo.Size = new Size(181, 24);
            LabelCantidadVentasTitulo.TabIndex = 1;
            LabelCantidadVentasTitulo.Text = "Cantidad de Ventas:";
            // 
            // LabelTotalFacturadoTitulo
            // 
            LabelTotalFacturadoTitulo.AutoSize = true;
            LabelTotalFacturadoTitulo.Depth = 0;
            LabelTotalFacturadoTitulo.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LabelTotalFacturadoTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LabelTotalFacturadoTitulo.Location = new Point(17, 71);
            LabelTotalFacturadoTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            LabelTotalFacturadoTitulo.Name = "LabelTotalFacturadoTitulo";
            LabelTotalFacturadoTitulo.Size = new Size(147, 24);
            LabelTotalFacturadoTitulo.TabIndex = 0;
            LabelTotalFacturadoTitulo.Text = "Total Facturado:";
            // 
            // LblRangoFechas
            // 
            LblRangoFechas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LblRangoFechas.AutoSize = true;
            LblRangoFechas.Depth = 0;
            LblRangoFechas.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LblRangoFechas.Location = new Point(548, 17);
            LblRangoFechas.MouseState = MaterialSkin.MouseState.HOVER;
            LblRangoFechas.Name = "LblRangoFechas";
            LblRangoFechas.Size = new Size(124, 19);
            LblRangoFechas.TabIndex = 6;
            LblRangoFechas.Text = "Rango de fechas:";
            // 
            // ComboBoxVendedor
            // 
            ComboBoxVendedor.AutoResize = false;
            ComboBoxVendedor.BackColor = Color.FromArgb(255, 255, 255);
            ComboBoxVendedor.Cursor = Cursors.Hand;
            ComboBoxVendedor.Depth = 0;
            ComboBoxVendedor.DrawMode = DrawMode.OwnerDrawVariable;
            ComboBoxVendedor.DropDownHeight = 217;
            ComboBoxVendedor.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxVendedor.DropDownWidth = 200;
            ComboBoxVendedor.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            ComboBoxVendedor.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ComboBoxVendedor.FormattingEnabled = true;
            ComboBoxVendedor.Hint = "Buscar por Vendedor";
            ComboBoxVendedor.IntegralHeight = false;
            ComboBoxVendedor.ItemHeight = 43;
            ComboBoxVendedor.Location = new Point(17, 17);
            ComboBoxVendedor.MaxDropDownItems = 5;
            ComboBoxVendedor.MouseState = MaterialSkin.MouseState.OUT;
            ComboBoxVendedor.Name = "ComboBoxVendedor";
            ComboBoxVendedor.Size = new Size(400, 49);
            ComboBoxVendedor.StartIndex = 0;
            ComboBoxVendedor.TabIndex = 1;
            // 
            // labelHasta
            // 
            labelHasta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelHasta.AutoSize = true;
            labelHasta.Depth = 0;
            labelHasta.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelHasta.Location = new Point(809, 44);
            labelHasta.MouseState = MaterialSkin.MouseState.HOVER;
            labelHasta.Name = "labelHasta";
            labelHasta.Size = new Size(43, 19);
            labelHasta.TabIndex = 5;
            labelHasta.Text = "Hasta";
            // 
            // labelDesde
            // 
            labelDesde.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelDesde.AutoSize = true;
            labelDesde.Depth = 0;
            labelDesde.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelDesde.Location = new Point(548, 44);
            labelDesde.MouseState = MaterialSkin.MouseState.HOVER;
            labelDesde.Name = "labelDesde";
            labelDesde.Size = new Size(45, 19);
            labelDesde.TabIndex = 4;
            labelDesde.Text = "Desde";
            // 
            // DtpDesde
            // 
            DtpDesde.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DtpDesde.Cursor = Cursors.Hand;
            DtpDesde.CustomFormat = "dd/MM/yyyy";
            DtpDesde.Format = DateTimePickerFormat.Custom;
            DtpDesde.Location = new Point(603, 43);
            DtpDesde.Margin = new Padding(3, 2, 3, 2);
            DtpDesde.Name = "DtpDesde";
            DtpDesde.RightToLeft = RightToLeft.No;
            DtpDesde.Size = new Size(140, 23);
            DtpDesde.TabIndex = 2;
            // 
            // DtpHasta
            // 
            DtpHasta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DtpHasta.Cursor = Cursors.Hand;
            DtpHasta.CustomFormat = "dd/MM/yyyy";
            DtpHasta.DropDownAlign = LeftRightAlignment.Right;
            DtpHasta.Format = DateTimePickerFormat.Custom;
            DtpHasta.Location = new Point(858, 43);
            DtpHasta.Margin = new Padding(3, 2, 3, 2);
            DtpHasta.Name = "DtpHasta";
            DtpHasta.Size = new Size(140, 23);
            DtpHasta.TabIndex = 3;
            // 
            // ReporteClientes
            // 
            ReporteClientes.Controls.Add(CardClientes);
            ReporteClientes.Location = new Point(4, 29);
            ReporteClientes.Name = "ReporteClientes";
            ReporteClientes.Size = new Size(1015, 453);
            ReporteClientes.TabIndex = 3;
            ReporteClientes.Text = "Reporte de Clientes";
            ReporteClientes.UseVisualStyleBackColor = true;
            // 
            // CardClientes
            // 
            CardClientes.BackColor = Color.FromArgb(255, 255, 255);
            CardClientes.Controls.Add(materialLabel1);
            CardClientes.Controls.Add(materialLabel2);
            CardClientes.Controls.Add(materialLabel3);
            CardClientes.Controls.Add(DtpDesdeClientes);
            CardClientes.Controls.Add(DtpHastaClientes);
            CardClientes.Controls.Add(txtBuscarDniCliente);
            CardClientes.Controls.Add(materialCard2);
            CardClientes.Controls.Add(CardDatosClientes);
            CardClientes.Depth = 0;
            CardClientes.Dock = DockStyle.Fill;
            CardClientes.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CardClientes.Location = new Point(0, 0);
            CardClientes.Margin = new Padding(14);
            CardClientes.MouseState = MaterialSkin.MouseState.HOVER;
            CardClientes.Name = "CardClientes";
            CardClientes.Padding = new Padding(14);
            CardClientes.Size = new Size(1015, 453);
            CardClientes.TabIndex = 0;
            // 
            // materialLabel1
            // 
            materialLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(548, 17);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(124, 19);
            materialLabel1.TabIndex = 11;
            materialLabel1.Text = "Rango de fechas:";
            // 
            // materialLabel2
            // 
            materialLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(809, 44);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(43, 19);
            materialLabel2.TabIndex = 10;
            materialLabel2.Text = "Hasta";
            // 
            // materialLabel3
            // 
            materialLabel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(548, 44);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(45, 19);
            materialLabel3.TabIndex = 9;
            materialLabel3.Text = "Desde";
            // 
            // DtpDesdeClientes
            // 
            DtpDesdeClientes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DtpDesdeClientes.Cursor = Cursors.Hand;
            DtpDesdeClientes.CustomFormat = "dd/MM/yyyy";
            DtpDesdeClientes.Format = DateTimePickerFormat.Custom;
            DtpDesdeClientes.Location = new Point(603, 43);
            DtpDesdeClientes.Margin = new Padding(3, 2, 3, 2);
            DtpDesdeClientes.Name = "DtpDesdeClientes";
            DtpDesdeClientes.RightToLeft = RightToLeft.No;
            DtpDesdeClientes.Size = new Size(140, 23);
            DtpDesdeClientes.TabIndex = 7;
            // 
            // DtpHastaClientes
            // 
            DtpHastaClientes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DtpHastaClientes.Cursor = Cursors.Hand;
            DtpHastaClientes.CustomFormat = "dd/MM/yyyy";
            DtpHastaClientes.DropDownAlign = LeftRightAlignment.Right;
            DtpHastaClientes.Format = DateTimePickerFormat.Custom;
            DtpHastaClientes.Location = new Point(858, 43);
            DtpHastaClientes.Margin = new Padding(3, 2, 3, 2);
            DtpHastaClientes.Name = "DtpHastaClientes";
            DtpHastaClientes.Size = new Size(140, 23);
            DtpHastaClientes.TabIndex = 8;
            // 
            // txtBuscarDniCliente
            // 
            txtBuscarDniCliente.AnimateReadOnly = false;
            txtBuscarDniCliente.BackgroundImageLayout = ImageLayout.None;
            txtBuscarDniCliente.CharacterCasing = CharacterCasing.Normal;
            txtBuscarDniCliente.Depth = 0;
            txtBuscarDniCliente.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarDniCliente.HideSelection = true;
            txtBuscarDniCliente.Hint = "Buscar por DNI del Cliente";
            txtBuscarDniCliente.LeadingIcon = Properties.Resources.clientes;
            txtBuscarDniCliente.Location = new Point(17, 17);
            txtBuscarDniCliente.MaxLength = 32767;
            txtBuscarDniCliente.MouseState = MaterialSkin.MouseState.OUT;
            txtBuscarDniCliente.Name = "txtBuscarDniCliente";
            txtBuscarDniCliente.PasswordChar = '\0';
            txtBuscarDniCliente.PrefixSuffixText = null;
            txtBuscarDniCliente.ReadOnly = false;
            txtBuscarDniCliente.RightToLeft = RightToLeft.No;
            txtBuscarDniCliente.SelectedText = "";
            txtBuscarDniCliente.SelectionLength = 0;
            txtBuscarDniCliente.SelectionStart = 0;
            txtBuscarDniCliente.ShortcutsEnabled = true;
            txtBuscarDniCliente.Size = new Size(400, 48);
            txtBuscarDniCliente.TabIndex = 2;
            txtBuscarDniCliente.TabStop = false;
            txtBuscarDniCliente.TextAlign = HorizontalAlignment.Left;
            txtBuscarDniCliente.TrailingIcon = null;
            txtBuscarDniCliente.UseSystemPasswordChar = false;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(548, 83);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(450, 356);
            materialCard2.TabIndex = 1;
            // 
            // CardDatosClientes
            // 
            CardDatosClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CardDatosClientes.BackColor = Color.FromArgb(255, 255, 255);
            CardDatosClientes.Controls.Add(LabelPromComprasClientesValor);
            CardDatosClientes.Controls.Add(LabelPromComprasClientesTitulo);
            CardDatosClientes.Controls.Add(LabelClienteEstrellaValor);
            CardDatosClientes.Controls.Add(LabelClienteEstrellaTitulo);
            CardDatosClientes.Controls.Add(LabelTotalClientesActivosValor);
            CardDatosClientes.Controls.Add(LabelTotalClientesActivosTitulo);
            CardDatosClientes.Depth = 0;
            CardDatosClientes.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CardDatosClientes.Location = new Point(17, 83);
            CardDatosClientes.Margin = new Padding(14);
            CardDatosClientes.MouseState = MaterialSkin.MouseState.HOVER;
            CardDatosClientes.Name = "CardDatosClientes";
            CardDatosClientes.Padding = new Padding(14);
            CardDatosClientes.Size = new Size(514, 356);
            CardDatosClientes.TabIndex = 0;
            // 
            // LabelPromComprasClientesValor
            // 
            LabelPromComprasClientesValor.AutoSize = true;
            LabelPromComprasClientesValor.Depth = 0;
            LabelPromComprasClientesValor.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LabelPromComprasClientesValor.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LabelPromComprasClientesValor.Location = new Point(332, 105);
            LabelPromComprasClientesValor.MouseState = MaterialSkin.MouseState.HOVER;
            LabelPromComprasClientesValor.Name = "LabelPromComprasClientesValor";
            LabelPromComprasClientesValor.Size = new Size(15, 24);
            LabelPromComprasClientesValor.TabIndex = 13;
            LabelPromComprasClientesValor.Text = "--";
            // 
            // LabelPromComprasClientesTitulo
            // 
            LabelPromComprasClientesTitulo.AutoSize = true;
            LabelPromComprasClientesTitulo.Depth = 0;
            LabelPromComprasClientesTitulo.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LabelPromComprasClientesTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LabelPromComprasClientesTitulo.Location = new Point(17, 105);
            LabelPromComprasClientesTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            LabelPromComprasClientesTitulo.Name = "LabelPromComprasClientesTitulo";
            LabelPromComprasClientesTitulo.Size = new Size(309, 24);
            LabelPromComprasClientesTitulo.TabIndex = 12;
            LabelPromComprasClientesTitulo.Text = "Promedio de Compras Efectuadas:";
            // 
            // LabelClienteEstrellaValor
            // 
            LabelClienteEstrellaValor.AutoSize = true;
            LabelClienteEstrellaValor.Depth = 0;
            LabelClienteEstrellaValor.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LabelClienteEstrellaValor.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LabelClienteEstrellaValor.Location = new Point(164, 71);
            LabelClienteEstrellaValor.MouseState = MaterialSkin.MouseState.HOVER;
            LabelClienteEstrellaValor.Name = "LabelClienteEstrellaValor";
            LabelClienteEstrellaValor.Size = new Size(15, 24);
            LabelClienteEstrellaValor.TabIndex = 11;
            LabelClienteEstrellaValor.Text = "--";
            // 
            // LabelClienteEstrellaTitulo
            // 
            LabelClienteEstrellaTitulo.AutoSize = true;
            LabelClienteEstrellaTitulo.Depth = 0;
            LabelClienteEstrellaTitulo.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LabelClienteEstrellaTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LabelClienteEstrellaTitulo.Location = new Point(17, 71);
            LabelClienteEstrellaTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            LabelClienteEstrellaTitulo.Name = "LabelClienteEstrellaTitulo";
            LabelClienteEstrellaTitulo.Size = new Size(141, 24);
            LabelClienteEstrellaTitulo.TabIndex = 10;
            LabelClienteEstrellaTitulo.Text = "Cliente Estrella:";
            // 
            // LabelTotalClientesActivosValor
            // 
            LabelTotalClientesActivosValor.AutoSize = true;
            LabelTotalClientesActivosValor.Depth = 0;
            LabelTotalClientesActivosValor.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LabelTotalClientesActivosValor.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LabelTotalClientesActivosValor.Location = new Point(251, 27);
            LabelTotalClientesActivosValor.MouseState = MaterialSkin.MouseState.HOVER;
            LabelTotalClientesActivosValor.Name = "LabelTotalClientesActivosValor";
            LabelTotalClientesActivosValor.Size = new Size(15, 24);
            LabelTotalClientesActivosValor.TabIndex = 9;
            LabelTotalClientesActivosValor.Text = "--";
            // 
            // LabelTotalClientesActivosTitulo
            // 
            LabelTotalClientesActivosTitulo.AutoSize = true;
            LabelTotalClientesActivosTitulo.Depth = 0;
            LabelTotalClientesActivosTitulo.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LabelTotalClientesActivosTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LabelTotalClientesActivosTitulo.Location = new Point(17, 27);
            LabelTotalClientesActivosTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            LabelTotalClientesActivosTitulo.Name = "LabelTotalClientesActivosTitulo";
            LabelTotalClientesActivosTitulo.Size = new Size(228, 24);
            LabelTotalClientesActivosTitulo.TabIndex = 8;
            LabelTotalClientesActivosTitulo.Text = "Total de Clientes Activos:";
            // 
            // ReporteProductos
            // 
            ReporteProductos.Location = new Point(4, 29);
            ReporteProductos.Name = "ReporteProductos";
            ReporteProductos.Padding = new Padding(3);
            ReporteProductos.Size = new Size(1015, 453);
            ReporteProductos.TabIndex = 1;
            ReporteProductos.Text = "Reporte de Productos";
            ReporteProductos.UseVisualStyleBackColor = true;
            // 
            // BackupRestauracion
            // 
            BackupRestauracion.Controls.Add(CardBackupRestauracion);
            BackupRestauracion.Location = new Point(4, 29);
            BackupRestauracion.Name = "BackupRestauracion";
            BackupRestauracion.Padding = new Padding(3);
            BackupRestauracion.Size = new Size(1015, 453);
            BackupRestauracion.TabIndex = 4;
            BackupRestauracion.Text = "Backup y Restauración";
            BackupRestauracion.UseVisualStyleBackColor = true;
            // 
            // CardBackupRestauracion
            // 
            CardBackupRestauracion.BackColor = Color.FromArgb(255, 255, 255);
            CardBackupRestauracion.Controls.Add(BtnRestaurar);
            CardBackupRestauracion.Controls.Add(LabelDescRestauracion);
            CardBackupRestauracion.Controls.Add(LabelTituloRestauracion);
            CardBackupRestauracion.Controls.Add(BtnBackup);
            CardBackupRestauracion.Controls.Add(LabelDescBackup);
            CardBackupRestauracion.Controls.Add(LabelTituloBackup);
            CardBackupRestauracion.Depth = 0;
            CardBackupRestauracion.Dock = DockStyle.Fill;
            CardBackupRestauracion.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CardBackupRestauracion.Location = new Point(3, 3);
            CardBackupRestauracion.Margin = new Padding(14);
            CardBackupRestauracion.MouseState = MaterialSkin.MouseState.HOVER;
            CardBackupRestauracion.Name = "CardBackupRestauracion";
            CardBackupRestauracion.Padding = new Padding(14);
            CardBackupRestauracion.Size = new Size(1009, 447);
            CardBackupRestauracion.TabIndex = 0;
            // 
            // BtnRestaurar
            // 
            BtnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnRestaurar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnRestaurar.Cursor = Cursors.Hand;
            BtnRestaurar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnRestaurar.Depth = 0;
            BtnRestaurar.HighEmphasis = true;
            BtnRestaurar.Icon = null;
            BtnRestaurar.Location = new Point(828, 133);
            BtnRestaurar.Margin = new Padding(4, 6, 4, 6);
            BtnRestaurar.MouseState = MaterialSkin.MouseState.HOVER;
            BtnRestaurar.Name = "BtnRestaurar";
            BtnRestaurar.NoAccentTextColor = Color.Empty;
            BtnRestaurar.Size = new Size(164, 36);
            BtnRestaurar.TabIndex = 5;
            BtnRestaurar.Text = "Restaurar backup";
            BtnRestaurar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            BtnRestaurar.UseAccentColor = false;
            BtnRestaurar.UseVisualStyleBackColor = true;
            BtnRestaurar.Click += BtnRestaurar_Click;
            // 
            // LabelDescRestauracion
            // 
            LabelDescRestauracion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LabelDescRestauracion.Depth = 0;
            LabelDescRestauracion.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelDescRestauracion.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            LabelDescRestauracion.Location = new Point(532, 70);
            LabelDescRestauracion.MouseState = MaterialSkin.MouseState.HOVER;
            LabelDescRestauracion.Name = "LabelDescRestauracion";
            LabelDescRestauracion.Size = new Size(460, 57);
            LabelDescRestauracion.TabIndex = 4;
            LabelDescRestauracion.Text = "Restaura la base de datos desde una copia previa (.bak). Atención: Esta acción sobrescribirá todos los registros actuales del sistema y reiniciará la aplicación.";
            // 
            // LabelTituloRestauracion
            // 
            LabelTituloRestauracion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LabelTituloRestauracion.AutoSize = true;
            LabelTituloRestauracion.Depth = 0;
            LabelTituloRestauracion.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LabelTituloRestauracion.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LabelTituloRestauracion.Location = new Point(532, 35);
            LabelTituloRestauracion.MouseState = MaterialSkin.MouseState.HOVER;
            LabelTituloRestauracion.Name = "LabelTituloRestauracion";
            LabelTituloRestauracion.Size = new Size(222, 24);
            LabelTituloRestauracion.TabIndex = 3;
            LabelTituloRestauracion.Text = "Restaurar Base de Datos";
            // 
            // BtnBackup
            // 
            BtnBackup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnBackup.Cursor = Cursors.Hand;
            BtnBackup.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnBackup.Depth = 0;
            BtnBackup.HighEmphasis = true;
            BtnBackup.Icon = null;
            BtnBackup.Location = new Point(339, 133);
            BtnBackup.Margin = new Padding(4, 6, 4, 6);
            BtnBackup.MouseState = MaterialSkin.MouseState.HOVER;
            BtnBackup.Name = "BtnBackup";
            BtnBackup.NoAccentTextColor = Color.Empty;
            BtnBackup.Size = new Size(147, 36);
            BtnBackup.TabIndex = 2;
            BtnBackup.Text = "Generar Backup";
            BtnBackup.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnBackup.UseAccentColor = false;
            BtnBackup.UseVisualStyleBackColor = true;
            BtnBackup.Click += BtnBackup_Click;
            // 
            // LabelDescBackup
            // 
            LabelDescBackup.Depth = 0;
            LabelDescBackup.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelDescBackup.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            LabelDescBackup.Location = new Point(17, 70);
            LabelDescBackup.MouseState = MaterialSkin.MouseState.HOVER;
            LabelDescBackup.Name = "LabelDescBackup";
            LabelDescBackup.Size = new Size(460, 57);
            LabelDescBackup.TabIndex = 1;
            LabelDescBackup.Text = "Genera una copia de seguridad en formato .bak con el estado actual de la base de datos de RGTS. Puede elegir la ruta de destino donde guardar la exportación";
            // 
            // LabelTituloBackup
            // 
            LabelTituloBackup.AutoSize = true;
            LabelTituloBackup.Depth = 0;
            LabelTituloBackup.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LabelTituloBackup.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LabelTituloBackup.Location = new Point(17, 35);
            LabelTituloBackup.MouseState = MaterialSkin.MouseState.HOVER;
            LabelTituloBackup.Name = "LabelTituloBackup";
            LabelTituloBackup.Size = new Size(254, 24);
            LabelTituloBackup.TabIndex = 0;
            LabelTituloBackup.Text = "Exportar Copia de Seguridad";
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 594);
            Controls.Add(materialCard1);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "FormReportes";
            Padding = new Padding(0);
            Text = "FormReportes";
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            materialTabControl1.ResumeLayout(false);
            ReporteVentas.ResumeLayout(false);
            CardVentas.ResumeLayout(false);
            CardVentas.PerformLayout();
            CardGraficoVentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartVentas).EndInit();
            CardDatosVenta.ResumeLayout(false);
            CardDatosVenta.PerformLayout();
            ReporteClientes.ResumeLayout(false);
            CardClientes.ResumeLayout(false);
            CardClientes.PerformLayout();
            CardDatosClientes.ResumeLayout(false);
            CardDatosClientes.PerformLayout();
            BackupRestauracion.ResumeLayout(false);
            CardBackupRestauracion.ResumeLayout(false);
            CardBackupRestauracion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage ReporteVentas;
        private TabPage ReporteProductos;
        private TabPage ReporteClientes;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialCard CardVentas;
        private MaterialSkin.Controls.MaterialCard CardDatosVenta;
        private MaterialSkin.Controls.MaterialCard CardGraficoVentas;
        private MaterialSkin.Controls.MaterialButton BtnGenerarReporte;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxVendedor;
        private MaterialSkin.Controls.MaterialLabel labelHasta;
        private MaterialSkin.Controls.MaterialLabel labelDesde;
        private MaterialSkin.Controls.MaterialLabel LblRangoFechas;
        private DateTimePicker DtpDesde;
        private DateTimePicker DtpHasta;
        private MaterialSkin.Controls.MaterialLabel LabelCantidadVentasTitulo;
        private MaterialSkin.Controls.MaterialLabel LabelCantidadVentasValor;
        private MaterialSkin.Controls.MaterialLabel LabelTotalFacturadoTitulo;
        private MaterialSkin.Controls.MaterialLabel LabelTotalFacturadoValor;
        private MaterialSkin.Controls.MaterialLabel LabelFacturaPromedioTitulo;
        private MaterialSkin.Controls.MaterialLabel LabelFacturaPromedioValor;
        private MaterialSkin.Controls.MaterialLabel LabelMargenGanaciasTitulo;
        private MaterialSkin.Controls.MaterialLabel LabelMargenGanaciasValor;
        private MaterialSkin.Controls.MaterialLabel LabelFechaVentasTitulo;
        private MaterialSkin.Controls.MaterialLabel LabelFechaVentasValor;
        private MaterialSkin.Controls.MaterialLabel LabelProductoMasVendidoTitulo;
        private MaterialSkin.Controls.MaterialLabel LabelProductoMasVendidoValor;
        private MaterialSkin.Controls.MaterialLabel LabelCategoriaMasVendidaTitulo;
        private MaterialSkin.Controls.MaterialLabel LabelCategoriaMasVendidaValor;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVentas;
        private MaterialSkin.Controls.MaterialCard CardClientes;
        private MaterialSkin.Controls.MaterialCard CardDatosClientes;
        private MaterialSkin.Controls.MaterialTextBox2 txtBuscarDniCliente;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private DateTimePicker DtpDesdeClientes;
        private DateTimePicker DtpHastaClientes;
        private MaterialSkin.Controls.MaterialLabel LabelClienteEstrellaValor;
        private MaterialSkin.Controls.MaterialLabel LabelClienteEstrellaTitulo;
        private MaterialSkin.Controls.MaterialLabel LabelTotalClientesActivosValor;
        private MaterialSkin.Controls.MaterialLabel LabelTotalClientesActivosTitulo;
        private MaterialSkin.Controls.MaterialLabel LabelPromComprasClientesValor;
        private MaterialSkin.Controls.MaterialLabel LabelPromComprasClientesTitulo;
        private TabPage BackupRestauracion;
        private MaterialSkin.Controls.MaterialCard CardBackupRestauracion;
        private MaterialSkin.Controls.MaterialLabel LabelDescBackup;
        private MaterialSkin.Controls.MaterialLabel LabelTituloBackup;
        private MaterialSkin.Controls.MaterialLabel LabelTituloRestauracion;
        private MaterialSkin.Controls.MaterialButton BtnBackup;
        private MaterialSkin.Controls.MaterialButton BtnRestaurar;
        private MaterialSkin.Controls.MaterialLabel LabelDescRestauracion;
    }
}