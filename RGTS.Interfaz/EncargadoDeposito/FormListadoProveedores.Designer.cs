namespace RGTS.Interfaz.EncargadoDeposito
{
    partial class FormListadoProveedores
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new MaterialSkin.Controls.MaterialCard();
            labelTitulo = new MaterialSkin.Controls.MaterialLabel();
            BtnVerDetalleProveedor = new MaterialSkin.Controls.MaterialButton();
            TextBoxBuscarProveedor = new MaterialSkin.Controls.MaterialTextBox2();
            BtnCambiarEstado = new MaterialSkin.Controls.MaterialButton();
            BtnEditarProveedor = new MaterialSkin.Controls.MaterialButton();
            BtnAgregarProveedor = new MaterialSkin.Controls.MaterialButton();
            materialListView1 = new MaterialSkin.Controls.MaterialListView();
            ProveedorID = new ColumnHeader();
            ProveedorRSocial = new ColumnHeader();
            ProveedorNombre = new ColumnHeader();
            ProveedorTelefono = new ColumnHeader();
            ProveedorEmail = new ColumnHeader();
            ProveedorEstado = new ColumnHeader();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 255);
            panel1.Controls.Add(labelTitulo);
            panel1.Controls.Add(BtnVerDetalleProveedor);
            panel1.Controls.Add(TextBoxBuscarProveedor);
            panel1.Controls.Add(BtnCambiarEstado);
            panel1.Controls.Add(BtnEditarProveedor);
            panel1.Controls.Add(BtnAgregarProveedor);
            panel1.Controls.Add(materialListView1);
            panel1.Depth = 0;
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(14);
            panel1.MouseState = MaterialSkin.MouseState.HOVER;
            panel1.Name = "panel1";
            panel1.Padding = new Padding(14);
            panel1.Size = new Size(760, 508);
            panel1.TabIndex = 0;
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
            labelTitulo.Size = new Size(256, 29);
            labelTitulo.TabIndex = 6;
            labelTitulo.Text = "Listado de Proveedores";
            // 
            // BtnVerDetalleProveedor
            // 
            BtnVerDetalleProveedor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnVerDetalleProveedor.AutoSize = false;
            BtnVerDetalleProveedor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnVerDetalleProveedor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnVerDetalleProveedor.Depth = 0;
            BtnVerDetalleProveedor.HighEmphasis = true;
            BtnVerDetalleProveedor.Icon = Properties.Resources.ojo;
            BtnVerDetalleProveedor.Location = new Point(588, 60);
            BtnVerDetalleProveedor.Margin = new Padding(4, 6, 4, 6);
            BtnVerDetalleProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            BtnVerDetalleProveedor.Name = "BtnVerDetalleProveedor";
            BtnVerDetalleProveedor.NoAccentTextColor = Color.Empty;
            BtnVerDetalleProveedor.Size = new Size(155, 48);
            BtnVerDetalleProveedor.TabIndex = 5;
            BtnVerDetalleProveedor.Text = "Ver Detalle";
            BtnVerDetalleProveedor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            BtnVerDetalleProveedor.UseAccentColor = false;
            BtnVerDetalleProveedor.UseVisualStyleBackColor = true;
            BtnVerDetalleProveedor.Click += BtnVerDetalleProveedor_Click;
            // 
            // TextBoxBuscarProveedor
            // 
            TextBoxBuscarProveedor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxBuscarProveedor.AnimateReadOnly = false;
            TextBoxBuscarProveedor.BackgroundImageLayout = ImageLayout.None;
            TextBoxBuscarProveedor.CharacterCasing = CharacterCasing.Normal;
            TextBoxBuscarProveedor.Depth = 0;
            TextBoxBuscarProveedor.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextBoxBuscarProveedor.HideSelection = true;
            TextBoxBuscarProveedor.Hint = "Buscar por Razón Social o Nombre comercial";
            TextBoxBuscarProveedor.LeadingIcon = Properties.Resources.busqueda;
            TextBoxBuscarProveedor.Location = new Point(12, 60);
            TextBoxBuscarProveedor.MaxLength = 32767;
            TextBoxBuscarProveedor.MouseState = MaterialSkin.MouseState.OUT;
            TextBoxBuscarProveedor.Name = "TextBoxBuscarProveedor";
            TextBoxBuscarProveedor.PasswordChar = '\0';
            TextBoxBuscarProveedor.PrefixSuffixText = null;
            TextBoxBuscarProveedor.ReadOnly = false;
            TextBoxBuscarProveedor.RightToLeft = RightToLeft.No;
            TextBoxBuscarProveedor.SelectedText = "";
            TextBoxBuscarProveedor.SelectionLength = 0;
            TextBoxBuscarProveedor.SelectionStart = 0;
            TextBoxBuscarProveedor.ShortcutsEnabled = true;
            TextBoxBuscarProveedor.Size = new Size(569, 48);
            TextBoxBuscarProveedor.TabIndex = 4;
            TextBoxBuscarProveedor.TabStop = false;
            TextBoxBuscarProveedor.TextAlign = HorizontalAlignment.Left;
            TextBoxBuscarProveedor.TrailingIcon = null;
            TextBoxBuscarProveedor.UseSystemPasswordChar = false;
            TextBoxBuscarProveedor.TextChanged += TextBoxBuscarProveedor_TextChanged;
            // 
            // BtnCambiarEstado
            // 
            BtnCambiarEstado.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnCambiarEstado.AutoSize = false;
            BtnCambiarEstado.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnCambiarEstado.Cursor = Cursors.Hand;
            BtnCambiarEstado.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnCambiarEstado.Depth = 0;
            BtnCambiarEstado.HighEmphasis = true;
            BtnCambiarEstado.Icon = Properties.Resources.click;
            BtnCambiarEstado.Location = new Point(602, 457);
            BtnCambiarEstado.Margin = new Padding(4, 6, 4, 6);
            BtnCambiarEstado.MouseState = MaterialSkin.MouseState.HOVER;
            BtnCambiarEstado.Name = "BtnCambiarEstado";
            BtnCambiarEstado.NoAccentTextColor = Color.Empty;
            BtnCambiarEstado.Size = new Size(140, 36);
            BtnCambiarEstado.TabIndex = 3;
            BtnCambiarEstado.Text = "Deshabilitar";
            BtnCambiarEstado.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            BtnCambiarEstado.UseAccentColor = false;
            BtnCambiarEstado.UseVisualStyleBackColor = true;
            BtnCambiarEstado.Click += btnCambiarEstado_Click;
            // 
            // BtnEditarProveedor
            // 
            BtnEditarProveedor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnEditarProveedor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnEditarProveedor.Cursor = Cursors.Hand;
            BtnEditarProveedor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnEditarProveedor.Depth = 0;
            BtnEditarProveedor.HighEmphasis = true;
            BtnEditarProveedor.Icon = Properties.Resources.editar;
            BtnEditarProveedor.Location = new Point(211, 457);
            BtnEditarProveedor.Margin = new Padding(4, 6, 4, 6);
            BtnEditarProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            BtnEditarProveedor.Name = "BtnEditarProveedor";
            BtnEditarProveedor.NoAccentTextColor = Color.Empty;
            BtnEditarProveedor.Size = new Size(187, 36);
            BtnEditarProveedor.TabIndex = 2;
            BtnEditarProveedor.Text = "Editar Proveedor";
            BtnEditarProveedor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            BtnEditarProveedor.UseAccentColor = false;
            BtnEditarProveedor.UseVisualStyleBackColor = true;
            BtnEditarProveedor.Click += BtnEditarProveedor_Click;
            // 
            // BtnAgregarProveedor
            // 
            BtnAgregarProveedor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnAgregarProveedor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnAgregarProveedor.Cursor = Cursors.Hand;
            BtnAgregarProveedor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnAgregarProveedor.Depth = 0;
            BtnAgregarProveedor.HighEmphasis = true;
            BtnAgregarProveedor.Icon = Properties.Resources.nuevo;
            BtnAgregarProveedor.Location = new Point(18, 457);
            BtnAgregarProveedor.Margin = new Padding(4, 6, 4, 6);
            BtnAgregarProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            BtnAgregarProveedor.Name = "BtnAgregarProveedor";
            BtnAgregarProveedor.NoAccentTextColor = Color.Empty;
            BtnAgregarProveedor.Size = new Size(185, 36);
            BtnAgregarProveedor.TabIndex = 1;
            BtnAgregarProveedor.Text = "Nuevo Proveedor";
            BtnAgregarProveedor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnAgregarProveedor.UseAccentColor = false;
            BtnAgregarProveedor.UseVisualStyleBackColor = true;
            BtnAgregarProveedor.Click += BtnAgregarProveedor_Click;
            // 
            // materialListView1
            // 
            materialListView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            materialListView1.AutoSizeTable = false;
            materialListView1.BackColor = Color.FromArgb(255, 255, 255);
            materialListView1.BorderStyle = BorderStyle.None;
            materialListView1.Columns.AddRange(new ColumnHeader[] { ProveedorID, ProveedorRSocial, ProveedorNombre, ProveedorTelefono, ProveedorEmail, ProveedorEstado });
            materialListView1.Depth = 0;
            materialListView1.FullRowSelect = true;
            materialListView1.Location = new Point(12, 114);
            materialListView1.MinimumSize = new Size(200, 100);
            materialListView1.MouseLocation = new Point(-1, -1);
            materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            materialListView1.Name = "materialListView1";
            materialListView1.OwnerDraw = true;
            materialListView1.Size = new Size(731, 301);
            materialListView1.TabIndex = 0;
            materialListView1.UseCompatibleStateImageBehavior = false;
            materialListView1.View = View.Details;
            materialListView1.SelectedIndexChanged += MaterialListView1_SelectedIndexChanged;
            // 
            // ProveedorID
            // 
            ProveedorID.Text = "ID";
            // 
            // ProveedorRSocial
            // 
            ProveedorRSocial.Text = "Razón social";
            ProveedorRSocial.Width = 130;
            // 
            // ProveedorNombre
            // 
            ProveedorNombre.Text = "Nombre Comercial";
            ProveedorNombre.Width = 150;
            // 
            // ProveedorTelefono
            // 
            ProveedorTelefono.Text = "Teléfono";
            ProveedorTelefono.Width = 130;
            // 
            // ProveedorEmail
            // 
            ProveedorEmail.Text = "Email";
            ProveedorEmail.Width = 130;
            // 
            // ProveedorEstado
            // 
            ProveedorEstado.Text = "Estado";
            ProveedorEstado.Width = 130;
            // 
            // FormListadoProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 508);
            Controls.Add(panel1);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "FormListadoProveedores";
            Padding = new Padding(0);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard panel1;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private ColumnHeader ProveedorID;
        private ColumnHeader idProveedor;
        private ColumnHeader ProveedorRSocial;
        private ColumnHeader ProveedorNombre;
        private ColumnHeader ProveedorTelefono;
        private ColumnHeader ProveedorEmail;
        private ColumnHeader ProveedorEstado;
        private MaterialSkin.Controls.MaterialButton BtnEditarProveedor;
        private MaterialSkin.Controls.MaterialButton BtnAgregarProveedor;
        private MaterialSkin.Controls.MaterialButton BtnCambiarEstado;
        private MaterialSkin.Controls.MaterialTextBox2 TextBoxBuscarProveedor;
        private MaterialSkin.Controls.MaterialButton BtnVerDetalleProveedor;
        private MaterialSkin.Controls.MaterialLabel labelTitulo;
    }
}
