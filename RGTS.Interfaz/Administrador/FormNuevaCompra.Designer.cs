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
            LTotal = new MaterialSkin.Controls.MaterialLabel();
            LDetalleCompra = new MaterialSkin.Controls.MaterialLabel();
            LtexOrden = new MaterialSkin.Controls.MaterialLabel();
            TxtCantidad = new MaterialSkin.Controls.MaterialTextBox();
            TxtCostoUni = new MaterialSkin.Controls.MaterialTextBox();
            TxtBuscarCoN = new MaterialSkin.Controls.MaterialTextBox();
            CmbFiltroProvee = new MaterialSkin.Controls.MaterialComboBox();
            BtnAñadirComp = new MaterialSkin.Controls.MaterialButton();
            BtnCancelarCompra = new MaterialSkin.Controls.MaterialButton();
            BtnRegistrarCompra = new MaterialSkin.Controls.MaterialButton();
            lstClientes = new MaterialSkin.Controls.MaterialListView();
            ID = new ColumnHeader();
            Descripcion = new ColumnHeader();
            Cantidad = new ColumnHeader();
            CostoUni = new ColumnHeader();
            SubTotal = new ColumnHeader();
            labelTitulo = new MaterialSkin.Controls.MaterialLabel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(255, 255, 255);
            panel2.Controls.Add(labelTitulo);
            panel2.Controls.Add(LTotal);
            panel2.Controls.Add(LDetalleCompra);
            panel2.Controls.Add(LtexOrden);
            panel2.Controls.Add(TxtCantidad);
            panel2.Controls.Add(TxtCostoUni);
            panel2.Controls.Add(TxtBuscarCoN);
            panel2.Controls.Add(CmbFiltroProvee);
            panel2.Controls.Add(BtnAñadirComp);
            panel2.Controls.Add(BtnCancelarCompra);
            panel2.Controls.Add(BtnRegistrarCompra);
            panel2.Controls.Add(lstClientes);
            panel2.Depth = 0;
            panel2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panel2.Location = new Point(4, 5);
            panel2.Margin = new Padding(12, 10, 12, 10);
            panel2.MouseState = MaterialSkin.MouseState.HOVER;
            panel2.Name = "panel2";
            panel2.Padding = new Padding(12, 10, 12, 10);
            panel2.Size = new Size(848, 520);
            panel2.TabIndex = 4;
            // 
            // LTotal
            // 
            LTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LTotal.AutoSize = true;
            LTotal.Depth = 0;
            LTotal.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LTotal.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LTotal.Location = new Point(731, 430);
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
            LDetalleCompra.Location = new Point(314, 76);
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
            LtexOrden.Location = new Point(17, 76);
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
            TxtCantidad.Location = new Point(169, 204);
            TxtCantidad.Margin = new Padding(3, 2, 3, 2);
            TxtCantidad.MaxLength = 50;
            TxtCantidad.MouseState = MaterialSkin.MouseState.OUT;
            TxtCantidad.Multiline = false;
            TxtCantidad.Name = "TxtCantidad";
            TxtCantidad.Size = new Size(104, 50);
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
            TxtCostoUni.Location = new Point(17, 204);
            TxtCostoUni.Margin = new Padding(3, 2, 3, 2);
            TxtCostoUni.MaxLength = 50;
            TxtCostoUni.MouseState = MaterialSkin.MouseState.OUT;
            TxtCostoUni.Multiline = false;
            TxtCostoUni.Name = "TxtCostoUni";
            TxtCostoUni.Size = new Size(147, 50);
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
            TxtBuscarCoN.Location = new Point(16, 150);
            TxtBuscarCoN.Margin = new Padding(3, 2, 3, 2);
            TxtBuscarCoN.MaxLength = 50;
            TxtBuscarCoN.MouseState = MaterialSkin.MouseState.OUT;
            TxtBuscarCoN.Multiline = false;
            TxtBuscarCoN.Name = "TxtBuscarCoN";
            TxtBuscarCoN.Size = new Size(257, 50);
            TxtBuscarCoN.TabIndex = 25;
            TxtBuscarCoN.Text = "";
            TxtBuscarCoN.TrailingIcon = null;
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
            CmbFiltroProvee.Location = new Point(16, 97);
            CmbFiltroProvee.Margin = new Padding(3, 2, 3, 2);
            CmbFiltroProvee.MaxDropDownItems = 4;
            CmbFiltroProvee.MouseState = MaterialSkin.MouseState.OUT;
            CmbFiltroProvee.Name = "CmbFiltroProvee";
            CmbFiltroProvee.Size = new Size(258, 49);
            CmbFiltroProvee.StartIndex = 0;
            CmbFiltroProvee.TabIndex = 21;
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
            BtnAñadirComp.Location = new Point(17, 272);
            BtnAñadirComp.Margin = new Padding(4, 4, 4, 4);
            BtnAñadirComp.MouseState = MaterialSkin.MouseState.HOVER;
            BtnAñadirComp.Name = "BtnAñadirComp";
            BtnAñadirComp.NoAccentTextColor = Color.Empty;
            BtnAñadirComp.Size = new Size(257, 35);
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
            BtnCancelarCompra.Location = new Point(493, 470);
            BtnCancelarCompra.Margin = new Padding(4, 4, 4, 4);
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
            BtnRegistrarCompra.Location = new Point(597, 470);
            BtnRegistrarCompra.Margin = new Padding(4, 4, 4, 4);
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
            lstClientes.Location = new Point(314, 97);
            lstClientes.Margin = new Padding(3, 2, 3, 2);
            lstClientes.MinimumSize = new Size(175, 75);
            lstClientes.MouseLocation = new Point(-1, -1);
            lstClientes.MouseState = MaterialSkin.MouseState.OUT;
            lstClientes.Name = "lstClientes";
            lstClientes.OwnerDraw = true;
            lstClientes.Size = new Size(519, 310);
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
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Depth = 0;
            labelTitulo.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            labelTitulo.Location = new Point(15, 10);
            labelTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(264, 29);
            labelTitulo.TabIndex = 31;
            labelTitulo.Text = "Nueva Orden de Compra";
            // 
            // FormNuevaCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 530);
            Controls.Add(panel2);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormNuevaCompra";
            Padding = new Padding(3, 0, 3, 2);
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
        private MaterialSkin.Controls.MaterialComboBox CmbFiltroProvee;
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
    }
}