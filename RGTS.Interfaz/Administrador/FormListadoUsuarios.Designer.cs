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
            panelListaUsuarios = new MaterialCard();
            labelTitulo = new MaterialLabel();
            materialCard1 = new MaterialCard();
            ListaUsuarios = new MaterialListView();
            UsuarioDNI = new ColumnHeader();
            UsuarioNombre = new ColumnHeader();
            UsuarioApellido = new ColumnHeader();
            UsuarioEmail = new ColumnHeader();
            UsuarioRol = new ColumnHeader();
            UsuarioEstado = new ColumnHeader();
            ComboBoxListarEstado = new MaterialComboBox();
            BtnCambiarEstadoUsuario = new MaterialButton();
            BtnEditarUsuario = new MaterialButton();
            BtnAgregarUsuario = new MaterialButton();
            ComboBoxListarRol = new MaterialComboBox();
            TxtBuscarUsuario = new MaterialTextBox2();
            pnlEdicionContenedor = new MaterialCard();
            panelListaUsuarios.SuspendLayout();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // panelListaUsuarios
            // 
            panelListaUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelListaUsuarios.BackColor = Color.FromArgb(255, 255, 255);
            panelListaUsuarios.Controls.Add(labelTitulo);
            panelListaUsuarios.Controls.Add(materialCard1);
            panelListaUsuarios.Controls.Add(ComboBoxListarEstado);
            panelListaUsuarios.Controls.Add(BtnCambiarEstadoUsuario);
            panelListaUsuarios.Controls.Add(BtnEditarUsuario);
            panelListaUsuarios.Controls.Add(BtnAgregarUsuario);
            panelListaUsuarios.Controls.Add(ComboBoxListarRol);
            panelListaUsuarios.Controls.Add(TxtBuscarUsuario);
            panelListaUsuarios.Depth = 0;
            panelListaUsuarios.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panelListaUsuarios.Location = new Point(5, 7);
            panelListaUsuarios.Margin = new Padding(20);
            panelListaUsuarios.MouseState = MaterialSkin.MouseState.HOVER;
            panelListaUsuarios.Name = "panelListaUsuarios";
            panelListaUsuarios.Padding = new Padding(15);
            panelListaUsuarios.Size = new Size(871, 550);
            panelListaUsuarios.TabIndex = 0;
            panelListaUsuarios.Tag = "";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Depth = 0;
            labelTitulo.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            labelTitulo.Location = new Point(13, 15);
            labelTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(214, 29);
            labelTitulo.TabIndex = 8;
            labelTitulo.Text = "Listado de Usuarios";
            // 
            // materialCard1
            // 
            materialCard1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            materialCard1.AutoSize = true;
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(ListaUsuarios);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(20, 126);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(833, 282);
            materialCard1.TabIndex = 7;
            // 
            // ListaUsuarios
            // 
            ListaUsuarios.Alignment = ListViewAlignment.Left;
            ListaUsuarios.AutoSizeTable = false;
            ListaUsuarios.BackColor = Color.FromArgb(255, 255, 255);
            ListaUsuarios.BorderStyle = BorderStyle.None;
            ListaUsuarios.Columns.AddRange(new ColumnHeader[] { UsuarioDNI, UsuarioNombre, UsuarioApellido, UsuarioEmail, UsuarioRol, UsuarioEstado });
            ListaUsuarios.Depth = 0;
            ListaUsuarios.Dock = DockStyle.Fill;
            ListaUsuarios.FullRowSelect = true;
            ListaUsuarios.Location = new Point(14, 14);
            ListaUsuarios.MinimumSize = new Size(200, 100);
            ListaUsuarios.MouseLocation = new Point(-1, -1);
            ListaUsuarios.MouseState = MaterialSkin.MouseState.OUT;
            ListaUsuarios.Name = "ListaUsuarios";
            ListaUsuarios.OwnerDraw = true;
            ListaUsuarios.Size = new Size(805, 254);
            ListaUsuarios.TabIndex = 2;
            ListaUsuarios.UseCompatibleStateImageBehavior = false;
            ListaUsuarios.View = View.Details;
            ListaUsuarios.SelectedIndexChanged += ListaUsuarios_SelectedIndexChanged;
            // 
            // UsuarioDNI
            // 
            UsuarioDNI.Tag = "";
            UsuarioDNI.Text = "DNI";
            UsuarioDNI.Width = 90;
            // 
            // UsuarioNombre
            // 
            UsuarioNombre.Text = "Nombre";
            UsuarioNombre.Width = 100;
            // 
            // UsuarioApellido
            // 
            UsuarioApellido.Text = "Apellido";
            UsuarioApellido.Width = 120;
            // 
            // UsuarioEmail
            // 
            UsuarioEmail.Text = "Email";
            UsuarioEmail.Width = 180;
            // 
            // UsuarioRol
            // 
            UsuarioRol.Text = "Rol";
            UsuarioRol.Width = 130;
            // 
            // UsuarioEstado
            // 
            UsuarioEstado.Text = "Estado";
            UsuarioEstado.Width = 120;
            // 
            // ComboBoxListarEstado
            // 
            ComboBoxListarEstado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            ComboBoxListarEstado.Location = new Point(626, 61);
            ComboBoxListarEstado.MaxDropDownItems = 4;
            ComboBoxListarEstado.MouseState = MaterialSkin.MouseState.OUT;
            ComboBoxListarEstado.Name = "ComboBoxListarEstado";
            ComboBoxListarEstado.Size = new Size(227, 49);
            ComboBoxListarEstado.StartIndex = 0;
            ComboBoxListarEstado.TabIndex = 4;
            ComboBoxListarEstado.SelectedIndexChanged += ComboBoxListarEstado_SelectedIndexChanged;
            // 
            // BtnCambiarEstadoUsuario
            // 
            BtnCambiarEstadoUsuario.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnCambiarEstadoUsuario.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnCambiarEstadoUsuario.BackColor = SystemColors.Window;
            BtnCambiarEstadoUsuario.Density = MaterialButton.MaterialButtonDensity.Default;
            BtnCambiarEstadoUsuario.Depth = 0;
            BtnCambiarEstadoUsuario.HighEmphasis = true;
            BtnCambiarEstadoUsuario.Icon = null;
            BtnCambiarEstadoUsuario.Location = new Point(731, 500);
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
            BtnEditarUsuario.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnEditarUsuario.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnEditarUsuario.BackColor = SystemColors.Window;
            BtnEditarUsuario.Density = MaterialButton.MaterialButtonDensity.Default;
            BtnEditarUsuario.Depth = 0;
            BtnEditarUsuario.HighEmphasis = true;
            BtnEditarUsuario.Icon = null;
            BtnEditarUsuario.Location = new Point(180, 500);
            BtnEditarUsuario.Margin = new Padding(4, 6, 4, 6);
            BtnEditarUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            BtnEditarUsuario.Name = "BtnEditarUsuario";
            BtnEditarUsuario.NoAccentTextColor = Color.Empty;
            BtnEditarUsuario.Size = new Size(136, 36);
            BtnEditarUsuario.TabIndex = 5;
            BtnEditarUsuario.Text = "Editar Usuario";
            BtnEditarUsuario.Type = MaterialButton.MaterialButtonType.Outlined;
            BtnEditarUsuario.UseAccentColor = false;
            BtnEditarUsuario.UseVisualStyleBackColor = false;
            BtnEditarUsuario.Click += BtnEditarUsuario_Click;
            // 
            // BtnAgregarUsuario
            // 
            BtnAgregarUsuario.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnAgregarUsuario.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnAgregarUsuario.Density = MaterialButton.MaterialButtonDensity.Default;
            BtnAgregarUsuario.Depth = 0;
            BtnAgregarUsuario.HighEmphasis = true;
            BtnAgregarUsuario.Icon = null;
            BtnAgregarUsuario.Location = new Point(20, 500);
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
            // ComboBoxListarRol
            // 
            ComboBoxListarRol.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            ComboBoxListarRol.Location = new Point(412, 61);
            ComboBoxListarRol.MaxDropDownItems = 4;
            ComboBoxListarRol.MouseState = MaterialSkin.MouseState.OUT;
            ComboBoxListarRol.Name = "ComboBoxListarRol";
            ComboBoxListarRol.Size = new Size(208, 49);
            ComboBoxListarRol.StartIndex = 0;
            ComboBoxListarRol.TabIndex = 3;
            ComboBoxListarRol.SelectedIndexChanged += ComboBoxListarRol_SelectedIndexChanged;
            // 
            // TxtBuscarUsuario
            // 
            TxtBuscarUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtBuscarUsuario.AnimateReadOnly = false;
            TxtBuscarUsuario.BackgroundImageLayout = ImageLayout.None;
            TxtBuscarUsuario.CharacterCasing = CharacterCasing.Normal;
            TxtBuscarUsuario.Depth = 0;
            TxtBuscarUsuario.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtBuscarUsuario.HideSelection = true;
            TxtBuscarUsuario.Hint = "Buscar por DNI o Nombre";
            TxtBuscarUsuario.LeadingIcon = null;
            TxtBuscarUsuario.Location = new Point(19, 61);
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
            TxtBuscarUsuario.Size = new Size(387, 48);
            TxtBuscarUsuario.TabIndex = 0;
            TxtBuscarUsuario.TabStop = false;
            TxtBuscarUsuario.TextAlign = HorizontalAlignment.Left;
            TxtBuscarUsuario.TrailingIcon = null;
            TxtBuscarUsuario.UseSystemPasswordChar = false;
            TxtBuscarUsuario.TextChanged += TxtBuscarUsuario_TextChanged;
            // 
            // pnlEdicionContenedor
            // 
            pnlEdicionContenedor.BackColor = Color.FromArgb(255, 255, 255);
            pnlEdicionContenedor.Depth = 0;
            pnlEdicionContenedor.Dock = DockStyle.Fill;
            pnlEdicionContenedor.ForeColor = Color.FromArgb(222, 0, 0, 0);
            pnlEdicionContenedor.Location = new Point(15, 15);
            pnlEdicionContenedor.Margin = new Padding(14);
            pnlEdicionContenedor.MouseState = MaterialSkin.MouseState.HOVER;
            pnlEdicionContenedor.Name = "pnlEdicionContenedor";
            pnlEdicionContenedor.Padding = new Padding(14);
            pnlEdicionContenedor.Size = new Size(852, 534);
            pnlEdicionContenedor.TabIndex = 8;
            pnlEdicionContenedor.Visible = false;
            // 
            // FormListadoUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 564);
            Controls.Add(panelListaUsuarios);
            Controls.Add(pnlEdicionContenedor);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "FormListadoUsuarios";
            Padding = new Padding(15);
            Sizable = false;
            Text = "Lista de usuarios";
            Load += FormListadoUsuarios_Load;
            panelListaUsuarios.ResumeLayout(false);
            panelListaUsuarios.PerformLayout();
            materialCard1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard panelListaUsuarios;
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
        private MaterialCard materialCard1;
        private MaterialCard pnlEdicionContenedor;
        private MaterialLabel labelTitulo;
    }
}