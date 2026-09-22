namespace RGTS.Interfaz.Administrador
{
    partial class FormDetalleCompra
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
            panel1 = new MaterialSkin.Controls.MaterialCard();
            labelTotal = new MaterialSkin.Controls.MaterialLabel();
            labelEstado = new MaterialSkin.Controls.MaterialLabel();
            labelFecha = new MaterialSkin.Controls.MaterialLabel();
            labelProveedor = new MaterialSkin.Controls.MaterialLabel();
            labelTitulo = new MaterialSkin.Controls.MaterialLabel();
            BtnVolver = new MaterialSkin.Controls.MaterialButton();
            materialCard4 = new MaterialSkin.Controls.MaterialCard();
            LTotal = new MaterialSkin.Controls.MaterialLabel();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            LEstado = new MaterialSkin.Controls.MaterialLabel();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            LFecha = new MaterialSkin.Controls.MaterialLabel();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            LProveedor = new MaterialSkin.Controls.MaterialLabel();
            LstProductos = new MaterialSkin.Controls.MaterialListView();
            Codigo = new ColumnHeader();
            Descripcion = new ColumnHeader();
            Cantidad = new ColumnHeader();
            Costo = new ColumnHeader();
            SubTotal = new ColumnHeader();
            panel1.SuspendLayout();
            materialCard4.SuspendLayout();
            materialCard3.SuspendLayout();
            materialCard2.SuspendLayout();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(255, 255, 255);
            panel1.Controls.Add(labelTotal);
            panel1.Controls.Add(labelEstado);
            panel1.Controls.Add(labelFecha);
            panel1.Controls.Add(labelProveedor);
            panel1.Controls.Add(labelTitulo);
            panel1.Controls.Add(BtnVolver);
            panel1.Controls.Add(materialCard4);
            panel1.Controls.Add(materialCard3);
            panel1.Controls.Add(materialCard2);
            panel1.Controls.Add(materialCard1);
            panel1.Controls.Add(LstProductos);
            panel1.Depth = 0;
            panel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panel1.Location = new Point(16, 10);
            panel1.Margin = new Padding(12, 10, 12, 10);
            panel1.MouseState = MaterialSkin.MouseState.HOVER;
            panel1.Name = "panel1";
            panel1.Padding = new Padding(12, 10, 12, 10);
            panel1.Size = new Size(849, 485);
            panel1.TabIndex = 9;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Depth = 0;
            labelTotal.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelTotal.Location = new Point(639, 56);
            labelTotal.MouseState = MaterialSkin.MouseState.HOVER;
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(42, 19);
            labelTotal.TabIndex = 14;
            labelTotal.Text = "Total ";
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Depth = 0;
            labelEstado.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelEstado.Location = new Point(458, 56);
            labelEstado.MouseState = MaterialSkin.MouseState.HOVER;
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(129, 19);
            labelEstado.TabIndex = 13;
            labelEstado.Text = "Estado de compra";
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Depth = 0;
            labelFecha.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelFecha.Location = new Point(302, 56);
            labelFecha.MouseState = MaterialSkin.MouseState.HOVER;
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(44, 19);
            labelFecha.TabIndex = 12;
            labelFecha.Text = "Fecha";
            // 
            // labelProveedor
            // 
            labelProveedor.AutoSize = true;
            labelProveedor.Depth = 0;
            labelProveedor.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelProveedor.Location = new Point(50, 56);
            labelProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            labelProveedor.Name = "labelProveedor";
            labelProveedor.Size = new Size(72, 19);
            labelProveedor.TabIndex = 11;
            labelProveedor.Text = "Proveedor";
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
            labelTitulo.Size = new Size(200, 29);
            labelTitulo.TabIndex = 10;
            labelTitulo.Text = "Detalle de Compra";
            // 
            // BtnVolver
            // 
            BtnVolver.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnVolver.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnVolver.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnVolver.Depth = 0;
            BtnVolver.HighEmphasis = true;
            BtnVolver.Icon = null;
            BtnVolver.Location = new Point(47, 435);
            BtnVolver.Margin = new Padding(4);
            BtnVolver.MouseState = MaterialSkin.MouseState.HOVER;
            BtnVolver.Name = "BtnVolver";
            BtnVolver.NoAccentTextColor = Color.Empty;
            BtnVolver.Size = new Size(126, 36);
            BtnVolver.TabIndex = 9;
            BtnVolver.Text = "Volver atras";
            BtnVolver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnVolver.UseAccentColor = false;
            BtnVolver.UseVisualStyleBackColor = true;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // materialCard4
            // 
            materialCard4.BackColor = Color.FromArgb(255, 255, 255);
            materialCard4.Controls.Add(LTotal);
            materialCard4.Depth = 0;
            materialCard4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard4.Location = new Point(639, 77);
            materialCard4.Margin = new Padding(12, 10, 12, 10);
            materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard4.Name = "materialCard4";
            materialCard4.Padding = new Padding(12, 10, 12, 10);
            materialCard4.Size = new Size(176, 44);
            materialCard4.TabIndex = 8;
            // 
            // LTotal
            // 
            LTotal.Depth = 0;
            LTotal.Dock = DockStyle.Fill;
            LTotal.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LTotal.Location = new Point(12, 10);
            LTotal.MouseState = MaterialSkin.MouseState.HOVER;
            LTotal.Name = "LTotal";
            LTotal.Size = new Size(152, 24);
            LTotal.TabIndex = 0;
            LTotal.Text = "Total de compra";
            // 
            // materialCard3
            // 
            materialCard3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(LEstado);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(458, 77);
            materialCard3.Margin = new Padding(12, 10, 12, 10);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(12, 10, 12, 10);
            materialCard3.Size = new Size(157, 42);
            materialCard3.TabIndex = 7;
            // 
            // LEstado
            // 
            LEstado.AutoSize = true;
            LEstado.Depth = 0;
            LEstado.Dock = DockStyle.Fill;
            LEstado.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LEstado.Location = new Point(12, 10);
            LEstado.MouseState = MaterialSkin.MouseState.HOVER;
            LEstado.Name = "LEstado";
            LEstado.Size = new Size(50, 19);
            LEstado.TabIndex = 0;
            LEstado.Text = "Estado";
            // 
            // materialCard2
            // 
            materialCard2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(LFecha);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(302, 77);
            materialCard2.Margin = new Padding(12, 10, 12, 10);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(12, 10, 12, 10);
            materialCard2.Size = new Size(132, 42);
            materialCard2.TabIndex = 6;
            // 
            // LFecha
            // 
            LFecha.AutoSize = true;
            LFecha.Depth = 0;
            LFecha.Dock = DockStyle.Fill;
            LFecha.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LFecha.Location = new Point(12, 10);
            LFecha.MouseState = MaterialSkin.MouseState.HOVER;
            LFecha.Name = "LFecha";
            LFecha.Size = new Size(44, 19);
            LFecha.TabIndex = 0;
            LFecha.Text = "Fecha";
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(LProveedor);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(47, 77);
            materialCard1.Margin = new Padding(12, 10, 12, 10);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(12, 10, 12, 10);
            materialCard1.Size = new Size(231, 42);
            materialCard1.TabIndex = 5;
            // 
            // LProveedor
            // 
            LProveedor.AutoSize = true;
            LProveedor.Depth = 0;
            LProveedor.Dock = DockStyle.Fill;
            LProveedor.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LProveedor.Location = new Point(12, 10);
            LProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            LProveedor.Name = "LProveedor";
            LProveedor.Size = new Size(72, 19);
            LProveedor.TabIndex = 0;
            LProveedor.Text = "Proveedor";
            // 
            // LstProductos
            // 
            LstProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LstProductos.AutoSizeTable = false;
            LstProductos.BackColor = Color.FromArgb(255, 255, 255);
            LstProductos.BorderStyle = BorderStyle.None;
            LstProductos.Columns.AddRange(new ColumnHeader[] { Codigo, Descripcion, Cantidad, Costo, SubTotal });
            LstProductos.Depth = 0;
            LstProductos.FullRowSelect = true;
            LstProductos.Location = new Point(47, 132);
            LstProductos.Margin = new Padding(3, 2, 3, 2);
            LstProductos.MinimumSize = new Size(175, 75);
            LstProductos.MouseLocation = new Point(-1, -1);
            LstProductos.MouseState = MaterialSkin.MouseState.OUT;
            LstProductos.Name = "LstProductos";
            LstProductos.OwnerDraw = true;
            LstProductos.Size = new Size(768, 220);
            LstProductos.TabIndex = 4;
            LstProductos.UseCompatibleStateImageBehavior = false;
            LstProductos.View = View.Details;
            // 
            // Codigo
            // 
            Codigo.Text = "Codigo";
            Codigo.Width = 100;
            // 
            // Descripcion
            // 
            Descripcion.Text = "Descripcion";
            Descripcion.Width = 150;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            Cantidad.Width = 100;
            // 
            // Costo
            // 
            Costo.Text = "Costo Unitario";
            Costo.Width = 100;
            // 
            // SubTotal
            // 
            SubTotal.Text = "SubTotal";
            SubTotal.Width = 100;
            // 
            // FormDetalleCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 507);
            Controls.Add(panel1);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormDetalleCompra";
            Padding = new Padding(3, 0, 3, 2);
            Sizable = false;
            Text = "Detalle de Compra:";
            Load += FormDetalleCompra_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            materialCard4.ResumeLayout(false);
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard panel1;
        private MaterialSkin.Controls.MaterialListView LstProductos;
        private ColumnHeader Codigo;
        private ColumnHeader Descripcion;
        private ColumnHeader Cantidad;
        private ColumnHeader Costo;
        private ColumnHeader SubTotal;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel LEstado;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel LFecha;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel LProveedor;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialLabel LTotal;
        private MaterialSkin.Controls.MaterialButton BtnVolver;
        private MaterialSkin.Controls.MaterialLabel labelTitulo;
        private MaterialSkin.Controls.MaterialLabel labelTotal;
        private MaterialSkin.Controls.MaterialLabel labelEstado;
        private MaterialSkin.Controls.MaterialLabel labelFecha;
        private MaterialSkin.Controls.MaterialLabel labelProveedor;
    }
}