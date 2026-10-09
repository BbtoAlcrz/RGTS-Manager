namespace RGTS.Interfaz.Vendedor
{
    partial class FormDetalleVenta
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
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            listViewProductos = new MaterialSkin.Controls.MaterialListView();
            BtnExportarPDF = new MaterialSkin.Controls.MaterialButton();
            labelDetalleProductosTitulo = new MaterialSkin.Controls.MaterialLabel();
            labelTotalVentaValor = new MaterialSkin.Controls.MaterialLabel();
            labelTotalVentaTitulo = new MaterialSkin.Controls.MaterialLabel();
            labelClienteValor = new MaterialSkin.Controls.MaterialLabel();
            labelClienteTitulo = new MaterialSkin.Controls.MaterialLabel();
            labelVendedorValor = new MaterialSkin.Controls.MaterialLabel();
            labelVendedorTitulo = new MaterialSkin.Controls.MaterialLabel();
            labelFechaVentaValor = new MaterialSkin.Controls.MaterialLabel();
            labelFechaVentaTitulo = new MaterialSkin.Controls.MaterialLabel();
            labelNroVentaValor = new MaterialSkin.Controls.MaterialLabel();
            labelNroVentaTitulo = new MaterialSkin.Controls.MaterialLabel();
            btnVolver = new MaterialSkin.Controls.MaterialButton();
            labelTitulo = new MaterialSkin.Controls.MaterialLabel();
            nombre = new ColumnHeader();
            precioUnitario = new ColumnHeader();
            cantidad = new ColumnHeader();
            subtotal = new ColumnHeader();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(listViewProductos);
            materialCard1.Controls.Add(BtnExportarPDF);
            materialCard1.Controls.Add(labelDetalleProductosTitulo);
            materialCard1.Controls.Add(labelTotalVentaValor);
            materialCard1.Controls.Add(labelTotalVentaTitulo);
            materialCard1.Controls.Add(labelClienteValor);
            materialCard1.Controls.Add(labelClienteTitulo);
            materialCard1.Controls.Add(labelVendedorValor);
            materialCard1.Controls.Add(labelVendedorTitulo);
            materialCard1.Controls.Add(labelFechaVentaValor);
            materialCard1.Controls.Add(labelFechaVentaTitulo);
            materialCard1.Controls.Add(labelNroVentaValor);
            materialCard1.Controls.Add(labelNroVentaTitulo);
            materialCard1.Controls.Add(btnVolver);
            materialCard1.Controls.Add(labelTitulo);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Fill;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(0, 0);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(925, 530);
            materialCard1.TabIndex = 0;
            // 
            // listViewProductos
            // 
            listViewProductos.AutoSizeTable = false;
            listViewProductos.BackColor = Color.FromArgb(255, 255, 255);
            listViewProductos.BorderStyle = BorderStyle.None;
            listViewProductos.Columns.AddRange(new ColumnHeader[] { nombre, cantidad, precioUnitario, subtotal });
            listViewProductos.Depth = 0;
            listViewProductos.FullRowSelect = true;
            listViewProductos.Location = new Point(394, 82);
            listViewProductos.MinimumSize = new Size(200, 100);
            listViewProductos.MouseLocation = new Point(-1, -1);
            listViewProductos.MouseState = MaterialSkin.MouseState.OUT;
            listViewProductos.Name = "listViewProductos";
            listViewProductos.OwnerDraw = true;
            listViewProductos.Size = new Size(514, 433);
            listViewProductos.TabIndex = 53;
            listViewProductos.UseCompatibleStateImageBehavior = false;
            listViewProductos.View = View.Details;
            // 
            // BtnExportarPDF
            // 
            BtnExportarPDF.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnExportarPDF.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnExportarPDF.Cursor = Cursors.Hand;
            BtnExportarPDF.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnExportarPDF.Depth = 0;
            BtnExportarPDF.HighEmphasis = true;
            BtnExportarPDF.Icon = Properties.Resources.confirmar;
            BtnExportarPDF.Location = new Point(151, 479);
            BtnExportarPDF.Margin = new Padding(4, 6, 4, 6);
            BtnExportarPDF.MouseState = MaterialSkin.MouseState.HOVER;
            BtnExportarPDF.Name = "BtnExportarPDF";
            BtnExportarPDF.NoAccentTextColor = Color.Empty;
            BtnExportarPDF.Size = new Size(154, 36);
            BtnExportarPDF.TabIndex = 52;
            BtnExportarPDF.Text = "Exportar PDF";
            BtnExportarPDF.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnExportarPDF.UseAccentColor = false;
            BtnExportarPDF.UseVisualStyleBackColor = true;
            BtnExportarPDF.Click += BtnExportarPDF_Click;
            // 
            // labelDetalleProductosTitulo
            // 
            labelDetalleProductosTitulo.AutoSize = true;
            labelDetalleProductosTitulo.Depth = 0;
            labelDetalleProductosTitulo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelDetalleProductosTitulo.Location = new Point(394, 60);
            labelDetalleProductosTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            labelDetalleProductosTitulo.Name = "labelDetalleProductosTitulo";
            labelDetalleProductosTitulo.Size = new Size(151, 19);
            labelDetalleProductosTitulo.TabIndex = 50;
            labelDetalleProductosTitulo.Text = "Detalle de Productos:";
            // 
            // labelTotalVentaValor
            // 
            labelTotalVentaValor.AutoSize = true;
            labelTotalVentaValor.Depth = 0;
            labelTotalVentaValor.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelTotalVentaValor.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            labelTotalVentaValor.Location = new Point(143, 254);
            labelTotalVentaValor.MouseState = MaterialSkin.MouseState.HOVER;
            labelTotalVentaValor.Name = "labelTotalVentaValor";
            labelTotalVentaValor.Size = new Size(6, 17);
            labelTotalVentaValor.TabIndex = 49;
            labelTotalVentaValor.Text = "-";
            // 
            // labelTotalVentaTitulo
            // 
            labelTotalVentaTitulo.AutoSize = true;
            labelTotalVentaTitulo.Depth = 0;
            labelTotalVentaTitulo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelTotalVentaTitulo.Location = new Point(12, 254);
            labelTotalVentaTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            labelTotalVentaTitulo.Name = "labelTotalVentaTitulo";
            labelTotalVentaTitulo.Size = new Size(125, 19);
            labelTotalVentaTitulo.TabIndex = 48;
            labelTotalVentaTitulo.Text = "Total de la Venta:";
            // 
            // labelClienteValor
            // 
            labelClienteValor.AutoSize = true;
            labelClienteValor.Depth = 0;
            labelClienteValor.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelClienteValor.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            labelClienteValor.Location = new Point(12, 215);
            labelClienteValor.MouseState = MaterialSkin.MouseState.HOVER;
            labelClienteValor.Name = "labelClienteValor";
            labelClienteValor.Size = new Size(6, 17);
            labelClienteValor.TabIndex = 47;
            labelClienteValor.Text = "-";
            // 
            // labelClienteTitulo
            // 
            labelClienteTitulo.AutoSize = true;
            labelClienteTitulo.Depth = 0;
            labelClienteTitulo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelClienteTitulo.Location = new Point(12, 196);
            labelClienteTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            labelClienteTitulo.Name = "labelClienteTitulo";
            labelClienteTitulo.Size = new Size(53, 19);
            labelClienteTitulo.TabIndex = 46;
            labelClienteTitulo.Text = "Cliente:";
            // 
            // labelVendedorValor
            // 
            labelVendedorValor.AutoSize = true;
            labelVendedorValor.Depth = 0;
            labelVendedorValor.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelVendedorValor.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            labelVendedorValor.Location = new Point(12, 157);
            labelVendedorValor.MouseState = MaterialSkin.MouseState.HOVER;
            labelVendedorValor.Name = "labelVendedorValor";
            labelVendedorValor.Size = new Size(6, 17);
            labelVendedorValor.TabIndex = 45;
            labelVendedorValor.Text = "-";
            // 
            // labelVendedorTitulo
            // 
            labelVendedorTitulo.AutoSize = true;
            labelVendedorTitulo.Depth = 0;
            labelVendedorTitulo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelVendedorTitulo.Location = new Point(12, 138);
            labelVendedorTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            labelVendedorTitulo.Name = "labelVendedorTitulo";
            labelVendedorTitulo.Size = new Size(72, 19);
            labelVendedorTitulo.TabIndex = 44;
            labelVendedorTitulo.Text = "Vendedor:";
            // 
            // labelFechaVentaValor
            // 
            labelFechaVentaValor.AutoSize = true;
            labelFechaVentaValor.Depth = 0;
            labelFechaVentaValor.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelFechaVentaValor.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            labelFechaVentaValor.Location = new Point(66, 99);
            labelFechaVentaValor.MouseState = MaterialSkin.MouseState.HOVER;
            labelFechaVentaValor.Name = "labelFechaVentaValor";
            labelFechaVentaValor.Size = new Size(6, 17);
            labelFechaVentaValor.TabIndex = 43;
            labelFechaVentaValor.Text = "-";
            // 
            // labelFechaVentaTitulo
            // 
            labelFechaVentaTitulo.AutoSize = true;
            labelFechaVentaTitulo.Depth = 0;
            labelFechaVentaTitulo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelFechaVentaTitulo.Location = new Point(12, 99);
            labelFechaVentaTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            labelFechaVentaTitulo.Name = "labelFechaVentaTitulo";
            labelFechaVentaTitulo.Size = new Size(48, 19);
            labelFechaVentaTitulo.TabIndex = 42;
            labelFechaVentaTitulo.Text = "Fecha:";
            // 
            // labelNroVentaValor
            // 
            labelNroVentaValor.AutoSize = true;
            labelNroVentaValor.Depth = 0;
            labelNroVentaValor.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelNroVentaValor.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            labelNroVentaValor.Location = new Point(216, 60);
            labelNroVentaValor.MouseState = MaterialSkin.MouseState.HOVER;
            labelNroVentaValor.Name = "labelNroVentaValor";
            labelNroVentaValor.Size = new Size(6, 17);
            labelNroVentaValor.TabIndex = 41;
            labelNroVentaValor.Text = "-";
            // 
            // labelNroVentaTitulo
            // 
            labelNroVentaTitulo.AutoSize = true;
            labelNroVentaTitulo.Depth = 0;
            labelNroVentaTitulo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelNroVentaTitulo.Location = new Point(12, 60);
            labelNroVentaTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            labelNroVentaTitulo.Name = "labelNroVentaTitulo";
            labelNroVentaTitulo.Size = new Size(198, 19);
            labelNroVentaTitulo.TabIndex = 40;
            labelNroVentaTitulo.Text = "Comprobante de venta Nro: ";
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVolver.AutoSize = false;
            btnVolver.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVolver.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnVolver.Depth = 0;
            btnVolver.HighEmphasis = true;
            btnVolver.Icon = null;
            btnVolver.Location = new Point(18, 479);
            btnVolver.Margin = new Padding(4, 6, 4, 6);
            btnVolver.MouseState = MaterialSkin.MouseState.HOVER;
            btnVolver.Name = "btnVolver";
            btnVolver.NoAccentTextColor = Color.Empty;
            btnVolver.Size = new Size(125, 36);
            btnVolver.TabIndex = 39;
            btnVolver.Text = "Volver ";
            btnVolver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnVolver.UseAccentColor = false;
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Depth = 0;
            labelTitulo.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            labelTitulo.Location = new Point(12, 15);
            labelTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(177, 29);
            labelTitulo.TabIndex = 20;
            labelTitulo.Text = "Detalle de Venta";
            // 
            // nombre
            // 
            nombre.DisplayIndex = 0;
            nombre.Text = "Nombre";
            nombre.Width = 100;
            // 
            // cantidad
            // 
            cantidad.DisplayIndex = 1;
            cantidad.Text = "Cantidad";
            cantidad.Width = 90;
            // 
            // precioUnitario
            // 
            precioUnitario.DisplayIndex = 2;
            precioUnitario.Text = "Precio U.";
            precioUnitario.Width = 90;
            // 
            // subtotal
            // 
            subtotal.DisplayIndex = 3;
            subtotal.Text = "SubTotal";
            subtotal.Width = 90;
            // 
            // FormDetalleVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 530);
            Controls.Add(materialCard1);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "FormDetalleVenta";
            Padding = new Padding(0);
            Sizable = false;
            Text = "FormDetalleVenta";
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton btnVolver;
        private MaterialSkin.Controls.MaterialLabel labelTitulo;
        private MaterialSkin.Controls.MaterialLabel labelNroVentaTitulo;
        private MaterialSkin.Controls.MaterialLabel labelNroVentaValor;
        private MaterialSkin.Controls.MaterialLabel labelFechaVentaTitulo;
        private MaterialSkin.Controls.MaterialLabel labelTotalVentaTitulo;
        private MaterialSkin.Controls.MaterialLabel labelTotalVentaValor;
        private MaterialSkin.Controls.MaterialLabel labelClienteValor;
        private MaterialSkin.Controls.MaterialLabel labelClienteTitulo;
        private MaterialSkin.Controls.MaterialLabel labelVendedorValor;
        private MaterialSkin.Controls.MaterialLabel labelVendedorTitulo;
        private MaterialSkin.Controls.MaterialLabel labelFechaVentaValor;
        private MaterialSkin.Controls.MaterialLabel labelDetalleProductosTitulo;
        private MaterialSkin.Controls.MaterialButton BtnExportarPDF;
        private MaterialSkin.Controls.MaterialListView listViewProductos;
        private ColumnHeader nombre;
        private ColumnHeader precioUnitario;
        private ColumnHeader cantidad;
        private ColumnHeader subtotal;
    }
}