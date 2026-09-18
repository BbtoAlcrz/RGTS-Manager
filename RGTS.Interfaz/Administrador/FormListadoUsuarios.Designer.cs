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
            ComboBoxListarEstado = new MaterialComboBox();
            BtnCambiarEstadoUsuario = new MaterialButton();
            BtnEditarUsuario = new MaterialButton();
            BtnAgregarUsuario = new MaterialButton();
            ListaUsuarios = new MaterialListView();
            UsuarioDNI = new ColumnHeader();
            UsuarioNombre = new ColumnHeader();
            UsuarioApellido = new ColumnHeader();
            UsuarioEmail = new ColumnHeader();
            UsuarioRol = new ColumnHeader();
            UsuarioEstado = new ColumnHeader();
            ComboBoxListarRol = new MaterialComboBox();
            TxtBuscarUsuario = new MaterialTextBox2();
            panelListaUsuarios.SuspendLayout();
            SuspendLayout();
            // 
            // panelListaUsuarios
            // 
            panelListaUsuarios.BackColor = SystemColors.WindowFrame;
            panelListaUsuarios.Controls.Add(ComboBoxListarEstado);
            panelListaUsuarios.Controls.Add(BtnCambiarEstadoUsuario);
            panelListaUsuarios.Controls.Add(BtnEditarUsuario);
            panelListaUsuarios.Controls.Add(BtnAgregarUsuario);
            panelListaUsuarios.Controls.Add(ListaUsuarios);
            panelListaUsuarios.Controls.Add(ComboBoxListarRol);
            panelListaUsuarios.Controls.Add(TxtBuscarUsuario);
            panelListaUsuarios.Location = new Point(27, 71);
            panelListaUsuarios.Name = "panelListaUsuarios";
            panelListaUsuarios.Size = new Size(744, 404);
            panelListaUsuarios.TabIndex = 0;
            panelListaUsuarios.Tag = "";
            // 
            // ComboBoxListarEstado
            // 
            ComboBoxListarEstado.AutoResize = false;
            ComboBoxListarEstado.BackColor = SystemColors.Window;
            ComboBoxListarEstado.Depth = 0;
            ComboBoxListarEstado.DrawMode = DrawMode.OwnerDrawVariable;
            ComboBoxListarEstado.DropDownHeight = 174;
            ComboBoxListarEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxListarEstado.DropDownWidth = 121;
            ComboBoxListarEstado.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            ComboBoxListarEstado.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ComboBoxListarEstado.FormattingEnabled = true;
            ComboBoxListarEstado.Hint = "Estado";
            ComboBoxListarEstado.IntegralHeight = false;
            ComboBoxListarEstado.ItemHeight = 43;
            ComboBoxListarEstado.Location = new Point(573, 11);
            ComboBoxListarEstado.MaxDropDownItems = 4;
            ComboBoxListarEstado.MouseState = MaterialSkin.MouseState.OUT;
            ComboBoxListarEstado.Name = "ComboBoxListarEstado";
            ComboBoxListarEstado.Size = new Size(166, 49);
            ComboBoxListarEstado.StartIndex = 0;
            ComboBoxListarEstado.TabIndex = 4;
            ComboBoxListarEstado.SelectedIndexChanged += ComboBoxListarEstado_SelectedIndexChanged;
            // 
            // BtnCambiarEstadoUsuario
            // 
            BtnCambiarEstadoUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCambiarEstadoUsuario.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnCambiarEstadoUsuario.BackColor = SystemColors.Window;
            BtnCambiarEstadoUsuario.Density = MaterialButton.MaterialButtonDensity.Default;
            BtnCambiarEstadoUsuario.Depth = 0;
            BtnCambiarEstadoUsuario.HighEmphasis = true;
            BtnCambiarEstadoUsuario.Icon = null;
            BtnCambiarEstadoUsuario.Location = new Point(618, 318);
            BtnCambiarEstadoUsuario.Margin = new Padding(4, 6, 4, 6);
            BtnCambiarEstadoUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            BtnCambiarEstadoUsuario.Name = "BtnCambiarEstadoUsuario";
            BtnCambiarEstadoUsuario.NoAccentTextColor = Color.Empty;
            BtnCambiarEstadoUsuario.Size = new Size(122, 36);
            BtnCambiarEstadoUsuario.TabIndex = 6;
            BtnCambiarEstadoUsuario.Text = "Deshabilitar";
            BtnCambiarEstadoUsuario.Type = MaterialButton.MaterialButtonType.Outlined;
            BtnCambiarEstadoUsuario.UseAccentColor = true;
            BtnCambiarEstadoUsuario.UseVisualStyleBackColor = false;
            BtnCambiarEstadoUsuario.Click += BtnCambiarEstadoUsuario_Click;
            // 
            // BtnEditarUsuario
            // 
            BtnEditarUsuario.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnEditarUsuario.BackColor = SystemColors.Window;
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
            BtnEditarUsuario.TabIndex = 5;
            BtnEditarUsuario.Text = "Editar";
            BtnEditarUsuario.Type = MaterialButton.MaterialButtonType.Outlined;
            BtnEditarUsuario.UseAccentColor = false;
            BtnEditarUsuario.UseVisualStyleBackColor = false;
            BtnEditarUsuario.Click += BtnEditarUsuario_Click;
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
            BtnAgregarUsuario.TabIndex = 1;
            BtnAgregarUsuario.Text = "Agregar Usuario";
            BtnAgregarUsuario.Type = MaterialButton.MaterialButtonType.Contained;
            BtnAgregarUsuario.UseAccentColor = false;
            BtnAgregarUsuario.UseVisualStyleBackColor = true;
            BtnAgregarUsuario.Click += BtnAgregarUsuario_Click;
            // 
            // ListaUsuarios
            // 
            ListaUsuarios.AutoSizeTable = false;
            ListaUsuarios.BackColor = Color.FromArgb(255, 255, 255);
            ListaUsuarios.BorderStyle = BorderStyle.None;
            ListaUsuarios.Columns.AddRange(new ColumnHeader[] { UsuarioDNI, UsuarioNombre, UsuarioApellido, UsuarioEmail, UsuarioRol, UsuarioEstado });
            ListaUsuarios.Depth = 0;
            ListaUsuarios.FullRowSelect = true;
            ListaUsuarios.Location = new Point(3, 66);
            ListaUsuarios.MinimumSize = new Size(200, 100);
            ListaUsuarios.MouseLocation = new Point(-1, -1);
            ListaUsuarios.MouseState = MaterialSkin.MouseState.OUT;
            ListaUsuarios.Name = "ListaUsuarios";
            ListaUsuarios.OwnerDraw = true;
            ListaUsuarios.Size = new Size(738, 243);
            ListaUsuarios.TabIndex = 2;
            ListaUsuarios.UseCompatibleStateImageBehavior = false;
            ListaUsuarios.View = View.Details;
            ListaUsuarios.SelectedIndexChanged += ListaUsuarios_SelectedIndexChanged;
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
            ComboBoxListarRol.BackColor = SystemColors.Window;
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
            ComboBoxListarRol.Location = new Point(405, 11);
            ComboBoxListarRol.MaxDropDownItems = 4;
            ComboBoxListarRol.MouseState = MaterialSkin.MouseState.OUT;
            ComboBoxListarRol.Name = "ComboBoxListarRol";
            ComboBoxListarRol.Size = new Size(162, 49);
            ComboBoxListarRol.StartIndex = 0;
            ComboBoxListarRol.TabIndex = 3;
            ComboBoxListarRol.SelectedIndexChanged += ComboBoxListarRol_SelectedIndexChanged;
            // 
            // TxtBuscarUsuario
            // 
            TxtBuscarUsuario.AnimateReadOnly = false;
            TxtBuscarUsuario.BackgroundImageLayout = ImageLayout.None;
            TxtBuscarUsuario.CharacterCasing = CharacterCasing.Normal;
            TxtBuscarUsuario.Depth = 0;
            TxtBuscarUsuario.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtBuscarUsuario.HideSelection = true;
            TxtBuscarUsuario.Hint = "Buscar por DNI o Nombre";
            TxtBuscarUsuario.LeadingIcon = null;
            TxtBuscarUsuario.Location = new Point(3, 12);
            TxtBuscarUsuario.MaxLength = 32767;
            TxtBuscarUsuario.MouseState = MaterialSkin.MouseState.OUT;
            TxtBuscarUsuario.Name = "TxtBuscarUsuario";
            TxtBuscarUsuario.PasswordChar = '\0';
            TxtBuscarUsuario.PrefixSuffixText = null;
            TxtBuscarUsuario.ReadOnly = false;
            TxtBuscarUsuario.RightToLeft = RightToLeft.No;
            TxtBuscarUsuario.SelectedText = "";
            TxtBuscarUsuario.SelectionLength = 0;
            TxtBuscarUsuario.SelectionStart = 0;
            TxtBuscarUsuario.ShortcutsEnabled = true;
            TxtBuscarUsuario.Size = new Size(396, 48);
            TxtBuscarUsuario.TabIndex = 0;
            TxtBuscarUsuario.TabStop = false;
            TxtBuscarUsuario.TextAlign = HorizontalAlignment.Left;
            TxtBuscarUsuario.TrailingIcon = null;
            TxtBuscarUsuario.UseSystemPasswordChar = false;
            TxtBuscarUsuario.TextChanged += TxtBuscarUsuario_TextChanged;
            // 
            // FormListadoUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 512);
            Controls.Add(panelListaUsuarios);
            Name = "FormListadoUsuarios";
            Text = "Lista de usuarios";
            Load += FormListadoUsuarios_Load;
            panelListaUsuarios.ResumeLayout(false);
            panelListaUsuarios.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelListaUsuarios;
        private MaterialTextBox2 TxtBuscarUsuario;
        private MaterialComboBox ComboBoxListarRol;
        private MaterialListView ListaUsuarios;
        private ColumnHeader UsuarioDNI;
        private ColumnHeader UsuarioNombre;
        private ColumnHeader UsuarioApellido;
        private ColumnHeader UsuarioEmail;
        private ColumnHeader UsuarioRol;
        private ColumnHeader UsuarioEstado;
        private MaterialButton BtnAgregarUsuario;
        private MaterialButton BtnEditarUsuario;
        private MaterialButton BtnCambiarEstadoUsuario;
        private MaterialComboBox ComboBoxListarEstado;
    }
}