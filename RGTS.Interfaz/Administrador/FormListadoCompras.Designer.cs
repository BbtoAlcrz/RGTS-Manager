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
            BtnCancelarC = new MaterialSkin.Controls.MaterialButton();
            DtpDesde = new DateTimePicker();
            DtpHasta = new DateTimePicker();
            CmbFiltroProvee = new MaterialSkin.Controls.MaterialComboBox();
            BtnRecibido = new MaterialSkin.Controls.MaterialButton();
            btnLimpiar = new MaterialSkin.Controls.MaterialButton();
            BtnDetalleComp = new MaterialSkin.Controls.MaterialButton();
            BtnNuevaCompra = new MaterialSkin.Controls.MaterialButton();
            lstClientes = new MaterialSkin.Controls.MaterialListView();
            ID = new ColumnHeader();
            Estado = new ColumnHeader();
            Proveedor = new ColumnHeader();
            Usuario = new ColumnHeader();
            Fecha = new ColumnHeader();
            Total = new ColumnHeader();
            labelDesde = new MaterialSkin.Controls.MaterialLabel();
            labelHasta = new MaterialSkin.Controls.MaterialLabel();
            labelTitulo = new MaterialSkin.Controls.MaterialLabel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(255, 255, 255);
            panel2.Controls.Add(labelTitulo);
            panel2.Controls.Add(labelHasta);
            panel2.Controls.Add(labelDesde);
            panel2.Controls.Add(BtnCancelarC);
            panel2.Controls.Add(DtpDesde);
            panel2.Controls.Add(DtpHasta);
            panel2.Controls.Add(CmbFiltroProvee);
            panel2.Controls.Add(BtnRecibido);
            panel2.Controls.Add(btnLimpiar);
            panel2.Controls.Add(BtnDetalleComp);
            panel2.Controls.Add(BtnNuevaCompra);
            panel2.Controls.Add(lstClientes);
            panel2.Depth = 0;
            panel2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panel2.Location = new Point(4, 4);
            panel2.Margin = new Padding(12, 10, 12, 10);
            panel2.MouseState = MaterialSkin.MouseState.HOVER;
            panel2.Name = "panel2";
            panel2.Padding = new Padding(12, 10, 12, 10);
            panel2.Size = new Size(810, 519);
            panel2.TabIndex = 3;
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
            BtnCancelarC.Location = new Point(159, 296);
            BtnCancelarC.Margin = new Padding(4, 4, 4, 4);
            BtnCancelarC.MouseState = MaterialSkin.MouseState.HOVER;
            BtnCancelarC.Name = "BtnCancelarC";
            BtnCancelarC.NoAccentTextColor = Color.Empty;
            BtnCancelarC.Size = new Size(132, 35);
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
            DtpDesde.Location = new Point(523, 88);
            DtpDesde.Margin = new Padding(3, 2, 3, 2);
            DtpDesde.Name = "DtpDesde";
            DtpDesde.Size = new Size(133, 23);
            DtpDesde.TabIndex = 23;
            DtpDesde.ValueChanged += DtpDesde_ValueChanged;
            // 
            // DtpHasta
            // 
            DtpHasta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DtpHasta.CustomFormat = "dd/MM/yyyy";
            DtpHasta.Format = DateTimePickerFormat.Custom;
            DtpHasta.Location = new Point(662, 88);
            DtpHasta.Margin = new Padding(3, 2, 3, 2);
            DtpHasta.Name = "DtpHasta";
            DtpHasta.Size = new Size(133, 23);
            DtpHasta.TabIndex = 22;
            DtpHasta.ValueChanged += DtpHasta_ValueChanged;
            // 
            // CmbFiltroProvee
            // 
            CmbFiltroProvee.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CmbFiltroProvee.AutoResize = false;
            CmbFiltroProvee.BackColor = Color.FromArgb(255, 255, 255);
            CmbFiltroProvee.Depth = 0;
            CmbFiltroProvee.DrawMode = DrawMode.OwnerDrawVariable;
            CmbFiltroProvee.DropDownHeight = 174;
            CmbFiltroProvee.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbFiltroProvee.DropDownWidth = 121;
            CmbFiltroProvee.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CmbFiltroProvee.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CmbFiltroProvee.FormattingEnabled = true;
            CmbFiltroProvee.Hint = "Proveedor";
            CmbFiltroProvee.IntegralHeight = false;
            CmbFiltroProvee.ItemHeight = 43;
            CmbFiltroProvee.Location = new Point(15, 62);
            CmbFiltroProvee.Margin = new Padding(3, 2, 3, 2);
            CmbFiltroProvee.MaxDropDownItems = 4;
            CmbFiltroProvee.MouseState = MaterialSkin.MouseState.OUT;
            CmbFiltroProvee.Name = "CmbFiltroProvee";
            CmbFiltroProvee.Size = new Size(502, 49);
            CmbFiltroProvee.StartIndex = 0;
            CmbFiltroProvee.TabIndex = 21;
            CmbFiltroProvee.SelectedIndexChanged += CmbFiltroProvee_SelectedIndexChanged;
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
            BtnRecibido.Location = new Point(15, 296);
            BtnRecibido.Margin = new Padding(4, 4, 4, 4);
            BtnRecibido.MouseState = MaterialSkin.MouseState.HOVER;
            BtnRecibido.Name = "BtnRecibido";
            BtnRecibido.NoAccentTextColor = Color.Empty;
            BtnRecibido.Size = new Size(132, 35);
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
            btnLimpiar.Location = new Point(698, 296);
            btnLimpiar.Margin = new Padding(4, 4, 4, 4);
            btnLimpiar.MouseState = MaterialSkin.MouseState.HOVER;
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.NoAccentTextColor = Color.Empty;
            btnLimpiar.Size = new Size(97, 35);
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
            BtnDetalleComp.Location = new Point(159, 465);
            BtnDetalleComp.Margin = new Padding(4, 4, 4, 4);
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
            BtnNuevaCompra.Location = new Point(17, 465);
            BtnNuevaCompra.Margin = new Padding(4, 4, 4, 4);
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
            // Column order: ID, Proveedor, Usuario, Fecha, Total, Estado
            lstClientes.Columns.AddRange(new ColumnHeader[] { ID, Proveedor, Usuario, Fecha, Total, Estado });
            lstClientes.Depth = 0;
            lstClientes.FullRowSelect = true;
            lstClientes.Location = new Point(15, 115);
            lstClientes.Margin = new Padding(3, 2, 3, 2);
            lstClientes.MinimumSize = new Size(175, 75);
            lstClientes.MouseLocation = new Point(-1, -1);
            lstClientes.MouseState = MaterialSkin.MouseState.OUT;
            lstClientes.Name = "lstClientes";
            lstClientes.OwnerDraw = true;
            lstClientes.Size = new Size(780, 175);
            lstClientes.TabIndex = 17;
            lstClientes.UseCompatibleStateImageBehavior = false;
            lstClientes.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 50;
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            Estado.Width = 100;
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
            // labelDesde
            // 
            labelDesde.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelDesde.AutoSize = true;
            labelDesde.Depth = 0;
            labelDesde.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelDesde.Location = new Point(523, 67);
            labelDesde.MouseState = MaterialSkin.MouseState.HOVER;
            labelDesde.Name = "labelDesde";
            labelDesde.Size = new Size(49, 19);
            labelDesde.TabIndex = 25;
            labelDesde.Text = "Desde:";
            // 
            // labelHasta
            // 
            labelHasta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelHasta.AutoSize = true;
            labelHasta.Depth = 0;
            labelHasta.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelHasta.Location = new Point(662, 67);
            labelHasta.MouseState = MaterialSkin.MouseState.HOVER;
            labelHasta.Name = "labelHasta";
            labelHasta.Size = new Size(47, 19);
            labelHasta.TabIndex = 26;
            labelHasta.Text = "Hasta:";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Depth = 0;
            labelTitulo.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            labelTitulo.Location = new Point(15, 20);
            labelTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(217, 29);
            labelTitulo.TabIndex = 27;
            labelTitulo.Text = "Listado de Compras";
            // 
            // FormListadoCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 528);
            Controls.Add(panel2);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormListadoCompras";
            Padding = new Padding(3, 0, 3, 2);
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
        private MaterialSkin.Controls.MaterialComboBox CmbFiltroProvee;
        private MaterialSkin.Controls.MaterialButton BtnCancelarC;
        private MaterialSkin.Controls.MaterialLabel labelHasta;
        private MaterialSkin.Controls.MaterialLabel labelDesde;
        private MaterialSkin.Controls.MaterialLabel labelTitulo;
    }
}