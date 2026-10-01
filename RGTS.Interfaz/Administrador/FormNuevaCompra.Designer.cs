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
            labelProducto = new MaterialSkin.Controls.MaterialLabel();
            labelProveedor = new MaterialSkin.Controls.MaterialLabel();
            TxtBuscarProveedor = new MaterialSkin.Controls.MaterialTextBox();
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
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 255, 255);
            panel2.Controls.Add(labelProducto);
            panel2.Controls.Add(labelProveedor);
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
            panel2.Dock = DockStyle.Fill;
            panel2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(12, 10, 12, 10);
            panel2.MouseState = MaterialSkin.MouseState.HOVER;
            panel2.Name = "panel2";
            panel2.Padding = new Padding(12, 10, 12, 10);
            panel2.Size = new Size(903, 530);
            panel2.TabIndex = 4;
            // 
            // labelProducto
            // 
            labelProducto.AutoSize = true;
            labelProducto.Depth = 0;
            labelProducto.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelProducto.Location = new Point(12, 197);
            labelProducto.MouseState = MaterialSkin.MouseState.HOVER;
            labelProducto.Name = "labelProducto";
            labelProducto.Size = new Size(69, 19);
            labelProducto.TabIndex = 33;
            labelProducto.Text = "Producto:";
            // 
            // labelProveedor
            // 
            labelProveedor.AutoSize = true;
            labelProveedor.Depth = 0;
            labelProveedor.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelProveedor.Location = new Point(12, 94);
            labelProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            labelProveedor.Name = "labelProveedor";
            labelProveedor.Size = new Size(76, 19);
            labelProveedor.TabIndex = 32;
            labelProveedor.Text = "Proveedor:";
            // 
            // TxtBuscarProveedor
            // 
            TxtBuscarProveedor.AnimateReadOnly = false;
            TxtBuscarProveedor.BorderStyle = BorderStyle.None;
            TxtBuscarProveedor.Depth = 0;
            TxtBuscarProveedor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtBuscarProveedor.Hint = "Buscar Proveedor";
            TxtBuscarProveedor.LeadingIcon = Properties.Resources.busqueda;
            TxtBuscarProveedor.Location = new Point(12, 115);
            TxtBuscarProveedor.Margin = new Padding(3, 2, 3, 2);
            TxtBuscarProveedor.MaxLength = 50;
            TxtBuscarProveedor.MouseState = MaterialSkin.MouseState.OUT;
            TxtBuscarProveedor.Multiline = false;
            TxtBuscarProveedor.Name = "TxtBuscarProveedor";
            TxtBuscarProveedor.Size = new Size(300, 50);
            TxtBuscarProveedor.TabIndex = 1;
            TxtBuscarProveedor.Text = "";
            TxtBuscarProveedor.TrailingIcon = null;
            TxtBuscarProveedor.TextChanged += TxtBuscarProveedor_TextChanged;
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
            LTotal.Location = new Point(623, 452);
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
            LDetalleCompra.Location = new Point(336, 60);
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
            LtexOrden.Location = new Point(12, 60);
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
            TxtCantidad.Location = new Point(186, 287);
            TxtCantidad.Margin = new Padding(3, 2, 3, 2);
            TxtCantidad.MaxLength = 50;
            TxtCantidad.MouseState = MaterialSkin.MouseState.OUT;
            TxtCantidad.Multiline = false;
            TxtCantidad.Name = "TxtCantidad";
            TxtCantidad.Size = new Size(126, 50);
            TxtCantidad.TabIndex = 3;
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
            TxtCostoUni.Location = new Point(12, 287);
            TxtCostoUni.Margin = new Padding(3, 2, 3, 2);
            TxtCostoUni.MaxLength = 50;
            TxtCostoUni.MouseState = MaterialSkin.MouseState.OUT;
            TxtCostoUni.Multiline = false;
            TxtCostoUni.Name = "TxtCostoUni";
            TxtCostoUni.Size = new Size(147, 50);
            TxtCostoUni.TabIndex = 4;
            TxtCostoUni.Text = "";
            TxtCostoUni.TrailingIcon = null;
            // 
            // TxtBuscarCoN
            // 
            TxtBuscarCoN.AnimateReadOnly = false;
            TxtBuscarCoN.BorderStyle = BorderStyle.None;
            TxtBuscarCoN.Depth = 0;
            TxtBuscarCoN.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtBuscarCoN.Hint = "Codigo o nombre del Producto";
            TxtBuscarCoN.LeadingIcon = Properties.Resources.busqueda;
            TxtBuscarCoN.Location = new Point(12, 218);
            TxtBuscarCoN.Margin = new Padding(3, 2, 3, 2);
            TxtBuscarCoN.MaxLength = 50;
            TxtBuscarCoN.MouseState = MaterialSkin.MouseState.OUT;
            TxtBuscarCoN.Multiline = false;
            TxtBuscarCoN.Name = "TxtBuscarCoN";
            TxtBuscarCoN.Size = new Size(300, 50);
            TxtBuscarCoN.TabIndex = 2;
            TxtBuscarCoN.Text = "";
            TxtBuscarCoN.TrailingIcon = null;
            TxtBuscarCoN.TextChanged += TxtBuscarCoN_TextChanged;
            // 
            // BtnAñadirComp
            // 
            BtnAñadirComp.AutoSize = false;
            BtnAñadirComp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnAñadirComp.BackColor = Color.IndianRed;
            BtnAñadirComp.Cursor = Cursors.Hand;
            BtnAñadirComp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnAñadirComp.Depth = 0;
            BtnAñadirComp.ForeColor = Color.CornflowerBlue;
            BtnAñadirComp.HighEmphasis = true;
            BtnAñadirComp.Icon = Properties.Resources.nuevo;
            BtnAñadirComp.Location = new Point(12, 358);
            BtnAñadirComp.Margin = new Padding(4);
            BtnAñadirComp.MouseState = MaterialSkin.MouseState.HOVER;
            BtnAñadirComp.Name = "BtnAñadirComp";
            BtnAñadirComp.NoAccentTextColor = Color.Empty;
            BtnAñadirComp.Size = new Size(300, 35);
            BtnAñadirComp.TabIndex = 5;
            BtnAñadirComp.Text = "Añadir A la Orden de Compra";
            BtnAñadirComp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnAñadirComp.UseAccentColor = false;
            BtnAñadirComp.UseVisualStyleBackColor = true;
            BtnAñadirComp.Click += BtnRecibido_Click;
            // 
            // BtnCancelarCompra
            // 
            BtnCancelarCompra.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnCancelarCompra.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnCancelarCompra.Cursor = Cursors.Hand;
            BtnCancelarCompra.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnCancelarCompra.Depth = 0;
            BtnCancelarCompra.HighEmphasis = true;
            BtnCancelarCompra.Icon = Properties.Resources.cancelar;
            BtnCancelarCompra.Location = new Point(439, 480);
            BtnCancelarCompra.Margin = new Padding(4);
            BtnCancelarCompra.MouseState = MaterialSkin.MouseState.HOVER;
            BtnCancelarCompra.Name = "BtnCancelarCompra";
            BtnCancelarCompra.NoAccentTextColor = Color.Empty;
            BtnCancelarCompra.Size = new Size(176, 36);
            BtnCancelarCompra.TabIndex = 7;
            BtnCancelarCompra.Text = "Cancelar orden";
            BtnCancelarCompra.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            BtnCancelarCompra.UseAccentColor = false;
            BtnCancelarCompra.UseVisualStyleBackColor = true;
            BtnCancelarCompra.Click += BtnCancelarCompra_Click;
            // 
            // BtnRegistrarCompra
            // 
            BtnRegistrarCompra.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnRegistrarCompra.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnRegistrarCompra.Cursor = Cursors.Hand;
            BtnRegistrarCompra.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnRegistrarCompra.Depth = 0;
            BtnRegistrarCompra.HighEmphasis = true;
            BtnRegistrarCompra.Icon = Properties.Resources.confirmar;
            BtnRegistrarCompra.Location = new Point(623, 480);
            BtnRegistrarCompra.Margin = new Padding(4);
            BtnRegistrarCompra.MouseState = MaterialSkin.MouseState.HOVER;
            BtnRegistrarCompra.Name = "BtnRegistrarCompra";
            BtnRegistrarCompra.NoAccentTextColor = Color.Empty;
            BtnRegistrarCompra.Size = new Size(265, 36);
            BtnRegistrarCompra.TabIndex = 6;
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
            lstClientes.Location = new Point(336, 94);
            lstClientes.Margin = new Padding(3, 2, 3, 2);
            lstClientes.MinimumSize = new Size(175, 75);
            lstClientes.MouseLocation = new Point(-1, -1);
            lstClientes.MouseState = MaterialSkin.MouseState.OUT;
            lstClientes.Name = "lstClientes";
            lstClientes.OwnerDraw = true;
            lstClientes.Size = new Size(552, 299);
            lstClientes.TabIndex = 17;
            lstClientes.TabStop = false;
            lstClientes.UseCompatibleStateImageBehavior = false;
            lstClientes.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "Codigo";
            ID.Width = 100;
            // 
            // Descripcion
            // 
            Descripcion.Text = "Descripcion";
            Descripcion.Width = 130;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            Cantidad.Width = 100;
            // 
            // CostoUni
            // 
            CostoUni.Text = "Costo unitario";
            CostoUni.Width = 130;
            // 
            // SubTotal
            // 
            SubTotal.Text = "SubTotal";
            SubTotal.Width = 130;
            // 
            // FormNuevaCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 530);
            Controls.Add(panel2);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormNuevaCompra";
            Padding = new Padding(0);
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
        private MaterialSkin.Controls.MaterialLabel labelProducto;
        private MaterialSkin.Controls.MaterialLabel labelProveedor;
    }
}