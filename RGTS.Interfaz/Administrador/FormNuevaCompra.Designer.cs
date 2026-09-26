namespace RGTS.Interfaz.Administrador
{
    partial class FormNuevaCompra
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
            labelTitulo = new MaterialSkin.Controls.MaterialLabel();
            LTotal = new MaterialSkin.Controls.MaterialLabel();
            LDetalleCompra = new MaterialSkin.Controls.MaterialLabel();
            LtexOrden = new MaterialSkin.Controls.MaterialLabel();
            TxtCantidad = new MaterialSkin.Controls.MaterialTextBox();
            TxtCostoUni = new MaterialSkin.Controls.MaterialTextBox();
            TxtBuscarCoN = new MaterialSkin.Controls.MaterialTextBox();
            BtnAñadirComp = new MaterialSkin.Controls.MaterialButton();
            BtnCancelarCompra = new MaterialSkin.Controls.MaterialButton();
            BtnRegistrarCompra = new MaterialSkin.Controls.MaterialButton();
            lstClientes = new MaterialSkin.Controls.MaterialListView();
            ID = new ColumnHeader();
            Descripcion = new ColumnHeader();
            Cantidad = new ColumnHeader();
            CostoUni = new ColumnHeader();
            SubTotal = new ColumnHeader();
            TxtBuscarProveedor = new MaterialSkin.Controls.MaterialTextBox();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(255, 255, 255);
            panel2.Controls.Add(TxtBuscarProveedor);
            panel2.Controls.Add(labelTitulo);
            panel2.Controls.Add(LTotal);
            panel2.Controls.Add(LDetalleCompra);
            panel2.Controls.Add(LtexOrden);
            panel2.Controls.Add(TxtCantidad);
            panel2.Controls.Add(TxtCostoUni);
            panel2.Controls.Add(TxtBuscarCoN);
            panel2.Controls.Add(BtnAñadirComp);
            panel2.Controls.Add(BtnCancelarCompra);
            panel2.Controls.Add(BtnRegistrarCompra);
            panel2.Controls.Add(lstClientes);
            panel2.Depth = 0;
            panel2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panel2.Location = new Point(5, 7);
            panel2.Margin = new Padding(14, 13, 14, 13);
            panel2.MouseState = MaterialSkin.MouseState.HOVER;
            panel2.Name = "panel2";
            panel2.Padding = new Padding(14, 13, 14, 13);
            panel2.Size = new Size(969, 693);
            panel2.TabIndex = 4;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Depth = 0;
            labelTitulo.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            labelTitulo.Location = new Point(17, 13);
            labelTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(264, 29);
            labelTitulo.TabIndex = 31;
            labelTitulo.Text = "Nueva Orden de Compra";
            // 
            // LTotal
            // 
            LTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LTotal.AutoSize = true;
            LTotal.Depth = 0;
            LTotal.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LTotal.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LTotal.Location = new Point(835, 573);
            LTotal.MouseState = MaterialSkin.MouseState.HOVER;
            LTotal.Name = "LTotal";
            LTotal.Size = new Size(102, 24);
            LTotal.TabIndex = 30;
            LTotal.Text = "Total $0.00";
            // 
            // LDetalleCompra
            // 
            LDetalleCompra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LDetalleCompra.AutoSize = true;
            LDetalleCompra.Depth = 0;
            LDetalleCompra.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LDetalleCompra.Location = new Point(359, 101);
            LDetalleCompra.MouseState = MaterialSkin.MouseState.HOVER;
            LDetalleCompra.Name = "LDetalleCompra";
            LDetalleCompra.Size = new Size(165, 19);
            LDetalleCompra.TabIndex = 29;
            LDetalleCompra.Text = "Detalle de esta Compra";
            // 
            // LtexOrden
            // 
            LtexOrden.AutoSize = true;
            LtexOrden.Depth = 0;
            LtexOrden.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LtexOrden.Location = new Point(19, 101);
            LtexOrden.MouseState = MaterialSkin.MouseState.HOVER;
            LtexOrden.Name = "LtexOrden";
            LtexOrden.Size = new Size(191, 19);
            LtexOrden.TabIndex = 28;
            LtexOrden.Text = "Cargar Orden de Productos";
            // 
            // TxtCantidad
            // 
            TxtCantidad.AnimateReadOnly = false;
            TxtCantidad.BorderStyle = BorderStyle.None;
            TxtCantidad.Depth = 0;
            TxtCantidad.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtCantidad.Hint = "Cantidad";
            TxtCantidad.LeadingIcon = null;
            TxtCantidad.Location = new Point(193, 272);
            TxtCantidad.MaxLength = 50;
            TxtCantidad.MouseState = MaterialSkin.MouseState.OUT;
            TxtCantidad.Multiline = false;
            TxtCantidad.Name = "TxtCantidad";
            TxtCantidad.Size = new Size(119, 50);
            TxtCantidad.TabIndex = 27;
            TxtCantidad.Text = "";
            TxtCantidad.TrailingIcon = null;
            // 
            // TxtCostoUni
            // 
            TxtCostoUni.AnimateReadOnly = false;
            TxtCostoUni.BorderStyle = BorderStyle.None;
            TxtCostoUni.Depth = 0;
            TxtCostoUni.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtCostoUni.Hint = "Costo Unitario $";
            TxtCostoUni.LeadingIcon = null;
            TxtCostoUni.Location = new Point(19, 272);
            TxtCostoUni.MaxLength = 50;
            TxtCostoUni.MouseState = MaterialSkin.MouseState.OUT;
            TxtCostoUni.Multiline = false;
            TxtCostoUni.Name = "TxtCostoUni";
            TxtCostoUni.Size = new Size(168, 50);
            TxtCostoUni.TabIndex = 26;
            TxtCostoUni.Text = "";
            TxtCostoUni.TrailingIcon = null;
            // 
            // TxtBuscarCoN
            // 
            TxtBuscarCoN.AnimateReadOnly = false;
            TxtBuscarCoN.BorderStyle = BorderStyle.None;
            TxtBuscarCoN.Depth = 0;
            TxtBuscarCoN.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtBuscarCoN.Hint = "Codigo o Nombre";
            TxtBuscarCoN.LeadingIcon = null;
            TxtBuscarCoN.Location = new Point(18, 200);
            TxtBuscarCoN.MaxLength = 50;
            TxtBuscarCoN.MouseState = MaterialSkin.MouseState.OUT;
            TxtBuscarCoN.Multiline = false;
            TxtBuscarCoN.Name = "TxtBuscarCoN";
            TxtBuscarCoN.Size = new Size(294, 50);
            TxtBuscarCoN.TabIndex = 25;
            TxtBuscarCoN.Text = "";
            TxtBuscarCoN.TrailingIcon = null;
            // 
            // BtnAñadirComp
            // 
            BtnAñadirComp.AutoSize = false;
            BtnAñadirComp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnAñadirComp.BackColor = Color.IndianRed;
            BtnAñadirComp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnAñadirComp.Depth = 0;
            BtnAñadirComp.ForeColor = Color.CornflowerBlue;
            BtnAñadirComp.HighEmphasis = true;
            BtnAñadirComp.Icon = null;
            BtnAñadirComp.Location = new Point(19, 363);
            BtnAñadirComp.Margin = new Padding(5, 5, 5, 5);
            BtnAñadirComp.MouseState = MaterialSkin.MouseState.HOVER;
            BtnAñadirComp.Name = "BtnAñadirComp";
            BtnAñadirComp.NoAccentTextColor = Color.Empty;
            BtnAñadirComp.Size = new Size(294, 47);
            BtnAñadirComp.TabIndex = 20;
            BtnAñadirComp.Text = "Añadir A la Orden de Compra";
            BtnAñadirComp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            BtnAñadirComp.UseAccentColor = false;
            BtnAñadirComp.UseVisualStyleBackColor = true;
            BtnAñadirComp.Click += BtnRecibido_Click;
            // 
            // BtnCancelarCompra
            // 
            BtnCancelarCompra.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnCancelarCompra.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnCancelarCompra.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnCancelarCompra.Depth = 0;
            BtnCancelarCompra.HighEmphasis = true;
            BtnCancelarCompra.Icon = null;
            BtnCancelarCompra.Location = new Point(577, 639);
            BtnCancelarCompra.Margin = new Padding(5, 5, 5, 5);
            BtnCancelarCompra.MouseState = MaterialSkin.MouseState.HOVER;
            BtnCancelarCompra.Name = "BtnCancelarCompra";
            BtnCancelarCompra.NoAccentTextColor = Color.Empty;
            BtnCancelarCompra.Size = new Size(96, 36);
            BtnCancelarCompra.TabIndex = 18;
            BtnCancelarCompra.Text = "Cancelar";
            BtnCancelarCompra.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            BtnCancelarCompra.UseAccentColor = false;
            BtnCancelarCompra.UseVisualStyleBackColor = true;
            BtnCancelarCompra.Click += BtnCancelarCompra_Click;
            // 
            // BtnRegistrarCompra
            // 
            BtnRegistrarCompra.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnRegistrarCompra.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnRegistrarCompra.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnRegistrarCompra.Depth = 0;
            BtnRegistrarCompra.HighEmphasis = true;
            BtnRegistrarCompra.Icon = null;
            BtnRegistrarCompra.Location = new Point(716, 639);
            BtnRegistrarCompra.Margin = new Padding(5, 5, 5, 5);
            BtnRegistrarCompra.MouseState = MaterialSkin.MouseState.HOVER;
            BtnRegistrarCompra.Name = "BtnRegistrarCompra";
            BtnRegistrarCompra.NoAccentTextColor = Color.Empty;
            BtnRegistrarCompra.Size = new Size(237, 36);
            BtnRegistrarCompra.TabIndex = 19;
            BtnRegistrarCompra.Text = "Registrar Orden de Compra";
            BtnRegistrarCompra.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnRegistrarCompra.UseAccentColor = false;
            BtnRegistrarCompra.UseVisualStyleBackColor = true;
            BtnRegistrarCompra.Click += BtnRegistrarCompra_Click;
            // 
            // lstClientes
            // 
            lstClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstClientes.AutoSizeTable = false;
            lstClientes.BackColor = Color.FromArgb(255, 255, 255);
            lstClientes.BorderStyle = BorderStyle.None;
            lstClientes.Columns.AddRange(new ColumnHeader[] { ID, Descripcion, Cantidad, CostoUni, SubTotal });
            lstClientes.Depth = 0;
            lstClientes.FullRowSelect = true;
            lstClientes.Location = new Point(359, 129);
            lstClientes.MinimumSize = new Size(200, 100);
            lstClientes.MouseLocation = new Point(-1, -1);
            lstClientes.MouseState = MaterialSkin.MouseState.OUT;
            lstClientes.Name = "lstClientes";
            lstClientes.OwnerDraw = true;
            lstClientes.Size = new Size(593, 413);
            lstClientes.TabIndex = 17;
            lstClientes.UseCompatibleStateImageBehavior = false;
            lstClientes.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 50;
            // 
            // Descripcion
            // 
            Descripcion.Text = "Descripcion";
            Descripcion.Width = 100;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            Cantidad.Width = 80;
            // 
            // CostoUni
            // 
            CostoUni.Text = "Costo unitario";
            CostoUni.Width = 80;
            // 
            // SubTotal
            // 
            SubTotal.Text = "SubTotal";
            SubTotal.Width = 100;
            // 
            // TxtBuscarProveedor
            // 
            TxtBuscarProveedor.AnimateReadOnly = false;
            TxtBuscarProveedor.BorderStyle = BorderStyle.None;
            TxtBuscarProveedor.Depth = 0;
            TxtBuscarProveedor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtBuscarProveedor.Hint = "Proveedor";
            TxtBuscarProveedor.LeadingIcon = null;
            TxtBuscarProveedor.Location = new Point(19, 129);
            TxtBuscarProveedor.MaxLength = 50;
            TxtBuscarProveedor.MouseState = MaterialSkin.MouseState.OUT;
            TxtBuscarProveedor.Multiline = false;
            TxtBuscarProveedor.Name = "TxtBuscarProveedor";
            TxtBuscarProveedor.Size = new Size(293, 50);
            TxtBuscarProveedor.TabIndex = 32;
            TxtBuscarProveedor.Text = "";
            TxtBuscarProveedor.TrailingIcon = null;
            // 
            // FormNuevaCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 707);
            Controls.Add(panel2);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "FormNuevaCompra";
            Padding = new Padding(3, 0, 3, 3);
            Sizable = false;
            Text = "Nueva Orden de Compra";
            Load += FormNuevaCompra_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard panel2;
        private DateTimePicker DtpDesde;
        private DateTimePicker DtpHasta;
        private MaterialSkin.Controls.MaterialButton BtnAñadirComp;
        private MaterialSkin.Controls.MaterialButton btnLimpiar;
        private MaterialSkin.Controls.MaterialButton BtnCancelarCompra;
        private MaterialSkin.Controls.MaterialButton BtnRegistrarCompra;
        private MaterialSkin.Controls.MaterialListView lstClientes;
        private ColumnHeader ID;
        private ColumnHeader Descripcion;
        private ColumnHeader Cantidad;
        private ColumnHeader Estado;
        private ColumnHeader Proveedor;
        private ColumnHeader Usuario;
        private ColumnHeader Fecha;
        private ColumnHeader CostoUni;
        private MaterialSkin.Controls.MaterialTextBox TxtCostoUni;
        private MaterialSkin.Controls.MaterialTextBox TxtBuscarCoN;
        private MaterialSkin.Controls.MaterialLabel LDetalleCompra;
        private MaterialSkin.Controls.MaterialLabel LtexOrden;
        private MaterialSkin.Controls.MaterialTextBox TxtCantidad;
        private MaterialSkin.Controls.MaterialLabel LTotal;
        private ColumnHeader SubTotal;
        private MaterialSkin.Controls.MaterialLabel labelTitulo;
        private MaterialSkin.Controls.MaterialTextBox TxtBuscarProveedor;
    }
}