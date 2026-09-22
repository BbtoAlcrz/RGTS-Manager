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
            panel1 = new MaterialSkin.Controls.MaterialCard();
            TxtExistenciasMax = new MaterialSkin.Controls.MaterialTextBox2();
            LExistenciasMax = new MaterialSkin.Controls.MaterialLabel();
            labelTitulo = new MaterialSkin.Controls.MaterialLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LCodigo
            // 
            LCodigo.AutoSize = true;
            LCodigo.Depth = 0;
            LCodigo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LCodigo.Location = new Point(15, 73);
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
            LCategoria.Location = new Point(15, 167);
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
            LPrecio.Location = new Point(206, 167);
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
            LExistenciasA.Location = new Point(15, 259);
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
            LExistenciasMin.Location = new Point(15, 353);
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
            LNombre.Location = new Point(413, 73);
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
            LDescripcion.Location = new Point(413, 167);
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
            TxtCodigo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtCodigo.HideSelection = true;
            TxtCodigo.LeadingIcon = null;
            TxtCodigo.Location = new Point(15, 94);
            TxtCodigo.Margin = new Padding(3, 2, 3, 2);
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
            TxtCodigo.Size = new Size(357, 48);
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
            TxtNombre.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtNombre.HideSelection = true;
            TxtNombre.LeadingIcon = null;
            TxtNombre.Location = new Point(413, 94);
            TxtNombre.Margin = new Padding(3, 2, 3, 2);
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
            TxtNombre.Size = new Size(397, 48);
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
            MltDescripcion.Location = new Point(413, 189);
            MltDescripcion.Margin = new Padding(3, 2, 3, 2);
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
            MltDescripcion.Size = new Size(397, 159);
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
            TxtPrecio.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtPrecio.HideSelection = true;
            TxtPrecio.LeadingIcon = null;
            TxtPrecio.Location = new Point(206, 189);
            TxtPrecio.Margin = new Padding(3, 2, 3, 2);
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
            TxtPrecio.Size = new Size(166, 48);
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
            TxtExistenciasA.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtExistenciasA.HideSelection = true;
            TxtExistenciasA.LeadingIcon = null;
            TxtExistenciasA.Location = new Point(15, 280);
            TxtExistenciasA.Margin = new Padding(3, 2, 3, 2);
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
            TxtExistenciasA.Size = new Size(169, 48);
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
            TxtExistenciasMin.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtExistenciasMin.HideSelection = true;
            TxtExistenciasMin.LeadingIcon = null;
            TxtExistenciasMin.Location = new Point(15, 374);
            TxtExistenciasMin.Margin = new Padding(3, 2, 3, 2);
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
            TxtExistenciasMin.Size = new Size(169, 48);
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
            CbCategoria.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CbCategoria.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CbCategoria.FormattingEnabled = true;
            CbCategoria.IntegralHeight = false;
            CbCategoria.ItemHeight = 43;
            CbCategoria.Location = new Point(15, 188);
            CbCategoria.Margin = new Padding(3, 2, 3, 2);
            CbCategoria.MaxDropDownItems = 4;
            CbCategoria.MouseState = MaterialSkin.MouseState.OUT;
            CbCategoria.Name = "CbCategoria";
            CbCategoria.Size = new Size(184, 49);
            CbCategoria.StartIndex = 0;
            CbCategoria.TabIndex = 13;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            BtnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnCancelar.Depth = 0;
            BtnCancelar.HighEmphasis = true;
            BtnCancelar.Icon = null;
            BtnCancelar.Location = new Point(618, 386);
            BtnCancelar.Margin = new Padding(4, 4, 4, 4);
            BtnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.NoAccentTextColor = Color.Empty;
            BtnCancelar.Size = new Size(96, 36);
            BtnCancelar.TabIndex = 14;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            BtnCancelar.UseAccentColor = false;
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            BtnGuardar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnGuardar.Depth = 0;
            BtnGuardar.HighEmphasis = true;
            BtnGuardar.Icon = null;
            BtnGuardar.Location = new Point(722, 386);
            BtnGuardar.Margin = new Padding(4, 4, 4, 4);
            BtnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.NoAccentTextColor = Color.Empty;
            BtnGuardar.Size = new Size(88, 36);
            BtnGuardar.TabIndex = 15;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnGuardar.UseAccentColor = false;
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(255, 255, 255);
            panel1.Controls.Add(labelTitulo);
            panel1.Controls.Add(BtnCancelar);
            panel1.Controls.Add(BtnGuardar);
            panel1.Controls.Add(TxtExistenciasMax);
            panel1.Controls.Add(LExistenciasMax);
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
            panel1.Depth = 0;
            panel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panel1.Location = new Point(5, 4);
            panel1.Margin = new Padding(12, 10, 12, 10);
            panel1.MouseState = MaterialSkin.MouseState.HOVER;
            panel1.Name = "panel1";
            panel1.Padding = new Padding(12, 10, 12, 10);
            panel1.Size = new Size(837, 530);
            panel1.TabIndex = 16;
            // 
            // TxtExistenciasMax
            // 
            TxtExistenciasMax.AnimateReadOnly = false;
            TxtExistenciasMax.BackgroundImageLayout = ImageLayout.None;
            TxtExistenciasMax.CharacterCasing = CharacterCasing.Normal;
            TxtExistenciasMax.Depth = 0;
            TxtExistenciasMax.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtExistenciasMax.HideSelection = true;
            TxtExistenciasMax.LeadingIcon = null;
            TxtExistenciasMax.Location = new Point(203, 374);
            TxtExistenciasMax.Margin = new Padding(3, 2, 3, 2);
            TxtExistenciasMax.MaxLength = 32767;
            TxtExistenciasMax.MouseState = MaterialSkin.MouseState.OUT;
            TxtExistenciasMax.Name = "TxtExistenciasMax";
            TxtExistenciasMax.PasswordChar = '\0';
            TxtExistenciasMax.PrefixSuffixText = null;
            TxtExistenciasMax.ReadOnly = false;
            TxtExistenciasMax.RightToLeft = RightToLeft.No;
            TxtExistenciasMax.SelectedText = "";
            TxtExistenciasMax.SelectionLength = 0;
            TxtExistenciasMax.SelectionStart = 0;
            TxtExistenciasMax.ShortcutsEnabled = true;
            TxtExistenciasMax.Size = new Size(169, 48);
            TxtExistenciasMax.TabIndex = 15;
            TxtExistenciasMax.TabStop = false;
            TxtExistenciasMax.TextAlign = HorizontalAlignment.Left;
            TxtExistenciasMax.TrailingIcon = null;
            TxtExistenciasMax.UseSystemPasswordChar = false;
            // 
            // LExistenciasMax
            // 
            LExistenciasMax.AutoSize = true;
            LExistenciasMax.Depth = 0;
            LExistenciasMax.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LExistenciasMax.Location = new Point(206, 353);
            LExistenciasMax.MouseState = MaterialSkin.MouseState.HOVER;
            LExistenciasMax.Name = "LExistenciasMax";
            LExistenciasMax.Size = new Size(151, 19);
            LExistenciasMax.TabIndex = 14;
            LExistenciasMax.Text = "Existencias Maximas";
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
            labelTitulo.Size = new Size(62, 29);
            labelTitulo.TabIndex = 16;
            labelTitulo.Text = "Titulo";
            // 
            // FormProductoAltaEdicion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 560);
            Controls.Add(panel1);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormProductoAltaEdicion";
            Padding = new Padding(3, 0, 3, 2);
            Sizable = false;
            Text = "Registrar Nuevo Producto";
            Load += FormProductoAltaEdicion_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private MaterialSkin.Controls.MaterialCard panel1;
        private MaterialSkin.Controls.MaterialTextBox2 TxtExistenciasMax;
        private MaterialSkin.Controls.MaterialLabel LExistenciasMax;
        private MaterialSkin.Controls.MaterialLabel labelTitulo;
    }
}