namespace RGTS.Interfaz.Vendedor
{
    partial class FormListadoVentas
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
            labelTitulo = new MaterialSkin.Controls.MaterialLabel();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            BtnNuevaVenta = new MaterialSkin.Controls.MaterialButton();
            BtnDetalleVenta = new MaterialSkin.Controls.MaterialButton();
            listaVentas = new MaterialSkin.Controls.MaterialListView();
            nroVenta = new ColumnHeader();
            fecha = new ColumnHeader();
            vendedor = new ColumnHeader();
            cliente = new ColumnHeader();
            total = new ColumnHeader();
            btnLimpiar = new MaterialSkin.Controls.MaterialButton();
            ComboBoxVendedor = new MaterialSkin.Controls.MaterialComboBox();
            labelHasta = new MaterialSkin.Controls.MaterialLabel();
            labelDesde = new MaterialSkin.Controls.MaterialLabel();
            DtpDesde = new DateTimePicker();
            DtpHasta = new DateTimePicker();
            TextBoxBuscarCliente = new MaterialSkin.Controls.MaterialTextBox2();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Depth = 0;
            labelTitulo.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            labelTitulo.Location = new Point(17, 19);
            labelTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(194, 29);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Listado de Ventas";
            // 
            // materialCard1
            // 
            materialCard1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(BtnNuevaVenta);
            materialCard1.Controls.Add(BtnDetalleVenta);
            materialCard1.Controls.Add(listaVentas);
            materialCard1.Controls.Add(btnLimpiar);
            materialCard1.Controls.Add(ComboBoxVendedor);
            materialCard1.Controls.Add(labelHasta);
            materialCard1.Controls.Add(labelDesde);
            materialCard1.Controls.Add(DtpDesde);
            materialCard1.Controls.Add(DtpHasta);
            materialCard1.Controls.Add(TextBoxBuscarCliente);
            materialCard1.Controls.Add(labelTitulo);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(1, 1);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(935, 534);
            materialCard1.TabIndex = 1;
            // 
            // BtnNuevaVenta
            // 
            BtnNuevaVenta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnNuevaVenta.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnNuevaVenta.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnNuevaVenta.Depth = 0;
            BtnNuevaVenta.HighEmphasis = true;
            BtnNuevaVenta.Icon = null;
            BtnNuevaVenta.Location = new Point(17, 480);
            BtnNuevaVenta.Margin = new Padding(4);
            BtnNuevaVenta.MouseState = MaterialSkin.MouseState.HOVER;
            BtnNuevaVenta.Name = "BtnNuevaVenta";
            BtnNuevaVenta.NoAccentTextColor = Color.Empty;
            BtnNuevaVenta.Size = new Size(120, 36);
            BtnNuevaVenta.TabIndex = 35;
            BtnNuevaVenta.Text = "Nueva Venta";
            BtnNuevaVenta.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnNuevaVenta.UseAccentColor = false;
            BtnNuevaVenta.UseVisualStyleBackColor = true;
            BtnNuevaVenta.Click += BtnNuevaVenta_Click;
            // 
            // BtnDetalleVenta
            // 
            BtnDetalleVenta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnDetalleVenta.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnDetalleVenta.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnDetalleVenta.Depth = 0;
            BtnDetalleVenta.HighEmphasis = true;
            BtnDetalleVenta.Icon = null;
            BtnDetalleVenta.Location = new Point(17, 348);
            BtnDetalleVenta.Margin = new Padding(4);
            BtnDetalleVenta.MouseState = MaterialSkin.MouseState.HOVER;
            BtnDetalleVenta.Name = "BtnDetalleVenta";
            BtnDetalleVenta.NoAccentTextColor = Color.Empty;
            BtnDetalleVenta.Size = new Size(176, 36);
            BtnDetalleVenta.TabIndex = 34;
            BtnDetalleVenta.Text = "Detalle de la Venta";
            BtnDetalleVenta.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            BtnDetalleVenta.UseAccentColor = false;
            BtnDetalleVenta.UseVisualStyleBackColor = true;
            BtnDetalleVenta.Click += BtnDetalleVenta_Click;
            // 
            // listaVentas
            // 
            listaVentas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listaVentas.AutoSizeTable = false;
            listaVentas.BackColor = Color.FromArgb(255, 255, 255);
            listaVentas.BorderStyle = BorderStyle.None;
            listaVentas.Columns.AddRange(new ColumnHeader[] { nroVenta, fecha, vendedor, cliente, total });
            listaVentas.Depth = 0;
            listaVentas.FullRowSelect = true;
            listaVentas.Location = new Point(17, 117);
            listaVentas.Margin = new Padding(3, 2, 3, 2);
            listaVentas.MinimumSize = new Size(175, 75);
            listaVentas.MouseLocation = new Point(-1, -1);
            listaVentas.MouseState = MaterialSkin.MouseState.OUT;
            listaVentas.Name = "listaVentas";
            listaVentas.OwnerDraw = true;
            listaVentas.Size = new Size(901, 225);
            listaVentas.TabIndex = 33;
            listaVentas.UseCompatibleStateImageBehavior = false;
            listaVentas.View = View.Details;
            listaVentas.SelectedIndexChanged += ListaVentas_SelectedIndexChanged;
            // 
            // nroVenta
            // 
            nroVenta.Text = "Nro Venta";
            nroVenta.Width = 100;
            // 
            // fecha
            // 
            fecha.Text = "Fecha";
            fecha.Width = 120;
            // 
            // vendedor
            // 
            vendedor.Text = "DNI Vendedor";
            vendedor.Width = 120;
            // 
            // cliente
            // 
            cliente.Text = "DNI Cliente";
            cliente.Width = 120;
            // 
            // total
            // 
            total.Text = "Total";
            total.Width = 120;
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
            btnLimpiar.Location = new Point(820, 348);
            btnLimpiar.Margin = new Padding(4);
            btnLimpiar.MouseState = MaterialSkin.MouseState.HOVER;
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.NoAccentTextColor = Color.Empty;
            btnLimpiar.Size = new Size(97, 35);
            btnLimpiar.TabIndex = 32;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnLimpiar.UseAccentColor = false;
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += BtnLimpiar_Click;
            // 
            // ComboBoxVendedor
            // 
            ComboBoxVendedor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ComboBoxVendedor.AutoResize = false;
            ComboBoxVendedor.BackColor = Color.FromArgb(255, 255, 255);
            ComboBoxVendedor.Depth = 0;
            ComboBoxVendedor.DrawMode = DrawMode.OwnerDrawVariable;
            ComboBoxVendedor.DropDownHeight = 174;
            ComboBoxVendedor.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxVendedor.DropDownWidth = 121;
            ComboBoxVendedor.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            ComboBoxVendedor.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ComboBoxVendedor.FormattingEnabled = true;
            ComboBoxVendedor.Hint = "Buscar por Vendedor";
            ComboBoxVendedor.IntegralHeight = false;
            ComboBoxVendedor.ItemHeight = 43;
            ComboBoxVendedor.Location = new Point(368, 62);
            ComboBoxVendedor.MaxDropDownItems = 4;
            ComboBoxVendedor.MouseState = MaterialSkin.MouseState.OUT;
            ComboBoxVendedor.Name = "ComboBoxVendedor";
            ComboBoxVendedor.Size = new Size(272, 49);
            ComboBoxVendedor.StartIndex = 0;
            ComboBoxVendedor.TabIndex = 31;
            // 
            // labelHasta
            // 
            labelHasta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelHasta.AutoSize = true;
            labelHasta.Depth = 0;
            labelHasta.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelHasta.Location = new Point(785, 66);
            labelHasta.MouseState = MaterialSkin.MouseState.HOVER;
            labelHasta.Name = "labelHasta";
            labelHasta.Size = new Size(47, 19);
            labelHasta.TabIndex = 30;
            labelHasta.Text = "Hasta:";
            // 
            // labelDesde
            // 
            labelDesde.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelDesde.AutoSize = true;
            labelDesde.Depth = 0;
            labelDesde.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelDesde.Location = new Point(646, 66);
            labelDesde.MouseState = MaterialSkin.MouseState.HOVER;
            labelDesde.Name = "labelDesde";
            labelDesde.Size = new Size(49, 19);
            labelDesde.TabIndex = 29;
            labelDesde.Text = "Desde:";
            // 
            // DtpDesde
            // 
            DtpDesde.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DtpDesde.CustomFormat = "dd/MM/yyyy";
            DtpDesde.Format = DateTimePickerFormat.Custom;
            DtpDesde.Location = new Point(646, 89);
            DtpDesde.Margin = new Padding(3, 2, 3, 2);
            DtpDesde.Name = "DtpDesde";
            DtpDesde.Size = new Size(133, 23);
            DtpDesde.TabIndex = 28;
            DtpDesde.ValueChanged += DtpDesde_ValueChanged;
            // 
            // DtpHasta
            // 
            DtpHasta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DtpHasta.CustomFormat = "dd/MM/yyyy";
            DtpHasta.Format = DateTimePickerFormat.Custom;
            DtpHasta.Location = new Point(785, 89);
            DtpHasta.Margin = new Padding(3, 2, 3, 2);
            DtpHasta.Name = "DtpHasta";
            DtpHasta.Size = new Size(133, 23);
            DtpHasta.TabIndex = 27;
            DtpHasta.ValueChanged += DtpHasta_ValueChanged;
            // 
            // TextBoxBuscarCliente
            // 
            TextBoxBuscarCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxBuscarCliente.AnimateReadOnly = false;
            TextBoxBuscarCliente.BackgroundImageLayout = ImageLayout.None;
            TextBoxBuscarCliente.CharacterCasing = CharacterCasing.Normal;
            TextBoxBuscarCliente.Depth = 0;
            TextBoxBuscarCliente.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextBoxBuscarCliente.HideSelection = true;
            TextBoxBuscarCliente.Hint = "Buscar por DNI Cliente";
            TextBoxBuscarCliente.LeadingIcon = null;
            TextBoxBuscarCliente.Location = new Point(17, 63);
            TextBoxBuscarCliente.MaxLength = 32767;
            TextBoxBuscarCliente.MouseState = MaterialSkin.MouseState.OUT;
            TextBoxBuscarCliente.Name = "TextBoxBuscarCliente";
            TextBoxBuscarCliente.PasswordChar = '\0';
            TextBoxBuscarCliente.PrefixSuffixText = null;
            TextBoxBuscarCliente.ReadOnly = false;
            TextBoxBuscarCliente.RightToLeft = RightToLeft.No;
            TextBoxBuscarCliente.SelectedText = "";
            TextBoxBuscarCliente.SelectionLength = 0;
            TextBoxBuscarCliente.SelectionStart = 0;
            TextBoxBuscarCliente.ShortcutsEnabled = true;
            TextBoxBuscarCliente.Size = new Size(345, 48);
            TextBoxBuscarCliente.TabIndex = 1;
            TextBoxBuscarCliente.TabStop = false;
            TextBoxBuscarCliente.TextAlign = HorizontalAlignment.Left;
            TextBoxBuscarCliente.TrailingIcon = null;
            TextBoxBuscarCliente.UseSystemPasswordChar = false;
            TextBoxBuscarCliente.TextChanged += TextBoxBuscarCliente_TextChanged;
            // 
            // FormListadoVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 534);
            Controls.Add(materialCard1);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "FormListadoVentas";
            Padding = new Padding(3, 0, 3, 3);
            Sizable = false;
            Text = "FormListaVentas";
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel labelTitulo;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox2 TextBoxBuscarCliente;
        private MaterialSkin.Controls.MaterialLabel labelHasta;
        private MaterialSkin.Controls.MaterialLabel labelDesde;
        private DateTimePicker DtpDesde;
        private DateTimePicker DtpHasta;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxVendedor;
        private MaterialSkin.Controls.MaterialButton btnLimpiar;
        private MaterialSkin.Controls.MaterialListView listaVentas;
        private ColumnHeader nroVenta;
        private ColumnHeader fecha;
        private ColumnHeader vendedor;
        private ColumnHeader cliente;
        private ColumnHeader total;
        private MaterialSkin.Controls.MaterialButton BtnDetalleVenta;
        private MaterialSkin.Controls.MaterialButton BtnNuevaVenta;
    }
}