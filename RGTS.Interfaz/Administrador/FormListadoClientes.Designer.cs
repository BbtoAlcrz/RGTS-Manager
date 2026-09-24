namespace RGTS.Interfaz
{
    partial class FormListadoClientes
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
            panel2 = new MaterialSkin.Controls.MaterialCard();
            BtnNuevo = new MaterialSkin.Controls.MaterialButton();
            btnEditar = new MaterialSkin.Controls.MaterialButton();
            btnCambiarEstado = new MaterialSkin.Controls.MaterialButton();
            lstClientes = new MaterialSkin.Controls.MaterialListView();
            ID = new ColumnHeader();
            DNI = new ColumnHeader();
            Apellido = new ColumnHeader();
            Nombre = new ColumnHeader();
            Teléfono = new ColumnHeader();
            Email = new ColumnHeader();
            Estado = new ColumnHeader();
            TxtBuscar = new MaterialSkin.Controls.MaterialTextBox();
            LListado = new MaterialSkin.Controls.MaterialLabel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 255, 255);
            panel2.Controls.Add(BtnNuevo);
            panel2.Controls.Add(btnEditar);
            panel2.Controls.Add(btnCambiarEstado);
            panel2.Controls.Add(lstClientes);
            panel2.Controls.Add(TxtBuscar);
            panel2.Controls.Add(LListado);
            panel2.Depth = 0;
            panel2.Dock = DockStyle.Fill;
            panel2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panel2.Location = new Point(3, 0);
            panel2.Margin = new Padding(12, 10, 12, 10);
            panel2.MouseState = MaterialSkin.MouseState.HOVER;
            panel2.Name = "panel2";
            panel2.Padding = new Padding(12, 10, 12, 10);
            panel2.Size = new Size(835, 422);
            panel2.TabIndex = 1;
            // 
            // BtnNuevo
            // 
            BtnNuevo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnNuevo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnNuevo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnNuevo.Depth = 0;
            BtnNuevo.HighEmphasis = true;
            BtnNuevo.Icon = null;
            BtnNuevo.Location = new Point(16, 372);
            BtnNuevo.Margin = new Padding(4);
            BtnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.NoAccentTextColor = Color.Empty;
            BtnNuevo.Size = new Size(131, 36);
            BtnNuevo.TabIndex = 19;
            BtnNuevo.Text = "Nuevo Cliente";
            BtnNuevo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnNuevo.UseAccentColor = false;
            BtnNuevo.UseVisualStyleBackColor = true;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditar.Depth = 0;
            btnEditar.HighEmphasis = true;
            btnEditar.Icon = null;
            btnEditar.Location = new Point(155, 372);
            btnEditar.Margin = new Padding(4);
            btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            btnEditar.Name = "btnEditar";
            btnEditar.NoAccentTextColor = Color.Empty;
            btnEditar.Size = new Size(133, 36);
            btnEditar.TabIndex = 18;
            btnEditar.Text = "Editar Cliente";
            btnEditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnEditar.UseAccentColor = false;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += BtnEditar_Click;
            // 
            // btnCambiarEstado
            // 
            btnCambiarEstado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCambiarEstado.AutoSize = false;
            btnCambiarEstado.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCambiarEstado.BackColor = Color.IndianRed;
            btnCambiarEstado.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCambiarEstado.Depth = 0;
            btnCambiarEstado.ForeColor = Color.Firebrick;
            btnCambiarEstado.HighEmphasis = true;
            btnCambiarEstado.Icon = null;
            btnCambiarEstado.Location = new Point(707, 55);
            btnCambiarEstado.Margin = new Padding(4);
            btnCambiarEstado.MouseState = MaterialSkin.MouseState.HOVER;
            btnCambiarEstado.Name = "btnCambiarEstado";
            btnCambiarEstado.NoAccentTextColor = Color.Empty;
            btnCambiarEstado.Size = new Size(112, 48);
            btnCambiarEstado.TabIndex = 14;
            btnCambiarEstado.Text = "Estado";
            btnCambiarEstado.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnCambiarEstado.UseAccentColor = false;
            btnCambiarEstado.UseVisualStyleBackColor = true;
            btnCambiarEstado.Click += btnCambiarEstado_Click;
            // 
            // lstClientes
            // 
            lstClientes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lstClientes.AutoSizeTable = false;
            lstClientes.BackColor = Color.FromArgb(255, 255, 255);
            lstClientes.BorderStyle = BorderStyle.None;
            lstClientes.Columns.AddRange(new ColumnHeader[] { ID, DNI, Nombre, Apellido, Teléfono, Email, Estado });
            lstClientes.Depth = 0;
            lstClientes.FullRowSelect = true;
            lstClientes.Location = new Point(16, 109);
            lstClientes.Margin = new Padding(3, 2, 3, 2);
            lstClientes.MinimumSize = new Size(175, 75);
            lstClientes.MouseLocation = new Point(-1, -1);
            lstClientes.MouseState = MaterialSkin.MouseState.OUT;
            lstClientes.Name = "lstClientes";
            lstClientes.OwnerDraw = true;
            lstClientes.Size = new Size(803, 156);
            lstClientes.TabIndex = 17;
            lstClientes.UseCompatibleStateImageBehavior = false;
            lstClientes.View = View.Details;
            lstClientes.SelectedIndexChanged += lstClientes_SelectedIndexChanged;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 50;
            // 
            // DNI
            // 
            DNI.Text = "DNI";
            DNI.Width = 100;
            // 
            // Apellido
            // 
            Apellido.Text = "Apellido";
            Apellido.Width = 100;
            // 
            // Nombre
            // 
            Nombre.Text = "Nombre";
            Nombre.Width = 100;
            // 
            // Teléfono
            // 
            Teléfono.Text = "Teléfono";
            Teléfono.Width = 140;
            // 
            // Email
            // 
            Email.Text = "Email";
            Email.Width = 140;
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            Estado.Width = 110;
            // 
            // TxtBuscar
            // 
            TxtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtBuscar.AnimateReadOnly = false;
            TxtBuscar.BorderStyle = BorderStyle.None;
            TxtBuscar.Depth = 0;
            TxtBuscar.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtBuscar.Hint = "Buscar por DNI, Nombre o Apellido";
            TxtBuscar.LeadingIcon = null;
            TxtBuscar.Location = new Point(16, 55);
            TxtBuscar.Margin = new Padding(3, 2, 3, 2);
            TxtBuscar.MaxLength = 50;
            TxtBuscar.MouseState = MaterialSkin.MouseState.OUT;
            TxtBuscar.Multiline = false;
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.Size = new Size(684, 50);
            TxtBuscar.TabIndex = 13;
            TxtBuscar.Text = "";
            TxtBuscar.TrailingIcon = null;
            TxtBuscar.TextChanged += TxtBuscar_TextChanged;
            // 
            // LListado
            // 
            LListado.AutoSize = true;
            LListado.Depth = 0;
            LListado.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            LListado.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            LListado.Location = new Point(15, 13);
            LListado.MouseState = MaterialSkin.MouseState.HOVER;
            LListado.Name = "LListado";
            LListado.Size = new Size(213, 29);
            LListado.TabIndex = 15;
            LListado.Text = "Listado de Clientes ";
            // 
            // FormListadoClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 424);
            Controls.Add(panel2);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormListadoClientes";
            Padding = new Padding(3, 0, 3, 2);
            Sizable = false;
            Text = "Gestion de Cliente";
            Load += FormListadoClientes_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel LUsuario;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialCard panel2;
        private MaterialSkin.Controls.MaterialLabel LListado;
        private MaterialSkin.Controls.MaterialTextBox TxtBuscar;
        private MaterialSkin.Controls.MaterialListView lstClientes;
        private ColumnHeader ID;
        private ColumnHeader DNI;
        private ColumnHeader Apellido;
        private ColumnHeader Nombre;
        private ColumnHeader Teléfono;
        private ColumnHeader Email;
        private MaterialSkin.Controls.MaterialButton btnCambiarEstado;
        private MaterialSkin.Controls.MaterialButton btnEditar;
        private MaterialSkin.Controls.MaterialButton BtnNuevo;
        private ColumnHeader Estado;
    }
}