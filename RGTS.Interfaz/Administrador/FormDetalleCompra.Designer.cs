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
            ListViewGroup listViewGroup1 = new ListViewGroup("Codigo", HorizontalAlignment.Left);
            panel1 = new Panel();
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
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(BtnVolver);
            panel1.Controls.Add(materialCard4);
            panel1.Controls.Add(materialCard3);
            panel1.Controls.Add(materialCard2);
            panel1.Controls.Add(materialCard1);
            panel1.Controls.Add(LstProductos);
            panel1.Location = new Point(18, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(970, 480);
            panel1.TabIndex = 9;
            // 
            // BtnVolver
            // 
            BtnVolver.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnVolver.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnVolver.Depth = 0;
            BtnVolver.HighEmphasis = true;
            BtnVolver.Icon = null;
            BtnVolver.Location = new Point(54, 422);
            BtnVolver.Margin = new Padding(4, 6, 4, 6);
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
            materialCard4.Location = new Point(722, 14);
            materialCard4.Margin = new Padding(14);
            materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard4.Name = "materialCard4";
            materialCard4.Padding = new Padding(14);
            materialCard4.Size = new Size(201, 59);
            materialCard4.TabIndex = 8;
            // 
            // LTotal
            // 
            LTotal.AutoSize = true;
            LTotal.Depth = 0;
            LTotal.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LTotal.Location = new Point(0, 7);
            LTotal.MouseState = MaterialSkin.MouseState.HOVER;
            LTotal.Name = "LTotal";
            LTotal.Size = new Size(117, 19);
            LTotal.TabIndex = 0;
            LTotal.Text = "Total de compra";
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(LEstado);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(458, 14);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(179, 56);
            materialCard3.TabIndex = 7;
            // 
            // LEstado
            // 
            LEstado.AutoSize = true;
            LEstado.Depth = 0;
            LEstado.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LEstado.Location = new Point(0, 0);
            LEstado.MouseState = MaterialSkin.MouseState.HOVER;
            LEstado.Name = "LEstado";
            LEstado.Size = new Size(50, 19);
            LEstado.TabIndex = 0;
            LEstado.Text = "Estado";
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(LFecha);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(337, 14);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(113, 56);
            materialCard2.TabIndex = 6;
            // 
            // LFecha
            // 
            LFecha.AutoSize = true;
            LFecha.Depth = 0;
            LFecha.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LFecha.Location = new Point(0, 0);
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
            materialCard1.Location = new Point(54, 14);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(264, 56);
            materialCard1.TabIndex = 5;
            // 
            // LProveedor
            // 
            LProveedor.AutoSize = true;
            LProveedor.Depth = 0;
            LProveedor.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LProveedor.Location = new Point(0, 0);
            LProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            LProveedor.Name = "LProveedor";
            LProveedor.Size = new Size(72, 19);
            LProveedor.TabIndex = 0;
            LProveedor.Text = "Proveedor";
            // 
            // LstProductos
            // 
            LstProductos.AutoSizeTable = false;
            LstProductos.BackColor = Color.FromArgb(255, 255, 255);
            LstProductos.BorderStyle = BorderStyle.None;
            LstProductos.Columns.AddRange(new ColumnHeader[] { Codigo, Descripcion, Cantidad, Costo, SubTotal });
            LstProductos.Depth = 0;
            LstProductos.FullRowSelect = true;
            listViewGroup1.Header = "Codigo";
            listViewGroup1.Name = "listViewGroup1";
            LstProductos.Groups.AddRange(new ListViewGroup[] { listViewGroup1 });
            LstProductos.Location = new Point(54, 87);
            LstProductos.MinimumSize = new Size(200, 100);
            LstProductos.MouseLocation = new Point(-1, -1);
            LstProductos.MouseState = MaterialSkin.MouseState.OUT;
            LstProductos.Name = "LstProductos";
            LstProductos.OwnerDraw = true;
            LstProductos.Size = new Size(869, 293);
            LstProductos.TabIndex = 4;
            LstProductos.UseCompatibleStateImageBehavior = false;
            LstProductos.View = View.Details;
            // 
            // Codigo
            // 
            Codigo.Text = "Codigo Pro";
            Codigo.Width = 80;
            // 
            // Descripcion
            // 
            Descripcion.Text = "Descripcion";
            Descripcion.Width = 100;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            Cantidad.Width = 100;
            // 
            // Costo
            // 
            Costo.Text = "Costo Uni";
            Costo.Width = 80;
            // 
            // SubTotal
            // 
            SubTotal.Text = "SubTotal";
            SubTotal.Width = 80;
            // 
            // FormDetalleCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 591);
            Controls.Add(panel1);
            Name = "FormDetalleCompra";
            Text = "Detalle de Compra:";
            Load += FormDetalleCompra_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            materialCard4.ResumeLayout(false);
            materialCard4.PerformLayout();
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
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
    }
}