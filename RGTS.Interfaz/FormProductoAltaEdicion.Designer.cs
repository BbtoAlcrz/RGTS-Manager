namespace RGTS.Interfaz
{
    partial class FormProductoAltaEdicion
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
            LCodigo = new MaterialSkin.Controls.MaterialLabel();
            LCategoria = new MaterialSkin.Controls.MaterialLabel();
            LPrecio = new MaterialSkin.Controls.MaterialLabel();
            LExistenciasA = new MaterialSkin.Controls.MaterialLabel();
            LExistenciasMin = new MaterialSkin.Controls.MaterialLabel();
            LNombre = new MaterialSkin.Controls.MaterialLabel();
            LDescripcion = new MaterialSkin.Controls.MaterialLabel();
            TxtCodigo = new MaterialSkin.Controls.MaterialTextBox2();
            TxtNombre = new MaterialSkin.Controls.MaterialTextBox2();
            MltDescripcion = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            TxtPrecio = new MaterialSkin.Controls.MaterialTextBox2();
            TxtExistenciasA = new MaterialSkin.Controls.MaterialTextBox2();
            TxtExistenciasMin = new MaterialSkin.Controls.MaterialTextBox2();
            CbCategoria = new MaterialSkin.Controls.MaterialComboBox();
            BtnCancelar = new MaterialSkin.Controls.MaterialButton();
            BtnGuardar = new MaterialSkin.Controls.MaterialButton();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LCodigo
            // 
            LCodigo.AutoSize = true;
            LCodigo.Depth = 0;
            LCodigo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LCodigo.Location = new Point(15, 0);
            LCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            LCodigo.Name = "LCodigo";
            LCodigo.Size = new Size(51, 19);
            LCodigo.TabIndex = 0;
            LCodigo.Text = "Codigo";
            // 
            // LCategoria
            // 
            LCategoria.AutoSize = true;
            LCategoria.Depth = 0;
            LCategoria.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LCategoria.Location = new Point(15, 325);
            LCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            LCategoria.Name = "LCategoria";
            LCategoria.Size = new Size(69, 19);
            LCategoria.TabIndex = 1;
            LCategoria.Text = "Categoria";
            // 
            // LPrecio
            // 
            LPrecio.AutoSize = true;
            LPrecio.Depth = 0;
            LPrecio.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LPrecio.Location = new Point(15, 411);
            LPrecio.MouseState = MaterialSkin.MouseState.HOVER;
            LPrecio.Name = "LPrecio";
            LPrecio.Size = new Size(45, 19);
            LPrecio.TabIndex = 2;
            LPrecio.Text = "Precio";
            // 
            // LExistenciasA
            // 
            LExistenciasA.AutoSize = true;
            LExistenciasA.Depth = 0;
            LExistenciasA.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LExistenciasA.Location = new Point(24, 497);
            LExistenciasA.MouseState = MaterialSkin.MouseState.HOVER;
            LExistenciasA.Name = "LExistenciasA";
            LExistenciasA.Size = new Size(146, 19);
            LExistenciasA.TabIndex = 3;
            LExistenciasA.Text = "Existencias Actuales";
            // 
            // LExistenciasMin
            // 
            LExistenciasMin.AutoSize = true;
            LExistenciasMin.Depth = 0;
            LExistenciasMin.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LExistenciasMin.Location = new Point(262, 497);
            LExistenciasMin.MouseState = MaterialSkin.MouseState.HOVER;
            LExistenciasMin.Name = "LExistenciasMin";
            LExistenciasMin.Size = new Size(147, 19);
            LExistenciasMin.TabIndex = 4;
            LExistenciasMin.Text = "Existencias Minimas";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Depth = 0;
            LNombre.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LNombre.Location = new Point(15, 82);
            LNombre.MouseState = MaterialSkin.MouseState.HOVER;
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(150, 19);
            LNombre.TabIndex = 5;
            LNombre.Text = "Nombre del Producto";
            // 
            // LDescripcion
            // 
            LDescripcion.AutoSize = true;
            LDescripcion.Depth = 0;
            LDescripcion.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LDescripcion.Location = new Point(15, 164);
            LDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            LDescripcion.Name = "LDescripcion";
            LDescripcion.Size = new Size(84, 19);
            LDescripcion.TabIndex = 6;
            LDescripcion.Text = "Descripcion";
            // 
            // TxtCodigo
            // 
            TxtCodigo.AnimateReadOnly = false;
            TxtCodigo.BackgroundImageLayout = ImageLayout.None;
            TxtCodigo.CharacterCasing = CharacterCasing.Normal;
            TxtCodigo.Depth = 0;
            TxtCodigo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtCodigo.HideSelection = true;
            TxtCodigo.LeadingIcon = null;
            TxtCodigo.Location = new Point(15, 22);
            TxtCodigo.MaxLength = 32767;
            TxtCodigo.MouseState = MaterialSkin.MouseState.OUT;
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.PasswordChar = '\0';
            TxtCodigo.PrefixSuffixText = null;
            TxtCodigo.ReadOnly = false;
            TxtCodigo.RightToLeft = RightToLeft.No;
            TxtCodigo.SelectedText = "";
            TxtCodigo.SelectionLength = 0;
            TxtCodigo.SelectionStart = 0;
            TxtCodigo.ShortcutsEnabled = true;
            TxtCodigo.Size = new Size(312, 48);
            TxtCodigo.TabIndex = 7;
            TxtCodigo.TabStop = false;
            TxtCodigo.TextAlign = HorizontalAlignment.Left;
            TxtCodigo.TrailingIcon = null;
            TxtCodigo.UseSystemPasswordChar = false;
            // 
            // TxtNombre
            // 
            TxtNombre.AnimateReadOnly = false;
            TxtNombre.BackgroundImageLayout = ImageLayout.None;
            TxtNombre.CharacterCasing = CharacterCasing.Normal;
            TxtNombre.Depth = 0;
            TxtNombre.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtNombre.HideSelection = true;
            TxtNombre.LeadingIcon = null;
            TxtNombre.Location = new Point(15, 104);
            TxtNombre.MaxLength = 32767;
            TxtNombre.MouseState = MaterialSkin.MouseState.OUT;
            TxtNombre.Name = "TxtNombre";
            TxtNombre.PasswordChar = '\0';
            TxtNombre.PrefixSuffixText = null;
            TxtNombre.ReadOnly = false;
            TxtNombre.RightToLeft = RightToLeft.No;
            TxtNombre.SelectedText = "";
            TxtNombre.SelectionLength = 0;
            TxtNombre.SelectionStart = 0;
            TxtNombre.ShortcutsEnabled = true;
            TxtNombre.Size = new Size(312, 48);
            TxtNombre.TabIndex = 8;
            TxtNombre.TabStop = false;
            TxtNombre.TextAlign = HorizontalAlignment.Left;
            TxtNombre.TrailingIcon = null;
            TxtNombre.UseSystemPasswordChar = false;
            // 
            // MltDescripcion
            // 
            MltDescripcion.AnimateReadOnly = false;
            MltDescripcion.BackgroundImageLayout = ImageLayout.None;
            MltDescripcion.CharacterCasing = CharacterCasing.Normal;
            MltDescripcion.Depth = 0;
            MltDescripcion.HideSelection = true;
            MltDescripcion.Location = new Point(15, 186);
            MltDescripcion.MaxLength = 32767;
            MltDescripcion.MouseState = MaterialSkin.MouseState.OUT;
            MltDescripcion.Name = "MltDescripcion";
            MltDescripcion.PasswordChar = '\0';
            MltDescripcion.ReadOnly = false;
            MltDescripcion.ScrollBars = ScrollBars.None;
            MltDescripcion.SelectedText = "";
            MltDescripcion.SelectionLength = 0;
            MltDescripcion.SelectionStart = 0;
            MltDescripcion.ShortcutsEnabled = true;
            MltDescripcion.Size = new Size(312, 125);
            MltDescripcion.TabIndex = 9;
            MltDescripcion.TabStop = false;
            MltDescripcion.TextAlign = HorizontalAlignment.Left;
            MltDescripcion.UseSystemPasswordChar = false;
            // 
            // TxtPrecio
            // 
            TxtPrecio.AnimateReadOnly = false;
            TxtPrecio.BackgroundImageLayout = ImageLayout.None;
            TxtPrecio.CharacterCasing = CharacterCasing.Normal;
            TxtPrecio.Depth = 0;
            TxtPrecio.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtPrecio.HideSelection = true;
            TxtPrecio.LeadingIcon = null;
            TxtPrecio.Location = new Point(15, 433);
            TxtPrecio.MaxLength = 32767;
            TxtPrecio.MouseState = MaterialSkin.MouseState.OUT;
            TxtPrecio.Name = "TxtPrecio";
            TxtPrecio.PasswordChar = '\0';
            TxtPrecio.PrefixSuffixText = null;
            TxtPrecio.ReadOnly = false;
            TxtPrecio.RightToLeft = RightToLeft.No;
            TxtPrecio.SelectedText = "";
            TxtPrecio.SelectionLength = 0;
            TxtPrecio.SelectionStart = 0;
            TxtPrecio.ShortcutsEnabled = true;
            TxtPrecio.Size = new Size(312, 48);
            TxtPrecio.TabIndex = 10;
            TxtPrecio.TabStop = false;
            TxtPrecio.TextAlign = HorizontalAlignment.Left;
            TxtPrecio.TrailingIcon = null;
            TxtPrecio.UseSystemPasswordChar = false;
            // 
            // TxtExistenciasA
            // 
            TxtExistenciasA.AnimateReadOnly = false;
            TxtExistenciasA.BackgroundImageLayout = ImageLayout.None;
            TxtExistenciasA.CharacterCasing = CharacterCasing.Normal;
            TxtExistenciasA.Depth = 0;
            TxtExistenciasA.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtExistenciasA.HideSelection = true;
            TxtExistenciasA.LeadingIcon = null;
            TxtExistenciasA.Location = new Point(24, 529);
            TxtExistenciasA.MaxLength = 32767;
            TxtExistenciasA.MouseState = MaterialSkin.MouseState.OUT;
            TxtExistenciasA.Name = "TxtExistenciasA";
            TxtExistenciasA.PasswordChar = '\0';
            TxtExistenciasA.PrefixSuffixText = null;
            TxtExistenciasA.ReadOnly = false;
            TxtExistenciasA.RightToLeft = RightToLeft.No;
            TxtExistenciasA.SelectedText = "";
            TxtExistenciasA.SelectionLength = 0;
            TxtExistenciasA.SelectionStart = 0;
            TxtExistenciasA.ShortcutsEnabled = true;
            TxtExistenciasA.Size = new Size(146, 48);
            TxtExistenciasA.TabIndex = 11;
            TxtExistenciasA.TabStop = false;
            TxtExistenciasA.TextAlign = HorizontalAlignment.Left;
            TxtExistenciasA.TrailingIcon = null;
            TxtExistenciasA.UseSystemPasswordChar = false;
            // 
            // TxtExistenciasMin
            // 
            TxtExistenciasMin.AnimateReadOnly = false;
            TxtExistenciasMin.BackgroundImageLayout = ImageLayout.None;
            TxtExistenciasMin.CharacterCasing = CharacterCasing.Normal;
            TxtExistenciasMin.Depth = 0;
            TxtExistenciasMin.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtExistenciasMin.HideSelection = true;
            TxtExistenciasMin.LeadingIcon = null;
            TxtExistenciasMin.Location = new Point(255, 529);
            TxtExistenciasMin.MaxLength = 32767;
            TxtExistenciasMin.MouseState = MaterialSkin.MouseState.OUT;
            TxtExistenciasMin.Name = "TxtExistenciasMin";
            TxtExistenciasMin.PasswordChar = '\0';
            TxtExistenciasMin.PrefixSuffixText = null;
            TxtExistenciasMin.ReadOnly = false;
            TxtExistenciasMin.RightToLeft = RightToLeft.No;
            TxtExistenciasMin.SelectedText = "";
            TxtExistenciasMin.SelectionLength = 0;
            TxtExistenciasMin.SelectionStart = 0;
            TxtExistenciasMin.ShortcutsEnabled = true;
            TxtExistenciasMin.Size = new Size(154, 48);
            TxtExistenciasMin.TabIndex = 12;
            TxtExistenciasMin.TabStop = false;
            TxtExistenciasMin.TextAlign = HorizontalAlignment.Left;
            TxtExistenciasMin.TrailingIcon = null;
            TxtExistenciasMin.UseSystemPasswordChar = false;
            // 
            // CbCategoria
            // 
            CbCategoria.AutoResize = false;
            CbCategoria.BackColor = Color.FromArgb(255, 255, 255);
            CbCategoria.Depth = 0;
            CbCategoria.DrawMode = DrawMode.OwnerDrawVariable;
            CbCategoria.DropDownHeight = 174;
            CbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            CbCategoria.DropDownWidth = 121;
            CbCategoria.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CbCategoria.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CbCategoria.FormattingEnabled = true;
            CbCategoria.IntegralHeight = false;
            CbCategoria.ItemHeight = 43;
            CbCategoria.Location = new Point(15, 347);
            CbCategoria.MaxDropDownItems = 4;
            CbCategoria.MouseState = MaterialSkin.MouseState.OUT;
            CbCategoria.Name = "CbCategoria";
            CbCategoria.Size = new Size(151, 49);
            CbCategoria.StartIndex = 0;
            CbCategoria.TabIndex = 13;
            // 
            // BtnCancelar
            // 
            BtnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnCancelar.Depth = 0;
            BtnCancelar.HighEmphasis = true;
            BtnCancelar.Icon = null;
            BtnCancelar.Location = new Point(243, 701);
            BtnCancelar.Margin = new Padding(4, 6, 4, 6);
            BtnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.NoAccentTextColor = Color.Empty;
            BtnCancelar.Size = new Size(96, 36);
            BtnCancelar.TabIndex = 14;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            BtnCancelar.UseAccentColor = false;
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            BtnGuardar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnGuardar.Depth = 0;
            BtnGuardar.HighEmphasis = true;
            BtnGuardar.Icon = null;
            BtnGuardar.Location = new Point(371, 701);
            BtnGuardar.Margin = new Padding(4, 6, 4, 6);
            BtnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.NoAccentTextColor = Color.Empty;
            BtnGuardar.Size = new Size(88, 36);
            BtnGuardar.TabIndex = 15;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnGuardar.UseAccentColor = false;
            BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(CbCategoria);
            panel1.Controls.Add(TxtExistenciasMin);
            panel1.Controls.Add(TxtExistenciasA);
            panel1.Controls.Add(TxtPrecio);
            panel1.Controls.Add(MltDescripcion);
            panel1.Controls.Add(TxtNombre);
            panel1.Controls.Add(TxtCodigo);
            panel1.Controls.Add(LDescripcion);
            panel1.Controls.Add(LNombre);
            panel1.Controls.Add(LExistenciasMin);
            panel1.Controls.Add(LExistenciasA);
            panel1.Controls.Add(LPrecio);
            panel1.Controls.Add(LCategoria);
            panel1.Controls.Add(LCodigo);
            panel1.Location = new Point(12, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(447, 612);
            panel1.TabIndex = 16;
            // 
            // FormProductoAltaEdicion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 746);
            Controls.Add(BtnGuardar);
            Controls.Add(BtnCancelar);
            Controls.Add(panel1);
            Name = "FormProductoAltaEdicion";
            Text = "Registrar Nuevo Producto";
            Load += FormProductoAltaEdicion_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LCodigo;
        private MaterialSkin.Controls.MaterialLabel LCategoria;
        private MaterialSkin.Controls.MaterialLabel LPrecio;
        private MaterialSkin.Controls.MaterialLabel LExistenciasA;
        private MaterialSkin.Controls.MaterialLabel LExistenciasMin;
        private MaterialSkin.Controls.MaterialLabel LNombre;
        private MaterialSkin.Controls.MaterialLabel LDescripcion;
        private MaterialSkin.Controls.MaterialTextBox2 TxtCodigo;
        private MaterialSkin.Controls.MaterialTextBox2 TxtNombre;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 MltDescripcion;
        private MaterialSkin.Controls.MaterialTextBox2 TxtPrecio;
        private MaterialSkin.Controls.MaterialTextBox2 TxtExistenciasA;
        private MaterialSkin.Controls.MaterialTextBox2 TxtExistenciasMin;
        private MaterialSkin.Controls.MaterialComboBox CbCategoria;
        private MaterialSkin.Controls.MaterialButton BtnCancelar;
        private MaterialSkin.Controls.MaterialButton BtnGuardar;
        private Panel panel1;
    }
}