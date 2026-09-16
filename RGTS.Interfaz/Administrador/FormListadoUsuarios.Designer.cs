using System;
using MaterialSkin.Controls;
namespace RGTS.Interfaz.Administrador

{
    partial class FormListadoUsuarios
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
            panelListaUsuarios = new Panel();
            BtnEliminarUsuario = new MaterialButton();
            BtnEditarUsuario = new MaterialButton();
            BtnAgregarUsuario = new MaterialButton();
            materialListView1 = new MaterialListView();
            UsuarioDNI = new ColumnHeader();
            UsuarioNombre = new ColumnHeader();
            UsuarioApellido = new ColumnHeader();
            UsuarioEmail = new ColumnHeader();
            UsuarioRol = new ColumnHeader();
            UsuarioEstado = new ColumnHeader();
            ComboBoxListarRol = new MaterialComboBox();
            TxtBuscarUsuaio = new MaterialTextBox2();
            panelListaUsuarios.SuspendLayout();
            SuspendLayout();
            // 
            // panelListaUsuarios
            // 
            panelListaUsuarios.Controls.Add(BtnEliminarUsuario);
            panelListaUsuarios.Controls.Add(BtnEditarUsuario);
            panelListaUsuarios.Controls.Add(BtnAgregarUsuario);
            panelListaUsuarios.Controls.Add(materialListView1);
            panelListaUsuarios.Controls.Add(ComboBoxListarRol);
            panelListaUsuarios.Controls.Add(TxtBuscarUsuaio);
            panelListaUsuarios.Location = new Point(27, 71);
            panelListaUsuarios.Name = "panelListaUsuarios";
            panelListaUsuarios.Size = new Size(744, 404);
            panelListaUsuarios.TabIndex = 0;
            panelListaUsuarios.Tag = "";
            // 
            // BtnEliminarUsuario
            // 
            BtnEliminarUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEliminarUsuario.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnEliminarUsuario.Density = MaterialButton.MaterialButtonDensity.Default;
            BtnEliminarUsuario.Depth = 0;
            BtnEliminarUsuario.HighEmphasis = true;
            BtnEliminarUsuario.Icon = null;
            BtnEliminarUsuario.Location = new Point(618, 318);
            BtnEliminarUsuario.Margin = new Padding(4, 6, 4, 6);
            BtnEliminarUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            BtnEliminarUsuario.Name = "BtnEliminarUsuario";
            BtnEliminarUsuario.NoAccentTextColor = Color.Empty;
            BtnEliminarUsuario.Size = new Size(122, 36);
            BtnEliminarUsuario.TabIndex = 5;
            BtnEliminarUsuario.Text = "Deshabilitar";
            BtnEliminarUsuario.Type = MaterialButton.MaterialButtonType.Outlined;
            BtnEliminarUsuario.UseAccentColor = false;
            BtnEliminarUsuario.UseVisualStyleBackColor = true;
            // 
            // BtnEditarUsuario
            // 
            BtnEditarUsuario.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnEditarUsuario.Density = MaterialButton.MaterialButtonDensity.Default;
            BtnEditarUsuario.Depth = 0;
            BtnEditarUsuario.HighEmphasis = true;
            BtnEditarUsuario.Icon = null;
            BtnEditarUsuario.Location = new Point(165, 318);
            BtnEditarUsuario.Margin = new Padding(4, 6, 4, 6);
            BtnEditarUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            BtnEditarUsuario.Name = "BtnEditarUsuario";
            BtnEditarUsuario.NoAccentTextColor = Color.Empty;
            BtnEditarUsuario.Size = new Size(71, 36);
            BtnEditarUsuario.TabIndex = 4;
            BtnEditarUsuario.Text = "Editar";
            BtnEditarUsuario.Type = MaterialButton.MaterialButtonType.Outlined;
            BtnEditarUsuario.UseAccentColor = false;
            BtnEditarUsuario.UseVisualStyleBackColor = true;
            // 
            // BtnAgregarUsuario
            // 
            BtnAgregarUsuario.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnAgregarUsuario.Density = MaterialButton.MaterialButtonDensity.Default;
            BtnAgregarUsuario.Depth = 0;
            BtnAgregarUsuario.HighEmphasis = true;
            BtnAgregarUsuario.Icon = null;
            BtnAgregarUsuario.Location = new Point(4, 318);
            BtnAgregarUsuario.Margin = new Padding(4, 6, 4, 6);
            BtnAgregarUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            BtnAgregarUsuario.Name = "BtnAgregarUsuario";
            BtnAgregarUsuario.NoAccentTextColor = Color.Empty;
            BtnAgregarUsuario.Size = new Size(153, 36);
            BtnAgregarUsuario.TabIndex = 3;
            BtnAgregarUsuario.Text = "Agregar Usuario";
            BtnAgregarUsuario.Type = MaterialButton.MaterialButtonType.Contained;
            BtnAgregarUsuario.UseAccentColor = false;
            BtnAgregarUsuario.UseVisualStyleBackColor = true;
            // 
            // materialListView1
            // 
            materialListView1.AutoSizeTable = false;
            materialListView1.BackColor = Color.FromArgb(255, 255, 255);
            materialListView1.BorderStyle = BorderStyle.None;
            materialListView1.Columns.AddRange(new ColumnHeader[] { UsuarioDNI, UsuarioNombre, UsuarioApellido, UsuarioEmail, UsuarioRol, UsuarioEstado });
            materialListView1.Depth = 0;
            materialListView1.FullRowSelect = true;
            materialListView1.Location = new Point(3, 66);
            materialListView1.MinimumSize = new Size(200, 100);
            materialListView1.MouseLocation = new Point(-1, -1);
            materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            materialListView1.Name = "materialListView1";
            materialListView1.OwnerDraw = true;
            materialListView1.Size = new Size(738, 243);
            materialListView1.TabIndex = 2;
            materialListView1.UseCompatibleStateImageBehavior = false;
            materialListView1.View = View.Details;
            // 
            // UsuarioDNI
            // 
            UsuarioDNI.Tag = "";
            UsuarioDNI.Text = "DNI";
            // 
            // UsuarioNombre
            // 
            UsuarioNombre.Text = "Nombre";
            UsuarioNombre.Width = 90;
            // 
            // UsuarioApellido
            // 
            UsuarioApellido.Text = "Apellido";
            UsuarioApellido.Width = 90;
            // 
            // UsuarioEmail
            // 
            UsuarioEmail.Text = "Email";
            UsuarioEmail.Width = 90;
            // 
            // UsuarioRol
            // 
            UsuarioRol.Text = "Rol";
            UsuarioRol.Width = 80;
            // 
            // UsuarioEstado
            // 
            UsuarioEstado.Text = "Estado";
            UsuarioEstado.Width = 80;
            // 
            // ComboBoxListarRol
            // 
            ComboBoxListarRol.AutoResize = false;
            ComboBoxListarRol.BackColor = Color.FromArgb(255, 255, 255);
            ComboBoxListarRol.Depth = 0;
            ComboBoxListarRol.DrawMode = DrawMode.OwnerDrawVariable;
            ComboBoxListarRol.DropDownHeight = 174;
            ComboBoxListarRol.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxListarRol.DropDownWidth = 121;
            ComboBoxListarRol.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            ComboBoxListarRol.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ComboBoxListarRol.FormattingEnabled = true;
            ComboBoxListarRol.Hint = "Rol";
            ComboBoxListarRol.IntegralHeight = false;
            ComboBoxListarRol.ItemHeight = 43;
            ComboBoxListarRol.Location = new Point(531, 12);
            ComboBoxListarRol.MaxDropDownItems = 4;
            ComboBoxListarRol.MouseState = MaterialSkin.MouseState.OUT;
            ComboBoxListarRol.Name = "ComboBoxListarRol";
            ComboBoxListarRol.Size = new Size(210, 49);
            ComboBoxListarRol.StartIndex = 0;
            ComboBoxListarRol.TabIndex = 1;
            // 
            // TxtBuscarUsuaio
            // 
            TxtBuscarUsuaio.AnimateReadOnly = false;
            TxtBuscarUsuaio.BackgroundImageLayout = ImageLayout.None;
            TxtBuscarUsuaio.CharacterCasing = CharacterCasing.Normal;
            TxtBuscarUsuaio.Depth = 0;
            TxtBuscarUsuaio.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtBuscarUsuaio.HideSelection = true;
            TxtBuscarUsuaio.LeadingIcon = null;
            TxtBuscarUsuaio.Location = new Point(3, 12);
            TxtBuscarUsuaio.MaxLength = 32767;
            TxtBuscarUsuaio.MouseState = MaterialSkin.MouseState.OUT;
            TxtBuscarUsuaio.Name = "TxtBuscarUsuaio";
            TxtBuscarUsuaio.PasswordChar = '\0';
            TxtBuscarUsuaio.PrefixSuffixText = null;
            TxtBuscarUsuaio.ReadOnly = false;
            TxtBuscarUsuaio.RightToLeft = RightToLeft.No;
            TxtBuscarUsuaio.SelectedText = "";
            TxtBuscarUsuaio.SelectionLength = 0;
            TxtBuscarUsuaio.SelectionStart = 0;
            TxtBuscarUsuaio.ShortcutsEnabled = true;
            TxtBuscarUsuaio.Size = new Size(503, 48);
            TxtBuscarUsuaio.TabIndex = 0;
            TxtBuscarUsuaio.TabStop = false;
            TxtBuscarUsuaio.Text = "Buscar por DNI o Nombre";
            TxtBuscarUsuaio.TextAlign = HorizontalAlignment.Left;
            TxtBuscarUsuaio.TrailingIcon = null;
            TxtBuscarUsuaio.UseSystemPasswordChar = false;
            // 
            // FormListadoUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 512);
            Controls.Add(panelListaUsuarios);
            Name = "FormListadoUsuarios";
            Text = "Lista de usuarios";
            panelListaUsuarios.ResumeLayout(false);
            panelListaUsuarios.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelListaUsuarios;
        private MaterialTextBox2 TxtBuscarUsuaio;
        private MaterialComboBox ComboBoxListarRol;
        private MaterialListView materialListView1;
        private ColumnHeader UsuarioDNI;
        private ColumnHeader UsuarioNombre;
        private ColumnHeader UsuarioApellido;
        private ColumnHeader UsuarioEmail;
        private ColumnHeader UsuarioRol;
        private ColumnHeader UsuarioEstado;
        private MaterialButton BtnAgregarUsuario;
        private MaterialButton BtnEditarUsuario;
        private MaterialButton BtnEliminarUsuario;
    }
}