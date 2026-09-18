using System;
using MaterialSkin.Controls;

namespace RGTS.Interfaz.Administrador
{
    partial class FormAgregarUsuario
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
            panel1 = new Panel();
            BtnCancelarUsuario = new MaterialButton();
            BtnAgregarUsuarioNuevo = new MaterialButton();
            TextBoxUsuarioContrasenia = new MaterialTextBox2();
            ComboBoxUsuarioRol = new MaterialComboBox();
            TextBoxUsuarioEmail = new MaterialTextBox2();
            TextBoxUsuarioDni = new MaterialTextBox2();
            TextBoxUsuarioApellido = new MaterialTextBox2();
            TextBoxUsuarioNombre = new MaterialTextBox2();
            LabelUsuarioContrasenia = new MaterialLabel();
            LabelUsuarioRol = new MaterialLabel();
            LabelUsuarioEmail = new MaterialLabel();
            LabelUsuarioApellido = new MaterialLabel();
            LabelUsuarioNombre = new MaterialLabel();
            LabelUsuarioDni = new MaterialLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnCancelarUsuario);
            panel1.Controls.Add(BtnAgregarUsuarioNuevo);
            panel1.Controls.Add(TextBoxUsuarioContrasenia);
            panel1.Controls.Add(ComboBoxUsuarioRol);
            panel1.Controls.Add(TextBoxUsuarioEmail);
            panel1.Controls.Add(TextBoxUsuarioDni);
            panel1.Controls.Add(TextBoxUsuarioApellido);
            panel1.Controls.Add(TextBoxUsuarioNombre);
            panel1.Controls.Add(LabelUsuarioContrasenia);
            panel1.Controls.Add(LabelUsuarioRol);
            panel1.Controls.Add(LabelUsuarioEmail);
            panel1.Controls.Add(LabelUsuarioApellido);
            panel1.Controls.Add(LabelUsuarioNombre);
            panel1.Controls.Add(LabelUsuarioDni);
            panel1.Location = new Point(31, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(595, 357);
            panel1.TabIndex = 0;
            // 
            // BtnCancelarUsuario
            // 
            BtnCancelarUsuario.AutoSize = false;
            BtnCancelarUsuario.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnCancelarUsuario.Density = MaterialButton.MaterialButtonDensity.Default;
            BtnCancelarUsuario.Depth = 0;
            BtnCancelarUsuario.HighEmphasis = true;
            BtnCancelarUsuario.Icon = null;
            BtnCancelarUsuario.Location = new Point(329, 300);
            BtnCancelarUsuario.Margin = new Padding(4, 6, 4, 6);
            BtnCancelarUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            BtnCancelarUsuario.Name = "BtnCancelarUsuario";
            BtnCancelarUsuario.NoAccentTextColor = Color.Empty;
            BtnCancelarUsuario.Size = new Size(121, 36);
            BtnCancelarUsuario.TabIndex = 14;
            BtnCancelarUsuario.Text = "Cancelar";
            BtnCancelarUsuario.Type = MaterialButton.MaterialButtonType.Outlined;
            BtnCancelarUsuario.UseAccentColor = false;
            BtnCancelarUsuario.UseVisualStyleBackColor = true;
            BtnCancelarUsuario.Click += BtnCancelarUsuario_Click;
            // 
            // BtnAgregarUsuarioNuevo
            // 
            BtnAgregarUsuarioNuevo.AutoSize = false;
            BtnAgregarUsuarioNuevo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnAgregarUsuarioNuevo.Density = MaterialButton.MaterialButtonDensity.Default;
            BtnAgregarUsuarioNuevo.Depth = 0;
            BtnAgregarUsuarioNuevo.HighEmphasis = true;
            BtnAgregarUsuarioNuevo.Icon = null;
            BtnAgregarUsuarioNuevo.Location = new Point(458, 300);
            BtnAgregarUsuarioNuevo.Margin = new Padding(4, 6, 4, 6);
            BtnAgregarUsuarioNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            BtnAgregarUsuarioNuevo.Name = "BtnAgregarUsuarioNuevo";
            BtnAgregarUsuarioNuevo.NoAccentTextColor = Color.Empty;
            BtnAgregarUsuarioNuevo.Size = new Size(121, 36);
            BtnAgregarUsuarioNuevo.TabIndex = 13;
            BtnAgregarUsuarioNuevo.Text = "Agregar";
            BtnAgregarUsuarioNuevo.Type = MaterialButton.MaterialButtonType.Contained;
            BtnAgregarUsuarioNuevo.UseAccentColor = false;
            BtnAgregarUsuarioNuevo.UseVisualStyleBackColor = true;
            BtnAgregarUsuarioNuevo.Click += BtnAgregarUsuarioNuevo_Click;
            // 
            // TextBoxUsuarioContrasenia
            // 
            TextBoxUsuarioContrasenia.AnimateReadOnly = false;
            TextBoxUsuarioContrasenia.BackgroundImageLayout = ImageLayout.None;
            TextBoxUsuarioContrasenia.CharacterCasing = CharacterCasing.Normal;
            TextBoxUsuarioContrasenia.Depth = 0;
            TextBoxUsuarioContrasenia.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextBoxUsuarioContrasenia.HideSelection = false;
            TextBoxUsuarioContrasenia.LeadingIcon = null;
            TextBoxUsuarioContrasenia.Location = new Point(329, 223);
            TextBoxUsuarioContrasenia.MaxLength = 32767;
            TextBoxUsuarioContrasenia.MouseState = MaterialSkin.MouseState.OUT;
            TextBoxUsuarioContrasenia.Name = "TextBoxUsuarioContrasenia";
            TextBoxUsuarioContrasenia.PasswordChar = '●';
            TextBoxUsuarioContrasenia.PrefixSuffixText = null;
            TextBoxUsuarioContrasenia.ReadOnly = false;
            TextBoxUsuarioContrasenia.RightToLeft = RightToLeft.No;
            TextBoxUsuarioContrasenia.SelectedText = "";
            TextBoxUsuarioContrasenia.SelectionLength = 0;
            TextBoxUsuarioContrasenia.SelectionStart = 0;
            TextBoxUsuarioContrasenia.ShortcutsEnabled = true;
            TextBoxUsuarioContrasenia.Size = new Size(250, 48);
            TextBoxUsuarioContrasenia.TabIndex = 12;
            TextBoxUsuarioContrasenia.TabStop = false;
            TextBoxUsuarioContrasenia.TextAlign = HorizontalAlignment.Left;
            TextBoxUsuarioContrasenia.TrailingIcon = null;
            TextBoxUsuarioContrasenia.UseSystemPasswordChar = true;
            // 
            // ComboBoxUsuarioRol
            // 
            ComboBoxUsuarioRol.AutoResize = false;
            ComboBoxUsuarioRol.BackColor = Color.FromArgb(255, 255, 255);
            ComboBoxUsuarioRol.Depth = 0;
            ComboBoxUsuarioRol.DrawMode = DrawMode.OwnerDrawVariable;
            ComboBoxUsuarioRol.DropDownHeight = 174;
            ComboBoxUsuarioRol.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxUsuarioRol.DropDownWidth = 121;
            ComboBoxUsuarioRol.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            ComboBoxUsuarioRol.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ComboBoxUsuarioRol.FormattingEnabled = true;
            ComboBoxUsuarioRol.IntegralHeight = false;
            ComboBoxUsuarioRol.ItemHeight = 43;
            ComboBoxUsuarioRol.Location = new Point(18, 223);
            ComboBoxUsuarioRol.MaxDropDownItems = 4;
            ComboBoxUsuarioRol.MouseState = MaterialSkin.MouseState.OUT;
            ComboBoxUsuarioRol.Name = "ComboBoxUsuarioRol";
            ComboBoxUsuarioRol.Size = new Size(250, 49);
            ComboBoxUsuarioRol.StartIndex = 0;
            ComboBoxUsuarioRol.TabIndex = 11;
            // 
            // TextBoxUsuarioEmail
            // 
            TextBoxUsuarioEmail.AnimateReadOnly = false;
            TextBoxUsuarioEmail.BackgroundImageLayout = ImageLayout.None;
            TextBoxUsuarioEmail.CharacterCasing = CharacterCasing.Normal;
            TextBoxUsuarioEmail.Depth = 0;
            TextBoxUsuarioEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextBoxUsuarioEmail.HideSelection = true;
            TextBoxUsuarioEmail.LeadingIcon = null;
            TextBoxUsuarioEmail.Location = new Point(329, 125);
            TextBoxUsuarioEmail.MaxLength = 32767;
            TextBoxUsuarioEmail.MouseState = MaterialSkin.MouseState.OUT;
            TextBoxUsuarioEmail.Name = "TextBoxUsuarioEmail";
            TextBoxUsuarioEmail.PasswordChar = '\0';
            TextBoxUsuarioEmail.PrefixSuffixText = null;
            TextBoxUsuarioEmail.ReadOnly = false;
            TextBoxUsuarioEmail.RightToLeft = RightToLeft.No;
            TextBoxUsuarioEmail.SelectedText = "";
            TextBoxUsuarioEmail.SelectionLength = 0;
            TextBoxUsuarioEmail.SelectionStart = 0;
            TextBoxUsuarioEmail.ShortcutsEnabled = true;
            TextBoxUsuarioEmail.Size = new Size(250, 48);
            TextBoxUsuarioEmail.TabIndex = 10;
            TextBoxUsuarioEmail.TabStop = false;
            TextBoxUsuarioEmail.TextAlign = HorizontalAlignment.Left;
            TextBoxUsuarioEmail.TrailingIcon = null;
            TextBoxUsuarioEmail.UseSystemPasswordChar = false;
            // 
            // TextBoxUsuarioDni
            // 
            TextBoxUsuarioDni.AnimateReadOnly = false;
            TextBoxUsuarioDni.BackgroundImageLayout = ImageLayout.None;
            TextBoxUsuarioDni.CharacterCasing = CharacterCasing.Normal;
            TextBoxUsuarioDni.Depth = 0;
            TextBoxUsuarioDni.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextBoxUsuarioDni.HideSelection = true;
            TextBoxUsuarioDni.LeadingIcon = null;
            TextBoxUsuarioDni.Location = new Point(18, 126);
            TextBoxUsuarioDni.MaxLength = 32767;
            TextBoxUsuarioDni.MouseState = MaterialSkin.MouseState.OUT;
            TextBoxUsuarioDni.Name = "TextBoxUsuarioDni";
            TextBoxUsuarioDni.PasswordChar = '\0';
            TextBoxUsuarioDni.PrefixSuffixText = null;
            TextBoxUsuarioDni.ReadOnly = false;
            TextBoxUsuarioDni.RightToLeft = RightToLeft.No;
            TextBoxUsuarioDni.SelectedText = "";
            TextBoxUsuarioDni.SelectionLength = 0;
            TextBoxUsuarioDni.SelectionStart = 0;
            TextBoxUsuarioDni.ShortcutsEnabled = true;
            TextBoxUsuarioDni.Size = new Size(250, 48);
            TextBoxUsuarioDni.TabIndex = 9;
            TextBoxUsuarioDni.TabStop = false;
            TextBoxUsuarioDni.TextAlign = HorizontalAlignment.Left;
            TextBoxUsuarioDni.TrailingIcon = null;
            TextBoxUsuarioDni.UseSystemPasswordChar = false;
            // 
            // TextBoxUsuarioApellido
            // 
            TextBoxUsuarioApellido.AnimateReadOnly = false;
            TextBoxUsuarioApellido.BackgroundImageLayout = ImageLayout.None;
            TextBoxUsuarioApellido.CharacterCasing = CharacterCasing.Normal;
            TextBoxUsuarioApellido.Depth = 0;
            TextBoxUsuarioApellido.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextBoxUsuarioApellido.HideSelection = true;
            TextBoxUsuarioApellido.LeadingIcon = null;
            TextBoxUsuarioApellido.Location = new Point(329, 32);
            TextBoxUsuarioApellido.MaxLength = 50;
            TextBoxUsuarioApellido.MouseState = MaterialSkin.MouseState.OUT;
            TextBoxUsuarioApellido.Name = "TextBoxUsuarioApellido";
            TextBoxUsuarioApellido.PasswordChar = '\0';
            TextBoxUsuarioApellido.PrefixSuffixText = null;
            TextBoxUsuarioApellido.ReadOnly = false;
            TextBoxUsuarioApellido.RightToLeft = RightToLeft.No;
            TextBoxUsuarioApellido.SelectedText = "";
            TextBoxUsuarioApellido.SelectionLength = 0;
            TextBoxUsuarioApellido.SelectionStart = 0;
            TextBoxUsuarioApellido.ShortcutsEnabled = true;
            TextBoxUsuarioApellido.Size = new Size(250, 48);
            TextBoxUsuarioApellido.TabIndex = 8;
            TextBoxUsuarioApellido.TabStop = false;
            TextBoxUsuarioApellido.TextAlign = HorizontalAlignment.Left;
            TextBoxUsuarioApellido.TrailingIcon = null;
            TextBoxUsuarioApellido.UseSystemPasswordChar = false;
            // 
            // TextBoxUsuarioNombre
            // 
            TextBoxUsuarioNombre.AnimateReadOnly = false;
            TextBoxUsuarioNombre.BackgroundImageLayout = ImageLayout.None;
            TextBoxUsuarioNombre.CharacterCasing = CharacterCasing.Normal;
            TextBoxUsuarioNombre.Depth = 0;
            TextBoxUsuarioNombre.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextBoxUsuarioNombre.HideSelection = true;
            TextBoxUsuarioNombre.LeadingIcon = null;
            TextBoxUsuarioNombre.Location = new Point(18, 32);
            TextBoxUsuarioNombre.MaxLength = 50;
            TextBoxUsuarioNombre.MouseState = MaterialSkin.MouseState.OUT;
            TextBoxUsuarioNombre.Name = "TextBoxUsuarioNombre";
            TextBoxUsuarioNombre.PasswordChar = '\0';
            TextBoxUsuarioNombre.PrefixSuffixText = null;
            TextBoxUsuarioNombre.ReadOnly = false;
            TextBoxUsuarioNombre.RightToLeft = RightToLeft.No;
            TextBoxUsuarioNombre.SelectedText = "";
            TextBoxUsuarioNombre.SelectionLength = 0;
            TextBoxUsuarioNombre.SelectionStart = 0;
            TextBoxUsuarioNombre.ShortcutsEnabled = true;
            TextBoxUsuarioNombre.Size = new Size(250, 48);
            TextBoxUsuarioNombre.TabIndex = 7;
            TextBoxUsuarioNombre.TabStop = false;
            TextBoxUsuarioNombre.TextAlign = HorizontalAlignment.Left;
            TextBoxUsuarioNombre.TrailingIcon = null;
            TextBoxUsuarioNombre.UseSystemPasswordChar = false;
            // 
            // LabelUsuarioContrasenia
            // 
            LabelUsuarioContrasenia.AutoSize = true;
            LabelUsuarioContrasenia.Depth = 0;
            LabelUsuarioContrasenia.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelUsuarioContrasenia.Location = new Point(329, 201);
            LabelUsuarioContrasenia.MouseState = MaterialSkin.MouseState.HOVER;
            LabelUsuarioContrasenia.Name = "LabelUsuarioContrasenia";
            LabelUsuarioContrasenia.Size = new Size(128, 19);
            LabelUsuarioContrasenia.TabIndex = 5;
            LabelUsuarioContrasenia.Text = "Contraseña inicial";
            // 
            // LabelUsuarioRol
            // 
            LabelUsuarioRol.AutoSize = true;
            LabelUsuarioRol.Depth = 0;
            LabelUsuarioRol.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelUsuarioRol.Location = new Point(18, 201);
            LabelUsuarioRol.MouseState = MaterialSkin.MouseState.HOVER;
            LabelUsuarioRol.Name = "LabelUsuarioRol";
            LabelUsuarioRol.Size = new Size(24, 19);
            LabelUsuarioRol.TabIndex = 4;
            LabelUsuarioRol.Text = "Rol";
            // 
            // LabelUsuarioEmail
            // 
            LabelUsuarioEmail.AutoSize = true;
            LabelUsuarioEmail.Depth = 0;
            LabelUsuarioEmail.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelUsuarioEmail.Location = new Point(329, 103);
            LabelUsuarioEmail.MouseState = MaterialSkin.MouseState.HOVER;
            LabelUsuarioEmail.Name = "LabelUsuarioEmail";
            LabelUsuarioEmail.Size = new Size(41, 19);
            LabelUsuarioEmail.TabIndex = 3;
            LabelUsuarioEmail.Text = "Email";
            // 
            // LabelUsuarioApellido
            // 
            LabelUsuarioApellido.AutoSize = true;
            LabelUsuarioApellido.Depth = 0;
            LabelUsuarioApellido.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelUsuarioApellido.Location = new Point(329, 10);
            LabelUsuarioApellido.MouseState = MaterialSkin.MouseState.HOVER;
            LabelUsuarioApellido.Name = "LabelUsuarioApellido";
            LabelUsuarioApellido.Size = new Size(58, 19);
            LabelUsuarioApellido.TabIndex = 2;
            LabelUsuarioApellido.Text = "Apellido";
            // 
            // LabelUsuarioNombre
            // 
            LabelUsuarioNombre.AutoSize = true;
            LabelUsuarioNombre.Depth = 0;
            LabelUsuarioNombre.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelUsuarioNombre.Location = new Point(18, 11);
            LabelUsuarioNombre.MouseState = MaterialSkin.MouseState.HOVER;
            LabelUsuarioNombre.Name = "LabelUsuarioNombre";
            LabelUsuarioNombre.Size = new Size(57, 19);
            LabelUsuarioNombre.TabIndex = 1;
            LabelUsuarioNombre.Text = "Nombre";
            // 
            // LabelUsuarioDni
            // 
            LabelUsuarioDni.AutoSize = true;
            LabelUsuarioDni.Depth = 0;
            LabelUsuarioDni.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelUsuarioDni.Location = new Point(18, 104);
            LabelUsuarioDni.MouseState = MaterialSkin.MouseState.HOVER;
            LabelUsuarioDni.Name = "LabelUsuarioDni";
            LabelUsuarioDni.Size = new Size(27, 19);
            LabelUsuarioDni.TabIndex = 0;
            LabelUsuarioDni.Text = "DNI";
            // 
            // FormAgregarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 459);
            Controls.Add(panel1);
            Name = "FormAgregarUsuario";
            Text = "Registrar nuevo usuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MaterialLabel LabelUsuarioApellido;
        private MaterialLabel LabelUsuarioNombre;
        private MaterialLabel LabelUsuarioDni;
        private MaterialLabel LabelUsuarioRol;
        private MaterialLabel LabelUsuarioEmail;
        private MaterialLabel LabelUsuarioContrasenia;
        private MaterialTextBox2 TextBoxUsuarioDni;
        private MaterialTextBox2 TextBoxUsuarioApellido;
        private MaterialTextBox2 TextBoxUsuarioNombre;
        private MaterialTextBox2 TextBoxUsuarioEmail;
        private MaterialTextBox2 TextBoxUsuarioContrasenia;
        private MaterialComboBox ComboBoxUsuarioRol;
        private MaterialButton BtnAgregarUsuarioNuevo;
        private MaterialButton BtnCancelarUsuario;
    }
}