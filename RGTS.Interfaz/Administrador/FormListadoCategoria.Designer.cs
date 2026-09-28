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
            ListViewGroup listViewGroup4 = new ListViewGroup("ListViewGroup", HorizontalAlignment.Left);
            ListViewGroup listViewGroup5 = new ListViewGroup("ListViewGroup", HorizontalAlignment.Left);
            ListViewGroup listViewGroup6 = new ListViewGroup("ListViewGroup", HorizontalAlignment.Left);
            panel2 = new MaterialSkin.Controls.MaterialCard();
            labelTitulo = new MaterialSkin.Controls.MaterialLabel();
            BtnNuevo = new MaterialSkin.Controls.MaterialButton();
            BtnEditar = new MaterialSkin.Controls.MaterialButton();
            BtnCambiarEstado = new MaterialSkin.Controls.MaterialButton();
            lstClientes = new MaterialSkin.Controls.MaterialListView();
            ID = new ColumnHeader();
            Nombre = new ColumnHeader();
            Descripcion = new ColumnHeader();
            Estado = new ColumnHeader();
            TxtBuscarNombre = new MaterialSkin.Controls.MaterialTextBox();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(255, 255, 255);
            panel2.Controls.Add(TxtBuscarNombre);
            panel2.Controls.Add(labelTitulo);
            panel2.Controls.Add(BtnNuevo);
            panel2.Controls.Add(BtnEditar);
            panel2.Controls.Add(BtnCambiarEstado);
            panel2.Controls.Add(lstClientes);
            panel2.Depth = 0;
            panel2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panel2.Location = new Point(18, 13);
            panel2.Margin = new Padding(14, 13, 14, 13);
            panel2.MouseState = MaterialSkin.MouseState.HOVER;
            panel2.Name = "panel2";
            panel2.Padding = new Padding(14, 13, 14, 13);
            panel2.Size = new Size(903, 637);
            panel2.TabIndex = 2;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Depth = 0;
            labelTitulo.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            labelTitulo.Location = new Point(18, 23);
            labelTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(208, 29);
            labelTitulo.TabIndex = 3;
            labelTitulo.Text = "Lista de Categorías";
            // 
            // BtnNuevo
            // 
            BtnNuevo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnNuevo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnNuevo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnNuevo.Depth = 0;
            BtnNuevo.HighEmphasis = true;
            BtnNuevo.Icon = null;
            BtnNuevo.Location = new Point(18, 577);
            BtnNuevo.Margin = new Padding(5);
            BtnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.NoAccentTextColor = Color.Empty;
            BtnNuevo.Size = new Size(153, 36);
            BtnNuevo.TabIndex = 1;
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
            BtnEditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnEditar.Depth = 0;
            BtnEditar.HighEmphasis = true;
            BtnEditar.Icon = null;
            BtnEditar.Location = new Point(202, 577);
            BtnEditar.Margin = new Padding(5);
            BtnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            BtnEditar.Name = "BtnEditar";
            BtnEditar.NoAccentTextColor = Color.Empty;
            BtnEditar.Size = new Size(155, 36);
            BtnEditar.TabIndex = 4;
            BtnEditar.Text = "Editar Categoria";
            BtnEditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            BtnEditar.UseAccentColor = false;
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnCambiarEstado
            // 
            BtnCambiarEstado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCambiarEstado.AutoSize = false;
            BtnCambiarEstado.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnCambiarEstado.BackColor = Color.IndianRed;
            BtnCambiarEstado.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnCambiarEstado.Depth = 0;
            BtnCambiarEstado.ForeColor = Color.Firebrick;
            BtnCambiarEstado.HighEmphasis = true;
            BtnCambiarEstado.Icon = null;
            BtnCambiarEstado.Location = new Point(773, 69);
            BtnCambiarEstado.Margin = new Padding(5);
            BtnCambiarEstado.MouseState = MaterialSkin.MouseState.HOVER;
            BtnCambiarEstado.Name = "BtnCambiarEstado";
            BtnCambiarEstado.NoAccentTextColor = Color.Empty;
            BtnCambiarEstado.Size = new Size(111, 47);
            BtnCambiarEstado.TabIndex = 2;
            BtnCambiarEstado.Text = "Estado";
            BtnCambiarEstado.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            BtnCambiarEstado.UseAccentColor = false;
            BtnCambiarEstado.UseVisualStyleBackColor = true;
            BtnCambiarEstado.Click += BtnCambiarEstado_Click;
            // 
            // lstClientes
            // 
            lstClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstClientes.AutoSizeTable = false;
            lstClientes.BackColor = Color.FromArgb(255, 255, 255);
            lstClientes.BorderStyle = BorderStyle.None;
            lstClientes.Columns.AddRange(new ColumnHeader[] { ID, Nombre, Descripcion, Estado });
            lstClientes.Depth = 0;
            lstClientes.FullRowSelect = true;
            lstClientes.Location = new Point(18, 146);
            lstClientes.MinimumSize = new Size(200, 100);
            lstClientes.MouseLocation = new Point(-1, -1);
            lstClientes.MouseState = MaterialSkin.MouseState.OUT;
            lstClientes.Name = "lstClientes";
            lstClientes.OwnerDraw = true;
            lstClientes.Size = new Size(730, 411);
            lstClientes.TabIndex = 17;
            lstClientes.TabStop = false;
            lstClientes.UseCompatibleStateImageBehavior = false;
            lstClientes.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 80;
            // 
            // Nombre
            // 
            Nombre.Text = "Nombre";
            Nombre.Width = 100;
            // 
            // Descripcion
            // 
            Descripcion.Text = "Descipcion";
            Descripcion.Width = 200;
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            Estado.Width = 90;
            // 
            // TxtBuscarNombre
            // 
            TxtBuscarNombre.AnimateReadOnly = false;
            TxtBuscarNombre.BorderStyle = BorderStyle.None;
            TxtBuscarNombre.Depth = 0;
            TxtBuscarNombre.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtBuscarNombre.Hint = "Nombre";
            TxtBuscarNombre.LeadingIcon = null;
            TxtBuscarNombre.Location = new Point(18, 66);
            TxtBuscarNombre.MaxLength = 50;
            TxtBuscarNombre.MouseState = MaterialSkin.MouseState.OUT;
            TxtBuscarNombre.Multiline = false;
            TxtBuscarNombre.Name = "TxtBuscarNombre";
            TxtBuscarNombre.Size = new Size(703, 50);
            TxtBuscarNombre.TabIndex = 18;
            TxtBuscarNombre.Text = "";
            TxtBuscarNombre.TrailingIcon = null;
            // 
            // FormCategoriaListado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 667);
            Controls.Add(panel2);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "FormCategoriaListado";
            Padding = new Padding(3, 0, 3, 3);
            Text = "Categorias";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard panel2;
        private MaterialSkin.Controls.MaterialButton BtnAlta;
        private MaterialSkin.Controls.MaterialButton BtnNuevo;
        private MaterialSkin.Controls.MaterialButton BtnEditar;
        private MaterialSkin.Controls.MaterialButton BtnCambiarEstado;
        private MaterialSkin.Controls.MaterialListView lstClientes;
        private ColumnHeader ID;
        private ColumnHeader Estado;
        private ColumnHeader Nombre;
        private ColumnHeader Descripcion;
        private MaterialSkin.Controls.MaterialLabel labelTitulo;
        private MaterialSkin.Controls.MaterialTextBox TxtBuscarNombre;
    }
}