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

            materialCard1 = new MSC.MaterialCard();
            BtnGenerarReporte = new MSC.MaterialButton();
            materialTabSelector1 = new MSC.MaterialTabSelector();
            materialTabControl1 = new MSC.MaterialTabControl();
            LblRangoFechas = new MSC.MaterialLabel();
            DtpDesde = new DateTimePicker();
            labelHasta = new MSC.MaterialLabel();
            DtpHasta = new DateTimePicker();
            labelDesde = new MSC.MaterialLabel();

            // ---- Pestaña Ventas ----
            ReporteVentas = new TabPage();
            CardVentas = new Panel();
            TablaVentas = new TableLayoutPanel();
            CardGraficoVentas = new MSC.MaterialCard();
            chartVentas = new Charting.Chart();
            CardDatosVenta = new MSC.MaterialCard();
            PanelInfoVentas = new BufferedPanel();
            TablaInfoVentas = new TableLayoutPanel();
            LabelDesempenio = new MSC.MaterialLabel();
            LabelCantidadVentasTitulo = new MSC.MaterialLabel();
            LabelCantidadVentasValor = new MSC.MaterialLabel();
            LabelTotalFacturadoTitulo = new MSC.MaterialLabel();
            LabelTotalFacturadoValor = new MSC.MaterialLabel();
            LabelFacturaPromedioTitulo = new MSC.MaterialLabel();
            LabelFacturaPromedioValor = new MSC.MaterialLabel();
            LabelMargenGanaciasTitulo = new MSC.MaterialLabel();
            LabelMargenGanaciasValor = new MSC.MaterialLabel();
            LabelRendimientoVendedores = new MSC.MaterialLabel();
            LabelVendedorEstrellaTitulo = new MSC.MaterialLabel();
            LabelVendedorEstrellaValor = new MSC.MaterialLabel();
            LabelMasOperacionesTitulo = new MSC.MaterialLabel();
            LabelMasOperacionesValor = new MSC.MaterialLabel();
            LabelDesempenioVentas = new MSC.MaterialLabel();
            LabelFechaPicoTitulo = new MSC.MaterialLabel();
            LabelFechaPicoValor = new MSC.MaterialLabel();
            LabelDiaMasVentasTitulo = new MSC.MaterialLabel();
            LabelDiaMasVentasValor = new MSC.MaterialLabel();
            LabelHoraPicoTitulo = new MSC.MaterialLabel();
            LabelHoraPicoValor = new MSC.MaterialLabel();

            // ---- Pestaña Clientes ----
            ReporteClientes = new TabPage();
            CardClientes = new Panel();
            TablaClientes = new TableLayoutPanel();
            CardGraficoClientes = new MSC.MaterialCard();
            chartClientes = new Charting.Chart();
            CardDatosClientes = new MSC.MaterialCard();
            PanelInfoClientes = new BufferedPanel();
            TablaInfoClientes = new TableLayoutPanel();
            LabelDesempenioCliente = new MSC.MaterialLabel();
            LabelClientesActivosTitulo = new MSC.MaterialLabel();
            LabelClientesActivosValor = new MSC.MaterialLabel();
            LabelClientesNuevosTitulo = new MSC.MaterialLabel();
            LabelClientesNuevosValor = new MSC.MaterialLabel();
            materialLabel1 = new MSC.MaterialLabel();
            LabelClienteEstrellaTitulo = new MSC.MaterialLabel();
            LabelClienteEstrellaValor = new MSC.MaterialLabel();
            LabelClientesRecurrentesTitulo = new MSC.MaterialLabel();
            LabelClientesRecurrentesValor = new MSC.MaterialLabel();
            LabelPorcentajeRecurrenciaTitulo = new MSC.MaterialLabel();
            LabelPorcentajeRecurrenciaValor = new MSC.MaterialLabel();
            materialLabel2 = new MSC.MaterialLabel();
            LabelPromGastoClienteTitulo = new MSC.MaterialLabel();
            LabelPromGastoClienteValor = new MSC.MaterialLabel();
            LabelPromedioComprasClientesTitulo = new MSC.MaterialLabel();
            LabelPromedioComprasClientesValor = new MSC.MaterialLabel();
            LabelClientesUnicosTitulo = new MSC.MaterialLabel();
            LabelClientesUnicosValor = new MSC.MaterialLabel();

            // ---- Pestaña Productos ----
            ReporteProductos = new TabPage();
            CardProductos = new Panel();
            TablaProductos = new TableLayoutPanel();
            materialCard2 = new MSC.MaterialCard();
            chartProductos = new Charting.Chart();
            CardDatosProductos = new MSC.MaterialCard();
            PanelInfoProductos = new BufferedPanel();
            TablaInfoProductos = new TableLayoutPanel();
            LabelValorizacionInventario = new MSC.MaterialLabel();
            LabelValorInventarioTitulo = new MSC.MaterialLabel();
            LabelValorInventarioValor = new MSC.MaterialLabel();
            LabelProductosActivosTitulo = new MSC.MaterialLabel();
            LabelProductosActivosValor = new MSC.MaterialLabel();
            LabelControlStock = new MSC.MaterialLabel();
            LabelStockCriticoTitulo = new MSC.MaterialLabel();
            LabelStockCriticoValor = new MSC.MaterialLabel();
            LabelPorductosAgotadosTitulo = new MSC.MaterialLabel();
            LabelPorductosAgotadosValor = new MSC.MaterialLabel();
            LabelStockOptimoTitulo = new MSC.MaterialLabel();
            LabelStockOptimoValor = new MSC.MaterialLabel();
            LabelRendimiento = new MSC.MaterialLabel();
            LabelProductoEstrellaTitulo = new MSC.MaterialLabel();
            LabelProductoEstrellaValor = new MSC.MaterialLabel();
            LabelCategoriaEstrellaTitulo = new MSC.MaterialLabel();
            LabelCategoriaEstrellaValor = new MSC.MaterialLabel();
            LabelPromedioVendidoTitulo = new MSC.MaterialLabel();
            LabelPromedioVendidoValor = new MSC.MaterialLabel();

            materialCard1.SuspendLayout();
            materialTabControl1.SuspendLayout();
            ReporteVentas.SuspendLayout();
            CardVentas.SuspendLayout();
            TablaVentas.SuspendLayout();
            CardGraficoVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartVentas).BeginInit();
            CardDatosVenta.SuspendLayout();
            PanelInfoVentas.SuspendLayout();
            TablaInfoVentas.SuspendLayout();
            ReporteClientes.SuspendLayout();
            CardClientes.SuspendLayout();
            TablaClientes.SuspendLayout();
            CardGraficoClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartClientes).BeginInit();
            CardDatosClientes.SuspendLayout();
            PanelInfoClientes.SuspendLayout();
            TablaInfoClientes.SuspendLayout();
            ReporteProductos.SuspendLayout();
            CardProductos.SuspendLayout();
            TablaProductos.SuspendLayout();
            materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartProductos).BeginInit();
            CardDatosProductos.SuspendLayout();
            PanelInfoProductos.SuspendLayout();
            TablaInfoProductos.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.White;
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
            materialCard1.Margin = new Padding(0);
            materialCard1.MouseState = MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(1041, 709);
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
            BtnGenerarReporte.Location = new Point(30, 658);
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
            materialTabControl1.Depth = 0;
            materialTabControl1.ItemSize = new Size(80, 25);
            materialTabControl1.Location = new Point(9, 114);
            materialTabControl1.Margin = new Padding(0);
            materialTabControl1.MouseState = MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1023, 538);
            materialTabControl1.TabIndex = 1;
            // 
            // LblRangoFechas
            // 
            LblRangoFechas.AutoSize = true;
            LblRangoFechas.Depth = 0;
            LblRangoFechas.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LblRangoFechas.Location = new Point(29, 61);
            LblRangoFechas.MouseState = MouseState.HOVER;
            LblRangoFechas.Name = "LblRangoFechas";
            LblRangoFechas.Size = new Size(124, 19);
            LblRangoFechas.TabIndex = 2;
            LblRangoFechas.Text = "Rango de fechas:";
            // 
            // labelDesde
            // 
            labelDesde.AutoSize = true;
            labelDesde.Depth = 0;
            labelDesde.FontType = MaterialSkinManager.fontType.Body2;
            labelDesde.Location = new Point(29, 90);
            labelDesde.MouseState = MouseState.HOVER;
            labelDesde.Name = "labelDesde";
            labelDesde.TabIndex = 3;
            labelDesde.Text = "Desde:";
            // 
            // DtpDesde
            // 
            DtpDesde.Cursor = Cursors.Hand;
            DtpDesde.CustomFormat = "dd/MM/yyyy";
            DtpDesde.Format = DateTimePickerFormat.Custom;
            DtpDesde.Location = new Point(77, 87);
            DtpDesde.Margin = new Padding(3, 2, 3, 2);
            DtpDesde.Name = "DtpDesde";
            DtpDesde.Size = new Size(140, 23);
            DtpDesde.TabIndex = 4;
            // 
            // labelHasta
            // 
            labelHasta.AutoSize = true;
            labelHasta.Depth = 0;
            labelHasta.FontType = MaterialSkinManager.fontType.Body2;
            labelHasta.Location = new Point(291, 90);
            labelHasta.MouseState = MouseState.HOVER;
            labelHasta.Name = "labelHasta";
            labelHasta.TabIndex = 5;
            labelHasta.Text = "Hasta:";
            // 
            // DtpHasta
            // 
            DtpHasta.Cursor = Cursors.Hand;
            DtpHasta.CustomFormat = "dd/MM/yyyy";
            DtpHasta.DropDownAlign = LeftRightAlignment.Right;
            DtpHasta.Format = DateTimePickerFormat.Custom;
            DtpHasta.Location = new Point(339, 87);
            DtpHasta.Margin = new Padding(3, 2, 3, 2);
            DtpHasta.Name = "DtpHasta";
            DtpHasta.Size = new Size(140, 23);
            DtpHasta.TabIndex = 6;

            // =====================================================================
            //  PESTAÑA: VENTAS
            // =====================================================================
            // 
            // ReporteVentas
            // 
            ReporteVentas.Controls.Add(CardVentas);
            ReporteVentas.Location = new Point(4, 29);
            ReporteVentas.Margin = new Padding(0);
            ReporteVentas.Name = "ReporteVentas";
            ReporteVentas.Size = new Size(1015, 505);
            ReporteVentas.TabIndex = 0;
            ReporteVentas.Text = "Reporte de Ventas";
            ReporteVentas.UseVisualStyleBackColor = true;
            // 
            // CardVentas (contenedor simple, sin sombra)
            // 
            CardVentas.BackColor = Color.White;
            CardVentas.Controls.Add(TablaVentas);
            CardVentas.Dock = DockStyle.Fill;
            CardVentas.Name = "CardVentas";
            CardVentas.Padding = new Padding(6);
            CardVentas.TabIndex = 0;
            // 
            // TablaVentas (datos a la izquierda, gráfico a la derecha)
            // 
            TablaVentas.ColumnCount = 2;
            TablaVentas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            TablaVentas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            TablaVentas.Controls.Add(CardDatosVenta, 0, 0);
            TablaVentas.Controls.Add(CardGraficoVentas, 1, 0);
            TablaVentas.Dock = DockStyle.Fill;
            TablaVentas.Name = "TablaVentas";
            TablaVentas.RowCount = 1;
            TablaVentas.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TablaVentas.TabIndex = 0;
            // 
            // CardDatosVenta
            // 
            CardDatosVenta.BackColor = Color.White;
            CardDatosVenta.Controls.Add(PanelInfoVentas);
            CardDatosVenta.Depth = 0;
            CardDatosVenta.Dock = DockStyle.Fill;
            CardDatosVenta.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CardDatosVenta.Margin = new Padding(8);
            CardDatosVenta.MouseState = MouseState.HOVER;
            CardDatosVenta.Name = "CardDatosVenta";
            CardDatosVenta.Padding = new Padding(14);
            CardDatosVenta.TabIndex = 0;
            // 
            // PanelInfoVentas
            // 
            PanelInfoVentas.AutoScroll = true;
            PanelInfoVentas.BackColor = Color.White;
            PanelInfoVentas.Controls.Add(TablaInfoVentas);
            PanelInfoVentas.Dock = DockStyle.Fill;
            PanelInfoVentas.Name = "PanelInfoVentas";
            PanelInfoVentas.Padding = new Padding(6);
            PanelInfoVentas.TabIndex = 0;
            // 
            // TablaInfoVentas (reemplaza las posiciones X/Y fijas)
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
            TablaInfoVentas.Name = "TablaInfoVentas";
            TablaInfoVentas.RowCount = 12;
            TablaInfoVentas.TabIndex = 0;
            // 
            // Encabezados de sección (Ventas)
            // 
            LabelDesempenio.Anchor = AnchorStyles.Left;
            LabelDesempenio.AutoSize = true;
            LabelDesempenio.FontType = MaterialSkinManager.fontType.H6;
            LabelDesempenio.Margin = new Padding(3, 3, 3, 8);
            LabelDesempenio.Name = "LabelDesempenio";
            LabelDesempenio.Text = "Desempeño Financiero";
            TablaInfoVentas.SetColumnSpan(LabelDesempenio, 2);

            LabelRendimientoVendedores.Anchor = AnchorStyles.Left;
            LabelRendimientoVendedores.AutoSize = true;
            LabelRendimientoVendedores.FontType = MaterialSkinManager.fontType.H6;
            LabelRendimientoVendedores.Margin = new Padding(3, 18, 3, 8);
            LabelRendimientoVendedores.Name = "LabelRendimientoVendedores";
            LabelRendimientoVendedores.Text = "Rendimiento de Vendedores";
            TablaInfoVentas.SetColumnSpan(LabelRendimientoVendedores, 2);

            LabelDesempenioVentas.Anchor = AnchorStyles.Left;
            LabelDesempenioVentas.AutoSize = true;
            LabelDesempenioVentas.FontType = MaterialSkinManager.fontType.H6;
            LabelDesempenioVentas.Margin = new Padding(3, 18, 3, 8);
            LabelDesempenioVentas.Name = "LabelDesempenioVentas";
            LabelDesempenioVentas.Text = "Desempeño Temporal";
            TablaInfoVentas.SetColumnSpan(LabelDesempenioVentas, 2);
            // 
            // Métricas (Ventas): título + valor
            // 
            LabelCantidadVentasTitulo.Anchor = AnchorStyles.Left;
            LabelCantidadVentasTitulo.AutoSize = true;
            LabelCantidadVentasTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelCantidadVentasTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelCantidadVentasTitulo.Name = "LabelCantidadVentasTitulo";
            LabelCantidadVentasTitulo.Text = "Cantidad de Ventas:";

            LabelCantidadVentasValor.Anchor = AnchorStyles.Left;
            LabelCantidadVentasValor.AutoSize = true;
            LabelCantidadVentasValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelCantidadVentasValor.Margin = new Padding(3, 5, 3, 5);
            LabelCantidadVentasValor.Name = "LabelCantidadVentasValor";
            LabelCantidadVentasValor.Text = "--";

            LabelTotalFacturadoTitulo.Anchor = AnchorStyles.Left;
            LabelTotalFacturadoTitulo.AutoSize = true;
            LabelTotalFacturadoTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelTotalFacturadoTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelTotalFacturadoTitulo.Name = "LabelTotalFacturadoTitulo";
            LabelTotalFacturadoTitulo.Text = "Total Facturado:";

            LabelTotalFacturadoValor.Anchor = AnchorStyles.Left;
            LabelTotalFacturadoValor.AutoSize = true;
            LabelTotalFacturadoValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelTotalFacturadoValor.Margin = new Padding(3, 5, 3, 5);
            LabelTotalFacturadoValor.Name = "LabelTotalFacturadoValor";
            LabelTotalFacturadoValor.Text = "--";

            LabelFacturaPromedioTitulo.Anchor = AnchorStyles.Left;
            LabelFacturaPromedioTitulo.AutoSize = true;
            LabelFacturaPromedioTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelFacturaPromedioTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelFacturaPromedioTitulo.Name = "LabelFacturaPromedioTitulo";
            LabelFacturaPromedioTitulo.Text = "Promedio Facturado por vendedor:";

            LabelFacturaPromedioValor.Anchor = AnchorStyles.Left;
            LabelFacturaPromedioValor.AutoSize = true;
            LabelFacturaPromedioValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelFacturaPromedioValor.Margin = new Padding(3, 5, 3, 5);
            LabelFacturaPromedioValor.Name = "LabelFacturaPromedioValor";
            LabelFacturaPromedioValor.Text = "--";

            LabelMargenGanaciasTitulo.Anchor = AnchorStyles.Left;
            LabelMargenGanaciasTitulo.AutoSize = true;
            LabelMargenGanaciasTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelMargenGanaciasTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelMargenGanaciasTitulo.Name = "LabelMargenGanaciasTitulo";
            LabelMargenGanaciasTitulo.Text = "Margen de Ganancias total:";

            LabelMargenGanaciasValor.Anchor = AnchorStyles.Left;
            LabelMargenGanaciasValor.AutoSize = true;
            LabelMargenGanaciasValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelMargenGanaciasValor.Margin = new Padding(3, 5, 3, 5);
            LabelMargenGanaciasValor.Name = "LabelMargenGanaciasValor";
            LabelMargenGanaciasValor.Text = "--";

            LabelVendedorEstrellaTitulo.Anchor = AnchorStyles.Left;
            LabelVendedorEstrellaTitulo.AutoSize = true;
            LabelVendedorEstrellaTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelVendedorEstrellaTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelVendedorEstrellaTitulo.Name = "LabelVendedorEstrellaTitulo";
            LabelVendedorEstrellaTitulo.Text = "Vendedor Estrella:";

            LabelVendedorEstrellaValor.Anchor = AnchorStyles.Left;
            LabelVendedorEstrellaValor.AutoSize = true;
            LabelVendedorEstrellaValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelVendedorEstrellaValor.Margin = new Padding(3, 5, 3, 5);
            LabelVendedorEstrellaValor.Name = "LabelVendedorEstrellaValor";
            LabelVendedorEstrellaValor.Text = "--";

            LabelMasOperacionesTitulo.Anchor = AnchorStyles.Left;
            LabelMasOperacionesTitulo.AutoSize = true;
            LabelMasOperacionesTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelMasOperacionesTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelMasOperacionesTitulo.Name = "LabelMasOperacionesTitulo";
            LabelMasOperacionesTitulo.Text = "Vendedor con más operaciones:";

            LabelMasOperacionesValor.Anchor = AnchorStyles.Left;
            LabelMasOperacionesValor.AutoSize = true;
            LabelMasOperacionesValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelMasOperacionesValor.Margin = new Padding(3, 5, 3, 5);
            LabelMasOperacionesValor.Name = "LabelMasOperacionesValor";
            LabelMasOperacionesValor.Text = "--";

            LabelFechaPicoTitulo.Anchor = AnchorStyles.Left;
            LabelFechaPicoTitulo.AutoSize = true;
            LabelFechaPicoTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelFechaPicoTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelFechaPicoTitulo.Name = "LabelFechaPicoTitulo";
            LabelFechaPicoTitulo.Text = "Fecha pico de ventas:";

            LabelFechaPicoValor.Anchor = AnchorStyles.Left;
            LabelFechaPicoValor.AutoSize = true;
            LabelFechaPicoValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelFechaPicoValor.Margin = new Padding(3, 5, 3, 5);
            LabelFechaPicoValor.Name = "LabelFechaPicoValor";
            LabelFechaPicoValor.Text = "--";

            LabelDiaMasVentasTitulo.Anchor = AnchorStyles.Left;
            LabelDiaMasVentasTitulo.AutoSize = true;
            LabelDiaMasVentasTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelDiaMasVentasTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelDiaMasVentasTitulo.Name = "LabelDiaMasVentasTitulo";
            LabelDiaMasVentasTitulo.Text = "Día con más ventas:";

            LabelDiaMasVentasValor.Anchor = AnchorStyles.Left;
            LabelDiaMasVentasValor.AutoSize = true;
            LabelDiaMasVentasValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelDiaMasVentasValor.Margin = new Padding(3, 5, 3, 5);
            LabelDiaMasVentasValor.Name = "LabelDiaMasVentasValor";
            LabelDiaMasVentasValor.Text = "--";

            LabelHoraPicoTitulo.Anchor = AnchorStyles.Left;
            LabelHoraPicoTitulo.AutoSize = true;
            LabelHoraPicoTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelHoraPicoTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelHoraPicoTitulo.Name = "LabelHoraPicoTitulo";
            LabelHoraPicoTitulo.Text = "Hora pico de ventas:";

            LabelHoraPicoValor.Anchor = AnchorStyles.Left;
            LabelHoraPicoValor.AutoSize = true;
            LabelHoraPicoValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelHoraPicoValor.Margin = new Padding(3, 5, 3, 5);
            LabelHoraPicoValor.Name = "LabelHoraPicoValor";
            LabelHoraPicoValor.Text = "--";
            // 
            // CardGraficoVentas
            // 
            CardGraficoVentas.BackColor = Color.White;
            CardGraficoVentas.Controls.Add(chartVentas);
            CardGraficoVentas.Depth = 0;
            CardGraficoVentas.Dock = DockStyle.Fill;
            CardGraficoVentas.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CardGraficoVentas.Margin = new Padding(8);
            CardGraficoVentas.MouseState = MouseState.HOVER;
            CardGraficoVentas.Name = "CardGraficoVentas";
            CardGraficoVentas.Padding = new Padding(14);
            CardGraficoVentas.TabIndex = 1;
            // 
            // chartVentas
            // 
            chartVentas.BackColor = Color.White;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.Title = "Nombre de vendedores";
            chartArea1.AxisX.TitleFont = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            chartArea1.AxisX2.Enabled = Charting.AxisEnabled.False;
            chartArea1.AxisY.Enabled = Charting.AxisEnabled.False;
            chartArea1.Name = "ChartArea1";
            chartVentas.ChartAreas.Add(chartArea1);
            chartVentas.Dock = DockStyle.Fill;
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
            chartVentas.TabIndex = 0;
            chartVentas.Text = "chartVentas";
            title1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title1.Name = "TituloVentas";
            title1.Text = "Facturación por Vendedor ( $ )";
            chartVentas.Titles.Add(title1);

            // =====================================================================
            //  PESTAÑA: CLIENTES
            // =====================================================================
            // 
            // ReporteClientes
            // 
            ReporteClientes.Controls.Add(CardClientes);
            ReporteClientes.Location = new Point(4, 29);
            ReporteClientes.Margin = new Padding(0);
            ReporteClientes.Name = "ReporteClientes";
            ReporteClientes.Size = new Size(1015, 505);
            ReporteClientes.TabIndex = 1;
            ReporteClientes.Text = "Reporte de Clientes";
            ReporteClientes.UseVisualStyleBackColor = true;
            // 
            // CardClientes
            // 
            CardClientes.BackColor = Color.White;
            CardClientes.Controls.Add(TablaClientes);
            CardClientes.Dock = DockStyle.Fill;
            CardClientes.Name = "CardClientes";
            CardClientes.Padding = new Padding(6);
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
            TablaClientes.Name = "TablaClientes";
            TablaClientes.RowCount = 1;
            TablaClientes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TablaClientes.TabIndex = 0;
            // 
            // CardDatosClientes
            // 
            CardDatosClientes.BackColor = Color.White;
            CardDatosClientes.Controls.Add(PanelInfoClientes);
            CardDatosClientes.Depth = 0;
            CardDatosClientes.Dock = DockStyle.Fill;
            CardDatosClientes.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CardDatosClientes.Margin = new Padding(8);
            CardDatosClientes.MouseState = MouseState.HOVER;
            CardDatosClientes.Name = "CardDatosClientes";
            CardDatosClientes.Padding = new Padding(14);
            CardDatosClientes.TabIndex = 0;
            // 
            // PanelInfoClientes
            // 
            PanelInfoClientes.AutoScroll = true;
            PanelInfoClientes.BackColor = Color.White;
            PanelInfoClientes.Controls.Add(TablaInfoClientes);
            PanelInfoClientes.Dock = DockStyle.Fill;
            PanelInfoClientes.Name = "PanelInfoClientes";
            PanelInfoClientes.Padding = new Padding(6);
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
            TablaInfoClientes.Name = "TablaInfoClientes";
            TablaInfoClientes.RowCount = 11;
            TablaInfoClientes.TabIndex = 0;
            // 
            // Encabezados de sección (Clientes)
            // 
            LabelDesempenioCliente.Anchor = AnchorStyles.Left;
            LabelDesempenioCliente.AutoSize = true;
            LabelDesempenioCliente.FontType = MaterialSkinManager.fontType.H6;
            LabelDesempenioCliente.Margin = new Padding(3, 3, 3, 8);
            LabelDesempenioCliente.Name = "LabelDesempenioCliente";
            LabelDesempenioCliente.Text = "Desempeño de Clientes";
            TablaInfoClientes.SetColumnSpan(LabelDesempenioCliente, 2);

            materialLabel1.Anchor = AnchorStyles.Left;
            materialLabel1.AutoSize = true;
            materialLabel1.FontType = MaterialSkinManager.fontType.H6;
            materialLabel1.Margin = new Padding(3, 18, 3, 8);
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Text = "Métricas de Recurrencia";
            TablaInfoClientes.SetColumnSpan(materialLabel1, 2);

            materialLabel2.Anchor = AnchorStyles.Left;
            materialLabel2.AutoSize = true;
            materialLabel2.FontType = MaterialSkinManager.fontType.H6;
            materialLabel2.Margin = new Padding(3, 18, 3, 8);
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Text = "Promedio Comercial";
            TablaInfoClientes.SetColumnSpan(materialLabel2, 2);
            // 
            // Métricas (Clientes): título + valor
            // 
            LabelClientesActivosTitulo.Anchor = AnchorStyles.Left;
            LabelClientesActivosTitulo.AutoSize = true;
            LabelClientesActivosTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelClientesActivosTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelClientesActivosTitulo.Name = "LabelClientesActivosTitulo";
            LabelClientesActivosTitulo.Text = "Total de Clientes activos:";

            LabelClientesActivosValor.Anchor = AnchorStyles.Left;
            LabelClientesActivosValor.AutoSize = true;
            LabelClientesActivosValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelClientesActivosValor.Margin = new Padding(3, 5, 3, 5);
            LabelClientesActivosValor.Name = "LabelClientesActivosValor";
            LabelClientesActivosValor.Text = "--";

            LabelClientesNuevosTitulo.Anchor = AnchorStyles.Left;
            LabelClientesNuevosTitulo.AutoSize = true;
            LabelClientesNuevosTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelClientesNuevosTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelClientesNuevosTitulo.Name = "LabelClientesNuevosTitulo";
            LabelClientesNuevosTitulo.Text = "Clientes Nuevos:";

            LabelClientesNuevosValor.Anchor = AnchorStyles.Left;
            LabelClientesNuevosValor.AutoSize = true;
            LabelClientesNuevosValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelClientesNuevosValor.Margin = new Padding(3, 5, 3, 5);
            LabelClientesNuevosValor.Name = "LabelClientesNuevosValor";
            LabelClientesNuevosValor.Text = "--";

            LabelClienteEstrellaTitulo.Anchor = AnchorStyles.Left;
            LabelClienteEstrellaTitulo.AutoSize = true;
            LabelClienteEstrellaTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelClienteEstrellaTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelClienteEstrellaTitulo.Name = "LabelClienteEstrellaTitulo";
            LabelClienteEstrellaTitulo.Text = "Cliente Estrella:";

            LabelClienteEstrellaValor.Anchor = AnchorStyles.Left;
            LabelClienteEstrellaValor.AutoSize = true;
            LabelClienteEstrellaValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelClienteEstrellaValor.Margin = new Padding(3, 5, 3, 5);
            LabelClienteEstrellaValor.Name = "LabelClienteEstrellaValor";
            LabelClienteEstrellaValor.Text = "--";

            LabelClientesRecurrentesTitulo.Anchor = AnchorStyles.Left;
            LabelClientesRecurrentesTitulo.AutoSize = true;
            LabelClientesRecurrentesTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelClientesRecurrentesTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelClientesRecurrentesTitulo.Name = "LabelClientesRecurrentesTitulo";
            LabelClientesRecurrentesTitulo.Text = "Cantidad de Clientes Recurrentes:";

            LabelClientesRecurrentesValor.Anchor = AnchorStyles.Left;
            LabelClientesRecurrentesValor.AutoSize = true;
            LabelClientesRecurrentesValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelClientesRecurrentesValor.Margin = new Padding(3, 5, 3, 5);
            LabelClientesRecurrentesValor.Name = "LabelClientesRecurrentesValor";
            LabelClientesRecurrentesValor.Text = "--";

            LabelPorcentajeRecurrenciaTitulo.Anchor = AnchorStyles.Left;
            LabelPorcentajeRecurrenciaTitulo.AutoSize = true;
            LabelPorcentajeRecurrenciaTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelPorcentajeRecurrenciaTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelPorcentajeRecurrenciaTitulo.Name = "LabelPorcentajeRecurrenciaTitulo";
            LabelPorcentajeRecurrenciaTitulo.Text = "Porcentaje de Recurrencia:";

            LabelPorcentajeRecurrenciaValor.Anchor = AnchorStyles.Left;
            LabelPorcentajeRecurrenciaValor.AutoSize = true;
            LabelPorcentajeRecurrenciaValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelPorcentajeRecurrenciaValor.Margin = new Padding(3, 5, 3, 5);
            LabelPorcentajeRecurrenciaValor.Name = "LabelPorcentajeRecurrenciaValor";
            LabelPorcentajeRecurrenciaValor.Text = "--";

            LabelPromGastoClienteTitulo.Anchor = AnchorStyles.Left;
            LabelPromGastoClienteTitulo.AutoSize = true;
            LabelPromGastoClienteTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelPromGastoClienteTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelPromGastoClienteTitulo.Name = "LabelPromGastoClienteTitulo";
            LabelPromGastoClienteTitulo.Text = "Facturación por Clientes Registrados:";

            LabelPromGastoClienteValor.Anchor = AnchorStyles.Left;
            LabelPromGastoClienteValor.AutoSize = true;
            LabelPromGastoClienteValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelPromGastoClienteValor.Margin = new Padding(3, 5, 3, 5);
            LabelPromGastoClienteValor.Name = "LabelPromGastoClienteValor";
            LabelPromGastoClienteValor.Text = "--";

            LabelPromedioComprasClientesTitulo.Anchor = AnchorStyles.Left;
            LabelPromedioComprasClientesTitulo.AutoSize = true;
            LabelPromedioComprasClientesTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelPromedioComprasClientesTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelPromedioComprasClientesTitulo.Name = "LabelPromedioComprasClientesTitulo";
            LabelPromedioComprasClientesTitulo.Text = "Promedio de Compras por Clientes:";

            LabelPromedioComprasClientesValor.Anchor = AnchorStyles.Left;
            LabelPromedioComprasClientesValor.AutoSize = true;
            LabelPromedioComprasClientesValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelPromedioComprasClientesValor.Margin = new Padding(3, 5, 3, 5);
            LabelPromedioComprasClientesValor.Name = "LabelPromedioComprasClientesValor";
            LabelPromedioComprasClientesValor.Text = "--";

            LabelClientesUnicosTitulo.Anchor = AnchorStyles.Left;
            LabelClientesUnicosTitulo.AutoSize = true;
            LabelClientesUnicosTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelClientesUnicosTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelClientesUnicosTitulo.Name = "LabelClientesUnicosTitulo";
            LabelClientesUnicosTitulo.Text = "Clientes compradores únicos:";

            LabelClientesUnicosValor.Anchor = AnchorStyles.Left;
            LabelClientesUnicosValor.AutoSize = true;
            LabelClientesUnicosValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelClientesUnicosValor.Margin = new Padding(3, 5, 3, 5);
            LabelClientesUnicosValor.Name = "LabelClientesUnicosValor";
            LabelClientesUnicosValor.Text = "--";
            // 
            // CardGraficoClientes
            // 
            CardGraficoClientes.BackColor = Color.White;
            CardGraficoClientes.Controls.Add(chartClientes);
            CardGraficoClientes.Depth = 0;
            CardGraficoClientes.Dock = DockStyle.Fill;
            CardGraficoClientes.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CardGraficoClientes.Margin = new Padding(8);
            CardGraficoClientes.MouseState = MouseState.HOVER;
            CardGraficoClientes.Name = "CardGraficoClientes";
            CardGraficoClientes.Padding = new Padding(14);
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
            chartClientes.Name = "chartClientes";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = Charting.SeriesChartType.Pie;
            series2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            series2.Legend = "Legend1";
            series2.Name = "DistribucionClientes";
            chartClientes.Series.Add(series2);
            chartClientes.TabIndex = 0;
            chartClientes.Text = "chartClientes";
            title2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title2.Name = "TituloClientes";
            title2.Text = "Distribución por Comportamiento";
            chartClientes.Titles.Add(title2);

            // =====================================================================
            //  PESTAÑA: PRODUCTOS
            // =====================================================================
            // 
            // ReporteProductos
            // 
            ReporteProductos.Controls.Add(CardProductos);
            ReporteProductos.Location = new Point(4, 29);
            ReporteProductos.Margin = new Padding(0);
            ReporteProductos.Name = "ReporteProductos";
            ReporteProductos.Size = new Size(1015, 505);
            ReporteProductos.TabIndex = 2;
            ReporteProductos.Text = "Reporte de Productos";
            ReporteProductos.UseVisualStyleBackColor = true;
            // 
            // CardProductos
            // 
            CardProductos.BackColor = Color.White;
            CardProductos.Controls.Add(TablaProductos);
            CardProductos.Dock = DockStyle.Fill;
            CardProductos.Name = "CardProductos";
            CardProductos.Padding = new Padding(6);
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
            TablaProductos.Name = "TablaProductos";
            TablaProductos.RowCount = 1;
            TablaProductos.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TablaProductos.TabIndex = 0;
            // 
            // CardDatosProductos
            // 
            CardDatosProductos.BackColor = Color.White;
            CardDatosProductos.Controls.Add(PanelInfoProductos);
            CardDatosProductos.Depth = 0;
            CardDatosProductos.Dock = DockStyle.Fill;
            CardDatosProductos.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CardDatosProductos.Margin = new Padding(8);
            CardDatosProductos.MouseState = MouseState.HOVER;
            CardDatosProductos.Name = "CardDatosProductos";
            CardDatosProductos.Padding = new Padding(14);
            CardDatosProductos.TabIndex = 0;
            // 
            // PanelInfoProductos
            // 
            PanelInfoProductos.AutoScroll = true;
            PanelInfoProductos.BackColor = Color.White;
            PanelInfoProductos.Controls.Add(TablaInfoProductos);
            PanelInfoProductos.Dock = DockStyle.Fill;
            PanelInfoProductos.Name = "PanelInfoProductos";
            PanelInfoProductos.Padding = new Padding(6);
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
            TablaInfoProductos.Name = "TablaInfoProductos";
            TablaInfoProductos.RowCount = 11;
            TablaInfoProductos.TabIndex = 0;
            // 
            // Encabezados de sección (Productos)
            // 
            LabelValorizacionInventario.Anchor = AnchorStyles.Left;
            LabelValorizacionInventario.AutoSize = true;
            LabelValorizacionInventario.FontType = MaterialSkinManager.fontType.H6;
            LabelValorizacionInventario.Margin = new Padding(3, 3, 3, 8);
            LabelValorizacionInventario.Name = "LabelValorizacionInventario";
            LabelValorizacionInventario.Text = "Valorización de Inventario";
            TablaInfoProductos.SetColumnSpan(LabelValorizacionInventario, 2);

            LabelControlStock.Anchor = AnchorStyles.Left;
            LabelControlStock.AutoSize = true;
            LabelControlStock.FontType = MaterialSkinManager.fontType.H6;
            LabelControlStock.Margin = new Padding(3, 18, 3, 8);
            LabelControlStock.Name = "LabelControlStock";
            LabelControlStock.Text = "Control de Stock";
            TablaInfoProductos.SetColumnSpan(LabelControlStock, 2);

            LabelRendimiento.Anchor = AnchorStyles.Left;
            LabelRendimiento.AutoSize = true;
            LabelRendimiento.FontType = MaterialSkinManager.fontType.H6;
            LabelRendimiento.Margin = new Padding(3, 18, 3, 8);
            LabelRendimiento.Name = "LabelRendimiento";
            LabelRendimiento.Text = "Rendimiento y Rotación";
            TablaInfoProductos.SetColumnSpan(LabelRendimiento, 2);
            // 
            // Métricas (Productos): título + valor
            // 
            LabelValorInventarioTitulo.Anchor = AnchorStyles.Left;
            LabelValorInventarioTitulo.AutoSize = true;
            LabelValorInventarioTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelValorInventarioTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelValorInventarioTitulo.Name = "LabelValorInventarioTitulo";
            LabelValorInventarioTitulo.Text = "Valor total del Inventario:";

            LabelValorInventarioValor.Anchor = AnchorStyles.Left;
            LabelValorInventarioValor.AutoSize = true;
            LabelValorInventarioValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelValorInventarioValor.Margin = new Padding(3, 5, 3, 5);
            LabelValorInventarioValor.Name = "LabelValorInventarioValor";
            LabelValorInventarioValor.Text = "--";

            LabelProductosActivosTitulo.Anchor = AnchorStyles.Left;
            LabelProductosActivosTitulo.AutoSize = true;
            LabelProductosActivosTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelProductosActivosTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelProductosActivosTitulo.Name = "LabelProductosActivosTitulo";
            LabelProductosActivosTitulo.Text = "Total de Productos Activos:";

            LabelProductosActivosValor.Anchor = AnchorStyles.Left;
            LabelProductosActivosValor.AutoSize = true;
            LabelProductosActivosValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelProductosActivosValor.Margin = new Padding(3, 5, 3, 5);
            LabelProductosActivosValor.Name = "LabelProductosActivosValor";
            LabelProductosActivosValor.Text = "--";

            LabelStockCriticoTitulo.Anchor = AnchorStyles.Left;
            LabelStockCriticoTitulo.AutoSize = true;
            LabelStockCriticoTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelStockCriticoTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelStockCriticoTitulo.Name = "LabelStockCriticoTitulo";
            LabelStockCriticoTitulo.Text = "Productos en Stock Crítico:";

            LabelStockCriticoValor.Anchor = AnchorStyles.Left;
            LabelStockCriticoValor.AutoSize = true;
            LabelStockCriticoValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelStockCriticoValor.Margin = new Padding(3, 5, 3, 5);
            LabelStockCriticoValor.Name = "LabelStockCriticoValor";
            LabelStockCriticoValor.Text = "--";

            LabelPorductosAgotadosTitulo.Anchor = AnchorStyles.Left;
            LabelPorductosAgotadosTitulo.AutoSize = true;
            LabelPorductosAgotadosTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelPorductosAgotadosTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelPorductosAgotadosTitulo.Name = "LabelPorductosAgotadosTitulo";
            LabelPorductosAgotadosTitulo.Text = "Productos Agotados:";

            LabelPorductosAgotadosValor.Anchor = AnchorStyles.Left;
            LabelPorductosAgotadosValor.AutoSize = true;
            LabelPorductosAgotadosValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelPorductosAgotadosValor.Margin = new Padding(3, 5, 3, 5);
            LabelPorductosAgotadosValor.Name = "LabelPorductosAgotadosValor";
            LabelPorductosAgotadosValor.Text = "--";

            LabelStockOptimoTitulo.Anchor = AnchorStyles.Left;
            LabelStockOptimoTitulo.AutoSize = true;
            LabelStockOptimoTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelStockOptimoTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelStockOptimoTitulo.Name = "LabelStockOptimoTitulo";
            LabelStockOptimoTitulo.Text = "Porcentaje de Stock Óptimo:";

            LabelStockOptimoValor.Anchor = AnchorStyles.Left;
            LabelStockOptimoValor.AutoSize = true;
            LabelStockOptimoValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelStockOptimoValor.Margin = new Padding(3, 5, 3, 5);
            LabelStockOptimoValor.Name = "LabelStockOptimoValor";
            LabelStockOptimoValor.Text = "--";

            LabelProductoEstrellaTitulo.Anchor = AnchorStyles.Left;
            LabelProductoEstrellaTitulo.AutoSize = true;
            LabelProductoEstrellaTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelProductoEstrellaTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelProductoEstrellaTitulo.Name = "LabelProductoEstrellaTitulo";
            LabelProductoEstrellaTitulo.Text = "Producto Estrella:";

            LabelProductoEstrellaValor.Anchor = AnchorStyles.Left;
            LabelProductoEstrellaValor.AutoSize = true;
            LabelProductoEstrellaValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelProductoEstrellaValor.Margin = new Padding(3, 5, 3, 5);
            LabelProductoEstrellaValor.Name = "LabelProductoEstrellaValor";
            LabelProductoEstrellaValor.Text = "--";

            LabelCategoriaEstrellaTitulo.Anchor = AnchorStyles.Left;
            LabelCategoriaEstrellaTitulo.AutoSize = true;
            LabelCategoriaEstrellaTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelCategoriaEstrellaTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelCategoriaEstrellaTitulo.Name = "LabelCategoriaEstrellaTitulo";
            LabelCategoriaEstrellaTitulo.Text = "Categoría Estrella:";

            LabelCategoriaEstrellaValor.Anchor = AnchorStyles.Left;
            LabelCategoriaEstrellaValor.AutoSize = true;
            LabelCategoriaEstrellaValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelCategoriaEstrellaValor.Margin = new Padding(3, 5, 3, 5);
            LabelCategoriaEstrellaValor.Name = "LabelCategoriaEstrellaValor";
            LabelCategoriaEstrellaValor.Text = "--";

            LabelPromedioVendidoTitulo.Anchor = AnchorStyles.Left;
            LabelPromedioVendidoTitulo.AutoSize = true;
            LabelPromedioVendidoTitulo.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelPromedioVendidoTitulo.Margin = new Padding(3, 5, 8, 5);
            LabelPromedioVendidoTitulo.Name = "LabelPromedioVendidoTitulo";
            LabelPromedioVendidoTitulo.Text = "Promedio de Unidades Vendidas:";

            LabelPromedioVendidoValor.Anchor = AnchorStyles.Left;
            LabelPromedioVendidoValor.AutoSize = true;
            LabelPromedioVendidoValor.FontType = MaterialSkinManager.fontType.Subtitle1;
            LabelPromedioVendidoValor.Margin = new Padding(3, 5, 3, 5);
            LabelPromedioVendidoValor.Name = "LabelPromedioVendidoValor";
            LabelPromedioVendidoValor.Text = "--";
            // 
            // materialCard2 (tarjeta del gráfico de productos)
            // 
            materialCard2.BackColor = Color.White;
            materialCard2.Controls.Add(chartProductos);
            materialCard2.Depth = 0;
            materialCard2.Dock = DockStyle.Fill;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Margin = new Padding(8);
            materialCard2.MouseState = MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.TabIndex = 1;
            // 
            // chartProductos
            // 
            chartProductos.BackColor = Color.White;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.MajorTickMark.Enabled = false;
            chartArea3.AxisY.Enabled = Charting.AxisEnabled.False;
            chartArea3.Name = "ChartArea1";
            chartProductos.ChartAreas.Add(chartArea3);
            chartProductos.Dock = DockStyle.Fill;
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
            chartProductos.TabIndex = 0;
            chartProductos.Text = "chartProductos";
            title3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title3.Name = "TituloProductos";
            title3.Text = "Top 5 Productos Más Vendidos";
            chartProductos.Titles.Add(title3);
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1041, 709);
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
            TablaVentas.ResumeLayout(false);
            CardGraficoVentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartVentas).EndInit();
            CardDatosVenta.ResumeLayout(false);
            PanelInfoVentas.ResumeLayout(false);
            PanelInfoVentas.PerformLayout();
            TablaInfoVentas.ResumeLayout(false);
            TablaInfoVentas.PerformLayout();
            ReporteClientes.ResumeLayout(false);
            CardClientes.ResumeLayout(false);
            TablaClientes.ResumeLayout(false);
            CardGraficoClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartClientes).EndInit();
            CardDatosClientes.ResumeLayout(false);
            PanelInfoClientes.ResumeLayout(false);
            PanelInfoClientes.PerformLayout();
            TablaInfoClientes.ResumeLayout(false);
            TablaInfoClientes.PerformLayout();
            ReporteProductos.ResumeLayout(false);
            CardProductos.ResumeLayout(false);
            TablaProductos.ResumeLayout(false);
            materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartProductos).EndInit();
            CardDatosProductos.ResumeLayout(false);
            PanelInfoProductos.ResumeLayout(false);
            PanelInfoProductos.PerformLayout();
            TablaInfoProductos.ResumeLayout(false);
            TablaInfoProductos.PerformLayout();
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