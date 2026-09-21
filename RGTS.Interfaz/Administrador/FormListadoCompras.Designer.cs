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
            panel2 = new Panel();
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
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(BtnCancelarC);
            panel2.Controls.Add(DtpDesde);
            panel2.Controls.Add(DtpHasta);
            panel2.Controls.Add(CmbFiltroProvee);
            panel2.Controls.Add(BtnRecibido);
            panel2.Controls.Add(btnLimpiar);
            panel2.Controls.Add(BtnDetalleComp);
            panel2.Controls.Add(BtnNuevaCompra);
            panel2.Controls.Add(lstClientes);
            panel2.Location = new Point(18, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(843, 372);
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
            BtnCancelarC.Location = new Point(19, 250);
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
            DtpDesde.CustomFormat = "dd/MM/yyyy";
            DtpDesde.Format = DateTimePickerFormat.Custom;
            DtpDesde.Location = new Point(683, 3);
            DtpDesde.Name = "DtpDesde";
            DtpDesde.Size = new Size(151, 27);
            DtpDesde.TabIndex = 23;
            // 
            // DtpHasta
            // 
            DtpHasta.CustomFormat = "dd/MM/yyyy";
            DtpHasta.Format = DateTimePickerFormat.Custom;
            DtpHasta.Location = new Point(683, 48);
            DtpHasta.Name = "DtpHasta";
            DtpHasta.Size = new Size(151, 27);
            DtpHasta.TabIndex = 22;
            // 
            // CmbFiltroProvee
            // 
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
            CmbFiltroProvee.Location = new Point(686, 95);
            CmbFiltroProvee.MaxDropDownItems = 4;
            CmbFiltroProvee.MouseState = MaterialSkin.MouseState.OUT;
            CmbFiltroProvee.Name = "CmbFiltroProvee";
            CmbFiltroProvee.Size = new Size(148, 49);
            CmbFiltroProvee.StartIndex = 0;
            CmbFiltroProvee.TabIndex = 21;
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
            BtnRecibido.Location = new Point(19, 307);
            BtnRecibido.Margin = new Padding(5);
            BtnRecibido.MouseState = MaterialSkin.MouseState.HOVER;
            BtnRecibido.Name = "BtnRecibido";
            BtnRecibido.NoAccentTextColor = Color.Empty;
            BtnRecibido.Size = new Size(151, 47);
            BtnRecibido.TabIndex = 20;
            BtnRecibido.Text = "Compra Recibida";
            BtnRecibido.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            BtnRecibido.UseAccentColor = false;
            BtnRecibido.UseVisualStyleBackColor = true;
            BtnRecibido.Click += BtnRecibido_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.AutoSize = false;
            btnLimpiar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLimpiar.BackColor = Color.IndianRed;
            btnLimpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLimpiar.Depth = 0;
            btnLimpiar.ForeColor = Color.Firebrick;
            btnLimpiar.HighEmphasis = true;
            btnLimpiar.Icon = null;
            btnLimpiar.Location = new Point(702, 169);
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
            BtnDetalleComp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnDetalleComp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnDetalleComp.Depth = 0;
            BtnDetalleComp.HighEmphasis = true;
            BtnDetalleComp.Icon = null;
            BtnDetalleComp.Location = new Point(308, 255);
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
            BtnNuevaCompra.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnNuevaCompra.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnNuevaCompra.Depth = 0;
            BtnNuevaCompra.HighEmphasis = true;
            BtnNuevaCompra.Icon = null;
            BtnNuevaCompra.Location = new Point(529, 255);
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
            lstClientes.AutoSizeTable = false;
            lstClientes.BackColor = Color.FromArgb(255, 255, 255);
            lstClientes.BorderStyle = BorderStyle.None;
            lstClientes.Columns.AddRange(new ColumnHeader[] { ID, Estado, Proveedor, Usuario, Fecha, Total });
            lstClientes.Depth = 0;
            lstClientes.FullRowSelect = true;
            lstClientes.Location = new Point(3, 3);
            lstClientes.MinimumSize = new Size(200, 100);
            lstClientes.MouseLocation = new Point(-1, -1);
            lstClientes.MouseState = MaterialSkin.MouseState.OUT;
            lstClientes.Name = "lstClientes";
            lstClientes.OwnerDraw = true;
            lstClientes.Size = new Size(674, 233);
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
            Estado.DisplayIndex = 2;
            // 
            // Proveedor
            // 
            Proveedor.DisplayIndex = 1;
            Proveedor.Text = "Proveedor";
            Proveedor.Width = 100;
            // 
            // Usuario
            // 
            Usuario.Text = "Usuario";
            // 
            // Fecha
            // 
            Fecha.Text = "Fecha";
            // 
            // Total
            // 
            Total.Text = "Total";
            // 
            // FormListadoCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 481);
            Controls.Add(panel2);
            Name = "FormListadoCompras";
            Text = "Listado de las Compras";
            Load += FormListadoCompras_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
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
    }
}