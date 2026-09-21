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
            panel1 = new Panel();
            BtnVerDetalleProveedor = new MaterialSkin.Controls.MaterialButton();
            TextBoxBuscarProveedor = new MaterialSkin.Controls.MaterialTextBox2();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
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
            panel1.Controls.Add(BtnVerDetalleProveedor);
            panel1.Controls.Add(TextBoxBuscarProveedor);
            panel1.Controls.Add(materialButton1);
            panel1.Controls.Add(BtnEditarProveedor);
            panel1.Controls.Add(BtnAgregarProveedor);
            panel1.Controls.Add(materialListView1);
            panel1.Location = new Point(6, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(621, 413);
            panel1.TabIndex = 0;
            // 
            // BtnVerDetalleProveedor
            // 
            BtnVerDetalleProveedor.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnVerDetalleProveedor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnVerDetalleProveedor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnVerDetalleProveedor.Depth = 0;
            BtnVerDetalleProveedor.HighEmphasis = true;
            BtnVerDetalleProveedor.Icon = null;
            BtnVerDetalleProveedor.Location = new Point(504, 24);
            BtnVerDetalleProveedor.Margin = new Padding(4, 6, 4, 6);
            BtnVerDetalleProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            BtnVerDetalleProveedor.Name = "BtnVerDetalleProveedor";
            BtnVerDetalleProveedor.NoAccentTextColor = Color.Empty;
            BtnVerDetalleProveedor.Size = new Size(113, 36);
            BtnVerDetalleProveedor.TabIndex = 5;
            BtnVerDetalleProveedor.Text = "Ver Detalle";
            BtnVerDetalleProveedor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnVerDetalleProveedor.UseAccentColor = false;
            BtnVerDetalleProveedor.UseVisualStyleBackColor = true;
            // 
            // TextBoxBuscarProveedor
            // 
            TextBoxBuscarProveedor.AnimateReadOnly = false;
            TextBoxBuscarProveedor.BackgroundImageLayout = ImageLayout.None;
            TextBoxBuscarProveedor.CharacterCasing = CharacterCasing.Normal;
            TextBoxBuscarProveedor.Depth = 0;
            TextBoxBuscarProveedor.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextBoxBuscarProveedor.HideSelection = true;
            TextBoxBuscarProveedor.LeadingIcon = null;
            TextBoxBuscarProveedor.Location = new Point(4, 15);
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
            TextBoxBuscarProveedor.Size = new Size(493, 48);
            TextBoxBuscarProveedor.TabIndex = 4;
            TextBoxBuscarProveedor.TabStop = false;
            TextBoxBuscarProveedor.Text = "Buscar por Razón Social o Nombre comercial";
            TextBoxBuscarProveedor.TextAlign = HorizontalAlignment.Left;
            TextBoxBuscarProveedor.TrailingIcon = null;
            TextBoxBuscarProveedor.UseSystemPasswordChar = false;
            // 
            // materialButton1
            // 
            materialButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(495, 362);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(122, 36);
            materialButton1.TabIndex = 3;
            materialButton1.Text = "Deshabilitar";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // BtnEditarProveedor
            // 
            BtnEditarProveedor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnEditarProveedor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnEditarProveedor.Depth = 0;
            BtnEditarProveedor.HighEmphasis = true;
            BtnEditarProveedor.Icon = null;
            BtnEditarProveedor.Location = new Point(187, 362);
            BtnEditarProveedor.Margin = new Padding(4, 6, 4, 6);
            BtnEditarProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            BtnEditarProveedor.Name = "BtnEditarProveedor";
            BtnEditarProveedor.NoAccentTextColor = Color.Empty;
            BtnEditarProveedor.Size = new Size(71, 36);
            BtnEditarProveedor.TabIndex = 2;
            BtnEditarProveedor.Text = "Editar";
            BtnEditarProveedor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            BtnEditarProveedor.UseAccentColor = false;
            BtnEditarProveedor.UseVisualStyleBackColor = true;
            BtnEditarProveedor.Click += BtnEditarProveedor_Click;
            // 
            // BtnAgregarProveedor
            // 
            BtnAgregarProveedor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnAgregarProveedor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnAgregarProveedor.Depth = 0;
            BtnAgregarProveedor.HighEmphasis = true;
            BtnAgregarProveedor.Icon = null;
            BtnAgregarProveedor.Location = new Point(4, 362);
            BtnAgregarProveedor.Margin = new Padding(4, 6, 4, 6);
            BtnAgregarProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            BtnAgregarProveedor.Name = "BtnAgregarProveedor";
            BtnAgregarProveedor.NoAccentTextColor = Color.Empty;
            BtnAgregarProveedor.Size = new Size(175, 36);
            BtnAgregarProveedor.TabIndex = 1;
            BtnAgregarProveedor.Text = "Agregar Proveedor";
            BtnAgregarProveedor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnAgregarProveedor.UseAccentColor = false;
            BtnAgregarProveedor.UseVisualStyleBackColor = true;
            BtnAgregarProveedor.Click += BtnAgregarProveedor_Click;
            // 
            // materialListView1
            // 
            materialListView1.AutoSizeTable = false;
            materialListView1.BackColor = Color.FromArgb(255, 255, 255);
            materialListView1.BorderStyle = BorderStyle.None;
            materialListView1.Columns.AddRange(new ColumnHeader[] { ProveedorID, ProveedorRSocial, ProveedorNombre, ProveedorTelefono, ProveedorEmail, ProveedorEstado });
            materialListView1.Depth = 0;
            materialListView1.FullRowSelect = true;
            materialListView1.Location = new Point(3, 69);
            materialListView1.MinimumSize = new Size(200, 100);
            materialListView1.MouseLocation = new Point(-1, -1);
            materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            materialListView1.Name = "materialListView1";
            materialListView1.OwnerDraw = true;
            materialListView1.Size = new Size(615, 284);
            materialListView1.TabIndex = 0;
            materialListView1.UseCompatibleStateImageBehavior = false;
            materialListView1.View = View.Details;
            // 
            // ProveedorID
            // 
            ProveedorID.Text = "ID";
            // 
            // ProveedorRSocial
            // 
            ProveedorRSocial.Text = "Razón social";
            ProveedorRSocial.Width = 115;
            // 
            // ProveedorNombre
            // 
            ProveedorNombre.Text = "Nombre Comercial";
            ProveedorNombre.Width = 150;
            // 
            // ProveedorTelefono
            // 
            ProveedorTelefono.Text = "Teléfono";
            ProveedorTelefono.Width = 90;
            // 
            // ProveedorEmail
            // 
            ProveedorEmail.Text = "Email";
            ProveedorEmail.Width = 90;
            // 
            // ProveedorEstado
            // 
            ProveedorEstado.Text = "Estado";
            ProveedorEstado.Width = 90;
            // 
            // FormListadoProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 507);
            Controls.Add(panel1);
            Name = "FormListadoProveedores";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
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
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox2 TextBoxBuscarProveedor;
        private MaterialSkin.Controls.MaterialButton BtnVerDetalleProveedor;
    }
}
