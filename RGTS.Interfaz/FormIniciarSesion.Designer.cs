namespace RGTS.Interfaz
{
    partial class FormIniciarSesion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MaterialSkin.Controls.MaterialLabel LUsuario;
            MaterialSkin.Controls.MaterialLabel LContraseña;
            TextboxUsuario = new MaterialSkin.Controls.MaterialTextBox();
            TextboxContraseña = new MaterialSkin.Controls.MaterialTextBox();
            BIniciarSesion = new MaterialSkin.Controls.MaterialButton();
            LUsuario = new MaterialSkin.Controls.MaterialLabel();
            LContraseña = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // TextboxUsuario
            // 
            TextboxUsuario.AnimateReadOnly = false;
            TextboxUsuario.BorderStyle = BorderStyle.None;
            TextboxUsuario.Depth = 0;
            TextboxUsuario.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextboxUsuario.Hint = "Ingresa tu usuario";
            TextboxUsuario.LeadingIcon = null;
            TextboxUsuario.Location = new Point(48, 139);
            TextboxUsuario.MaxLength = 50;
            TextboxUsuario.MouseState = MaterialSkin.MouseState.OUT;
            TextboxUsuario.Multiline = false;
            TextboxUsuario.Name = "TextboxUsuario";
            TextboxUsuario.Size = new Size(285, 50);
            TextboxUsuario.TabIndex = 0;
            TextboxUsuario.Text = "";
            TextboxUsuario.TrailingIcon = null;
            // 
            // TextboxContraseña
            // 
            TextboxContraseña.AnimateReadOnly = false;
            TextboxContraseña.BorderStyle = BorderStyle.None;
            TextboxContraseña.Depth = 0;
            TextboxContraseña.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextboxContraseña.Hint = "Ingresa tu contraseña";
            TextboxContraseña.LeadingIcon = null;
            TextboxContraseña.Location = new Point(48, 241);
            TextboxContraseña.MaxLength = 50;
            TextboxContraseña.MouseState = MaterialSkin.MouseState.OUT;
            TextboxContraseña.Multiline = false;
            TextboxContraseña.Name = "TextboxContraseña";
            TextboxContraseña.Password = true;
            TextboxContraseña.Size = new Size(285, 50);
            TextboxContraseña.TabIndex = 1;
            TextboxContraseña.Text = "";
            TextboxContraseña.TrailingIcon = null;
            // 
            // LUsuario
            // 
            LUsuario.AutoSize = true;
            LUsuario.Depth = 0;
            LUsuario.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            LUsuario.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            LUsuario.Location = new Point(48, 119);
            LUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            LUsuario.Name = "LUsuario";
            LUsuario.Size = new Size(50, 17);
            LUsuario.TabIndex = 2;
            LUsuario.Text = "Usuario";
            // 
            // LContraseña
            // 
            LContraseña.AutoSize = true;
            LContraseña.Depth = 0;
            LContraseña.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            LContraseña.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            LContraseña.Location = new Point(48, 221);
            LContraseña.MouseState = MaterialSkin.MouseState.HOVER;
            LContraseña.Name = "LContraseña";
            LContraseña.Size = new Size(75, 17);
            LContraseña.TabIndex = 3;
            LContraseña.Text = "Contraseña";
            // 
            // BIniciarSesion
            // 
            BIniciarSesion.AutoSize = false;
            BIniciarSesion.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BIniciarSesion.Cursor = Cursors.Hand;
            BIniciarSesion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BIniciarSesion.Depth = 0;
            BIniciarSesion.HighEmphasis = true;
            BIniciarSesion.Icon = null;
            BIniciarSesion.Location = new Point(48, 334);
            BIniciarSesion.Margin = new Padding(4, 6, 4, 6);
            BIniciarSesion.MouseState = MaterialSkin.MouseState.HOVER;
            BIniciarSesion.Name = "BIniciarSesion";
            BIniciarSesion.NoAccentTextColor = Color.Empty;
            BIniciarSesion.Size = new Size(285, 36);
            BIniciarSesion.TabIndex = 4;
            BIniciarSesion.Text = "Iniciar Sesión";
            BIniciarSesion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BIniciarSesion.UseAccentColor = false;
            BIniciarSesion.UseVisualStyleBackColor = true;
            BIniciarSesion.Click += BIniciarSesion_Click;
            // 
            // FormIniciarSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 464);
            Controls.Add(BIniciarSesion);
            Controls.Add(LContraseña);
            Controls.Add(LUsuario);
            Controls.Add(TextboxContraseña);
            Controls.Add(TextboxUsuario);
            Name = "FormIniciarSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar Sesión";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox TextboxUsuario;
        private MaterialSkin.Controls.MaterialTextBox TextboxContraseña;
        private MaterialSkin.Controls.MaterialLabel LUsuario;
        private MaterialSkin.Controls.MaterialLabel LContraseña;
        private MaterialSkin.Controls.MaterialButton BIniciarSesion;
    }
}
