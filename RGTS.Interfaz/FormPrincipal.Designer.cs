namespace RGTS.Interfaz
{
    partial class FormPrincipal
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
            PanelContenedorVistas = new MaterialSkin.Controls.MaterialCard();
            PanelPerfilInfo = new MaterialSkin.Controls.MaterialCard();
            LabelRolUsuario = new MaterialSkin.Controls.MaterialLabel();
            LabelNombreUsuario = new MaterialSkin.Controls.MaterialLabel();
            BotonCerrarSesion = new MaterialSkin.Controls.MaterialButton();
            PanelBotones = new FlowLayoutPanel();
            BotonModuloUsuarios = new MaterialSkin.Controls.MaterialButton();
            BotonModuloProductos = new MaterialSkin.Controls.MaterialButton();
            BotonModuloProveedores = new MaterialSkin.Controls.MaterialButton();
            BotonModuloClientes = new MaterialSkin.Controls.MaterialButton();
            BotonModuloVentas = new MaterialSkin.Controls.MaterialButton();
            BotonModuloCompras = new MaterialSkin.Controls.MaterialButton();
            PanelContenedorMenu = new MaterialSkin.Controls.MaterialCard();
            PanelPerfilInfo.SuspendLayout();
            PanelBotones.SuspendLayout();
            PanelContenedorMenu.SuspendLayout();
            SuspendLayout();
            // 
            // PanelContenedorVistas
            // 
            PanelContenedorVistas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelContenedorVistas.AutoScroll = true;
            PanelContenedorVistas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelContenedorVistas.BackColor = Color.FromArgb(255, 255, 255);
            PanelContenedorVistas.Depth = 0;
            PanelContenedorVistas.ForeColor = Color.FromArgb(222, 0, 0, 0);
            PanelContenedorVistas.Location = new Point(218, 69);
            PanelContenedorVistas.Margin = new Padding(15);
            PanelContenedorVistas.MouseState = MaterialSkin.MouseState.HOVER;
            PanelContenedorVistas.Name = "PanelContenedorVistas";
            PanelContenedorVistas.Padding = new Padding(15);
            PanelContenedorVistas.Size = new Size(610, 468);
            PanelContenedorVistas.TabIndex = 2;
            // 
            // PanelPerfilInfo
            // 
            PanelPerfilInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            PanelPerfilInfo.BackColor = Color.FromArgb(255, 255, 255);
            PanelPerfilInfo.Controls.Add(LabelRolUsuario);
            PanelPerfilInfo.Controls.Add(LabelNombreUsuario);
            PanelPerfilInfo.Controls.Add(BotonCerrarSesion);
            PanelPerfilInfo.Depth = 0;
            PanelPerfilInfo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            PanelPerfilInfo.Location = new Point(10, 351);
            PanelPerfilInfo.Margin = new Padding(14);
            PanelPerfilInfo.MouseState = MaterialSkin.MouseState.HOVER;
            PanelPerfilInfo.Name = "PanelPerfilInfo";
            PanelPerfilInfo.Padding = new Padding(10);
            PanelPerfilInfo.Size = new Size(188, 100);
            PanelPerfilInfo.TabIndex = 3;
            // 
            // LabelRolUsuario
            // 
            LabelRolUsuario.AutoSize = true;
            LabelRolUsuario.Depth = 0;
            LabelRolUsuario.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelRolUsuario.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            LabelRolUsuario.Location = new Point(13, 34);
            LabelRolUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            LabelRolUsuario.Name = "LabelRolUsuario";
            LabelRolUsuario.Size = new Size(79, 14);
            LabelRolUsuario.TabIndex = 3;
            LabelRolUsuario.Text = "nombre del rol";
            // 
            // LabelNombreUsuario
            // 
            LabelNombreUsuario.AutoSize = true;
            LabelNombreUsuario.Depth = 0;
            LabelNombreUsuario.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelNombreUsuario.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            LabelNombreUsuario.Location = new Point(13, 10);
            LabelNombreUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            LabelNombreUsuario.Name = "LabelNombreUsuario";
            LabelNombreUsuario.Size = new Size(117, 17);
            LabelNombreUsuario.TabIndex = 2;
            LabelNombreUsuario.Text = "nombre de usuario";
            // 
            // BotonCerrarSesion
            // 
            BotonCerrarSesion.AutoSize = false;
            BotonCerrarSesion.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BotonCerrarSesion.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            BotonCerrarSesion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BotonCerrarSesion.Depth = 0;
            BotonCerrarSesion.Dock = DockStyle.Bottom;
            BotonCerrarSesion.HighEmphasis = false;
            BotonCerrarSesion.Icon = null;
            BotonCerrarSesion.Location = new Point(10, 54);
            BotonCerrarSesion.Margin = new Padding(4, 6, 4, 6);
            BotonCerrarSesion.MouseState = MaterialSkin.MouseState.HOVER;
            BotonCerrarSesion.Name = "BotonCerrarSesion";
            BotonCerrarSesion.NoAccentTextColor = Color.Empty;
            BotonCerrarSesion.Size = new Size(168, 36);
            BotonCerrarSesion.TabIndex = 6;
            BotonCerrarSesion.TabStop = false;
            BotonCerrarSesion.Text = "Cerrar Sesión";
            BotonCerrarSesion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BotonCerrarSesion.UseAccentColor = false;
            BotonCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // PanelBotones
            // 
            PanelBotones.AutoScroll = true;
            PanelBotones.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelBotones.Controls.Add(BotonModuloUsuarios);
            PanelBotones.Controls.Add(BotonModuloProductos);
            PanelBotones.Controls.Add(BotonModuloProveedores);
            PanelBotones.Controls.Add(BotonModuloClientes);
            PanelBotones.Controls.Add(BotonModuloVentas);
            PanelBotones.Controls.Add(BotonModuloCompras);
            PanelBotones.Dock = DockStyle.Top;
            PanelBotones.FlowDirection = FlowDirection.TopDown;
            PanelBotones.Location = new Point(10, 10);
            PanelBotones.Margin = new Padding(0);
            PanelBotones.Name = "PanelBotones";
            PanelBotones.Size = new Size(188, 319);
            PanelBotones.TabIndex = 1;
            // 
            // BotonModuloUsuarios
            // 
            BotonModuloUsuarios.AutoSize = false;
            BotonModuloUsuarios.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BotonModuloUsuarios.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            BotonModuloUsuarios.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BotonModuloUsuarios.Depth = 0;
            BotonModuloUsuarios.Dock = DockStyle.Fill;
            BotonModuloUsuarios.DrawShadows = false;
            BotonModuloUsuarios.HighEmphasis = true;
            BotonModuloUsuarios.Icon = null;
            BotonModuloUsuarios.Location = new Point(4, 6);
            BotonModuloUsuarios.Margin = new Padding(4, 6, 4, 6);
            BotonModuloUsuarios.MouseState = MaterialSkin.MouseState.HOVER;
            BotonModuloUsuarios.Name = "BotonModuloUsuarios";
            BotonModuloUsuarios.NoAccentTextColor = Color.Empty;
            BotonModuloUsuarios.Size = new Size(180, 36);
            BotonModuloUsuarios.TabIndex = 1;
            BotonModuloUsuarios.Text = "Usuarios";
            BotonModuloUsuarios.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BotonModuloUsuarios.UseAccentColor = false;
            BotonModuloUsuarios.UseVisualStyleBackColor = true;
            BotonModuloUsuarios.Click += BotonModuloUsuarios_Click;
            // 
            // BotonModuloProductos
            // 
            BotonModuloProductos.AutoSize = false;
            BotonModuloProductos.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BotonModuloProductos.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            BotonModuloProductos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BotonModuloProductos.Depth = 0;
            BotonModuloProductos.Dock = DockStyle.Fill;
            BotonModuloProductos.DrawShadows = false;
            BotonModuloProductos.HighEmphasis = true;
            BotonModuloProductos.Icon = null;
            BotonModuloProductos.Location = new Point(4, 54);
            BotonModuloProductos.Margin = new Padding(4, 6, 4, 6);
            BotonModuloProductos.MouseState = MaterialSkin.MouseState.HOVER;
            BotonModuloProductos.Name = "BotonModuloProductos";
            BotonModuloProductos.NoAccentTextColor = Color.Empty;
            BotonModuloProductos.Size = new Size(180, 36);
            BotonModuloProductos.TabIndex = 2;
            BotonModuloProductos.Text = "Productos";
            BotonModuloProductos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BotonModuloProductos.UseAccentColor = false;
            BotonModuloProductos.UseVisualStyleBackColor = true;
            BotonModuloProductos.Click += BotonModuloProductos_Click;
            // 
            // BotonModuloProveedores
            // 
            BotonModuloProveedores.AutoSize = false;
            BotonModuloProveedores.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BotonModuloProveedores.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            BotonModuloProveedores.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BotonModuloProveedores.Depth = 0;
            BotonModuloProveedores.Dock = DockStyle.Fill;
            BotonModuloProveedores.DrawShadows = false;
            BotonModuloProveedores.HighEmphasis = true;
            BotonModuloProveedores.Icon = null;
            BotonModuloProveedores.Location = new Point(4, 102);
            BotonModuloProveedores.Margin = new Padding(4, 6, 4, 6);
            BotonModuloProveedores.MouseState = MaterialSkin.MouseState.HOVER;
            BotonModuloProveedores.Name = "BotonModuloProveedores";
            BotonModuloProveedores.NoAccentTextColor = Color.Empty;
            BotonModuloProveedores.Size = new Size(180, 36);
            BotonModuloProveedores.TabIndex = 6;
            BotonModuloProveedores.Text = "Proveedores";
            BotonModuloProveedores.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BotonModuloProveedores.UseAccentColor = false;
            BotonModuloProveedores.UseVisualStyleBackColor = true;
            BotonModuloProveedores.Click += BotonModuloProveedores_Click;
            // 
            // BotonModuloClientes
            // 
            BotonModuloClientes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BotonModuloClientes.AutoSize = false;
            BotonModuloClientes.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BotonModuloClientes.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            BotonModuloClientes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BotonModuloClientes.Depth = 0;
            BotonModuloClientes.DrawShadows = false;
            BotonModuloClientes.HighEmphasis = true;
            BotonModuloClientes.Icon = null;
            BotonModuloClientes.Location = new Point(4, 150);
            BotonModuloClientes.Margin = new Padding(4, 6, 4, 6);
            BotonModuloClientes.MouseState = MaterialSkin.MouseState.HOVER;
            BotonModuloClientes.Name = "BotonModuloClientes";
            BotonModuloClientes.NoAccentTextColor = Color.Empty;
            BotonModuloClientes.Size = new Size(180, 36);
            BotonModuloClientes.TabIndex = 3;
            BotonModuloClientes.Text = "Clientes";
            BotonModuloClientes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BotonModuloClientes.UseAccentColor = false;
            BotonModuloClientes.UseVisualStyleBackColor = true;
            BotonModuloClientes.Click += BotonModuloClientes_Click;
            // 
            // BotonModuloVentas
            // 
            BotonModuloVentas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BotonModuloVentas.AutoSize = false;
            BotonModuloVentas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BotonModuloVentas.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            BotonModuloVentas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BotonModuloVentas.Depth = 0;
            BotonModuloVentas.DrawShadows = false;
            BotonModuloVentas.HighEmphasis = true;
            BotonModuloVentas.Icon = null;
            BotonModuloVentas.Location = new Point(4, 198);
            BotonModuloVentas.Margin = new Padding(4, 6, 4, 6);
            BotonModuloVentas.MouseState = MaterialSkin.MouseState.HOVER;
            BotonModuloVentas.Name = "BotonModuloVentas";
            BotonModuloVentas.NoAccentTextColor = Color.Empty;
            BotonModuloVentas.Size = new Size(180, 36);
            BotonModuloVentas.TabIndex = 4;
            BotonModuloVentas.Text = "Ventas";
            BotonModuloVentas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BotonModuloVentas.UseAccentColor = false;
            BotonModuloVentas.UseVisualStyleBackColor = true;
            // 
            // BotonModuloCompras
            // 
            BotonModuloCompras.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BotonModuloCompras.AutoSize = false;
            BotonModuloCompras.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BotonModuloCompras.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            BotonModuloCompras.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BotonModuloCompras.Depth = 0;
            BotonModuloCompras.DrawShadows = false;
            BotonModuloCompras.HighEmphasis = true;
            BotonModuloCompras.Icon = null;
            BotonModuloCompras.Location = new Point(4, 246);
            BotonModuloCompras.Margin = new Padding(4, 6, 4, 6);
            BotonModuloCompras.MouseState = MaterialSkin.MouseState.HOVER;
            BotonModuloCompras.Name = "BotonModuloCompras";
            BotonModuloCompras.NoAccentTextColor = Color.Empty;
            BotonModuloCompras.Size = new Size(180, 36);
            BotonModuloCompras.TabIndex = 5;
            BotonModuloCompras.Text = "Compras";
            BotonModuloCompras.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BotonModuloCompras.UseAccentColor = false;
            BotonModuloCompras.UseVisualStyleBackColor = true;
            BotonModuloCompras.Click += BotonModuloCompras_Click;
            // 
            // PanelContenedorMenu
            // 
            PanelContenedorMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            PanelContenedorMenu.BackColor = Color.FromArgb(255, 255, 255);
            PanelContenedorMenu.Controls.Add(PanelBotones);
            PanelContenedorMenu.Controls.Add(PanelPerfilInfo);
            PanelContenedorMenu.Depth = 0;
            PanelContenedorMenu.ForeColor = Color.FromArgb(222, 0, 0, 0);
            PanelContenedorMenu.Location = new Point(5, 70);
            PanelContenedorMenu.Margin = new Padding(10);
            PanelContenedorMenu.MouseState = MaterialSkin.MouseState.HOVER;
            PanelContenedorMenu.Name = "PanelContenedorMenu";
            PanelContenedorMenu.Padding = new Padding(10);
            PanelContenedorMenu.Size = new Size(208, 466);
            PanelContenedorMenu.TabIndex = 0;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(833, 542);
            Controls.Add(PanelContenedorVistas);
            Controls.Add(PanelContenedorMenu);
            Name = "FormPrincipal";
            Padding = new Padding(5, 69, 5, 5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RGTS - Manager";
            WindowState = FormWindowState.Maximized;
            FormClosed += FormPrincipal_FormClosed;
            PanelPerfilInfo.ResumeLayout(false);
            PanelPerfilInfo.PerformLayout();
            PanelBotones.ResumeLayout(false);
            PanelContenedorMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialCard PanelContenedorVistas;
        private MaterialSkin.Controls.MaterialCard PanelPerfilInfo;
        private FlowLayoutPanel PanelBotones;
        private MaterialSkin.Controls.MaterialCard PanelContenedorMenu;
        private MaterialSkin.Controls.MaterialButton BotonModuloVentas;
        private MaterialSkin.Controls.MaterialButton BotonModuloUsuarios;
        private MaterialSkin.Controls.MaterialButton BotonModuloProductos;
        private MaterialSkin.Controls.MaterialLabel LabelNombreUsuario;
        private MaterialSkin.Controls.MaterialButton BotonCerrarSesion;
        private MaterialSkin.Controls.MaterialButton BotonModuloClientes;
        private MaterialSkin.Controls.MaterialButton BotonModuloCompras;
        private MaterialSkin.Controls.MaterialLabel LabelRolUsuario;
        private MaterialSkin.Controls.MaterialButton BotonModuloProveedores;
    }
}