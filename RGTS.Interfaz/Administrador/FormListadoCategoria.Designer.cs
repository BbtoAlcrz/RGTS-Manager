namespace RGTS.Interfaz.Administrador
{
    partial class FormListadoCategoria
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
            BtnEditar = new MaterialSkin.Controls.MaterialButton();
            BtnCambiarEstado = new MaterialSkin.Controls.MaterialButton();
            lstClientes = new MaterialSkin.Controls.MaterialListView();
            ID = new ColumnHeader();
            Nombre = new ColumnHeader();
            Descripcion = new ColumnHeader();
            Estado = new ColumnHeader();
            TxtBuscarNombre = new MaterialSkin.Controls.MaterialTextBox();
            labelTitulo = new MaterialSkin.Controls.MaterialLabel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 255, 255);
            panel2.Controls.Add(BtnNuevo);
            panel2.Controls.Add(BtnEditar);
            panel2.Controls.Add(BtnCambiarEstado);
            panel2.Controls.Add(lstClientes);
            panel2.Controls.Add(TxtBuscarNombre);
            panel2.Controls.Add(labelTitulo);
            panel2.Depth = 0;
            panel2.Dock = DockStyle.Fill;
            panel2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(12, 10, 12, 10);
            panel2.MouseState = MaterialSkin.MouseState.HOVER;
            panel2.Name = "panel2";
            panel2.Padding = new Padding(12, 10, 12, 10);
            panel2.Size = new Size(841, 424);
            panel2.TabIndex = 1;
            // 
            // BtnNuevo
            // 
            BtnNuevo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnNuevo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnNuevo.Cursor = Cursors.Hand;
            BtnNuevo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnNuevo.Depth = 0;
            BtnNuevo.HighEmphasis = true;
            BtnNuevo.Icon = Properties.Resources.nuevo;
            BtnNuevo.Location = new Point(16, 374);
            BtnNuevo.Margin = new Padding(4);
            BtnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.NoAccentTextColor = Color.Empty;
            BtnNuevo.Size = new Size(181, 36);
            BtnNuevo.TabIndex = 19;
            BtnNuevo.Text = "Nueva Categoria";
            BtnNuevo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnNuevo.UseAccentColor = false;
            BtnNuevo.UseVisualStyleBackColor = true;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnEditar.Cursor = Cursors.Hand;
            BtnEditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnEditar.Depth = 0;
            BtnEditar.HighEmphasis = true;
            BtnEditar.Icon = Properties.Resources.editar;
            BtnEditar.Location = new Point(205, 375);
            BtnEditar.Margin = new Padding(4);
            BtnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            BtnEditar.Name = "BtnEditar";
            BtnEditar.NoAccentTextColor = Color.Empty;
            BtnEditar.Size = new Size(183, 36);
            BtnEditar.TabIndex = 18;
            BtnEditar.Text = "Editar Categoria";
            BtnEditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            BtnEditar.UseAccentColor = false;
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnCambiarEstado
            // 
            BtnCambiarEstado.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnCambiarEstado.AutoSize = false;
            BtnCambiarEstado.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnCambiarEstado.BackColor = Color.IndianRed;
            BtnCambiarEstado.Cursor = Cursors.Hand;
            BtnCambiarEstado.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnCambiarEstado.Depth = 0;
            BtnCambiarEstado.ForeColor = Color.Firebrick;
            BtnCambiarEstado.HighEmphasis = true;
            BtnCambiarEstado.Icon = Properties.Resources.click;
            BtnCambiarEstado.Location = new Point(681, 375);
            BtnCambiarEstado.Margin = new Padding(4);
            BtnCambiarEstado.MouseState = MaterialSkin.MouseState.HOVER;
            BtnCambiarEstado.Name = "BtnCambiarEstado";
            BtnCambiarEstado.NoAccentTextColor = Color.Empty;
            BtnCambiarEstado.Size = new Size(140, 36);
            BtnCambiarEstado.TabIndex = 14;
            BtnCambiarEstado.Text = "Deshabilitar";
            BtnCambiarEstado.TextAlign = ContentAlignment.MiddleRight;
            BtnCambiarEstado.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            BtnCambiarEstado.UseAccentColor = false;
            BtnCambiarEstado.UseVisualStyleBackColor = true;
            BtnCambiarEstado.Click += BtnCambiarEstado_Click;
            // 
            // lstClientes
            // 
            lstClientes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lstClientes.AutoSizeTable = false;
            lstClientes.BackColor = Color.FromArgb(255, 255, 255);
            lstClientes.BorderStyle = BorderStyle.None;
            lstClientes.Columns.AddRange(new ColumnHeader[] { ID, Nombre, Descripcion, Estado });
            lstClientes.Depth = 0;
            lstClientes.FullRowSelect = true;
            lstClientes.Location = new Point(12, 114);
            lstClientes.Margin = new Padding(3, 2, 3, 2);
            lstClientes.MinimumSize = new Size(175, 75);
            lstClientes.MouseLocation = new Point(-1, -1);
            lstClientes.MouseState = MaterialSkin.MouseState.OUT;
            lstClientes.Name = "lstClientes";
            lstClientes.OwnerDraw = true;
            lstClientes.Size = new Size(809, 250);
            lstClientes.TabIndex = 17;
            lstClientes.UseCompatibleStateImageBehavior = false;
            lstClientes.View = View.Details;
            lstClientes.SelectedIndexChanged += LstClientes_SelectedIndexChanged;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 50;
            // 
            // Nombre
            // 
            Nombre.Text = "Nombre";
            Nombre.Width = 150;
            // 
            // Descripcion
            // 
            Descripcion.Text = "Descripcion";
            Descripcion.Width = 300;
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            Estado.Width = 110;
            // 
            // TxtBuscarNombre
            // 
            TxtBuscarNombre.AnimateReadOnly = false;
            TxtBuscarNombre.BorderStyle = BorderStyle.None;
            TxtBuscarNombre.Depth = 0;
            TxtBuscarNombre.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtBuscarNombre.Hint = "Buscar por nombre";
            TxtBuscarNombre.LeadingIcon = Properties.Resources.busqueda;
            TxtBuscarNombre.Location = new Point(12, 60);
            TxtBuscarNombre.Margin = new Padding(3, 2, 3, 2);
            TxtBuscarNombre.MaxLength = 50;
            TxtBuscarNombre.MouseState = MaterialSkin.MouseState.OUT;
            TxtBuscarNombre.Multiline = false;
            TxtBuscarNombre.Name = "TxtBuscarNombre";
            TxtBuscarNombre.Size = new Size(550, 50);
            TxtBuscarNombre.TabIndex = 13;
            TxtBuscarNombre.Text = "";
            TxtBuscarNombre.TrailingIcon = null;
            TxtBuscarNombre.TextChanged += TxtBuscarNombre_TextChanged;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Depth = 0;
            labelTitulo.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            labelTitulo.Location = new Point(12, 15);
            labelTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(236, 29);
            labelTitulo.TabIndex = 15;
            labelTitulo.Text = "Listado de Categorías";
            // 
            // FormListadoCategoria
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(841, 424);
            Controls.Add(panel2);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormListadoCategoria";
            Padding = new Padding(0);
            Sizable = false;
            Text = "Gestión de Categoría";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialCard panel2;
        private MaterialSkin.Controls.MaterialLabel labelTitulo;
        private MaterialSkin.Controls.MaterialTextBox TxtBuscarNombre;
        private MaterialSkin.Controls.MaterialListView lstClientes;
        private ColumnHeader ID;
        private ColumnHeader Nombre;
        private ColumnHeader Descripcion;
        private ColumnHeader Estado;
        private MaterialSkin.Controls.MaterialButton BtnNuevo;
        private MaterialSkin.Controls.MaterialButton BtnEditar;
        private MaterialSkin.Controls.MaterialButton BtnCambiarEstado;
    }
}