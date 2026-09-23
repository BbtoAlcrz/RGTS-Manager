namespace RGTS.Interfaz.Vendedor
{
    partial class FormNuevaVenta
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
            btnBuscarProducto = new MaterialSkin.Controls.MaterialButton();
            labelMetodoPago = new MaterialSkin.Controls.MaterialLabel();
            labelDetalleVenta = new MaterialSkin.Controls.MaterialLabel();
            labelTotalCompraValor = new MaterialSkin.Controls.MaterialLabel();
            btnCancelarCompra = new MaterialSkin.Controls.MaterialButton();
            btnConfirmarCompra = new MaterialSkin.Controls.MaterialButton();
            comboBoxMetodoPago = new MaterialSkin.Controls.MaterialComboBox();
            btnCancelarAgregado = new MaterialSkin.Controls.MaterialButton();
            btnAgregarProducto = new MaterialSkin.Controls.MaterialButton();
            labelStockDisponibleValor = new MaterialSkin.Controls.MaterialLabel();
            labelStockDisponibleTitulo = new MaterialSkin.Controls.MaterialLabel();
            numericCantidadProducto = new NumericUpDown();
            labelPrecioProductoValor = new MaterialSkin.Controls.MaterialLabel();
            labelNombreProductoValor = new MaterialSkin.Controls.MaterialLabel();
            labelCantidadProducto = new MaterialSkin.Controls.MaterialLabel();
            labelPrecioProductoTitulo = new MaterialSkin.Controls.MaterialLabel();
            labelNombreProductoTitulo = new MaterialSkin.Controls.MaterialLabel();
            txtBuscarProducto = new MaterialSkin.Controls.MaterialTextBox2();
            labelApellidoValor = new MaterialSkin.Controls.MaterialLabel();
            labelNombreValor = new MaterialSkin.Controls.MaterialLabel();
            labelApellidoTitulo = new MaterialSkin.Controls.MaterialLabel();
            labelNombreTitulo = new MaterialSkin.Controls.MaterialLabel();
            BtnBuscarDniCliente = new MaterialSkin.Controls.MaterialButton();
            txtBuscarDniCliente = new MaterialSkin.Controls.MaterialTextBox2();
            labelProducto = new MaterialSkin.Controls.MaterialLabel();
            labelCliente = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            labelTotalCompraTitulo = new MaterialSkin.Controls.MaterialLabel();
            ListaDetalleVenta = new MaterialSkin.Controls.MaterialListView();
            Codigo = new ColumnHeader();
            Producto = new ColumnHeader();
            Cantidad = new ColumnHeader();
            Precio = new ColumnHeader();
            Subtotal = new ColumnHeader();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericCantidadProducto).BeginInit();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(btnBuscarProducto);
            materialCard1.Controls.Add(labelMetodoPago);
            materialCard1.Controls.Add(labelDetalleVenta);
            materialCard1.Controls.Add(labelTotalCompraValor);
            materialCard1.Controls.Add(btnCancelarCompra);
            materialCard1.Controls.Add(btnConfirmarCompra);
            materialCard1.Controls.Add(comboBoxMetodoPago);
            materialCard1.Controls.Add(btnCancelarAgregado);
            materialCard1.Controls.Add(btnAgregarProducto);
            materialCard1.Controls.Add(labelStockDisponibleValor);
            materialCard1.Controls.Add(labelStockDisponibleTitulo);
            materialCard1.Controls.Add(numericCantidadProducto);
            materialCard1.Controls.Add(labelPrecioProductoValor);
            materialCard1.Controls.Add(labelNombreProductoValor);
            materialCard1.Controls.Add(labelCantidadProducto);
            materialCard1.Controls.Add(labelPrecioProductoTitulo);
            materialCard1.Controls.Add(labelNombreProductoTitulo);
            materialCard1.Controls.Add(txtBuscarProducto);
            materialCard1.Controls.Add(labelApellidoValor);
            materialCard1.Controls.Add(labelNombreValor);
            materialCard1.Controls.Add(labelApellidoTitulo);
            materialCard1.Controls.Add(labelNombreTitulo);
            materialCard1.Controls.Add(BtnBuscarDniCliente);
            materialCard1.Controls.Add(txtBuscarDniCliente);
            materialCard1.Controls.Add(labelProducto);
            materialCard1.Controls.Add(labelCliente);
            materialCard1.Controls.Add(materialLabel1);
            materialCard1.Controls.Add(labelTotalCompraTitulo);
            materialCard1.Controls.Add(ListaDetalleVenta);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(0, 1);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(970, 532);
            materialCard1.TabIndex = 0;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBuscarProducto.AutoSize = false;
            btnBuscarProducto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBuscarProducto.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            btnBuscarProducto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnBuscarProducto.Depth = 0;
            btnBuscarProducto.HighEmphasis = true;
            btnBuscarProducto.Icon = null;
            btnBuscarProducto.Location = new Point(274, 257);
            btnBuscarProducto.Margin = new Padding(4, 6, 4, 6);
            btnBuscarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.NoAccentTextColor = Color.Empty;
            btnBuscarProducto.Size = new Size(119, 48);
            btnBuscarProducto.TabIndex = 27;
            btnBuscarProducto.Text = "Buscar Producto";
            btnBuscarProducto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnBuscarProducto.UseAccentColor = false;
            btnBuscarProducto.UseVisualStyleBackColor = true;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // labelMetodoPago
            // 
            labelMetodoPago.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelMetodoPago.AutoSize = true;
            labelMetodoPago.Depth = 0;
            labelMetodoPago.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelMetodoPago.Location = new Point(551, 388);
            labelMetodoPago.MouseState = MaterialSkin.MouseState.HOVER;
            labelMetodoPago.Name = "labelMetodoPago";
            labelMetodoPago.Size = new Size(121, 19);
            labelMetodoPago.TabIndex = 26;
            labelMetodoPago.Text = "Método de Pago:";
            labelMetodoPago.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelDetalleVenta
            // 
            labelDetalleVenta.AutoSize = true;
            labelDetalleVenta.Depth = 0;
            labelDetalleVenta.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelDetalleVenta.Location = new Point(428, 34);
            labelDetalleVenta.MouseState = MaterialSkin.MouseState.HOVER;
            labelDetalleVenta.Name = "labelDetalleVenta";
            labelDetalleVenta.Size = new Size(116, 19);
            labelDetalleVenta.TabIndex = 25;
            labelDetalleVenta.Text = "Detalle de Venta";
            // 
            // labelTotalCompraValor
            // 
            labelTotalCompraValor.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelTotalCompraValor.AutoSize = true;
            labelTotalCompraValor.Depth = 0;
            labelTotalCompraValor.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelTotalCompraValor.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            labelTotalCompraValor.Location = new Point(780, 332);
            labelTotalCompraValor.MouseState = MaterialSkin.MouseState.HOVER;
            labelTotalCompraValor.Name = "labelTotalCompraValor";
            labelTotalCompraValor.Size = new Size(8, 24);
            labelTotalCompraValor.TabIndex = 24;
            labelTotalCompraValor.Text = "-";
            // 
            // btnCancelarCompra
            // 
            btnCancelarCompra.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelarCompra.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelarCompra.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelarCompra.Depth = 0;
            btnCancelarCompra.HighEmphasis = true;
            btnCancelarCompra.Icon = null;
            btnCancelarCompra.Location = new Point(856, 427);
            btnCancelarCompra.Margin = new Padding(4, 6, 4, 6);
            btnCancelarCompra.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancelarCompra.Name = "btnCancelarCompra";
            btnCancelarCompra.NoAccentTextColor = Color.Empty;
            btnCancelarCompra.Size = new Size(96, 36);
            btnCancelarCompra.TabIndex = 23;
            btnCancelarCompra.Text = "Cancelar";
            btnCancelarCompra.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnCancelarCompra.UseAccentColor = false;
            btnCancelarCompra.UseVisualStyleBackColor = true;
            btnCancelarCompra.Click += BtnCancelarCompra_Click;
            // 
            // btnConfirmarCompra
            // 
            btnConfirmarCompra.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConfirmarCompra.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnConfirmarCompra.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnConfirmarCompra.Depth = 0;
            btnConfirmarCompra.HighEmphasis = true;
            btnConfirmarCompra.Icon = null;
            btnConfirmarCompra.Location = new Point(678, 427);
            btnConfirmarCompra.Margin = new Padding(4, 6, 4, 6);
            btnConfirmarCompra.MouseState = MaterialSkin.MouseState.HOVER;
            btnConfirmarCompra.Name = "btnConfirmarCompra";
            btnConfirmarCompra.NoAccentTextColor = Color.Empty;
            btnConfirmarCompra.Size = new Size(170, 36);
            btnConfirmarCompra.TabIndex = 22;
            btnConfirmarCompra.Text = "Confirmar compra";
            btnConfirmarCompra.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnConfirmarCompra.UseAccentColor = false;
            btnConfirmarCompra.UseVisualStyleBackColor = true;
            btnConfirmarCompra.Click += BtnConfirmarCompra_Click;
            // 
            // comboBoxMetodoPago
            // 
            comboBoxMetodoPago.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            comboBoxMetodoPago.AutoResize = false;
            comboBoxMetodoPago.BackColor = Color.FromArgb(255, 255, 255);
            comboBoxMetodoPago.Depth = 0;
            comboBoxMetodoPago.DrawMode = DrawMode.OwnerDrawVariable;
            comboBoxMetodoPago.DropDownHeight = 174;
            comboBoxMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMetodoPago.DropDownWidth = 121;
            comboBoxMetodoPago.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comboBoxMetodoPago.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboBoxMetodoPago.FormattingEnabled = true;
            comboBoxMetodoPago.IntegralHeight = false;
            comboBoxMetodoPago.ItemHeight = 43;
            comboBoxMetodoPago.Location = new Point(678, 359);
            comboBoxMetodoPago.MaxDropDownItems = 4;
            comboBoxMetodoPago.MouseState = MaterialSkin.MouseState.OUT;
            comboBoxMetodoPago.Name = "comboBoxMetodoPago";
            comboBoxMetodoPago.Size = new Size(275, 49);
            comboBoxMetodoPago.StartIndex = 0;
            comboBoxMetodoPago.TabIndex = 21;
            // 
            // btnCancelarAgregado
            // 
            btnCancelarAgregado.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelarAgregado.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelarAgregado.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelarAgregado.Depth = 0;
            btnCancelarAgregado.HighEmphasis = true;
            btnCancelarAgregado.Icon = null;
            btnCancelarAgregado.Location = new Point(197, 427);
            btnCancelarAgregado.Margin = new Padding(4, 6, 4, 6);
            btnCancelarAgregado.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancelarAgregado.Name = "btnCancelarAgregado";
            btnCancelarAgregado.NoAccentTextColor = Color.Empty;
            btnCancelarAgregado.Size = new Size(96, 36);
            btnCancelarAgregado.TabIndex = 20;
            btnCancelarAgregado.Text = "Cancelar ";
            btnCancelarAgregado.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnCancelarAgregado.UseAccentColor = false;
            btnCancelarAgregado.UseVisualStyleBackColor = true;
            btnCancelarAgregado.Click += btnCancelarAgregado_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAgregarProducto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAgregarProducto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAgregarProducto.Depth = 0;
            btnAgregarProducto.HighEmphasis = true;
            btnAgregarProducto.Icon = null;
            btnAgregarProducto.Location = new Point(21, 427);
            btnAgregarProducto.Margin = new Padding(4, 6, 4, 6);
            btnAgregarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.NoAccentTextColor = Color.Empty;
            btnAgregarProducto.Size = new Size(168, 36);
            btnAgregarProducto.TabIndex = 19;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAgregarProducto.UseAccentColor = false;
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += BtnAgregarProducto_Click;
            // 
            // labelStockDisponibleValor
            // 
            labelStockDisponibleValor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelStockDisponibleValor.AutoSize = true;
            labelStockDisponibleValor.Depth = 0;
            labelStockDisponibleValor.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelStockDisponibleValor.Location = new Point(247, 388);
            labelStockDisponibleValor.MouseState = MaterialSkin.MouseState.HOVER;
            labelStockDisponibleValor.Name = "labelStockDisponibleValor";
            labelStockDisponibleValor.Size = new Size(5, 19);
            labelStockDisponibleValor.TabIndex = 18;
            labelStockDisponibleValor.Text = "-";
            // 
            // labelStockDisponibleTitulo
            // 
            labelStockDisponibleTitulo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelStockDisponibleTitulo.AutoSize = true;
            labelStockDisponibleTitulo.Depth = 0;
            labelStockDisponibleTitulo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelStockDisponibleTitulo.Location = new Point(177, 388);
            labelStockDisponibleTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            labelStockDisponibleTitulo.Name = "labelStockDisponibleTitulo";
            labelStockDisponibleTitulo.Size = new Size(64, 19);
            labelStockDisponibleTitulo.TabIndex = 17;
            labelStockDisponibleTitulo.Text = "Quedan: ";
            // 
            // numericCantidadProducto
            // 
            numericCantidadProducto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            numericCantidadProducto.BorderStyle = BorderStyle.FixedSingle;
            numericCantidadProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericCantidadProducto.Location = new Point(96, 383);
            numericCantidadProducto.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericCantidadProducto.Name = "numericCantidadProducto";
            numericCantidadProducto.Size = new Size(75, 29);
            numericCantidadProducto.TabIndex = 16;
            numericCantidadProducto.TextAlign = HorizontalAlignment.Center;
            numericCantidadProducto.UpDownAlign = LeftRightAlignment.Left;
            numericCantidadProducto.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelPrecioProductoValor
            // 
            labelPrecioProductoValor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelPrecioProductoValor.AutoSize = true;
            labelPrecioProductoValor.Depth = 0;
            labelPrecioProductoValor.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelPrecioProductoValor.Location = new Point(156, 345);
            labelPrecioProductoValor.MouseState = MaterialSkin.MouseState.HOVER;
            labelPrecioProductoValor.Name = "labelPrecioProductoValor";
            labelPrecioProductoValor.Size = new Size(5, 19);
            labelPrecioProductoValor.TabIndex = 15;
            labelPrecioProductoValor.Text = "-";
            // 
            // labelNombreProductoValor
            // 
            labelNombreProductoValor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelNombreProductoValor.AutoSize = true;
            labelNombreProductoValor.Depth = 0;
            labelNombreProductoValor.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelNombreProductoValor.Location = new Point(156, 315);
            labelNombreProductoValor.MouseState = MaterialSkin.MouseState.HOVER;
            labelNombreProductoValor.Name = "labelNombreProductoValor";
            labelNombreProductoValor.Size = new Size(5, 19);
            labelNombreProductoValor.TabIndex = 14;
            labelNombreProductoValor.Text = "-";
            // 
            // labelCantidadProducto
            // 
            labelCantidadProducto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelCantidadProducto.AutoSize = true;
            labelCantidadProducto.Depth = 0;
            labelCantidadProducto.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelCantidadProducto.Location = new Point(21, 389);
            labelCantidadProducto.MouseState = MaterialSkin.MouseState.HOVER;
            labelCantidadProducto.Name = "labelCantidadProducto";
            labelCantidadProducto.Size = new Size(69, 19);
            labelCantidadProducto.TabIndex = 13;
            labelCantidadProducto.Text = "Cantidad:";
            // 
            // labelPrecioProductoTitulo
            // 
            labelPrecioProductoTitulo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelPrecioProductoTitulo.AutoSize = true;
            labelPrecioProductoTitulo.Depth = 0;
            labelPrecioProductoTitulo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelPrecioProductoTitulo.Location = new Point(21, 345);
            labelPrecioProductoTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            labelPrecioProductoTitulo.Name = "labelPrecioProductoTitulo";
            labelPrecioProductoTitulo.Size = new Size(108, 19);
            labelPrecioProductoTitulo.TabIndex = 12;
            labelPrecioProductoTitulo.Text = "Precio Unitario:";
            // 
            // labelNombreProductoTitulo
            // 
            labelNombreProductoTitulo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelNombreProductoTitulo.AutoSize = true;
            labelNombreProductoTitulo.Depth = 0;
            labelNombreProductoTitulo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelNombreProductoTitulo.Location = new Point(21, 315);
            labelNombreProductoTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            labelNombreProductoTitulo.Name = "labelNombreProductoTitulo";
            labelNombreProductoTitulo.Size = new Size(129, 19);
            labelNombreProductoTitulo.TabIndex = 11;
            labelNombreProductoTitulo.Text = "Nombre Producto:";
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtBuscarProducto.AnimateReadOnly = false;
            txtBuscarProducto.BackgroundImageLayout = ImageLayout.None;
            txtBuscarProducto.CharacterCasing = CharacterCasing.Normal;
            txtBuscarProducto.Depth = 0;
            txtBuscarProducto.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBuscarProducto.HideSelection = true;
            txtBuscarProducto.Hint = "Código o Nombre del Producto";
            txtBuscarProducto.LeadingIcon = null;
            txtBuscarProducto.Location = new Point(21, 257);
            txtBuscarProducto.MaxLength = 32767;
            txtBuscarProducto.MouseState = MaterialSkin.MouseState.OUT;
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.PasswordChar = '\0';
            txtBuscarProducto.PrefixSuffixText = null;
            txtBuscarProducto.ReadOnly = false;
            txtBuscarProducto.RightToLeft = RightToLeft.No;
            txtBuscarProducto.SelectedText = "";
            txtBuscarProducto.SelectionLength = 0;
            txtBuscarProducto.SelectionStart = 0;
            txtBuscarProducto.ShortcutsEnabled = true;
            txtBuscarProducto.Size = new Size(246, 48);
            txtBuscarProducto.TabIndex = 10;
            txtBuscarProducto.TabStop = false;
            txtBuscarProducto.TextAlign = HorizontalAlignment.Left;
            txtBuscarProducto.TrailingIcon = null;
            txtBuscarProducto.UseSystemPasswordChar = false;
            // 
            // labelApellidoValor
            // 
            labelApellidoValor.AutoSize = true;
            labelApellidoValor.Depth = 0;
            labelApellidoValor.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelApellidoValor.Location = new Point(89, 165);
            labelApellidoValor.MouseState = MaterialSkin.MouseState.HOVER;
            labelApellidoValor.Name = "labelApellidoValor";
            labelApellidoValor.Size = new Size(5, 19);
            labelApellidoValor.TabIndex = 9;
            labelApellidoValor.Text = "-";
            // 
            // labelNombreValor
            // 
            labelNombreValor.AutoSize = true;
            labelNombreValor.Depth = 0;
            labelNombreValor.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelNombreValor.Location = new Point(89, 133);
            labelNombreValor.MouseState = MaterialSkin.MouseState.HOVER;
            labelNombreValor.Name = "labelNombreValor";
            labelNombreValor.Size = new Size(5, 19);
            labelNombreValor.TabIndex = 8;
            labelNombreValor.Text = "-";
            // 
            // labelApellidoTitulo
            // 
            labelApellidoTitulo.AutoSize = true;
            labelApellidoTitulo.Depth = 0;
            labelApellidoTitulo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelApellidoTitulo.Location = new Point(21, 165);
            labelApellidoTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            labelApellidoTitulo.Name = "labelApellidoTitulo";
            labelApellidoTitulo.Size = new Size(62, 19);
            labelApellidoTitulo.TabIndex = 7;
            labelApellidoTitulo.Text = "Apellido:";
            // 
            // labelNombreTitulo
            // 
            labelNombreTitulo.AutoSize = true;
            labelNombreTitulo.Depth = 0;
            labelNombreTitulo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelNombreTitulo.Location = new Point(21, 133);
            labelNombreTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            labelNombreTitulo.Name = "labelNombreTitulo";
            labelNombreTitulo.Size = new Size(61, 19);
            labelNombreTitulo.TabIndex = 6;
            labelNombreTitulo.Text = "Nombre:";
            // 
            // BtnBuscarDniCliente
            // 
            BtnBuscarDniCliente.AutoSize = false;
            BtnBuscarDniCliente.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnBuscarDniCliente.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            BtnBuscarDniCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnBuscarDniCliente.Depth = 0;
            BtnBuscarDniCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnBuscarDniCliente.HighEmphasis = true;
            BtnBuscarDniCliente.Icon = null;
            BtnBuscarDniCliente.Location = new Point(274, 78);
            BtnBuscarDniCliente.Margin = new Padding(4, 6, 4, 6);
            BtnBuscarDniCliente.MouseState = MaterialSkin.MouseState.HOVER;
            BtnBuscarDniCliente.Name = "BtnBuscarDniCliente";
            BtnBuscarDniCliente.NoAccentTextColor = Color.Empty;
            BtnBuscarDniCliente.Size = new Size(119, 48);
            BtnBuscarDniCliente.TabIndex = 5;
            BtnBuscarDniCliente.Text = "Buscar Cliente";
            BtnBuscarDniCliente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnBuscarDniCliente.UseAccentColor = false;
            BtnBuscarDniCliente.UseVisualStyleBackColor = true;
            BtnBuscarDniCliente.Click += BtnBuscarDniCliente_Click;
            // 
            // txtBuscarDniCliente
            // 
            txtBuscarDniCliente.AnimateReadOnly = false;
            txtBuscarDniCliente.BackgroundImageLayout = ImageLayout.None;
            txtBuscarDniCliente.CharacterCasing = CharacterCasing.Normal;
            txtBuscarDniCliente.Depth = 0;
            txtBuscarDniCliente.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarDniCliente.HideSelection = true;
            txtBuscarDniCliente.Hint = "Ingrese DNI del Cliente";
            txtBuscarDniCliente.LeadingIcon = null;
            txtBuscarDniCliente.Location = new Point(17, 78);
            txtBuscarDniCliente.MaxLength = 32767;
            txtBuscarDniCliente.MouseState = MaterialSkin.MouseState.OUT;
            txtBuscarDniCliente.Name = "txtBuscarDniCliente";
            txtBuscarDniCliente.PasswordChar = '\0';
            txtBuscarDniCliente.PrefixSuffixText = null;
            txtBuscarDniCliente.ReadOnly = false;
            txtBuscarDniCliente.RightToLeft = RightToLeft.No;
            txtBuscarDniCliente.SelectedText = "";
            txtBuscarDniCliente.SelectionLength = 0;
            txtBuscarDniCliente.SelectionStart = 0;
            txtBuscarDniCliente.ShortcutsEnabled = true;
            txtBuscarDniCliente.Size = new Size(250, 48);
            txtBuscarDniCliente.TabIndex = 1;
            txtBuscarDniCliente.TabStop = false;
            txtBuscarDniCliente.TextAlign = HorizontalAlignment.Left;
            txtBuscarDniCliente.TrailingIcon = null;
            txtBuscarDniCliente.UseSystemPasswordChar = false;
            // 
            // labelProducto
            // 
            labelProducto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelProducto.AutoSize = true;
            labelProducto.Depth = 0;
            labelProducto.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelProducto.Location = new Point(18, 235);
            labelProducto.MouseState = MaterialSkin.MouseState.HOVER;
            labelProducto.Name = "labelProducto";
            labelProducto.Size = new Size(65, 19);
            labelProducto.TabIndex = 4;
            labelProducto.Text = "Producto";
            // 
            // labelCliente
            // 
            labelCliente.AutoSize = true;
            labelCliente.Depth = 0;
            labelCliente.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelCliente.Location = new Point(17, 56);
            labelCliente.MouseState = MaterialSkin.MouseState.HOVER;
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(53, 19);
            labelCliente.TabIndex = 3;
            labelCliente.Text = "Clliente";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel1.Location = new Point(17, 14);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(137, 29);
            materialLabel1.TabIndex = 2;
            materialLabel1.Text = "Nueva Venta";
            // 
            // labelTotalCompraTitulo
            // 
            labelTotalCompraTitulo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelTotalCompraTitulo.Depth = 0;
            labelTotalCompraTitulo.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelTotalCompraTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            labelTotalCompraTitulo.Location = new Point(699, 333);
            labelTotalCompraTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            labelTotalCompraTitulo.Name = "labelTotalCompraTitulo";
            labelTotalCompraTitulo.Size = new Size(75, 23);
            labelTotalCompraTitulo.TabIndex = 1;
            labelTotalCompraTitulo.Text = "TOTAL: ";
            // 
            // ListaDetalleVenta
            // 
            ListaDetalleVenta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ListaDetalleVenta.AutoSizeTable = false;
            ListaDetalleVenta.BackColor = Color.FromArgb(255, 255, 255);
            ListaDetalleVenta.BorderStyle = BorderStyle.FixedSingle;
            ListaDetalleVenta.Columns.AddRange(new ColumnHeader[] { Codigo, Producto, Cantidad, Precio, Subtotal });
            ListaDetalleVenta.Depth = 0;
            ListaDetalleVenta.FullRowSelect = true;
            ListaDetalleVenta.GridLines = true;
            ListaDetalleVenta.Location = new Point(428, 56);
            ListaDetalleVenta.MinimumSize = new Size(200, 100);
            ListaDetalleVenta.MouseLocation = new Point(-1, -1);
            ListaDetalleVenta.MouseState = MaterialSkin.MouseState.OUT;
            ListaDetalleVenta.MultiSelect = false;
            ListaDetalleVenta.Name = "ListaDetalleVenta";
            ListaDetalleVenta.OwnerDraw = true;
            ListaDetalleVenta.Size = new Size(525, 273);
            ListaDetalleVenta.TabIndex = 0;
            ListaDetalleVenta.UseCompatibleStateImageBehavior = false;
            ListaDetalleVenta.View = View.Details;
            // 
            // Codigo
            // 
            Codigo.Text = "Código";
            Codigo.Width = 80;
            // 
            // Producto
            // 
            Producto.Text = "Producto";
            Producto.Width = 100;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            Cantidad.Width = 100;
            // 
            // Precio
            // 
            Precio.Text = "Precio Unitario";
            Precio.Width = 130;
            // 
            // Subtotal
            // 
            Subtotal.Text = "SubTotal";
            Subtotal.Width = 130;
            // 
            // FormNuevaVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 534);
            Controls.Add(materialCard1);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "FormNuevaVenta";
            Padding = new Padding(3, 0, 3, 3);
            Sizable = false;
            Text = "FormNuevaVenta";
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericCantidadProducto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialListView ListaDetalleVenta;
        private ColumnHeader Codigo;
        private ColumnHeader Producto;
        private ColumnHeader Cantidad;
        private ColumnHeader Precio;
        private ColumnHeader Subtotal;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel labelTotalCompraTitulo;
        private MaterialSkin.Controls.MaterialTextBox2 txtBuscarDniCliente;
        private MaterialSkin.Controls.MaterialLabel labelProducto;
        private MaterialSkin.Controls.MaterialLabel labelCliente;
        private MaterialSkin.Controls.MaterialButton BtnBuscarDniCliente;
        private MaterialSkin.Controls.MaterialLabel labelApellidoValor;
        private MaterialSkin.Controls.MaterialLabel labelNombreValor;
        private MaterialSkin.Controls.MaterialLabel labelApellidoTitulo;
        private MaterialSkin.Controls.MaterialLabel labelNombreTitulo;
        private MaterialSkin.Controls.MaterialTextBox2 txtBuscarProducto;
        private MaterialSkin.Controls.MaterialLabel labelPrecioProductoTitulo;
        private MaterialSkin.Controls.MaterialLabel labelNombreProductoTitulo;
        private MaterialSkin.Controls.MaterialLabel labelPrecioProductoValor;
        private MaterialSkin.Controls.MaterialLabel labelNombreProductoValor;
        private MaterialSkin.Controls.MaterialLabel labelCantidadProducto;
        private NumericUpDown numericCantidadProducto;
        private MaterialSkin.Controls.MaterialLabel labelStockDisponibleTitulo;
        private MaterialSkin.Controls.MaterialButton btnCancelarAgregado;
        private MaterialSkin.Controls.MaterialButton btnAgregarProducto;
        private MaterialSkin.Controls.MaterialLabel labelStockDisponibleValor;
        private MaterialSkin.Controls.MaterialButton btnConfirmarCompra;
        private MaterialSkin.Controls.MaterialComboBox comboBoxMetodoPago;
        private MaterialSkin.Controls.MaterialLabel labelTotalCompraValor;
        private MaterialSkin.Controls.MaterialButton btnCancelarCompra;
        private MaterialSkin.Controls.MaterialLabel labelDetalleVenta;
        private MaterialSkin.Controls.MaterialLabel labelMetodoPago;
        private MaterialSkin.Controls.MaterialButton btnBuscarProducto;
    }
}