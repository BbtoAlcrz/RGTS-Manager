using MaterialSkin.Controls;
namespace RGTS.Interfaz.EncargadoDeposito
{
    partial class FormAgregarProveedor
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
            TextBoxProveedorApellido = new MaterialTextBox2();
            TextBoxProveedorNombre = new MaterialTextBox2();
            TextBoxProveedorTelefono = new MaterialTextBox2();
            TextBoxProveedorNombreComercial = new MaterialTextBox2();
            TextBoxProveedorRazonSocial = new MaterialTextBox2();
            LabelProveedorDireccion = new MaterialLabel();
            LabelProveedorApellido = new MaterialLabel();
            LabelProveedorNombre = new MaterialLabel();
            LabelProveedorTelefono = new MaterialLabel();
            LabelProveedorTipoProveedor = new MaterialLabel();
            LabelProveedorNombreComercial = new MaterialLabel();
            LabelProveedorRSocial = new MaterialLabel();
            TextBoxProveedorDireccion = new MaterialMultiLineTextBox2();
            BtnProveedorGuardar = new MaterialButton();
            BtnProveedorCancelar = new MaterialButton();
            ComboBoxProveedorTipo = new MaterialComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ComboBoxProveedorTipo);
            panel1.Controls.Add(BtnProveedorCancelar);
            panel1.Controls.Add(BtnProveedorGuardar);
            panel1.Controls.Add(TextBoxProveedorDireccion);
            panel1.Controls.Add(TextBoxProveedorApellido);
            panel1.Controls.Add(TextBoxProveedorNombre);
            panel1.Controls.Add(TextBoxProveedorTelefono);
            panel1.Controls.Add(TextBoxProveedorNombreComercial);
            panel1.Controls.Add(TextBoxProveedorRazonSocial);
            panel1.Controls.Add(LabelProveedorDireccion);
            panel1.Controls.Add(LabelProveedorApellido);
            panel1.Controls.Add(LabelProveedorNombre);
            panel1.Controls.Add(LabelProveedorTelefono);
            panel1.Controls.Add(LabelProveedorTipoProveedor);
            panel1.Controls.Add(LabelProveedorNombreComercial);
            panel1.Controls.Add(LabelProveedorRSocial);
            panel1.Location = new Point(36, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 465);
            panel1.TabIndex = 0;
            // 
            // TextBoxProveedorApellido
            // 
            TextBoxProveedorApellido.AnimateReadOnly = false;
            TextBoxProveedorApellido.BackgroundImageLayout = ImageLayout.None;
            TextBoxProveedorApellido.CharacterCasing = CharacterCasing.Normal;
            TextBoxProveedorApellido.Depth = 0;
            TextBoxProveedorApellido.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextBoxProveedorApellido.HideSelection = true;
            TextBoxProveedorApellido.LeadingIcon = null;
            TextBoxProveedorApellido.Location = new Point(307, 232);
            TextBoxProveedorApellido.MaxLength = 32767;
            TextBoxProveedorApellido.MouseState = MaterialSkin.MouseState.OUT;
            TextBoxProveedorApellido.Name = "TextBoxProveedorApellido";
            TextBoxProveedorApellido.PasswordChar = '\0';
            TextBoxProveedorApellido.PrefixSuffixText = null;
            TextBoxProveedorApellido.ReadOnly = false;
            TextBoxProveedorApellido.RightToLeft = RightToLeft.No;
            TextBoxProveedorApellido.SelectedText = "";
            TextBoxProveedorApellido.SelectionLength = 0;
            TextBoxProveedorApellido.SelectionStart = 0;
            TextBoxProveedorApellido.ShortcutsEnabled = true;
            TextBoxProveedorApellido.Size = new Size(250, 48);
            TextBoxProveedorApellido.TabIndex = 12;
            TextBoxProveedorApellido.TabStop = false;
            TextBoxProveedorApellido.TextAlign = HorizontalAlignment.Left;
            TextBoxProveedorApellido.TrailingIcon = null;
            TextBoxProveedorApellido.UseSystemPasswordChar = false;
            // 
            // TextBoxProveedorNombre
            // 
            TextBoxProveedorNombre.AnimateReadOnly = false;
            TextBoxProveedorNombre.BackgroundImageLayout = ImageLayout.None;
            TextBoxProveedorNombre.CharacterCasing = CharacterCasing.Normal;
            TextBoxProveedorNombre.Depth = 0;
            TextBoxProveedorNombre.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextBoxProveedorNombre.HideSelection = true;
            TextBoxProveedorNombre.LeadingIcon = null;
            TextBoxProveedorNombre.Location = new Point(10, 232);
            TextBoxProveedorNombre.MaxLength = 32767;
            TextBoxProveedorNombre.MouseState = MaterialSkin.MouseState.OUT;
            TextBoxProveedorNombre.Name = "TextBoxProveedorNombre";
            TextBoxProveedorNombre.PasswordChar = '\0';
            TextBoxProveedorNombre.PrefixSuffixText = null;
            TextBoxProveedorNombre.ReadOnly = false;
            TextBoxProveedorNombre.RightToLeft = RightToLeft.No;
            TextBoxProveedorNombre.SelectedText = "";
            TextBoxProveedorNombre.SelectionLength = 0;
            TextBoxProveedorNombre.SelectionStart = 0;
            TextBoxProveedorNombre.ShortcutsEnabled = true;
            TextBoxProveedorNombre.Size = new Size(250, 48);
            TextBoxProveedorNombre.TabIndex = 11;
            TextBoxProveedorNombre.TabStop = false;
            TextBoxProveedorNombre.TextAlign = HorizontalAlignment.Left;
            TextBoxProveedorNombre.TrailingIcon = null;
            TextBoxProveedorNombre.UseSystemPasswordChar = false;
            // 
            // TextBoxProveedorTelefono
            // 
            TextBoxProveedorTelefono.AnimateReadOnly = false;
            TextBoxProveedorTelefono.BackgroundImageLayout = ImageLayout.None;
            TextBoxProveedorTelefono.CharacterCasing = CharacterCasing.Normal;
            TextBoxProveedorTelefono.Depth = 0;
            TextBoxProveedorTelefono.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextBoxProveedorTelefono.HideSelection = true;
            TextBoxProveedorTelefono.LeadingIcon = null;
            TextBoxProveedorTelefono.Location = new Point(307, 135);
            TextBoxProveedorTelefono.MaxLength = 32767;
            TextBoxProveedorTelefono.MouseState = MaterialSkin.MouseState.OUT;
            TextBoxProveedorTelefono.Name = "TextBoxProveedorTelefono";
            TextBoxProveedorTelefono.PasswordChar = '\0';
            TextBoxProveedorTelefono.PrefixSuffixText = null;
            TextBoxProveedorTelefono.ReadOnly = false;
            TextBoxProveedorTelefono.RightToLeft = RightToLeft.No;
            TextBoxProveedorTelefono.SelectedText = "";
            TextBoxProveedorTelefono.SelectionLength = 0;
            TextBoxProveedorTelefono.SelectionStart = 0;
            TextBoxProveedorTelefono.ShortcutsEnabled = true;
            TextBoxProveedorTelefono.Size = new Size(250, 48);
            TextBoxProveedorTelefono.TabIndex = 10;
            TextBoxProveedorTelefono.TabStop = false;
            TextBoxProveedorTelefono.TextAlign = HorizontalAlignment.Left;
            TextBoxProveedorTelefono.TrailingIcon = null;
            TextBoxProveedorTelefono.UseSystemPasswordChar = false;
            // 
            // TextBoxProveedorNombreComercial
            // 
            TextBoxProveedorNombreComercial.AnimateReadOnly = false;
            TextBoxProveedorNombreComercial.BackgroundImageLayout = ImageLayout.None;
            TextBoxProveedorNombreComercial.CharacterCasing = CharacterCasing.Normal;
            TextBoxProveedorNombreComercial.Depth = 0;
            TextBoxProveedorNombreComercial.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextBoxProveedorNombreComercial.HideSelection = true;
            TextBoxProveedorNombreComercial.LeadingIcon = null;
            TextBoxProveedorNombreComercial.Location = new Point(307, 40);
            TextBoxProveedorNombreComercial.MaxLength = 32767;
            TextBoxProveedorNombreComercial.MouseState = MaterialSkin.MouseState.OUT;
            TextBoxProveedorNombreComercial.Name = "TextBoxProveedorNombreComercial";
            TextBoxProveedorNombreComercial.PasswordChar = '\0';
            TextBoxProveedorNombreComercial.PrefixSuffixText = null;
            TextBoxProveedorNombreComercial.ReadOnly = false;
            TextBoxProveedorNombreComercial.RightToLeft = RightToLeft.No;
            TextBoxProveedorNombreComercial.SelectedText = "";
            TextBoxProveedorNombreComercial.SelectionLength = 0;
            TextBoxProveedorNombreComercial.SelectionStart = 0;
            TextBoxProveedorNombreComercial.ShortcutsEnabled = true;
            TextBoxProveedorNombreComercial.Size = new Size(250, 48);
            TextBoxProveedorNombreComercial.TabIndex = 8;
            TextBoxProveedorNombreComercial.TabStop = false;
            TextBoxProveedorNombreComercial.TextAlign = HorizontalAlignment.Left;
            TextBoxProveedorNombreComercial.TrailingIcon = null;
            TextBoxProveedorNombreComercial.UseSystemPasswordChar = false;
            // 
            // TextBoxProveedorRazonSocial
            // 
            TextBoxProveedorRazonSocial.AnimateReadOnly = false;
            TextBoxProveedorRazonSocial.BackgroundImageLayout = ImageLayout.None;
            TextBoxProveedorRazonSocial.CharacterCasing = CharacterCasing.Normal;
            TextBoxProveedorRazonSocial.Depth = 0;
            TextBoxProveedorRazonSocial.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextBoxProveedorRazonSocial.HideSelection = true;
            TextBoxProveedorRazonSocial.LeadingIcon = null;
            TextBoxProveedorRazonSocial.Location = new Point(10, 40);
            TextBoxProveedorRazonSocial.MaxLength = 32767;
            TextBoxProveedorRazonSocial.MouseState = MaterialSkin.MouseState.OUT;
            TextBoxProveedorRazonSocial.Name = "TextBoxProveedorRazonSocial";
            TextBoxProveedorRazonSocial.PasswordChar = '\0';
            TextBoxProveedorRazonSocial.PrefixSuffixText = null;
            TextBoxProveedorRazonSocial.ReadOnly = false;
            TextBoxProveedorRazonSocial.RightToLeft = RightToLeft.No;
            TextBoxProveedorRazonSocial.SelectedText = "";
            TextBoxProveedorRazonSocial.SelectionLength = 0;
            TextBoxProveedorRazonSocial.SelectionStart = 0;
            TextBoxProveedorRazonSocial.ShortcutsEnabled = true;
            TextBoxProveedorRazonSocial.Size = new Size(250, 48);
            TextBoxProveedorRazonSocial.TabIndex = 7;
            TextBoxProveedorRazonSocial.TabStop = false;
            TextBoxProveedorRazonSocial.TextAlign = HorizontalAlignment.Left;
            TextBoxProveedorRazonSocial.TrailingIcon = null;
            TextBoxProveedorRazonSocial.UseSystemPasswordChar = false;
            // 
            // LabelProveedorDireccion
            // 
            LabelProveedorDireccion.AutoSize = true;
            LabelProveedorDireccion.Depth = 0;
            LabelProveedorDireccion.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelProveedorDireccion.Location = new Point(10, 300);
            LabelProveedorDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            LabelProveedorDireccion.Name = "LabelProveedorDireccion";
            LabelProveedorDireccion.Size = new Size(71, 19);
            LabelProveedorDireccion.TabIndex = 6;
            LabelProveedorDireccion.Text = "Dirección ";
            // 
            // LabelProveedorApellido
            // 
            LabelProveedorApellido.AutoSize = true;
            LabelProveedorApellido.Depth = 0;
            LabelProveedorApellido.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelProveedorApellido.Location = new Point(307, 210);
            LabelProveedorApellido.MouseState = MaterialSkin.MouseState.HOVER;
            LabelProveedorApellido.Name = "LabelProveedorApellido";
            LabelProveedorApellido.Size = new Size(149, 19);
            LabelProveedorApellido.TabIndex = 5;
            LabelProveedorApellido.Text = "Apellido del contacto";
            // 
            // LabelProveedorNombre
            // 
            LabelProveedorNombre.AutoSize = true;
            LabelProveedorNombre.Depth = 0;
            LabelProveedorNombre.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelProveedorNombre.Location = new Point(10, 210);
            LabelProveedorNombre.MouseState = MaterialSkin.MouseState.HOVER;
            LabelProveedorNombre.Name = "LabelProveedorNombre";
            LabelProveedorNombre.Size = new Size(148, 19);
            LabelProveedorNombre.TabIndex = 4;
            LabelProveedorNombre.Text = "Nombre del contacto";
            // 
            // LabelProveedorTelefono
            // 
            LabelProveedorTelefono.AutoSize = true;
            LabelProveedorTelefono.Depth = 0;
            LabelProveedorTelefono.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelProveedorTelefono.Location = new Point(307, 113);
            LabelProveedorTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            LabelProveedorTelefono.Name = "LabelProveedorTelefono";
            LabelProveedorTelefono.Size = new Size(151, 19);
            LabelProveedorTelefono.TabIndex = 3;
            LabelProveedorTelefono.Text = "Teléfono de contacto";
            // 
            // LabelProveedorTipoProveedor
            // 
            LabelProveedorTipoProveedor.AutoSize = true;
            LabelProveedorTipoProveedor.Depth = 0;
            LabelProveedorTipoProveedor.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelProveedorTipoProveedor.Location = new Point(10, 113);
            LabelProveedorTipoProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            LabelProveedorTipoProveedor.Name = "LabelProveedorTipoProveedor";
            LabelProveedorTipoProveedor.Size = new Size(128, 19);
            LabelProveedorTipoProveedor.TabIndex = 2;
            LabelProveedorTipoProveedor.Text = "Tipo de proveedor";
            // 
            // LabelProveedorNombreComercial
            // 
            LabelProveedorNombreComercial.AutoSize = true;
            LabelProveedorNombreComercial.Depth = 0;
            LabelProveedorNombreComercial.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelProveedorNombreComercial.Location = new Point(307, 18);
            LabelProveedorNombreComercial.MouseState = MaterialSkin.MouseState.HOVER;
            LabelProveedorNombreComercial.Name = "LabelProveedorNombreComercial";
            LabelProveedorNombreComercial.Size = new Size(130, 19);
            LabelProveedorNombreComercial.TabIndex = 1;
            LabelProveedorNombreComercial.Text = "Nombre comercial";
            // 
            // LabelProveedorRSocial
            // 
            LabelProveedorRSocial.AutoSize = true;
            LabelProveedorRSocial.Depth = 0;
            LabelProveedorRSocial.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelProveedorRSocial.Location = new Point(10, 18);
            LabelProveedorRSocial.MouseState = MaterialSkin.MouseState.HOVER;
            LabelProveedorRSocial.Name = "LabelProveedorRSocial";
            LabelProveedorRSocial.Size = new Size(92, 19);
            LabelProveedorRSocial.TabIndex = 0;
            LabelProveedorRSocial.Text = "Razón social";
            // 
            // TextBoxProveedorDireccion
            // 
            TextBoxProveedorDireccion.AnimateReadOnly = false;
            TextBoxProveedorDireccion.BackgroundImageLayout = ImageLayout.None;
            TextBoxProveedorDireccion.CharacterCasing = CharacterCasing.Normal;
            TextBoxProveedorDireccion.Depth = 0;
            TextBoxProveedorDireccion.HideSelection = true;
            TextBoxProveedorDireccion.Location = new Point(10, 322);
            TextBoxProveedorDireccion.MaxLength = 32767;
            TextBoxProveedorDireccion.MouseState = MaterialSkin.MouseState.OUT;
            TextBoxProveedorDireccion.Name = "TextBoxProveedorDireccion";
            TextBoxProveedorDireccion.PasswordChar = '\0';
            TextBoxProveedorDireccion.ReadOnly = false;
            TextBoxProveedorDireccion.ScrollBars = ScrollBars.None;
            TextBoxProveedorDireccion.SelectedText = "";
            TextBoxProveedorDireccion.SelectionLength = 0;
            TextBoxProveedorDireccion.SelectionStart = 0;
            TextBoxProveedorDireccion.ShortcutsEnabled = true;
            TextBoxProveedorDireccion.Size = new Size(547, 70);
            TextBoxProveedorDireccion.TabIndex = 13;
            TextBoxProveedorDireccion.TabStop = false;
            TextBoxProveedorDireccion.TextAlign = HorizontalAlignment.Left;
            TextBoxProveedorDireccion.UseSystemPasswordChar = false;
            // 
            // BtnProveedorGuardar
            // 
            BtnProveedorGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnProveedorGuardar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnProveedorGuardar.Density = MaterialButton.MaterialButtonDensity.Default;
            BtnProveedorGuardar.Depth = 0;
            BtnProveedorGuardar.HighEmphasis = true;
            BtnProveedorGuardar.Icon = null;
            BtnProveedorGuardar.Location = new Point(469, 416);
            BtnProveedorGuardar.Margin = new Padding(4, 6, 4, 6);
            BtnProveedorGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            BtnProveedorGuardar.Name = "BtnProveedorGuardar";
            BtnProveedorGuardar.NoAccentTextColor = Color.Empty;
            BtnProveedorGuardar.Size = new Size(88, 36);
            BtnProveedorGuardar.TabIndex = 14;
            BtnProveedorGuardar.Text = "Guardar";
            BtnProveedorGuardar.Type = MaterialButton.MaterialButtonType.Contained;
            BtnProveedorGuardar.UseAccentColor = false;
            BtnProveedorGuardar.UseVisualStyleBackColor = true;
            // 
            // BtnProveedorCancelar
            // 
            BtnProveedorCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnProveedorCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnProveedorCancelar.Density = MaterialButton.MaterialButtonDensity.Default;
            BtnProveedorCancelar.Depth = 0;
            BtnProveedorCancelar.HighEmphasis = true;
            BtnProveedorCancelar.Icon = null;
            BtnProveedorCancelar.Location = new Point(369, 416);
            BtnProveedorCancelar.Margin = new Padding(4, 6, 4, 6);
            BtnProveedorCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            BtnProveedorCancelar.Name = "BtnProveedorCancelar";
            BtnProveedorCancelar.NoAccentTextColor = Color.Empty;
            BtnProveedorCancelar.Size = new Size(96, 36);
            BtnProveedorCancelar.TabIndex = 15;
            BtnProveedorCancelar.Text = "Cancelar";
            BtnProveedorCancelar.Type = MaterialButton.MaterialButtonType.Outlined;
            BtnProveedorCancelar.UseAccentColor = false;
            BtnProveedorCancelar.UseVisualStyleBackColor = true;
            // 
            // ComboBoxProveedorTipo
            // 
            ComboBoxProveedorTipo.AutoResize = false;
            ComboBoxProveedorTipo.BackColor = Color.FromArgb(255, 255, 255);
            ComboBoxProveedorTipo.Depth = 0;
            ComboBoxProveedorTipo.DrawMode = DrawMode.OwnerDrawVariable;
            ComboBoxProveedorTipo.DropDownHeight = 174;
            ComboBoxProveedorTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxProveedorTipo.DropDownWidth = 121;
            ComboBoxProveedorTipo.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            ComboBoxProveedorTipo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ComboBoxProveedorTipo.FormattingEnabled = true;
            ComboBoxProveedorTipo.IntegralHeight = false;
            ComboBoxProveedorTipo.ItemHeight = 43;
            ComboBoxProveedorTipo.Location = new Point(10, 135);
            ComboBoxProveedorTipo.MaxDropDownItems = 4;
            ComboBoxProveedorTipo.MouseState = MaterialSkin.MouseState.OUT;
            ComboBoxProveedorTipo.Name = "ComboBoxProveedorTipo";
            ComboBoxProveedorTipo.Size = new Size(250, 49);
            ComboBoxProveedorTipo.StartIndex = 0;
            ComboBoxProveedorTipo.TabIndex = 9;
            // 
            // FormAgregarProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "FormAgregarProveedor";
            Size = new Size(639, 508);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MaterialLabel LabelProveedorRSocial;
        private MaterialLabel LabelProveedorNombreComercial;
        private MaterialLabel LabelProveedorTipoProveedor;
        private MaterialLabel LabelProveedorTelefono;
        private MaterialLabel LabelProveedorNombre;
        private MaterialLabel LabelProveedorApellido;
        private MaterialLabel LabelProveedorDireccion;
        private MaterialTextBox2 TextBoxProveedorRazonSocial;
        private MaterialTextBox2 TextBoxProveedorNombreComercial;
        private MaterialComboBox ComboBoxProveedorTipo;
        private MaterialTextBox2 TextBoxProveedorTelefono;
        private MaterialTextBox2 TextBoxProveedorNombre;
        private MaterialTextBox2 TextBoxProveedorApellido;
        private MaterialMultiLineTextBox2 TextBoxProveedorDireccion;
        private MaterialButton BtnProveedorGuardar;
        private MaterialButton BtnProveedorCancelar;
    }
}
