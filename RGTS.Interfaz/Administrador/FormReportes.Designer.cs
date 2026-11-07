using MaterialSkin;
using Charting = System.Windows.Forms.DataVisualization.Charting;
using MSC = MaterialSkin.Controls;

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
            Charting.ChartArea chartArea1 = new Charting.ChartArea();
            Charting.Series series1 = new Charting.Series();
            Charting.Title title1 = new Charting.Title();
            Charting.ChartArea chartArea2 = new Charting.ChartArea();
            Charting.Legend legend1 = new Charting.Legend();
            Charting.Series series2 = new Charting.Series();
            Charting.Title title2 = new Charting.Title();
            Charting.ChartArea chartArea3 = new Charting.ChartArea();
            Charting.Series series3 = new Charting.Series();
            Charting.Title title3 = new Charting.Title();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            BtnGenerarReporte = new MaterialSkin.Controls.MaterialButton();
            materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            ReporteVentas = new TabPage();
            CardVentas = new Panel();
            TablaVentas = new TableLayoutPanel();
            CardDatosVenta = new MaterialSkin.Controls.MaterialCard();
            PanelInfoVentas = new BufferedPanel();
            TablaInfoVentas = new TableLayoutPanel();
            LabelDesempenio = new MaterialSkin.Controls.MaterialLabel();
            LabelCantidadVentasTitulo = new MaterialSkin.Controls.MaterialLabel();
            LabelCantidadVentasValor = new MaterialSkin.Controls.MaterialLabel();
            LabelTotalFacturadoTitulo = new MaterialSkin.Controls.MaterialLabel();
            LabelTotalFacturadoValor = new MaterialSkin.Controls.MaterialLabel();
            LabelFacturaPromedioTitulo = new MaterialSkin.Controls.MaterialLabel();
            LabelFacturaPromedioValor = new MaterialSkin.Controls.MaterialLabel();
            LabelMargenGanaciasTitulo = new MaterialSkin.Controls.MaterialLabel();
            LabelMargenGanaciasValor = new MaterialSkin.Controls.MaterialLabel();
            LabelRendimientoVendedores = new MaterialSkin.Controls.MaterialLabel();
            LabelVendedorEstrellaTitulo = new MaterialSkin.Controls.MaterialLabel();
            LabelVendedorEstrellaValor = new MaterialSkin.Controls.MaterialLabel();
            LabelMasOperacionesTitulo = new MaterialSkin.Controls.MaterialLabel();
            LabelMasOperacionesValor = new MaterialSkin.Controls.MaterialLabel();
            LabelDesempenioVentas = new MaterialSkin.Controls.MaterialLabel();
            LabelFechaPicoTitulo = new MaterialSkin.Controls.MaterialLabel();
            LabelFechaPicoValor = new MaterialSkin.Controls.MaterialLabel();
            LabelDiaMasVentasTitulo = new MaterialSkin.Controls.MaterialLabel();
            LabelDiaMasVentasValor = new MaterialSkin.Controls.MaterialLabel();
            LabelHoraPicoTitulo = new MaterialSkin.Controls.MaterialLabel();
            LabelHoraPicoValor = new MaterialSkin.Controls.MaterialLabel();
            CardGraficoVentas = new MaterialSkin.Controls.MaterialCard();
            chartVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ReporteClientes = new TabPage();
            CardClientes = new Panel();
            TablaClientes = new TableLayoutPanel();
            CardDatosClientes = new MaterialSkin.Controls.MaterialCard();
            PanelInfoClientes = new BufferedPanel();
            TablaInfoClientes = new TableLayoutPanel();
            LabelDesempenioCliente = new MaterialSkin.Controls.MaterialLabel();
            LabelClientesActivosTitulo = new MaterialSkin.Controls.MaterialLabel();
            LabelClientesActivosValor = new MaterialSkin.Controls.MaterialLabel();
            LabelClientesNuevosTitulo = new MaterialSkin.Controls.MaterialLabel();
            LabelClientesNuevosValor = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            LabelClienteEstrellaTitulo = new MaterialSkin.Controls.MaterialLabel();
            LabelClienteEstrellaValor = new MaterialSkin.Controls.MaterialLabel();
            LabelClientesRecurrentesTitulo = new MaterialSkin.Controls.MaterialLabel();
            LabelClientesRecurrentesValor = new MaterialSkin.Controls.MaterialLabel();
            LabelPorcentajeRecurrenciaTitulo = new MaterialSkin.Controls.MaterialLabel();
            LabelPorcentajeRecurrenciaValor = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            LabelPromGastoClienteTitulo = new MaterialSkin.Controls.MaterialLabel();
            LabelPromGastoClienteValor = new MaterialSkin.Controls.MaterialLabel();
            LabelPromedioComprasClientesTitulo = new MaterialSkin.Controls.MaterialLabel();
            LabelPromedioComprasClientesValor = new MaterialSkin.Controls.MaterialLabel();
            LabelClientesUnicosTitulo = new MaterialSkin.Controls.MaterialLabel();
            LabelClientesUnicosValor = new MaterialSkin.Controls.MaterialLabel();
            CardGraficoClientes = new MaterialSkin.Controls.MaterialCard();
            chartClientes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ReporteProductos = new TabPage();
            CardProductos = new Panel();
            TablaProductos = new TableLayoutPanel();
            CardDatosProductos = new MaterialSkin.Controls.MaterialCard();
            PanelInfoProductos = new BufferedPanel();
            TablaInfoProductos = new TableLayoutPanel();
            LabelValorizacionInventario = new MaterialSkin.Controls.MaterialLabel();
            LabelValorInventarioTitulo = new MaterialSkin.Controls.MaterialLabel();
            LabelValorInventarioValor = new MaterialSkin.Controls.MaterialLabel();
            LabelProductosActivosTitulo = new MaterialSkin.Controls.MaterialLabel();
            LabelProductosActivosValor = new MaterialSkin.Controls.MaterialLabel();
            LabelControlStock = new MaterialSkin.Controls.MaterialLabel();
            LabelStockCriticoTitulo = new MaterialSkin.Controls.MaterialLabel();
            LabelStockCriticoValor = new MaterialSkin.Controls.MaterialLabel();
            LabelPorductosAgotadosTitulo = new MaterialSkin.Controls.MaterialLabel();
            LabelPorductosAgotadosValor = new MaterialSkin.Controls.MaterialLabel();
            LabelStockOptimoTitulo = new MaterialSkin.Controls.MaterialLabel();
            LabelStockOptimoValor = new MaterialSkin.Controls.MaterialLabel();
            LabelRendimiento = new MaterialSkin.Controls.MaterialLabel();
            LabelProductoEstrellaTitulo = new MaterialSkin.Controls.MaterialLabel();
            LabelProductoEstrellaValor = new MaterialSkin.Controls.MaterialLabel();
            LabelCategoriaEstrellaTitulo = new MaterialSkin.Controls.MaterialLabel();
            LabelCategoriaEstrellaValor = new MaterialSkin.Controls.MaterialLabel();
            LabelPromedioVendidoTitulo = new MaterialSkin.Controls.MaterialLabel();
            LabelPromedioVendidoValor = new MaterialSkin.Controls.MaterialLabel();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            chartProductos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            LblRangoFechas = new MaterialSkin.Controls.MaterialLabel();
            DtpDesde = new DateTimePicker();
            labelHasta = new MaterialSkin.Controls.MaterialLabel();
            DtpHasta = new DateTimePicker();
            labelDesde = new MaterialSkin.Controls.MaterialLabel();
            materialCard1.SuspendLayout();
            materialTabControl1.SuspendLayout();
            ReporteVentas.SuspendLayout();
            CardVentas.SuspendLayout();
            TablaVentas.SuspendLayout();
            CardDatosVenta.SuspendLayout();
            PanelInfoVentas.SuspendLayout();
            TablaInfoVentas.SuspendLayout();
            CardGraficoVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartVentas).BeginInit();
            ReporteClientes.SuspendLayout();
            CardClientes.SuspendLayout();
            TablaClientes.SuspendLayout();
            CardDatosClientes.SuspendLayout();
            PanelInfoClientes.SuspendLayout();
            TablaInfoClientes.SuspendLayout();
            CardGraficoClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartClientes).BeginInit();
            ReporteProductos.SuspendLayout();
            CardProductos.SuspendLayout();
            TablaProductos.SuspendLayout();
            CardDatosProductos.SuspendLayout();
            PanelInfoProductos.SuspendLayout();
            TablaInfoProductos.SuspendLayout();
            materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartProductos).BeginInit();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(BtnGenerarReporte);
            materialCard1.Controls.Add(materialTabSelector1);
            materialCard1.Controls.Add(LblRangoFechas);
            materialCard1.Controls.Add(materialTabControl1);
            materialCard1.Controls.Add(DtpDesde);
            materialCard1.Controls.Add(labelHasta);
            materialCard1.Controls.Add(DtpHasta);
            materialCard1.Controls.Add(labelDesde);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Fill;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(0, 0);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(1006, 709);
            materialCard1.TabIndex = 0;
            // 
            // BtnGenerarReporte
            // 
            BtnGenerarReporte.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnGenerarReporte.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnGenerarReporte.Cursor = Cursors.Hand;
            BtnGenerarReporte.Density = MSC.MaterialButton.MaterialButtonDensity.Default;
            BtnGenerarReporte.Depth = 0;
            BtnGenerarReporte.HighEmphasis = true;
            BtnGenerarReporte.Icon = Properties.Resources.confirmar;
            BtnGenerarReporte.Location = new Point(16, 666);
            BtnGenerarReporte.Margin = new Padding(4, 6, 4, 6);
            BtnGenerarReporte.MouseState = MouseState.HOVER;
            BtnGenerarReporte.Name = "BtnGenerarReporte";
            BtnGenerarReporte.NoAccentTextColor = Color.Empty;
            BtnGenerarReporte.Size = new Size(235, 36);
            BtnGenerarReporte.TabIndex = 8;
            BtnGenerarReporte.Text = "Generar PDF de Reporte";
            BtnGenerarReporte.Type = MSC.MaterialButton.MaterialButtonType.Contained;
            BtnGenerarReporte.UseAccentColor = false;
            BtnGenerarReporte.UseVisualStyleBackColor = true;
            BtnGenerarReporte.Click += BtnGenerarReporte_Click;
            // 
            // materialTabSelector1
            // 
            materialTabSelector1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            materialTabSelector1.BaseTabControl = materialTabControl1;
            materialTabSelector1.CharacterCasing = MSC.MaterialTabSelector.CustomCharacterCasing.Normal;
            materialTabSelector1.Depth = 0;
            materialTabSelector1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTabSelector1.Location = new Point(0, 0);
            materialTabSelector1.Margin = new Padding(0);
            materialTabSelector1.MouseState = MouseState.HOVER;
            materialTabSelector1.Name = "materialTabSelector1";
            materialTabSelector1.Size = new Size(1006, 48);
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
            materialTabControl1.Depth = 0;
            materialTabControl1.ItemSize = new Size(80, 25);
            materialTabControl1.Location = new Point(14, 105);
            materialTabControl1.Margin = new Padding(0);
            materialTabControl1.MouseState = MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(983, 556);
            materialTabControl1.TabIndex = 1;
            // 
            // ReporteVentas
            // 
            ReporteVentas.Controls.Add(CardVentas);
            ReporteVentas.Location = new Point(4, 29);
            ReporteVentas.Margin = new Padding(0);
            ReporteVentas.Name = "ReporteVentas";
            ReporteVentas.Size = new Size(975, 523);
            ReporteVentas.TabIndex = 0;
            ReporteVentas.Text = "Reporte de Ventas";
            ReporteVentas.UseVisualStyleBackColor = true;
            // 
            // CardVentas
            // 
            CardVentas.AutoSize = true;
            CardVentas.BackColor = Color.White;
            CardVentas.Controls.Add(TablaVentas);
            CardVentas.Dock = DockStyle.Fill;
            CardVentas.Location = new Point(0, 0);
            CardVentas.Name = "CardVentas";
            CardVentas.Padding = new Padding(6);
            CardVentas.Size = new Size(975, 523);
            CardVentas.TabIndex = 0;
            // 
            // TablaVentas
            // 
            TablaVentas.ColumnCount = 2;
            TablaVentas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            TablaVentas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            TablaVentas.Controls.Add(CardDatosVenta, 0, 0);
            TablaVentas.Controls.Add(CardGraficoVentas, 1, 0);
            TablaVentas.Dock = DockStyle.Fill;
            TablaVentas.Location = new Point(6, 6);
            TablaVentas.Name = "TablaVentas";
            TablaVentas.RowCount = 1;
            TablaVentas.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TablaVentas.Size = new Size(963, 511);
            TablaVentas.TabIndex = 0;
            // 
            // CardDatosVenta
            // 
            CardDatosVenta.BackColor = Color.FromArgb(255, 255, 255);
            CardDatosVenta.Controls.Add(PanelInfoVentas);
            CardDatosVenta.Depth = 0;
            CardDatosVenta.Dock = DockStyle.Fill;
            CardDatosVenta.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CardDatosVenta.Location = new Point(8, 8);
            CardDatosVenta.Margin = new Padding(8);
            CardDatosVenta.MouseState = MouseState.HOVER;
            CardDatosVenta.Name = "CardDatosVenta";
            CardDatosVenta.Padding = new Padding(14);
            CardDatosVenta.Size = new Size(513, 495);
            CardDatosVenta.TabIndex = 0;
            // 
            // PanelInfoVentas
            // 
            PanelInfoVentas.AutoScroll = true;
            PanelInfoVentas.BackColor = Color.White;
            PanelInfoVentas.Controls.Add(TablaInfoVentas);
            PanelInfoVentas.Dock = DockStyle.Fill;
            PanelInfoVentas.Location = new Point(14, 14);
            PanelInfoVentas.Name = "PanelInfoVentas";
            PanelInfoVentas.Padding = new Padding(6);
            PanelInfoVentas.Size = new Size(485, 467);
            PanelInfoVentas.TabIndex = 0;
            // 
            // TablaInfoVentas
            // 
            TablaInfoVentas.AutoSize = true;
            TablaInfoVentas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TablaInfoVentas.BackColor = Color.White;
            TablaInfoVentas.ColumnCount = 2;
            TablaInfoVentas.ColumnStyles.Add(new ColumnStyle());
            TablaInfoVentas.ColumnStyles.Add(new ColumnStyle());
            TablaInfoVentas.Controls.Add(LabelDesempenio, 0, 0);
            TablaInfoVentas.Controls.Add(LabelCantidadVentasTitulo, 0, 1);
            TablaInfoVentas.Controls.Add(LabelCantidadVentasValor, 1, 1);
            TablaInfoVentas.Controls.Add(LabelTotalFacturadoTitulo, 0, 2);
            TablaInfoVentas.Controls.Add(LabelTotalFacturadoValor, 1, 2);
            TablaInfoVentas.Controls.Add(LabelFacturaPromedioTitulo, 0, 3);
            TablaInfoVentas.Controls.Add(LabelFacturaPromedioValor, 1, 3);
            TablaInfoVentas.Controls.Add(LabelMargenGanaciasTitulo, 0, 4);
            TablaInfoVentas.Controls.Add(LabelMargenGanaciasValor, 1, 4);
            TablaInfoVentas.Controls.Add(LabelRendimientoVendedores, 0, 5);
            TablaInfoVentas.Controls.Add(LabelVendedorEstrellaTitulo, 0, 6);
            TablaInfoVentas.Controls.Add(LabelVendedorEstrellaValor, 1, 6);
            TablaInfoVentas.Controls.Add(LabelMasOperacionesTitulo, 0, 7);
            TablaInfoVentas.Controls.Add(LabelMasOperacionesValor, 1, 7);
            TablaInfoVentas.Controls.Add(LabelDesempenioVentas, 0, 8);
            TablaInfoVentas.Controls.Add(LabelFechaPicoTitulo, 0, 9);
            TablaInfoVentas.Controls.Add(LabelFechaPicoValor, 1, 9);
            TablaInfoVentas.Controls.Add(LabelDiaMasVentasTitulo, 0, 10);
            TablaInfoVentas.Controls.Add(LabelDiaMasVentasValor, 1, 10);
            TablaInfoVentas.Controls.Add(LabelHoraPicoTitulo, 0, 11);
            TablaInfoVentas.Controls.Add(LabelHoraPicoValor, 1, 11);
            TablaInfoVentas.Dock = DockStyle.Top;
            TablaInfoVentas.Location = new Point(6, 6);
            TablaInfoVentas.Name = "TablaInfoVentas";
            TablaInfoVentas.RowCount = 12;
            TablaInfoVentas.RowStyles.Add(new RowStyle());
            TablaInfoVentas.RowStyles.Add(new RowStyle());
            TablaInfoVentas.RowStyles.Add(new RowStyle());
            TablaInfoVentas.RowStyles.Add(new RowStyle());
            TablaInfoVentas.RowStyles.Add(new RowStyle());
            TablaInfoVentas.RowStyles.Add(new RowStyle());
            TablaInfoVentas.RowStyles.Add(new RowStyle());
            TablaInfoVentas.RowStyles.Add(new RowStyle());
            TablaInfoVentas.RowStyles.Add(new RowStyle());
            TablaInfoVentas.RowStyles.Add(new RowStyle());
            TablaInfoVentas.RowStyles.Add(new RowStyle());
            TablaInfoVentas.RowStyles.Add(new RowStyle());
            TablaInfoVentas.Size = new Size(473, 396);
            TablaInfoVentas.TabIndex = 0;
            // 
            // LabelDesempenio
            // 
            LabelDesempenio.Anchor = AnchorStyles.Left;
            LabelDesempenio.AutoSize = true;
            TablaInfoVentas.SetColumnSpan(LabelDesempenio, 2);
            LabelDesempenio.Depth = 0;
            LabelDesempenio.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LabelDesempenio.FontType = MaterialSkinManager.fontType.H6;
            LabelDesempenio.Location = new Point(3, 3);
            LabelDesempenio.Margin = new Padding(3, 3, 3, 8);
            LabelDesempenio.MouseState = MouseState.HOVER;
            LabelDesempenio.Name = "LabelDesempenio";
            LabelDesempenio.Size = new Size(205, 24);
            LabelDesempenio.TabIndex = 0;
            LabelDesempenio.Text = "Desempeño Financiero";
            // 
            // LabelCantidadVentasTitulo
            // 
            LabelCantidadVentasTitulo.Anchor = AnchorStyles.Left;
            LabelCantidadVentasTitulo.AutoSize = true;
            LabelCantidadVentasTitulo.Depth = 0;
            LabelCantidadVentasTitulo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelCantidadVentasTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelCantidadVentasTitulo.Location = new Point(3, 40);
            LabelCantidadVentasTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelCantidadVentasTitulo.MouseState = MouseState.HOVER;
            LabelCantidadVentasTitulo.Name = "LabelCantidadVentasTitulo";
            LabelCantidadVentasTitulo.Size = new Size(143, 19);
            LabelCantidadVentasTitulo.TabIndex = 1;
            LabelCantidadVentasTitulo.Text = "Cantidad de Ventas:";
            // 
            // LabelCantidadVentasValor
            // 
            LabelCantidadVentasValor.Anchor = AnchorStyles.Left;
            LabelCantidadVentasValor.AutoSize = true;
            LabelCantidadVentasValor.Depth = 0;
            LabelCantidadVentasValor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelCantidadVentasValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelCantidadVentasValor.Location = new Point(259, 40);
            LabelCantidadVentasValor.Margin = new Padding(3, 5, 3, 5);
            LabelCantidadVentasValor.MouseState = MouseState.HOVER;
            LabelCantidadVentasValor.Name = "LabelCantidadVentasValor";
            LabelCantidadVentasValor.Size = new Size(9, 19);
            LabelCantidadVentasValor.TabIndex = 2;
            LabelCantidadVentasValor.Text = "--";
            // 
            // LabelTotalFacturadoTitulo
            // 
            LabelTotalFacturadoTitulo.Anchor = AnchorStyles.Left;
            LabelTotalFacturadoTitulo.AutoSize = true;
            LabelTotalFacturadoTitulo.Depth = 0;
            LabelTotalFacturadoTitulo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelTotalFacturadoTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelTotalFacturadoTitulo.Location = new Point(3, 69);
            LabelTotalFacturadoTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelTotalFacturadoTitulo.MouseState = MouseState.HOVER;
            LabelTotalFacturadoTitulo.Name = "LabelTotalFacturadoTitulo";
            LabelTotalFacturadoTitulo.Size = new Size(118, 19);
            LabelTotalFacturadoTitulo.TabIndex = 3;
            LabelTotalFacturadoTitulo.Text = "Total Facturado:";
            // 
            // LabelTotalFacturadoValor
            // 
            LabelTotalFacturadoValor.Anchor = AnchorStyles.Left;
            LabelTotalFacturadoValor.AutoSize = true;
            LabelTotalFacturadoValor.Depth = 0;
            LabelTotalFacturadoValor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelTotalFacturadoValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelTotalFacturadoValor.Location = new Point(259, 69);
            LabelTotalFacturadoValor.Margin = new Padding(3, 5, 3, 5);
            LabelTotalFacturadoValor.MouseState = MouseState.HOVER;
            LabelTotalFacturadoValor.Name = "LabelTotalFacturadoValor";
            LabelTotalFacturadoValor.Size = new Size(9, 19);
            LabelTotalFacturadoValor.TabIndex = 4;
            LabelTotalFacturadoValor.Text = "--";
            // 
            // LabelFacturaPromedioTitulo
            // 
            LabelFacturaPromedioTitulo.Anchor = AnchorStyles.Left;
            LabelFacturaPromedioTitulo.AutoSize = true;
            LabelFacturaPromedioTitulo.Depth = 0;
            LabelFacturaPromedioTitulo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelFacturaPromedioTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelFacturaPromedioTitulo.Location = new Point(3, 98);
            LabelFacturaPromedioTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelFacturaPromedioTitulo.MouseState = MouseState.HOVER;
            LabelFacturaPromedioTitulo.Name = "LabelFacturaPromedioTitulo";
            LabelFacturaPromedioTitulo.Size = new Size(245, 19);
            LabelFacturaPromedioTitulo.TabIndex = 5;
            LabelFacturaPromedioTitulo.Text = "Promedio Facturado por vendedor:";
            // 
            // LabelFacturaPromedioValor
            // 
            LabelFacturaPromedioValor.Anchor = AnchorStyles.Left;
            LabelFacturaPromedioValor.AutoSize = true;
            LabelFacturaPromedioValor.Depth = 0;
            LabelFacturaPromedioValor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelFacturaPromedioValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelFacturaPromedioValor.Location = new Point(259, 98);
            LabelFacturaPromedioValor.Margin = new Padding(3, 5, 3, 5);
            LabelFacturaPromedioValor.MouseState = MouseState.HOVER;
            LabelFacturaPromedioValor.Name = "LabelFacturaPromedioValor";
            LabelFacturaPromedioValor.Size = new Size(9, 19);
            LabelFacturaPromedioValor.TabIndex = 6;
            LabelFacturaPromedioValor.Text = "--";
            // 
            // LabelMargenGanaciasTitulo
            // 
            LabelMargenGanaciasTitulo.Anchor = AnchorStyles.Left;
            LabelMargenGanaciasTitulo.AutoSize = true;
            LabelMargenGanaciasTitulo.Depth = 0;
            LabelMargenGanaciasTitulo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelMargenGanaciasTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelMargenGanaciasTitulo.Location = new Point(3, 127);
            LabelMargenGanaciasTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelMargenGanaciasTitulo.MouseState = MouseState.HOVER;
            LabelMargenGanaciasTitulo.Name = "LabelMargenGanaciasTitulo";
            LabelMargenGanaciasTitulo.Size = new Size(196, 19);
            LabelMargenGanaciasTitulo.TabIndex = 7;
            LabelMargenGanaciasTitulo.Text = "Margen de Ganancias total:";
            // 
            // LabelMargenGanaciasValor
            // 
            LabelMargenGanaciasValor.Anchor = AnchorStyles.Left;
            LabelMargenGanaciasValor.AutoSize = true;
            LabelMargenGanaciasValor.Depth = 0;
            LabelMargenGanaciasValor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelMargenGanaciasValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelMargenGanaciasValor.Location = new Point(259, 127);
            LabelMargenGanaciasValor.Margin = new Padding(3, 5, 3, 5);
            LabelMargenGanaciasValor.MouseState = MouseState.HOVER;
            LabelMargenGanaciasValor.Name = "LabelMargenGanaciasValor";
            LabelMargenGanaciasValor.Size = new Size(9, 19);
            LabelMargenGanaciasValor.TabIndex = 8;
            LabelMargenGanaciasValor.Text = "--";
            // 
            // LabelRendimientoVendedores
            // 
            LabelRendimientoVendedores.Anchor = AnchorStyles.Left;
            LabelRendimientoVendedores.AutoSize = true;
            TablaInfoVentas.SetColumnSpan(LabelRendimientoVendedores, 2);
            LabelRendimientoVendedores.Depth = 0;
            LabelRendimientoVendedores.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LabelRendimientoVendedores.FontType = MaterialSkinManager.fontType.H6;
            LabelRendimientoVendedores.Location = new Point(3, 169);
            LabelRendimientoVendedores.Margin = new Padding(3, 18, 3, 8);
            LabelRendimientoVendedores.MouseState = MouseState.HOVER;
            LabelRendimientoVendedores.Name = "LabelRendimientoVendedores";
            LabelRendimientoVendedores.Size = new Size(252, 24);
            LabelRendimientoVendedores.TabIndex = 9;
            LabelRendimientoVendedores.Text = "Rendimiento de Vendedores";
            // 
            // LabelVendedorEstrellaTitulo
            // 
            LabelVendedorEstrellaTitulo.Anchor = AnchorStyles.Left;
            LabelVendedorEstrellaTitulo.AutoSize = true;
            LabelVendedorEstrellaTitulo.Depth = 0;
            LabelVendedorEstrellaTitulo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelVendedorEstrellaTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelVendedorEstrellaTitulo.Location = new Point(3, 206);
            LabelVendedorEstrellaTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelVendedorEstrellaTitulo.MouseState = MouseState.HOVER;
            LabelVendedorEstrellaTitulo.Name = "LabelVendedorEstrellaTitulo";
            LabelVendedorEstrellaTitulo.Size = new Size(128, 19);
            LabelVendedorEstrellaTitulo.TabIndex = 10;
            LabelVendedorEstrellaTitulo.Text = "Vendedor Estrella:";
            // 
            // LabelVendedorEstrellaValor
            // 
            LabelVendedorEstrellaValor.Anchor = AnchorStyles.Left;
            LabelVendedorEstrellaValor.AutoSize = true;
            LabelVendedorEstrellaValor.Depth = 0;
            LabelVendedorEstrellaValor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelVendedorEstrellaValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelVendedorEstrellaValor.Location = new Point(259, 206);
            LabelVendedorEstrellaValor.Margin = new Padding(3, 5, 3, 5);
            LabelVendedorEstrellaValor.MouseState = MouseState.HOVER;
            LabelVendedorEstrellaValor.Name = "LabelVendedorEstrellaValor";
            LabelVendedorEstrellaValor.Size = new Size(9, 19);
            LabelVendedorEstrellaValor.TabIndex = 11;
            LabelVendedorEstrellaValor.Text = "--";
            // 
            // LabelMasOperacionesTitulo
            // 
            LabelMasOperacionesTitulo.Anchor = AnchorStyles.Left;
            LabelMasOperacionesTitulo.AutoSize = true;
            LabelMasOperacionesTitulo.Depth = 0;
            LabelMasOperacionesTitulo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelMasOperacionesTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelMasOperacionesTitulo.Location = new Point(3, 235);
            LabelMasOperacionesTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelMasOperacionesTitulo.MouseState = MouseState.HOVER;
            LabelMasOperacionesTitulo.Name = "LabelMasOperacionesTitulo";
            LabelMasOperacionesTitulo.Size = new Size(227, 19);
            LabelMasOperacionesTitulo.TabIndex = 12;
            LabelMasOperacionesTitulo.Text = "Vendedor con más operaciones:";
            // 
            // LabelMasOperacionesValor
            // 
            LabelMasOperacionesValor.Anchor = AnchorStyles.Left;
            LabelMasOperacionesValor.AutoSize = true;
            LabelMasOperacionesValor.Depth = 0;
            LabelMasOperacionesValor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelMasOperacionesValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelMasOperacionesValor.Location = new Point(259, 235);
            LabelMasOperacionesValor.Margin = new Padding(3, 5, 3, 5);
            LabelMasOperacionesValor.MouseState = MouseState.HOVER;
            LabelMasOperacionesValor.Name = "LabelMasOperacionesValor";
            LabelMasOperacionesValor.Size = new Size(9, 19);
            LabelMasOperacionesValor.TabIndex = 13;
            LabelMasOperacionesValor.Text = "--";
            // 
            // LabelDesempenioVentas
            // 
            LabelDesempenioVentas.Anchor = AnchorStyles.Left;
            LabelDesempenioVentas.AutoSize = true;
            TablaInfoVentas.SetColumnSpan(LabelDesempenioVentas, 2);
            LabelDesempenioVentas.Depth = 0;
            LabelDesempenioVentas.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LabelDesempenioVentas.FontType = MaterialSkinManager.fontType.H6;
            LabelDesempenioVentas.Location = new Point(3, 277);
            LabelDesempenioVentas.Margin = new Padding(3, 18, 3, 8);
            LabelDesempenioVentas.MouseState = MouseState.HOVER;
            LabelDesempenioVentas.Name = "LabelDesempenioVentas";
            LabelDesempenioVentas.Size = new Size(197, 24);
            LabelDesempenioVentas.TabIndex = 14;
            LabelDesempenioVentas.Text = "Desempeño Temporal";
            // 
            // LabelFechaPicoTitulo
            // 
            LabelFechaPicoTitulo.Anchor = AnchorStyles.Left;
            LabelFechaPicoTitulo.AutoSize = true;
            LabelFechaPicoTitulo.Depth = 0;
            LabelFechaPicoTitulo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelFechaPicoTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelFechaPicoTitulo.Location = new Point(3, 314);
            LabelFechaPicoTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelFechaPicoTitulo.MouseState = MouseState.HOVER;
            LabelFechaPicoTitulo.Name = "LabelFechaPicoTitulo";
            LabelFechaPicoTitulo.Size = new Size(154, 19);
            LabelFechaPicoTitulo.TabIndex = 15;
            LabelFechaPicoTitulo.Text = "Fecha pico de ventas:";
            // 
            // LabelFechaPicoValor
            // 
            LabelFechaPicoValor.Anchor = AnchorStyles.Left;
            LabelFechaPicoValor.AutoSize = true;
            LabelFechaPicoValor.Depth = 0;
            LabelFechaPicoValor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelFechaPicoValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelFechaPicoValor.Location = new Point(259, 314);
            LabelFechaPicoValor.Margin = new Padding(3, 5, 3, 5);
            LabelFechaPicoValor.MouseState = MouseState.HOVER;
            LabelFechaPicoValor.Name = "LabelFechaPicoValor";
            LabelFechaPicoValor.Size = new Size(9, 19);
            LabelFechaPicoValor.TabIndex = 16;
            LabelFechaPicoValor.Text = "--";
            // 
            // LabelDiaMasVentasTitulo
            // 
            LabelDiaMasVentasTitulo.Anchor = AnchorStyles.Left;
            LabelDiaMasVentasTitulo.AutoSize = true;
            LabelDiaMasVentasTitulo.Depth = 0;
            LabelDiaMasVentasTitulo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelDiaMasVentasTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelDiaMasVentasTitulo.Location = new Point(3, 343);
            LabelDiaMasVentasTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelDiaMasVentasTitulo.MouseState = MouseState.HOVER;
            LabelDiaMasVentasTitulo.Name = "LabelDiaMasVentasTitulo";
            LabelDiaMasVentasTitulo.Size = new Size(145, 19);
            LabelDiaMasVentasTitulo.TabIndex = 17;
            LabelDiaMasVentasTitulo.Text = "Día con más ventas:";
            // 
            // LabelDiaMasVentasValor
            // 
            LabelDiaMasVentasValor.Anchor = AnchorStyles.Left;
            LabelDiaMasVentasValor.AutoSize = true;
            LabelDiaMasVentasValor.Depth = 0;
            LabelDiaMasVentasValor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelDiaMasVentasValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelDiaMasVentasValor.Location = new Point(259, 343);
            LabelDiaMasVentasValor.Margin = new Padding(3, 5, 3, 5);
            LabelDiaMasVentasValor.MouseState = MouseState.HOVER;
            LabelDiaMasVentasValor.Name = "LabelDiaMasVentasValor";
            LabelDiaMasVentasValor.Size = new Size(9, 19);
            LabelDiaMasVentasValor.TabIndex = 18;
            LabelDiaMasVentasValor.Text = "--";
            // 
            // LabelHoraPicoTitulo
            // 
            LabelHoraPicoTitulo.Anchor = AnchorStyles.Left;
            LabelHoraPicoTitulo.AutoSize = true;
            LabelHoraPicoTitulo.Depth = 0;
            LabelHoraPicoTitulo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelHoraPicoTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelHoraPicoTitulo.Location = new Point(3, 372);
            LabelHoraPicoTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelHoraPicoTitulo.MouseState = MouseState.HOVER;
            LabelHoraPicoTitulo.Name = "LabelHoraPicoTitulo";
            LabelHoraPicoTitulo.Size = new Size(145, 19);
            LabelHoraPicoTitulo.TabIndex = 19;
            LabelHoraPicoTitulo.Text = "Hora pico de ventas:";
            // 
            // LabelHoraPicoValor
            // 
            LabelHoraPicoValor.Anchor = AnchorStyles.Left;
            LabelHoraPicoValor.AutoSize = true;
            LabelHoraPicoValor.Depth = 0;
            LabelHoraPicoValor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelHoraPicoValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelHoraPicoValor.Location = new Point(259, 372);
            LabelHoraPicoValor.Margin = new Padding(3, 5, 3, 5);
            LabelHoraPicoValor.MouseState = MouseState.HOVER;
            LabelHoraPicoValor.Name = "LabelHoraPicoValor";
            LabelHoraPicoValor.Size = new Size(9, 19);
            LabelHoraPicoValor.TabIndex = 20;
            LabelHoraPicoValor.Text = "--";
            // 
            // CardGraficoVentas
            // 
            CardGraficoVentas.BackColor = Color.FromArgb(255, 255, 255);
            CardGraficoVentas.Controls.Add(chartVentas);
            CardGraficoVentas.Depth = 0;
            CardGraficoVentas.Dock = DockStyle.Fill;
            CardGraficoVentas.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CardGraficoVentas.Location = new Point(537, 8);
            CardGraficoVentas.Margin = new Padding(8);
            CardGraficoVentas.MouseState = MouseState.HOVER;
            CardGraficoVentas.Name = "CardGraficoVentas";
            CardGraficoVentas.Padding = new Padding(14);
            CardGraficoVentas.Size = new Size(418, 495);
            CardGraficoVentas.TabIndex = 1;
            // 
            // chartVentas
            // 
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.Title = "Nombre de vendedores";
            chartArea1.AxisX.TitleFont = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            chartArea1.AxisX2.Enabled = Charting.AxisEnabled.False;
            chartArea1.AxisY.Enabled = Charting.AxisEnabled.False;
            chartArea1.Name = "ChartArea1";
            chartVentas.ChartAreas.Add(chartArea1);
            chartVentas.Dock = DockStyle.Fill;
            chartVentas.Location = new Point(14, 14);
            chartVentas.Name = "chartVentas";
            chartVentas.Palette = Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Color = Color.Transparent;
            series1.CustomProperties = "DrawingStyle=LightToDark, EmptyPointValue=Zero, LabelStyle=Top";
            series1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.IsXValueIndexed = true;
            series1.Name = "VentasDiarias";
            series1.Palette = Charting.ChartColorPalette.SeaGreen;
            series1.SmartLabelStyle.CalloutStyle = Charting.LabelCalloutStyle.None;
            series1.XValueType = Charting.ChartValueType.String;
            chartVentas.Series.Add(series1);
            chartVentas.Size = new Size(390, 467);
            chartVentas.TabIndex = 0;
            chartVentas.Text = "chartVentas";
            title1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title1.Name = "TituloVentas";
            title1.Text = "Facturación por Vendedor ( $ )";
            chartVentas.Titles.Add(title1);
            // 
            // ReporteClientes
            // 
            ReporteClientes.Controls.Add(CardClientes);
            ReporteClientes.Location = new Point(4, 29);
            ReporteClientes.Margin = new Padding(0);
            ReporteClientes.Name = "ReporteClientes";
            ReporteClientes.Size = new Size(975, 523);
            ReporteClientes.TabIndex = 1;
            ReporteClientes.Text = "Reporte de Clientes";
            ReporteClientes.UseVisualStyleBackColor = true;
            // 
            // CardClientes
            // 
            CardClientes.BackColor = Color.White;
            CardClientes.Controls.Add(TablaClientes);
            CardClientes.Dock = DockStyle.Fill;
            CardClientes.Location = new Point(0, 0);
            CardClientes.Name = "CardClientes";
            CardClientes.Padding = new Padding(6);
            CardClientes.Size = new Size(975, 523);
            CardClientes.TabIndex = 0;
            // 
            // TablaClientes
            // 
            TablaClientes.ColumnCount = 2;
            TablaClientes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            TablaClientes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            TablaClientes.Controls.Add(CardDatosClientes, 0, 0);
            TablaClientes.Controls.Add(CardGraficoClientes, 1, 0);
            TablaClientes.Dock = DockStyle.Fill;
            TablaClientes.Location = new Point(6, 6);
            TablaClientes.Name = "TablaClientes";
            TablaClientes.RowCount = 1;
            TablaClientes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TablaClientes.Size = new Size(963, 511);
            TablaClientes.TabIndex = 0;
            // 
            // CardDatosClientes
            // 
            CardDatosClientes.BackColor = Color.FromArgb(255, 255, 255);
            CardDatosClientes.Controls.Add(PanelInfoClientes);
            CardDatosClientes.Depth = 0;
            CardDatosClientes.Dock = DockStyle.Fill;
            CardDatosClientes.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CardDatosClientes.Location = new Point(8, 8);
            CardDatosClientes.Margin = new Padding(8);
            CardDatosClientes.MouseState = MouseState.HOVER;
            CardDatosClientes.Name = "CardDatosClientes";
            CardDatosClientes.Padding = new Padding(14);
            CardDatosClientes.Size = new Size(513, 495);
            CardDatosClientes.TabIndex = 0;
            // 
            // PanelInfoClientes
            // 
            PanelInfoClientes.AutoScroll = true;
            PanelInfoClientes.BackColor = Color.White;
            PanelInfoClientes.Controls.Add(TablaInfoClientes);
            PanelInfoClientes.Dock = DockStyle.Fill;
            PanelInfoClientes.Location = new Point(14, 14);
            PanelInfoClientes.Name = "PanelInfoClientes";
            PanelInfoClientes.Padding = new Padding(6);
            PanelInfoClientes.Size = new Size(485, 467);
            PanelInfoClientes.TabIndex = 0;
            // 
            // TablaInfoClientes
            // 
            TablaInfoClientes.AutoSize = true;
            TablaInfoClientes.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TablaInfoClientes.BackColor = Color.White;
            TablaInfoClientes.ColumnCount = 2;
            TablaInfoClientes.ColumnStyles.Add(new ColumnStyle());
            TablaInfoClientes.ColumnStyles.Add(new ColumnStyle());
            TablaInfoClientes.Controls.Add(LabelDesempenioCliente, 0, 0);
            TablaInfoClientes.Controls.Add(LabelClientesActivosTitulo, 0, 1);
            TablaInfoClientes.Controls.Add(LabelClientesActivosValor, 1, 1);
            TablaInfoClientes.Controls.Add(LabelClientesNuevosTitulo, 0, 2);
            TablaInfoClientes.Controls.Add(LabelClientesNuevosValor, 1, 2);
            TablaInfoClientes.Controls.Add(materialLabel1, 0, 3);
            TablaInfoClientes.Controls.Add(LabelClienteEstrellaTitulo, 0, 4);
            TablaInfoClientes.Controls.Add(LabelClienteEstrellaValor, 1, 4);
            TablaInfoClientes.Controls.Add(LabelClientesRecurrentesTitulo, 0, 5);
            TablaInfoClientes.Controls.Add(LabelClientesRecurrentesValor, 1, 5);
            TablaInfoClientes.Controls.Add(LabelPorcentajeRecurrenciaTitulo, 0, 6);
            TablaInfoClientes.Controls.Add(LabelPorcentajeRecurrenciaValor, 1, 6);
            TablaInfoClientes.Controls.Add(materialLabel2, 0, 7);
            TablaInfoClientes.Controls.Add(LabelPromGastoClienteTitulo, 0, 8);
            TablaInfoClientes.Controls.Add(LabelPromGastoClienteValor, 1, 8);
            TablaInfoClientes.Controls.Add(LabelPromedioComprasClientesTitulo, 0, 9);
            TablaInfoClientes.Controls.Add(LabelPromedioComprasClientesValor, 1, 9);
            TablaInfoClientes.Controls.Add(LabelClientesUnicosTitulo, 0, 10);
            TablaInfoClientes.Controls.Add(LabelClientesUnicosValor, 1, 10);
            TablaInfoClientes.Dock = DockStyle.Top;
            TablaInfoClientes.Location = new Point(6, 6);
            TablaInfoClientes.Name = "TablaInfoClientes";
            TablaInfoClientes.RowCount = 11;
            TablaInfoClientes.RowStyles.Add(new RowStyle());
            TablaInfoClientes.RowStyles.Add(new RowStyle());
            TablaInfoClientes.RowStyles.Add(new RowStyle());
            TablaInfoClientes.RowStyles.Add(new RowStyle());
            TablaInfoClientes.RowStyles.Add(new RowStyle());
            TablaInfoClientes.RowStyles.Add(new RowStyle());
            TablaInfoClientes.RowStyles.Add(new RowStyle());
            TablaInfoClientes.RowStyles.Add(new RowStyle());
            TablaInfoClientes.RowStyles.Add(new RowStyle());
            TablaInfoClientes.RowStyles.Add(new RowStyle());
            TablaInfoClientes.RowStyles.Add(new RowStyle());
            TablaInfoClientes.Size = new Size(473, 367);
            TablaInfoClientes.TabIndex = 0;
            // 
            // LabelDesempenioCliente
            // 
            LabelDesempenioCliente.Anchor = AnchorStyles.Left;
            LabelDesempenioCliente.AutoSize = true;
            TablaInfoClientes.SetColumnSpan(LabelDesempenioCliente, 2);
            LabelDesempenioCliente.Depth = 0;
            LabelDesempenioCliente.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LabelDesempenioCliente.FontType = MaterialSkinManager.fontType.H6;
            LabelDesempenioCliente.Location = new Point(3, 3);
            LabelDesempenioCliente.Margin = new Padding(3, 3, 3, 8);
            LabelDesempenioCliente.MouseState = MouseState.HOVER;
            LabelDesempenioCliente.Name = "LabelDesempenioCliente";
            LabelDesempenioCliente.Size = new Size(212, 24);
            LabelDesempenioCliente.TabIndex = 0;
            LabelDesempenioCliente.Text = "Desempeño de Clientes";
            // 
            // LabelClientesActivosTitulo
            // 
            LabelClientesActivosTitulo.Anchor = AnchorStyles.Left;
            LabelClientesActivosTitulo.AutoSize = true;
            LabelClientesActivosTitulo.Depth = 0;
            LabelClientesActivosTitulo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelClientesActivosTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelClientesActivosTitulo.Location = new Point(3, 40);
            LabelClientesActivosTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelClientesActivosTitulo.MouseState = MouseState.HOVER;
            LabelClientesActivosTitulo.Name = "LabelClientesActivosTitulo";
            LabelClientesActivosTitulo.Size = new Size(178, 19);
            LabelClientesActivosTitulo.TabIndex = 1;
            LabelClientesActivosTitulo.Text = "Total de Clientes activos:";
            // 
            // LabelClientesActivosValor
            // 
            LabelClientesActivosValor.Anchor = AnchorStyles.Left;
            LabelClientesActivosValor.AutoSize = true;
            LabelClientesActivosValor.Depth = 0;
            LabelClientesActivosValor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelClientesActivosValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelClientesActivosValor.Location = new Point(278, 40);
            LabelClientesActivosValor.Margin = new Padding(3, 5, 3, 5);
            LabelClientesActivosValor.MouseState = MouseState.HOVER;
            LabelClientesActivosValor.Name = "LabelClientesActivosValor";
            LabelClientesActivosValor.Size = new Size(9, 19);
            LabelClientesActivosValor.TabIndex = 2;
            LabelClientesActivosValor.Text = "--";
            // 
            // LabelClientesNuevosTitulo
            // 
            LabelClientesNuevosTitulo.Anchor = AnchorStyles.Left;
            LabelClientesNuevosTitulo.AutoSize = true;
            LabelClientesNuevosTitulo.Depth = 0;
            LabelClientesNuevosTitulo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelClientesNuevosTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelClientesNuevosTitulo.Location = new Point(3, 69);
            LabelClientesNuevosTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelClientesNuevosTitulo.MouseState = MouseState.HOVER;
            LabelClientesNuevosTitulo.Name = "LabelClientesNuevosTitulo";
            LabelClientesNuevosTitulo.Size = new Size(118, 19);
            LabelClientesNuevosTitulo.TabIndex = 3;
            LabelClientesNuevosTitulo.Text = "Clientes Nuevos:";
            // 
            // LabelClientesNuevosValor
            // 
            LabelClientesNuevosValor.Anchor = AnchorStyles.Left;
            LabelClientesNuevosValor.AutoSize = true;
            LabelClientesNuevosValor.Depth = 0;
            LabelClientesNuevosValor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelClientesNuevosValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelClientesNuevosValor.Location = new Point(278, 69);
            LabelClientesNuevosValor.Margin = new Padding(3, 5, 3, 5);
            LabelClientesNuevosValor.MouseState = MouseState.HOVER;
            LabelClientesNuevosValor.Name = "LabelClientesNuevosValor";
            LabelClientesNuevosValor.Size = new Size(9, 19);
            LabelClientesNuevosValor.TabIndex = 4;
            LabelClientesNuevosValor.Text = "--";
            // 
            // materialLabel1
            // 
            materialLabel1.Anchor = AnchorStyles.Left;
            materialLabel1.AutoSize = true;
            TablaInfoClientes.SetColumnSpan(materialLabel1, 2);
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkinManager.fontType.H6;
            materialLabel1.Location = new Point(3, 111);
            materialLabel1.Margin = new Padding(3, 18, 3, 8);
            materialLabel1.MouseState = MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(218, 24);
            materialLabel1.TabIndex = 5;
            materialLabel1.Text = "Métricas de Recurrencia";
            // 
            // LabelClienteEstrellaTitulo
            // 
            LabelClienteEstrellaTitulo.Anchor = AnchorStyles.Left;
            LabelClienteEstrellaTitulo.AutoSize = true;
            LabelClienteEstrellaTitulo.Depth = 0;
            LabelClienteEstrellaTitulo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelClienteEstrellaTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelClienteEstrellaTitulo.Location = new Point(3, 148);
            LabelClienteEstrellaTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelClienteEstrellaTitulo.MouseState = MouseState.HOVER;
            LabelClienteEstrellaTitulo.Name = "LabelClienteEstrellaTitulo";
            LabelClienteEstrellaTitulo.Size = new Size(109, 19);
            LabelClienteEstrellaTitulo.TabIndex = 6;
            LabelClienteEstrellaTitulo.Text = "Cliente Estrella:";
            // 
            // LabelClienteEstrellaValor
            // 
            LabelClienteEstrellaValor.Anchor = AnchorStyles.Left;
            LabelClienteEstrellaValor.AutoSize = true;
            LabelClienteEstrellaValor.Depth = 0;
            LabelClienteEstrellaValor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelClienteEstrellaValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelClienteEstrellaValor.Location = new Point(278, 148);
            LabelClienteEstrellaValor.Margin = new Padding(3, 5, 3, 5);
            LabelClienteEstrellaValor.MouseState = MouseState.HOVER;
            LabelClienteEstrellaValor.Name = "LabelClienteEstrellaValor";
            LabelClienteEstrellaValor.Size = new Size(9, 19);
            LabelClienteEstrellaValor.TabIndex = 7;
            LabelClienteEstrellaValor.Text = "--";
            // 
            // LabelClientesRecurrentesTitulo
            // 
            LabelClientesRecurrentesTitulo.Anchor = AnchorStyles.Left;
            LabelClientesRecurrentesTitulo.AutoSize = true;
            LabelClientesRecurrentesTitulo.Depth = 0;
            LabelClientesRecurrentesTitulo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelClientesRecurrentesTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelClientesRecurrentesTitulo.Location = new Point(3, 177);
            LabelClientesRecurrentesTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelClientesRecurrentesTitulo.MouseState = MouseState.HOVER;
            LabelClientesRecurrentesTitulo.Name = "LabelClientesRecurrentesTitulo";
            LabelClientesRecurrentesTitulo.Size = new Size(237, 19);
            LabelClientesRecurrentesTitulo.TabIndex = 8;
            LabelClientesRecurrentesTitulo.Text = "Cantidad de Clientes Recurrentes:";
            // 
            // LabelClientesRecurrentesValor
            // 
            LabelClientesRecurrentesValor.Anchor = AnchorStyles.Left;
            LabelClientesRecurrentesValor.AutoSize = true;
            LabelClientesRecurrentesValor.Depth = 0;
            LabelClientesRecurrentesValor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelClientesRecurrentesValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelClientesRecurrentesValor.Location = new Point(278, 177);
            LabelClientesRecurrentesValor.Margin = new Padding(3, 5, 3, 5);
            LabelClientesRecurrentesValor.MouseState = MouseState.HOVER;
            LabelClientesRecurrentesValor.Name = "LabelClientesRecurrentesValor";
            LabelClientesRecurrentesValor.Size = new Size(9, 19);
            LabelClientesRecurrentesValor.TabIndex = 9;
            LabelClientesRecurrentesValor.Text = "--";
            // 
            // LabelPorcentajeRecurrenciaTitulo
            // 
            LabelPorcentajeRecurrenciaTitulo.Anchor = AnchorStyles.Left;
            LabelPorcentajeRecurrenciaTitulo.AutoSize = true;
            LabelPorcentajeRecurrenciaTitulo.Depth = 0;
            LabelPorcentajeRecurrenciaTitulo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelPorcentajeRecurrenciaTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelPorcentajeRecurrenciaTitulo.Location = new Point(3, 206);
            LabelPorcentajeRecurrenciaTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelPorcentajeRecurrenciaTitulo.MouseState = MouseState.HOVER;
            LabelPorcentajeRecurrenciaTitulo.Name = "LabelPorcentajeRecurrenciaTitulo";
            LabelPorcentajeRecurrenciaTitulo.Size = new Size(188, 19);
            LabelPorcentajeRecurrenciaTitulo.TabIndex = 10;
            LabelPorcentajeRecurrenciaTitulo.Text = "Porcentaje de Recurrencia:";
            // 
            // LabelPorcentajeRecurrenciaValor
            // 
            LabelPorcentajeRecurrenciaValor.Anchor = AnchorStyles.Left;
            LabelPorcentajeRecurrenciaValor.AutoSize = true;
            LabelPorcentajeRecurrenciaValor.Depth = 0;
            LabelPorcentajeRecurrenciaValor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelPorcentajeRecurrenciaValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelPorcentajeRecurrenciaValor.Location = new Point(278, 206);
            LabelPorcentajeRecurrenciaValor.Margin = new Padding(3, 5, 3, 5);
            LabelPorcentajeRecurrenciaValor.MouseState = MouseState.HOVER;
            LabelPorcentajeRecurrenciaValor.Name = "LabelPorcentajeRecurrenciaValor";
            LabelPorcentajeRecurrenciaValor.Size = new Size(9, 19);
            LabelPorcentajeRecurrenciaValor.TabIndex = 11;
            LabelPorcentajeRecurrenciaValor.Text = "--";
            // 
            // materialLabel2
            // 
            materialLabel2.Anchor = AnchorStyles.Left;
            materialLabel2.AutoSize = true;
            TablaInfoClientes.SetColumnSpan(materialLabel2, 2);
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkinManager.fontType.H6;
            materialLabel2.Location = new Point(3, 248);
            materialLabel2.Margin = new Padding(3, 18, 3, 8);
            materialLabel2.MouseState = MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(182, 24);
            materialLabel2.TabIndex = 12;
            materialLabel2.Text = "Promedio Comercial";
            // 
            // LabelPromGastoClienteTitulo
            // 
            LabelPromGastoClienteTitulo.Anchor = AnchorStyles.Left;
            LabelPromGastoClienteTitulo.AutoSize = true;
            LabelPromGastoClienteTitulo.Depth = 0;
            LabelPromGastoClienteTitulo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelPromGastoClienteTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelPromGastoClienteTitulo.Location = new Point(3, 285);
            LabelPromGastoClienteTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelPromGastoClienteTitulo.MouseState = MouseState.HOVER;
            LabelPromGastoClienteTitulo.Name = "LabelPromGastoClienteTitulo";
            LabelPromGastoClienteTitulo.Size = new Size(264, 19);
            LabelPromGastoClienteTitulo.TabIndex = 13;
            LabelPromGastoClienteTitulo.Text = "Facturación por Clientes Registrados:";
            // 
            // LabelPromGastoClienteValor
            // 
            LabelPromGastoClienteValor.Anchor = AnchorStyles.Left;
            LabelPromGastoClienteValor.AutoSize = true;
            LabelPromGastoClienteValor.Depth = 0;
            LabelPromGastoClienteValor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelPromGastoClienteValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelPromGastoClienteValor.Location = new Point(278, 285);
            LabelPromGastoClienteValor.Margin = new Padding(3, 5, 3, 5);
            LabelPromGastoClienteValor.MouseState = MouseState.HOVER;
            LabelPromGastoClienteValor.Name = "LabelPromGastoClienteValor";
            LabelPromGastoClienteValor.Size = new Size(9, 19);
            LabelPromGastoClienteValor.TabIndex = 14;
            LabelPromGastoClienteValor.Text = "--";
            // 
            // LabelPromedioComprasClientesTitulo
            // 
            LabelPromedioComprasClientesTitulo.Anchor = AnchorStyles.Left;
            LabelPromedioComprasClientesTitulo.AutoSize = true;
            LabelPromedioComprasClientesTitulo.Depth = 0;
            LabelPromedioComprasClientesTitulo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelPromedioComprasClientesTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelPromedioComprasClientesTitulo.Location = new Point(3, 314);
            LabelPromedioComprasClientesTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelPromedioComprasClientesTitulo.MouseState = MouseState.HOVER;
            LabelPromedioComprasClientesTitulo.Name = "LabelPromedioComprasClientesTitulo";
            LabelPromedioComprasClientesTitulo.Size = new Size(249, 19);
            LabelPromedioComprasClientesTitulo.TabIndex = 15;
            LabelPromedioComprasClientesTitulo.Text = "Promedio de Compras por Clientes:";
            // 
            // LabelPromedioComprasClientesValor
            // 
            LabelPromedioComprasClientesValor.Anchor = AnchorStyles.Left;
            LabelPromedioComprasClientesValor.AutoSize = true;
            LabelPromedioComprasClientesValor.Depth = 0;
            LabelPromedioComprasClientesValor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelPromedioComprasClientesValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelPromedioComprasClientesValor.Location = new Point(278, 314);
            LabelPromedioComprasClientesValor.Margin = new Padding(3, 5, 3, 5);
            LabelPromedioComprasClientesValor.MouseState = MouseState.HOVER;
            LabelPromedioComprasClientesValor.Name = "LabelPromedioComprasClientesValor";
            LabelPromedioComprasClientesValor.Size = new Size(9, 19);
            LabelPromedioComprasClientesValor.TabIndex = 16;
            LabelPromedioComprasClientesValor.Text = "--";
            // 
            // LabelClientesUnicosTitulo
            // 
            LabelClientesUnicosTitulo.Anchor = AnchorStyles.Left;
            LabelClientesUnicosTitulo.AutoSize = true;
            LabelClientesUnicosTitulo.Depth = 0;
            LabelClientesUnicosTitulo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelClientesUnicosTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelClientesUnicosTitulo.Location = new Point(3, 343);
            LabelClientesUnicosTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelClientesUnicosTitulo.MouseState = MouseState.HOVER;
            LabelClientesUnicosTitulo.Name = "LabelClientesUnicosTitulo";
            LabelClientesUnicosTitulo.Size = new Size(209, 19);
            LabelClientesUnicosTitulo.TabIndex = 17;
            LabelClientesUnicosTitulo.Text = "Clientes compradores únicos:";
            // 
            // LabelClientesUnicosValor
            // 
            LabelClientesUnicosValor.Anchor = AnchorStyles.Left;
            LabelClientesUnicosValor.AutoSize = true;
            LabelClientesUnicosValor.Depth = 0;
            LabelClientesUnicosValor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelClientesUnicosValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelClientesUnicosValor.Location = new Point(278, 343);
            LabelClientesUnicosValor.Margin = new Padding(3, 5, 3, 5);
            LabelClientesUnicosValor.MouseState = MouseState.HOVER;
            LabelClientesUnicosValor.Name = "LabelClientesUnicosValor";
            LabelClientesUnicosValor.Size = new Size(9, 19);
            LabelClientesUnicosValor.TabIndex = 18;
            LabelClientesUnicosValor.Text = "--";
            // 
            // CardGraficoClientes
            // 
            CardGraficoClientes.BackColor = Color.FromArgb(255, 255, 255);
            CardGraficoClientes.Controls.Add(chartClientes);
            CardGraficoClientes.Depth = 0;
            CardGraficoClientes.Dock = DockStyle.Fill;
            CardGraficoClientes.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CardGraficoClientes.Location = new Point(537, 8);
            CardGraficoClientes.Margin = new Padding(8);
            CardGraficoClientes.MouseState = MouseState.HOVER;
            CardGraficoClientes.Name = "CardGraficoClientes";
            CardGraficoClientes.Padding = new Padding(14);
            CardGraficoClientes.Size = new Size(418, 495);
            CardGraficoClientes.TabIndex = 1;
            // 
            // chartClientes
            // 
            chartArea2.Name = "ChartArea1";
            chartClientes.ChartAreas.Add(chartArea2);
            chartClientes.Dock = DockStyle.Fill;
            legend1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            chartClientes.Legends.Add(legend1);
            chartClientes.Location = new Point(14, 14);
            chartClientes.Name = "chartClientes";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = Charting.SeriesChartType.Pie;
            series2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            series2.Legend = "Legend1";
            series2.Name = "DistribucionClientes";
            chartClientes.Series.Add(series2);
            chartClientes.Size = new Size(390, 467);
            chartClientes.TabIndex = 0;
            chartClientes.Text = "chartClientes";
            title2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title2.Name = "TituloClientes";
            title2.Text = "Distribución por Comportamiento";
            chartClientes.Titles.Add(title2);
            // 
            // ReporteProductos
            // 
            ReporteProductos.Controls.Add(CardProductos);
            ReporteProductos.Location = new Point(4, 29);
            ReporteProductos.Margin = new Padding(0);
            ReporteProductos.Name = "ReporteProductos";
            ReporteProductos.Size = new Size(975, 523);
            ReporteProductos.TabIndex = 2;
            ReporteProductos.Text = "Reporte de Productos";
            ReporteProductos.UseVisualStyleBackColor = true;
            // 
            // CardProductos
            // 
            CardProductos.BackColor = Color.White;
            CardProductos.Controls.Add(TablaProductos);
            CardProductos.Dock = DockStyle.Fill;
            CardProductos.Location = new Point(0, 0);
            CardProductos.Name = "CardProductos";
            CardProductos.Padding = new Padding(6);
            CardProductos.Size = new Size(975, 523);
            CardProductos.TabIndex = 0;
            // 
            // TablaProductos
            // 
            TablaProductos.ColumnCount = 2;
            TablaProductos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            TablaProductos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            TablaProductos.Controls.Add(CardDatosProductos, 0, 0);
            TablaProductos.Controls.Add(materialCard2, 1, 0);
            TablaProductos.Dock = DockStyle.Fill;
            TablaProductos.Location = new Point(6, 6);
            TablaProductos.Name = "TablaProductos";
            TablaProductos.RowCount = 1;
            TablaProductos.RowStyles.Add(new RowStyle());
            TablaProductos.Size = new Size(963, 511);
            TablaProductos.TabIndex = 0;
            // 
            // CardDatosProductos
            // 
            CardDatosProductos.BackColor = Color.FromArgb(255, 255, 255);
            CardDatosProductos.Controls.Add(PanelInfoProductos);
            CardDatosProductos.Depth = 0;
            CardDatosProductos.Dock = DockStyle.Fill;
            CardDatosProductos.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CardDatosProductos.Location = new Point(8, 8);
            CardDatosProductos.Margin = new Padding(8);
            CardDatosProductos.MouseState = MouseState.HOVER;
            CardDatosProductos.Name = "CardDatosProductos";
            CardDatosProductos.Padding = new Padding(14);
            CardDatosProductos.Size = new Size(513, 500);
            CardDatosProductos.TabIndex = 0;
            // 
            // PanelInfoProductos
            // 
            PanelInfoProductos.AutoScroll = true;
            PanelInfoProductos.BackColor = Color.White;
            PanelInfoProductos.Controls.Add(TablaInfoProductos);
            PanelInfoProductos.Dock = DockStyle.Fill;
            PanelInfoProductos.Location = new Point(14, 14);
            PanelInfoProductos.Name = "PanelInfoProductos";
            PanelInfoProductos.Padding = new Padding(6);
            PanelInfoProductos.Size = new Size(485, 472);
            PanelInfoProductos.TabIndex = 0;
            // 
            // TablaInfoProductos
            // 
            TablaInfoProductos.AutoSize = true;
            TablaInfoProductos.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TablaInfoProductos.BackColor = Color.White;
            TablaInfoProductos.ColumnCount = 2;
            TablaInfoProductos.ColumnStyles.Add(new ColumnStyle());
            TablaInfoProductos.ColumnStyles.Add(new ColumnStyle());
            TablaInfoProductos.Controls.Add(LabelValorizacionInventario, 0, 0);
            TablaInfoProductos.Controls.Add(LabelValorInventarioTitulo, 0, 1);
            TablaInfoProductos.Controls.Add(LabelValorInventarioValor, 1, 1);
            TablaInfoProductos.Controls.Add(LabelProductosActivosTitulo, 0, 2);
            TablaInfoProductos.Controls.Add(LabelProductosActivosValor, 1, 2);
            TablaInfoProductos.Controls.Add(LabelControlStock, 0, 3);
            TablaInfoProductos.Controls.Add(LabelStockCriticoTitulo, 0, 4);
            TablaInfoProductos.Controls.Add(LabelStockCriticoValor, 1, 4);
            TablaInfoProductos.Controls.Add(LabelPorductosAgotadosTitulo, 0, 5);
            TablaInfoProductos.Controls.Add(LabelPorductosAgotadosValor, 1, 5);
            TablaInfoProductos.Controls.Add(LabelStockOptimoTitulo, 0, 6);
            TablaInfoProductos.Controls.Add(LabelStockOptimoValor, 1, 6);
            TablaInfoProductos.Controls.Add(LabelRendimiento, 0, 7);
            TablaInfoProductos.Controls.Add(LabelProductoEstrellaTitulo, 0, 8);
            TablaInfoProductos.Controls.Add(LabelProductoEstrellaValor, 1, 8);
            TablaInfoProductos.Controls.Add(LabelCategoriaEstrellaTitulo, 0, 9);
            TablaInfoProductos.Controls.Add(LabelCategoriaEstrellaValor, 1, 9);
            TablaInfoProductos.Controls.Add(LabelPromedioVendidoTitulo, 0, 10);
            TablaInfoProductos.Controls.Add(LabelPromedioVendidoValor, 1, 10);
            TablaInfoProductos.Dock = DockStyle.Top;
            TablaInfoProductos.Location = new Point(6, 6);
            TablaInfoProductos.Name = "TablaInfoProductos";
            TablaInfoProductos.RowCount = 11;
            TablaInfoProductos.RowStyles.Add(new RowStyle());
            TablaInfoProductos.RowStyles.Add(new RowStyle());
            TablaInfoProductos.RowStyles.Add(new RowStyle());
            TablaInfoProductos.RowStyles.Add(new RowStyle());
            TablaInfoProductos.RowStyles.Add(new RowStyle());
            TablaInfoProductos.RowStyles.Add(new RowStyle());
            TablaInfoProductos.RowStyles.Add(new RowStyle());
            TablaInfoProductos.RowStyles.Add(new RowStyle());
            TablaInfoProductos.RowStyles.Add(new RowStyle());
            TablaInfoProductos.RowStyles.Add(new RowStyle());
            TablaInfoProductos.RowStyles.Add(new RowStyle());
            TablaInfoProductos.Size = new Size(473, 367);
            TablaInfoProductos.TabIndex = 0;
            // 
            // LabelValorizacionInventario
            // 
            LabelValorizacionInventario.Anchor = AnchorStyles.Left;
            LabelValorizacionInventario.AutoSize = true;
            TablaInfoProductos.SetColumnSpan(LabelValorizacionInventario, 2);
            LabelValorizacionInventario.Depth = 0;
            LabelValorizacionInventario.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LabelValorizacionInventario.FontType = MaterialSkinManager.fontType.H6;
            LabelValorizacionInventario.Location = new Point(3, 3);
            LabelValorizacionInventario.Margin = new Padding(3, 3, 3, 8);
            LabelValorizacionInventario.MouseState = MouseState.HOVER;
            LabelValorizacionInventario.Name = "LabelValorizacionInventario";
            LabelValorizacionInventario.Size = new Size(233, 24);
            LabelValorizacionInventario.TabIndex = 0;
            LabelValorizacionInventario.Text = "Valorización de Inventario";
            // 
            // LabelValorInventarioTitulo
            // 
            LabelValorInventarioTitulo.Anchor = AnchorStyles.Left;
            LabelValorInventarioTitulo.AutoSize = true;
            LabelValorInventarioTitulo.Depth = 0;
            LabelValorInventarioTitulo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelValorInventarioTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelValorInventarioTitulo.Location = new Point(3, 40);
            LabelValorInventarioTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelValorInventarioTitulo.MouseState = MouseState.HOVER;
            LabelValorInventarioTitulo.Name = "LabelValorInventarioTitulo";
            LabelValorInventarioTitulo.Size = new Size(177, 19);
            LabelValorInventarioTitulo.TabIndex = 1;
            LabelValorInventarioTitulo.Text = "Valor total del Inventario:";
            // 
            // LabelValorInventarioValor
            // 
            LabelValorInventarioValor.Anchor = AnchorStyles.Left;
            LabelValorInventarioValor.AutoSize = true;
            LabelValorInventarioValor.Depth = 0;
            LabelValorInventarioValor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelValorInventarioValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelValorInventarioValor.Location = new Point(248, 40);
            LabelValorInventarioValor.Margin = new Padding(3, 5, 3, 5);
            LabelValorInventarioValor.MouseState = MouseState.HOVER;
            LabelValorInventarioValor.Name = "LabelValorInventarioValor";
            LabelValorInventarioValor.Size = new Size(9, 19);
            LabelValorInventarioValor.TabIndex = 2;
            LabelValorInventarioValor.Text = "--";
            // 
            // LabelProductosActivosTitulo
            // 
            LabelProductosActivosTitulo.Anchor = AnchorStyles.Left;
            LabelProductosActivosTitulo.AutoSize = true;
            LabelProductosActivosTitulo.Depth = 0;
            LabelProductosActivosTitulo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelProductosActivosTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelProductosActivosTitulo.Location = new Point(3, 69);
            LabelProductosActivosTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelProductosActivosTitulo.MouseState = MouseState.HOVER;
            LabelProductosActivosTitulo.Name = "LabelProductosActivosTitulo";
            LabelProductosActivosTitulo.Size = new Size(195, 19);
            LabelProductosActivosTitulo.TabIndex = 3;
            LabelProductosActivosTitulo.Text = "Total de Productos Activos:";
            // 
            // LabelProductosActivosValor
            // 
            LabelProductosActivosValor.Anchor = AnchorStyles.Left;
            LabelProductosActivosValor.AutoSize = true;
            LabelProductosActivosValor.Depth = 0;
            LabelProductosActivosValor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelProductosActivosValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelProductosActivosValor.Location = new Point(248, 69);
            LabelProductosActivosValor.Margin = new Padding(3, 5, 3, 5);
            LabelProductosActivosValor.MouseState = MouseState.HOVER;
            LabelProductosActivosValor.Name = "LabelProductosActivosValor";
            LabelProductosActivosValor.Size = new Size(9, 19);
            LabelProductosActivosValor.TabIndex = 4;
            LabelProductosActivosValor.Text = "--";
            // 
            // LabelControlStock
            // 
            LabelControlStock.Anchor = AnchorStyles.Left;
            LabelControlStock.AutoSize = true;
            TablaInfoProductos.SetColumnSpan(LabelControlStock, 2);
            LabelControlStock.Depth = 0;
            LabelControlStock.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LabelControlStock.FontType = MaterialSkinManager.fontType.H6;
            LabelControlStock.Location = new Point(3, 111);
            LabelControlStock.Margin = new Padding(3, 18, 3, 8);
            LabelControlStock.MouseState = MouseState.HOVER;
            LabelControlStock.Name = "LabelControlStock";
            LabelControlStock.Size = new Size(148, 24);
            LabelControlStock.TabIndex = 5;
            LabelControlStock.Text = "Control de Stock";
            // 
            // LabelStockCriticoTitulo
            // 
            LabelStockCriticoTitulo.Anchor = AnchorStyles.Left;
            LabelStockCriticoTitulo.AutoSize = true;
            LabelStockCriticoTitulo.Depth = 0;
            LabelStockCriticoTitulo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelStockCriticoTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelStockCriticoTitulo.Location = new Point(3, 148);
            LabelStockCriticoTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelStockCriticoTitulo.MouseState = MouseState.HOVER;
            LabelStockCriticoTitulo.Name = "LabelStockCriticoTitulo";
            LabelStockCriticoTitulo.Size = new Size(191, 19);
            LabelStockCriticoTitulo.TabIndex = 6;
            LabelStockCriticoTitulo.Text = "Productos en Stock Crítico:";
            // 
            // LabelStockCriticoValor
            // 
            LabelStockCriticoValor.Anchor = AnchorStyles.Left;
            LabelStockCriticoValor.AutoSize = true;
            LabelStockCriticoValor.Depth = 0;
            LabelStockCriticoValor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelStockCriticoValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelStockCriticoValor.Location = new Point(248, 148);
            LabelStockCriticoValor.Margin = new Padding(3, 5, 3, 5);
            LabelStockCriticoValor.MouseState = MouseState.HOVER;
            LabelStockCriticoValor.Name = "LabelStockCriticoValor";
            LabelStockCriticoValor.Size = new Size(9, 19);
            LabelStockCriticoValor.TabIndex = 7;
            LabelStockCriticoValor.Text = "--";
            // 
            // LabelPorductosAgotadosTitulo
            // 
            LabelPorductosAgotadosTitulo.Anchor = AnchorStyles.Left;
            LabelPorductosAgotadosTitulo.AutoSize = true;
            LabelPorductosAgotadosTitulo.Depth = 0;
            LabelPorductosAgotadosTitulo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelPorductosAgotadosTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelPorductosAgotadosTitulo.Location = new Point(3, 177);
            LabelPorductosAgotadosTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelPorductosAgotadosTitulo.MouseState = MouseState.HOVER;
            LabelPorductosAgotadosTitulo.Name = "LabelPorductosAgotadosTitulo";
            LabelPorductosAgotadosTitulo.Size = new Size(149, 19);
            LabelPorductosAgotadosTitulo.TabIndex = 8;
            LabelPorductosAgotadosTitulo.Text = "Productos Agotados:";
            // 
            // LabelPorductosAgotadosValor
            // 
            LabelPorductosAgotadosValor.Anchor = AnchorStyles.Left;
            LabelPorductosAgotadosValor.AutoSize = true;
            LabelPorductosAgotadosValor.Depth = 0;
            LabelPorductosAgotadosValor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelPorductosAgotadosValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelPorductosAgotadosValor.Location = new Point(248, 177);
            LabelPorductosAgotadosValor.Margin = new Padding(3, 5, 3, 5);
            LabelPorductosAgotadosValor.MouseState = MouseState.HOVER;
            LabelPorductosAgotadosValor.Name = "LabelPorductosAgotadosValor";
            LabelPorductosAgotadosValor.Size = new Size(9, 19);
            LabelPorductosAgotadosValor.TabIndex = 9;
            LabelPorductosAgotadosValor.Text = "--";
            // 
            // LabelStockOptimoTitulo
            // 
            LabelStockOptimoTitulo.Anchor = AnchorStyles.Left;
            LabelStockOptimoTitulo.AutoSize = true;
            LabelStockOptimoTitulo.Depth = 0;
            LabelStockOptimoTitulo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelStockOptimoTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelStockOptimoTitulo.Location = new Point(3, 206);
            LabelStockOptimoTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelStockOptimoTitulo.MouseState = MouseState.HOVER;
            LabelStockOptimoTitulo.Name = "LabelStockOptimoTitulo";
            LabelStockOptimoTitulo.Size = new Size(201, 19);
            LabelStockOptimoTitulo.TabIndex = 10;
            LabelStockOptimoTitulo.Text = "Porcentaje de Stock Óptimo:";
            // 
            // LabelStockOptimoValor
            // 
            LabelStockOptimoValor.Anchor = AnchorStyles.Left;
            LabelStockOptimoValor.AutoSize = true;
            LabelStockOptimoValor.Depth = 0;
            LabelStockOptimoValor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelStockOptimoValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelStockOptimoValor.Location = new Point(248, 206);
            LabelStockOptimoValor.Margin = new Padding(3, 5, 3, 5);
            LabelStockOptimoValor.MouseState = MouseState.HOVER;
            LabelStockOptimoValor.Name = "LabelStockOptimoValor";
            LabelStockOptimoValor.Size = new Size(9, 19);
            LabelStockOptimoValor.TabIndex = 11;
            LabelStockOptimoValor.Text = "--";
            // 
            // LabelRendimiento
            // 
            LabelRendimiento.Anchor = AnchorStyles.Left;
            LabelRendimiento.AutoSize = true;
            TablaInfoProductos.SetColumnSpan(LabelRendimiento, 2);
            LabelRendimiento.Depth = 0;
            LabelRendimiento.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LabelRendimiento.FontType = MaterialSkinManager.fontType.H6;
            LabelRendimiento.Location = new Point(3, 248);
            LabelRendimiento.Margin = new Padding(3, 18, 3, 8);
            LabelRendimiento.MouseState = MouseState.HOVER;
            LabelRendimiento.Name = "LabelRendimiento";
            LabelRendimiento.Size = new Size(211, 24);
            LabelRendimiento.TabIndex = 12;
            LabelRendimiento.Text = "Rendimiento y Rotación";
            // 
            // LabelProductoEstrellaTitulo
            // 
            LabelProductoEstrellaTitulo.Anchor = AnchorStyles.Left;
            LabelProductoEstrellaTitulo.AutoSize = true;
            LabelProductoEstrellaTitulo.Depth = 0;
            LabelProductoEstrellaTitulo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelProductoEstrellaTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelProductoEstrellaTitulo.Location = new Point(3, 285);
            LabelProductoEstrellaTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelProductoEstrellaTitulo.MouseState = MouseState.HOVER;
            LabelProductoEstrellaTitulo.Name = "LabelProductoEstrellaTitulo";
            LabelProductoEstrellaTitulo.Size = new Size(125, 19);
            LabelProductoEstrellaTitulo.TabIndex = 13;
            LabelProductoEstrellaTitulo.Text = "Producto Estrella:";
            // 
            // LabelProductoEstrellaValor
            // 
            LabelProductoEstrellaValor.Anchor = AnchorStyles.Left;
            LabelProductoEstrellaValor.AutoSize = true;
            LabelProductoEstrellaValor.Depth = 0;
            LabelProductoEstrellaValor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelProductoEstrellaValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelProductoEstrellaValor.Location = new Point(248, 285);
            LabelProductoEstrellaValor.Margin = new Padding(3, 5, 3, 5);
            LabelProductoEstrellaValor.MouseState = MouseState.HOVER;
            LabelProductoEstrellaValor.Name = "LabelProductoEstrellaValor";
            LabelProductoEstrellaValor.Size = new Size(9, 19);
            LabelProductoEstrellaValor.TabIndex = 14;
            LabelProductoEstrellaValor.Text = "--";
            // 
            // LabelCategoriaEstrellaTitulo
            // 
            LabelCategoriaEstrellaTitulo.Anchor = AnchorStyles.Left;
            LabelCategoriaEstrellaTitulo.AutoSize = true;
            LabelCategoriaEstrellaTitulo.Depth = 0;
            LabelCategoriaEstrellaTitulo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelCategoriaEstrellaTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelCategoriaEstrellaTitulo.Location = new Point(3, 314);
            LabelCategoriaEstrellaTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelCategoriaEstrellaTitulo.MouseState = MouseState.HOVER;
            LabelCategoriaEstrellaTitulo.Name = "LabelCategoriaEstrellaTitulo";
            LabelCategoriaEstrellaTitulo.Size = new Size(129, 19);
            LabelCategoriaEstrellaTitulo.TabIndex = 15;
            LabelCategoriaEstrellaTitulo.Text = "Categoría Estrella:";
            // 
            // LabelCategoriaEstrellaValor
            // 
            LabelCategoriaEstrellaValor.Anchor = AnchorStyles.Left;
            LabelCategoriaEstrellaValor.AutoSize = true;
            LabelCategoriaEstrellaValor.Depth = 0;
            LabelCategoriaEstrellaValor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelCategoriaEstrellaValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelCategoriaEstrellaValor.Location = new Point(248, 314);
            LabelCategoriaEstrellaValor.Margin = new Padding(3, 5, 3, 5);
            LabelCategoriaEstrellaValor.MouseState = MouseState.HOVER;
            LabelCategoriaEstrellaValor.Name = "LabelCategoriaEstrellaValor";
            LabelCategoriaEstrellaValor.Size = new Size(9, 19);
            LabelCategoriaEstrellaValor.TabIndex = 16;
            LabelCategoriaEstrellaValor.Text = "--";
            // 
            // LabelPromedioVendidoTitulo
            // 
            LabelPromedioVendidoTitulo.Anchor = AnchorStyles.Left;
            LabelPromedioVendidoTitulo.AutoSize = true;
            LabelPromedioVendidoTitulo.Depth = 0;
            LabelPromedioVendidoTitulo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelPromedioVendidoTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelPromedioVendidoTitulo.Location = new Point(3, 343);
            LabelPromedioVendidoTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelPromedioVendidoTitulo.MouseState = MouseState.HOVER;
            LabelPromedioVendidoTitulo.Name = "LabelPromedioVendidoTitulo";
            LabelPromedioVendidoTitulo.Size = new Size(234, 19);
            LabelPromedioVendidoTitulo.TabIndex = 17;
            LabelPromedioVendidoTitulo.Text = "Promedio de Unidades Vendidas:";
            // 
            // LabelPromedioVendidoValor
            // 
            LabelPromedioVendidoValor.Anchor = AnchorStyles.Left;
            LabelPromedioVendidoValor.AutoSize = true;
            LabelPromedioVendidoValor.Depth = 0;
            LabelPromedioVendidoValor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelPromedioVendidoValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelPromedioVendidoValor.Location = new Point(248, 343);
            LabelPromedioVendidoValor.Margin = new Padding(3, 5, 3, 5);
            LabelPromedioVendidoValor.MouseState = MouseState.HOVER;
            LabelPromedioVendidoValor.Name = "LabelPromedioVendidoValor";
            LabelPromedioVendidoValor.Size = new Size(9, 19);
            LabelPromedioVendidoValor.TabIndex = 18;
            LabelPromedioVendidoValor.Text = "--";
            // 
            // materialCard2
            // 
            materialCard2.AutoScroll = true;
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(chartProductos);
            materialCard2.Depth = 0;
            materialCard2.Dock = DockStyle.Fill;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(537, 8);
            materialCard2.Margin = new Padding(8);
            materialCard2.MouseState = MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(418, 500);
            materialCard2.TabIndex = 1;
            // 
            // chartProductos
            // 
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.MajorTickMark.Enabled = false;
            chartArea3.AxisY.Enabled = Charting.AxisEnabled.False;
            chartArea3.Name = "ChartArea1";
            chartProductos.ChartAreas.Add(chartArea3);
            chartProductos.Dock = DockStyle.Fill;
            chartProductos.Location = new Point(14, 14);
            chartProductos.Name = "chartProductos";
            chartProductos.Palette = Charting.ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = Charting.SeriesChartType.Bar;
            series3.Color = Color.Transparent;
            series3.CustomProperties = "DrawingStyle=LightToDark, EmptyPointValue=Zero, LabelStyle=Top";
            series3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            series3.IsValueShownAsLabel = true;
            series3.IsXValueIndexed = true;
            series3.Name = "TopProductos";
            series3.Palette = Charting.ChartColorPalette.Pastel;
            series3.SmartLabelStyle.CalloutStyle = Charting.LabelCalloutStyle.None;
            series3.XValueType = Charting.ChartValueType.String;
            chartProductos.Series.Add(series3);
            chartProductos.Size = new Size(390, 472);
            chartProductos.TabIndex = 0;
            chartProductos.Text = "chartProductos";
            title3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title3.Name = "TituloProductos";
            title3.Text = "Top 5 Productos Más Vendidos";
            chartProductos.Titles.Add(title3);
            // 
            // LblRangoFechas
            // 
            LblRangoFechas.AutoSize = true;
            LblRangoFechas.Depth = 0;
            LblRangoFechas.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LblRangoFechas.Location = new Point(18, 59);
            LblRangoFechas.MouseState = MouseState.HOVER;
            LblRangoFechas.Name = "LblRangoFechas";
            LblRangoFechas.Size = new Size(124, 19);
            LblRangoFechas.TabIndex = 2;
            LblRangoFechas.Text = "Rango de fechas:";
            // 
            // DtpDesde
            // 
            DtpDesde.Cursor = Cursors.Hand;
            DtpDesde.CustomFormat = "dd/MM/yyyy";
            DtpDesde.Format = DateTimePickerFormat.Custom;
            DtpDesde.Location = new Point(66, 80);
            DtpDesde.Margin = new Padding(3, 2, 3, 2);
            DtpDesde.Name = "DtpDesde";
            DtpDesde.Size = new Size(140, 23);
            DtpDesde.TabIndex = 4;
            // 
            // labelHasta
            // 
            labelHasta.AutoSize = true;
            labelHasta.Depth = 0;
            labelHasta.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelHasta.FontType = MaterialSkinManager.fontType.Body2;
            labelHasta.Location = new Point(260, 83);
            labelHasta.MouseState = MouseState.HOVER;
            labelHasta.Name = "labelHasta";
            labelHasta.Size = new Size(42, 17);
            labelHasta.TabIndex = 5;
            labelHasta.Text = "Hasta:";
            // 
            // DtpHasta
            // 
            DtpHasta.Cursor = Cursors.Hand;
            DtpHasta.CustomFormat = "dd/MM/yyyy";
            DtpHasta.DropDownAlign = LeftRightAlignment.Right;
            DtpHasta.Format = DateTimePickerFormat.Custom;
            DtpHasta.Location = new Point(308, 80);
            DtpHasta.Margin = new Padding(3, 2, 3, 2);
            DtpHasta.Name = "DtpHasta";
            DtpHasta.Size = new Size(140, 23);
            DtpHasta.TabIndex = 6;
            // 
            // labelDesde
            // 
            labelDesde.AutoSize = true;
            labelDesde.Depth = 0;
            labelDesde.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelDesde.FontType = MaterialSkinManager.fontType.Body2;
            labelDesde.Location = new Point(18, 83);
            labelDesde.MouseState = MouseState.HOVER;
            labelDesde.Name = "labelDesde";
            labelDesde.Size = new Size(42, 17);
            labelDesde.TabIndex = 3;
            labelDesde.Text = "Desde:";
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1006, 709);
            Controls.Add(materialCard1);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "FormReportes";
            Padding = new Padding(0);
            Text = "FormReportes";
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            materialTabControl1.ResumeLayout(false);
            ReporteVentas.ResumeLayout(false);
            ReporteVentas.PerformLayout();
            CardVentas.ResumeLayout(false);
            TablaVentas.ResumeLayout(false);
            CardDatosVenta.ResumeLayout(false);
            PanelInfoVentas.ResumeLayout(false);
            PanelInfoVentas.PerformLayout();
            TablaInfoVentas.ResumeLayout(false);
            TablaInfoVentas.PerformLayout();
            CardGraficoVentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartVentas).EndInit();
            ReporteClientes.ResumeLayout(false);
            CardClientes.ResumeLayout(false);
            TablaClientes.ResumeLayout(false);
            CardDatosClientes.ResumeLayout(false);
            PanelInfoClientes.ResumeLayout(false);
            PanelInfoClientes.PerformLayout();
            TablaInfoClientes.ResumeLayout(false);
            TablaInfoClientes.PerformLayout();
            CardGraficoClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartClientes).EndInit();
            ReporteProductos.ResumeLayout(false);
            CardProductos.ResumeLayout(false);
            TablaProductos.ResumeLayout(false);
            CardDatosProductos.ResumeLayout(false);
            PanelInfoProductos.ResumeLayout(false);
            PanelInfoProductos.PerformLayout();
            TablaInfoProductos.ResumeLayout(false);
            TablaInfoProductos.PerformLayout();
            materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        // ---- Contenedor principal ----
        private MSC.MaterialCard materialCard1;
        private MSC.MaterialTabSelector materialTabSelector1;
        private MSC.MaterialTabControl materialTabControl1;
        private MSC.MaterialButton BtnGenerarReporte;
        private MSC.MaterialLabel LblRangoFechas;
        private MSC.MaterialLabel labelDesde;
        private MSC.MaterialLabel labelHasta;
        private DateTimePicker DtpDesde;
        private DateTimePicker DtpHasta;

        // ---- Ventas ----
        private TabPage ReporteVentas;
        private Panel CardVentas;
        private TableLayoutPanel TablaVentas;
        private MSC.MaterialCard CardDatosVenta;
        private MSC.MaterialCard CardGraficoVentas;
        private BufferedPanel PanelInfoVentas;
        private TableLayoutPanel TablaInfoVentas;
        private Charting.Chart chartVentas;
        private MSC.MaterialLabel LabelDesempenio;
        private MSC.MaterialLabel LabelCantidadVentasTitulo;
        private MSC.MaterialLabel LabelCantidadVentasValor;
        private MSC.MaterialLabel LabelTotalFacturadoTitulo;
        private MSC.MaterialLabel LabelTotalFacturadoValor;
        private MSC.MaterialLabel LabelFacturaPromedioTitulo;
        private MSC.MaterialLabel LabelFacturaPromedioValor;
        private MSC.MaterialLabel LabelMargenGanaciasTitulo;
        private MSC.MaterialLabel LabelMargenGanaciasValor;
        private MSC.MaterialLabel LabelRendimientoVendedores;
        private MSC.MaterialLabel LabelVendedorEstrellaTitulo;
        private MSC.MaterialLabel LabelVendedorEstrellaValor;
        private MSC.MaterialLabel LabelMasOperacionesTitulo;
        private MSC.MaterialLabel LabelMasOperacionesValor;
        private MSC.MaterialLabel LabelDesempenioVentas;
        private MSC.MaterialLabel LabelFechaPicoTitulo;
        private MSC.MaterialLabel LabelFechaPicoValor;
        private MSC.MaterialLabel LabelDiaMasVentasTitulo;
        private MSC.MaterialLabel LabelDiaMasVentasValor;
        private MSC.MaterialLabel LabelHoraPicoTitulo;
        private MSC.MaterialLabel LabelHoraPicoValor;

        // ---- Clientes ----
        private TabPage ReporteClientes;
        private Panel CardClientes;
        private TableLayoutPanel TablaClientes;
        private MSC.MaterialCard CardDatosClientes;
        private MSC.MaterialCard CardGraficoClientes;
        private BufferedPanel PanelInfoClientes;
        private TableLayoutPanel TablaInfoClientes;
        private Charting.Chart chartClientes;
        private MSC.MaterialLabel LabelDesempenioCliente;
        private MSC.MaterialLabel LabelClientesActivosTitulo;
        private MSC.MaterialLabel LabelClientesActivosValor;
        private MSC.MaterialLabel LabelClientesNuevosTitulo;
        private MSC.MaterialLabel LabelClientesNuevosValor;
        private MSC.MaterialLabel materialLabel1;
        private MSC.MaterialLabel LabelClienteEstrellaTitulo;
        private MSC.MaterialLabel LabelClienteEstrellaValor;
        private MSC.MaterialLabel LabelClientesRecurrentesTitulo;
        private MSC.MaterialLabel LabelClientesRecurrentesValor;
        private MSC.MaterialLabel LabelPorcentajeRecurrenciaTitulo;
        private MSC.MaterialLabel LabelPorcentajeRecurrenciaValor;
        private MSC.MaterialLabel materialLabel2;
        private MSC.MaterialLabel LabelPromGastoClienteTitulo;
        private MSC.MaterialLabel LabelPromGastoClienteValor;
        private MSC.MaterialLabel LabelPromedioComprasClientesTitulo;
        private MSC.MaterialLabel LabelPromedioComprasClientesValor;
        private MSC.MaterialLabel LabelClientesUnicosTitulo;
        private MSC.MaterialLabel LabelClientesUnicosValor;

        // ---- Productos ----
        private TabPage ReporteProductos;
        private Panel CardProductos;
        private TableLayoutPanel TablaProductos;
        private MSC.MaterialCard CardDatosProductos;
        private MSC.MaterialCard materialCard2;
        private BufferedPanel PanelInfoProductos;
        private TableLayoutPanel TablaInfoProductos;
        private Charting.Chart chartProductos;
        private MSC.MaterialLabel LabelValorizacionInventario;
        private MSC.MaterialLabel LabelValorInventarioTitulo;
        private MSC.MaterialLabel LabelValorInventarioValor;
        private MSC.MaterialLabel LabelProductosActivosTitulo;
        private MSC.MaterialLabel LabelProductosActivosValor;
        private MSC.MaterialLabel LabelControlStock;
        private MSC.MaterialLabel LabelStockCriticoTitulo;
        private MSC.MaterialLabel LabelStockCriticoValor;
        private MSC.MaterialLabel LabelPorductosAgotadosTitulo;
        private MSC.MaterialLabel LabelPorductosAgotadosValor;
        private MSC.MaterialLabel LabelStockOptimoTitulo;
        private MSC.MaterialLabel LabelStockOptimoValor;
        private MSC.MaterialLabel LabelRendimiento;
        private MSC.MaterialLabel LabelProductoEstrellaTitulo;
        private MSC.MaterialLabel LabelProductoEstrellaValor;
        private MSC.MaterialLabel LabelCategoriaEstrellaTitulo;
        private MSC.MaterialLabel LabelCategoriaEstrellaValor;
        private MSC.MaterialLabel LabelPromedioVendidoTitulo;
        private MSC.MaterialLabel LabelPromedioVendidoValor;
    }
}