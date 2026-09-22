namespace RGTS.Interfaz.Administrador
{
    partial class FormAgregarCategoria
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
            MltDescripcion = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            btnCancelar = new MaterialSkin.Controls.MaterialButton();
            btnGuardar = new MaterialSkin.Controls.MaterialButton();
            LNombre = new MaterialSkin.Controls.MaterialLabel();
            LDescripcion = new MaterialSkin.Controls.MaterialLabel();
            txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            labelTitulo = new MaterialSkin.Controls.MaterialLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(255, 255, 255);
            panel1.Controls.Add(labelTitulo);
            panel1.Controls.Add(MltDescripcion);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(LNombre);
            panel1.Controls.Add(LDescripcion);
            panel1.Controls.Add(txtNombre);
            panel1.Depth = 0;
            panel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panel1.Location = new Point(2, 1);
            panel1.Margin = new Padding(12, 10, 12, 10);
            panel1.MouseState = MaterialSkin.MouseState.HOVER;
            panel1.Name = "panel1";
            panel1.Padding = new Padding(12, 10, 12, 10);
            panel1.Size = new Size(765, 557);
            panel1.TabIndex = 2;
            // 
            // MltDescripcion
            // 
            MltDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MltDescripcion.AnimateReadOnly = false;
            MltDescripcion.BackgroundImageLayout = ImageLayout.None;
            MltDescripcion.CharacterCasing = CharacterCasing.Normal;
            MltDescripcion.Depth = 0;
            MltDescripcion.HideSelection = true;
            MltDescripcion.Location = new Point(146, 236);
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
            MltDescripcion.Size = new Size(420, 134);
            MltDescripcion.TabIndex = 2;
            MltDescripcion.TabStop = false;
            MltDescripcion.TextAlign = HorizontalAlignment.Left;
            MltDescripcion.UseSystemPasswordChar = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.Location = new Point(374, 407);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(96, 36);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnGuardar.Depth = 0;
            btnGuardar.HighEmphasis = true;
            btnGuardar.Icon = null;
            btnGuardar.Location = new Point(478, 407);
            btnGuardar.Margin = new Padding(4);
            btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            btnGuardar.Name = "btnGuardar";
            btnGuardar.NoAccentTextColor = Color.Empty;
            btnGuardar.Size = new Size(88, 36);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGuardar.UseAccentColor = false;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // LNombre
            // 
            LNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LNombre.AutoSize = true;
            LNombre.Depth = 0;
            LNombre.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LNombre.Location = new Point(146, 117);
            LNombre.MouseState = MaterialSkin.MouseState.HOVER;
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(154, 19);
            LNombre.TabIndex = 16;
            LNombre.Text = "Nombre de Categoría:";
            // 
            // LDescripcion
            // 
            LDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LDescripcion.AutoSize = true;
            LDescripcion.Depth = 0;
            LDescripcion.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LDescripcion.Location = new Point(146, 215);
            LDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            LDescripcion.Name = "LDescripcion";
            LDescripcion.Size = new Size(181, 19);
            LDescripcion.TabIndex = 13;
            LDescripcion.Text = "Descripcion de Categoría:";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.AnimateReadOnly = false;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Depth = 0;
            txtNombre.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombre.LeadingIcon = null;
            txtNombre.Location = new Point(146, 138);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.MaxLength = 50;
            txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            txtNombre.Multiline = false;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(420, 50);
            txtNombre.TabIndex = 1;
            txtNombre.Text = "";
            txtNombre.TrailingIcon = null;
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
            labelTitulo.TabIndex = 17;
            labelTitulo.Text = "Titulo";
            // 
            // FormAgregarCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 560);
            Controls.Add(panel1);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAgregarCategoria";
            Padding = new Padding(3, 0, 3, 2);
            Text = "Agregar Categorias";
            Load += FormAgregarCategoria_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard panel1;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private MaterialSkin.Controls.MaterialLabel LNombre;
        private MaterialSkin.Controls.MaterialLabel LDescripcion;
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 MltDescripcion;
        private MaterialSkin.Controls.MaterialLabel labelTitulo;
    }
}