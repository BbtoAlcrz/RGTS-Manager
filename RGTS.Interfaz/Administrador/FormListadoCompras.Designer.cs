namespace RGTS.Interfaz.Administrador
{
    partial class FormListadoCompras
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
            panel2 = new MaterialSkin.Controls.MaterialCard();
            TxtFiltroProveedor = new MaterialSkin.Controls.MaterialTextBox();
            labelTitulo = new MaterialSkin.Controls.MaterialLabel();
            labelHasta = new MaterialSkin.Controls.MaterialLabel();
            labelDesde = new MaterialSkin.Controls.MaterialLabel();
            BtnCancelarC = new MaterialSkin.Controls.MaterialButton();
            DtpDesde = new DateTimePicker();
            DtpHasta = new DateTimePicker();
            BtnRecibido = new MaterialSkin.Controls.MaterialButton();
            btnLimpiar = new MaterialSkin.Controls.MaterialButton();
            BtnDetalleComp = new MaterialSkin.Controls.MaterialButton();
            BtnNuevaCompra = new MaterialSkin.Controls.MaterialButton();
            lstClientes = new MaterialSkin.Controls.MaterialListView();
            ID = new ColumnHeader();
            Proveedor = new ColumnHeader();
            Usuario = new ColumnHeader();
            Fecha = new ColumnHeader();
            Total = new ColumnHeader();
            Estado = new ColumnHeader();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(255, 255, 255);
            panel2.Controls.Add(TxtFiltroProveedor);
            panel2.Controls.Add(labelTitulo);
            panel2.Controls.Add(labelHasta);
            panel2.Controls.Add(labelDesde);
            panel2.Controls.Add(BtnCancelarC);
            panel2.Controls.Add(DtpDesde);
            panel2.Controls.Add(DtpHasta);
            panel2.Controls.Add(BtnRecibido);
            panel2.Controls.Add(btnLimpiar);
            panel2.Controls.Add(BtnDetalleComp);
            panel2.Controls.Add(BtnNuevaCompra);
            panel2.Controls.Add(lstClientes);
            panel2.Depth = 0;
            panel2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panel2.Location = new Point(5, 5);
            panel2.Margin = new Padding(14, 13, 14, 13);
            panel2.MouseState = MaterialSkin.MouseState.HOVER;
            panel2.Name = "panel2";
            panel2.Padding = new Padding(14, 13, 14, 13);
            panel2.Size = new Size(926, 692);
            panel2.TabIndex = 3;
            // 
            // TxtFiltroProveedor
            // 
            TxtFiltroProveedor.AnimateReadOnly = false;
            TxtFiltroProveedor.BorderStyle = BorderStyle.None;
            TxtFiltroProveedor.Depth = 0;
            TxtFiltroProveedor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtFiltroProveedor.Hint = "Proveedor";
            TxtFiltroProveedor.LeadingIcon = null;
            TxtFiltroProveedor.Location = new Point(28, 87);
            TxtFiltroProveedor.MaxLength = 50;
            TxtFiltroProveedor.MouseState = MaterialSkin.MouseState.OUT;
            TxtFiltroProveedor.Multiline = false;
            TxtFiltroProveedor.Name = "TxtFiltroProveedor";
            TxtFiltroProveedor.Size = new Size(564, 50);
            TxtFiltroProveedor.TabIndex = 28;
            TxtFiltroProveedor.Text = "";
            TxtFiltroProveedor.TrailingIcon = null;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Depth = 0;
            labelTitulo.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            labelTitulo.Location = new Point(17, 27);
            labelTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(217, 29);
            labelTitulo.TabIndex = 27;
            labelTitulo.Text = "Listado de Compras";
            // 
            // labelHasta
            // 
            labelHasta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelHasta.AutoSize = true;
            labelHasta.Depth = 0;
            labelHasta.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelHasta.Location = new Point(757, 89);
            labelHasta.MouseState = MaterialSkin.MouseState.HOVER;
            labelHasta.Name = "labelHasta";
            labelHasta.Size = new Size(47, 19);
            labelHasta.TabIndex = 26;
            labelHasta.Text = "Hasta:";
            // 
            // labelDesde
            // 
            labelDesde.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelDesde.AutoSize = true;
            labelDesde.Depth = 0;
            labelDesde.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelDesde.Location = new Point(598, 89);
            labelDesde.MouseState = MaterialSkin.MouseState.HOVER;
            labelDesde.Name = "labelDesde";
            labelDesde.Size = new Size(49, 19);
            labelDesde.TabIndex = 25;
            labelDesde.Text = "Desde:";
            // 
            // BtnCancelarC
            // 
            BtnCancelarC.AutoSize = false;
            BtnCancelarC.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnCancelarC.BackColor = Color.IndianRed;
            BtnCancelarC.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnCancelarC.Depth = 0;
            BtnCancelarC.ForeColor = Color.Firebrick;
            BtnCancelarC.HighEmphasis = true;
            BtnCancelarC.Icon = null;
            BtnCancelarC.Location = new Point(182, 395);
            BtnCancelarC.Margin = new Padding(5);
            BtnCancelarC.MouseState = MaterialSkin.MouseState.HOVER;
            BtnCancelarC.Name = "BtnCancelarC";
            BtnCancelarC.NoAccentTextColor = Color.Empty;
            BtnCancelarC.Size = new Size(151, 47);
            BtnCancelarC.TabIndex = 24;
            BtnCancelarC.Text = "Cancelar Compra";
            BtnCancelarC.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            BtnCancelarC.UseAccentColor = false;
            BtnCancelarC.UseVisualStyleBackColor = true;
            BtnCancelarC.Click += BtnCancelarC_Click;
            // 
            // DtpDesde
            // 
            DtpDesde.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DtpDesde.CustomFormat = "dd/MM/yyyy";
            DtpDesde.Format = DateTimePickerFormat.Custom;
            DtpDesde.Location = new Point(598, 117);
            DtpDesde.Name = "DtpDesde";
            DtpDesde.Size = new Size(151, 27);
            DtpDesde.TabIndex = 23;
            DtpDesde.ValueChanged += DtpDesde_ValueChanged;
            // 
            // DtpHasta
            // 
            DtpHasta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DtpHasta.CustomFormat = "dd/MM/yyyy";
            DtpHasta.Format = DateTimePickerFormat.Custom;
            DtpHasta.Location = new Point(757, 117);
            DtpHasta.Name = "DtpHasta";
            DtpHasta.Size = new Size(151, 27);
            DtpHasta.TabIndex = 22;
            DtpHasta.ValueChanged += DtpHasta_ValueChanged;
            // 
            // BtnRecibido
            // 
            BtnRecibido.AutoSize = false;
            BtnRecibido.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnRecibido.BackColor = Color.IndianRed;
            BtnRecibido.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnRecibido.Depth = 0;
            BtnRecibido.ForeColor = Color.Firebrick;
            BtnRecibido.HighEmphasis = true;
            BtnRecibido.Icon = null;
            BtnRecibido.Location = new Point(17, 395);
            BtnRecibido.Margin = new Padding(5);
            BtnRecibido.MouseState = MaterialSkin.MouseState.HOVER;
            BtnRecibido.Name = "BtnRecibido";
            BtnRecibido.NoAccentTextColor = Color.Empty;
            BtnRecibido.Size = new Size(151, 47);
            BtnRecibido.TabIndex = 20;
            BtnRecibido.Text = "Compra Recibida";
            BtnRecibido.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnRecibido.UseAccentColor = false;
            BtnRecibido.UseVisualStyleBackColor = true;
            BtnRecibido.Click += BtnRecibido_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimpiar.AutoSize = false;
            btnLimpiar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLimpiar.BackColor = Color.IndianRed;
            btnLimpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLimpiar.Depth = 0;
            btnLimpiar.ForeColor = Color.Firebrick;
            btnLimpiar.HighEmphasis = true;
            btnLimpiar.Icon = null;
            btnLimpiar.Location = new Point(798, 395);
            btnLimpiar.Margin = new Padding(5);
            btnLimpiar.MouseState = MaterialSkin.MouseState.HOVER;
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.NoAccentTextColor = Color.Empty;
            btnLimpiar.Size = new Size(111, 47);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnLimpiar.UseAccentColor = false;
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // BtnDetalleComp
            // 
            BtnDetalleComp.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnDetalleComp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnDetalleComp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnDetalleComp.Depth = 0;
            BtnDetalleComp.HighEmphasis = true;
            BtnDetalleComp.Icon = null;
            BtnDetalleComp.Location = new Point(182, 632);
            BtnDetalleComp.Margin = new Padding(5);
            BtnDetalleComp.MouseState = MaterialSkin.MouseState.HOVER;
            BtnDetalleComp.Name = "BtnDetalleComp";
            BtnDetalleComp.NoAccentTextColor = Color.Empty;
            BtnDetalleComp.Size = new Size(190, 36);
            BtnDetalleComp.TabIndex = 18;
            BtnDetalleComp.Text = "Detalle de la Compra";
            BtnDetalleComp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            BtnDetalleComp.UseAccentColor = false;
            BtnDetalleComp.UseVisualStyleBackColor = true;
            BtnDetalleComp.Click += BtnDetalleComp_Click;
            // 
            // BtnNuevaCompra
            // 
            BtnNuevaCompra.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnNuevaCompra.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnNuevaCompra.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnNuevaCompra.Depth = 0;
            BtnNuevaCompra.HighEmphasis = true;
            BtnNuevaCompra.Icon = null;
            BtnNuevaCompra.Location = new Point(19, 632);
            BtnNuevaCompra.Margin = new Padding(5);
            BtnNuevaCompra.MouseState = MaterialSkin.MouseState.HOVER;
            BtnNuevaCompra.Name = "BtnNuevaCompra";
            BtnNuevaCompra.NoAccentTextColor = Color.Empty;
            BtnNuevaCompra.Size = new Size(134, 36);
            BtnNuevaCompra.TabIndex = 19;
            BtnNuevaCompra.Text = "Nueva Compra";
            BtnNuevaCompra.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnNuevaCompra.UseAccentColor = false;
            BtnNuevaCompra.UseVisualStyleBackColor = true;
            BtnNuevaCompra.Click += BtnNuevaCompra_Click;
            // 
            // lstClientes
            // 
            lstClientes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lstClientes.AutoSizeTable = false;
            lstClientes.BackColor = Color.FromArgb(255, 255, 255);
            lstClientes.BorderStyle = BorderStyle.None;
            lstClientes.Columns.AddRange(new ColumnHeader[] { ID, Proveedor, Usuario, Fecha, Total, Estado });
            lstClientes.Depth = 0;
            lstClientes.FullRowSelect = true;
            lstClientes.Location = new Point(17, 153);
            lstClientes.MinimumSize = new Size(200, 100);
            lstClientes.MouseLocation = new Point(-1, -1);
            lstClientes.MouseState = MaterialSkin.MouseState.OUT;
            lstClientes.Name = "lstClientes";
            lstClientes.OwnerDraw = true;
            lstClientes.Size = new Size(891, 233);
            lstClientes.TabIndex = 17;
            lstClientes.UseCompatibleStateImageBehavior = false;
            lstClientes.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 50;
            // 
            // Proveedor
            // 
            Proveedor.Text = "Proveedor";
            Proveedor.Width = 100;
            // 
            // Usuario
            // 
            Usuario.Text = "Usuario";
            Usuario.Width = 100;
            // 
            // Fecha
            // 
            Fecha.Text = "Fecha";
            Fecha.Width = 100;
            // 
            // Total
            // 
            Total.Text = "Total";
            Total.Width = 100;
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            Estado.Width = 100;
            // 
            // FormListadoCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 704);
            Controls.Add(panel2);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "FormListadoCompras";
            Padding = new Padding(3, 0, 3, 3);
            Sizable = false;
            Text = "Listado de las Compras";
            Load += FormListadoCompras_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard panel2;
        private MaterialSkin.Controls.MaterialButton BtnRecibido;
        private MaterialSkin.Controls.MaterialButton BtnNuevaCompra;
        private MaterialSkin.Controls.MaterialButton BtnDetalleComp;
        private MaterialSkin.Controls.MaterialButton btnLimpiar;
        private MaterialSkin.Controls.MaterialListView lstClientes;
        private ColumnHeader ID;
        private ColumnHeader Estado;
        private ColumnHeader Proveedor;
        private ColumnHeader Usuario;
        private ColumnHeader Fecha;
        private ColumnHeader Total;
        private DateTimePicker DtpDesde;
        private DateTimePicker DtpHasta;
        private MaterialSkin.Controls.MaterialButton BtnCancelarC;
        private MaterialSkin.Controls.MaterialLabel labelHasta;
        private MaterialSkin.Controls.MaterialLabel labelDesde;
        private MaterialSkin.Controls.MaterialLabel labelTitulo;
        private MaterialSkin.Controls.MaterialTextBox TxtFiltroProveedor;
    }
}