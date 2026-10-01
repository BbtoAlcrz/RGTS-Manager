namespace RGTS.Interfaz
{
    partial class FormListadoProductos
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
            TxtBuscar = new MaterialSkin.Controls.MaterialTextBox2();
            CmbFiltroCat = new MaterialSkin.Controls.MaterialComboBox();
            LstProductos = new MaterialSkin.Controls.MaterialListView();
            Codigo = new ColumnHeader();
            Nombre = new ColumnHeader();
            Categoria = new ColumnHeader();
            Precio = new ColumnHeader();
            Existencias = new ColumnHeader();
            Estado = new ColumnHeader();
            BtnNuevo = new MaterialSkin.Controls.MaterialButton();
            BtnEditar = new MaterialSkin.Controls.MaterialButton();
            BtnEliminar = new MaterialSkin.Controls.MaterialButton();
            BtnGestionarCat = new MaterialSkin.Controls.MaterialButton();
            panel1 = new MaterialSkin.Controls.MaterialCard();
            labelTitulo = new MaterialSkin.Controls.MaterialLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TxtBuscar
            // 
            TxtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtBuscar.AnimateReadOnly = false;
            TxtBuscar.BackgroundImageLayout = ImageLayout.None;
            TxtBuscar.CharacterCasing = CharacterCasing.Normal;
            TxtBuscar.Depth = 0;
            TxtBuscar.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtBuscar.HideSelection = true;
            TxtBuscar.Hint = "Buscar por codigo o nombre";
            TxtBuscar.LeadingIcon = Properties.Resources.busqueda;
            TxtBuscar.Location = new Point(12, 60);
            TxtBuscar.Margin = new Padding(3, 2, 3, 2);
            TxtBuscar.MaxLength = 32767;
            TxtBuscar.MouseState = MaterialSkin.MouseState.OUT;
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.PasswordChar = '\0';
            TxtBuscar.PrefixSuffixText = null;
            TxtBuscar.ReadOnly = false;
            TxtBuscar.RightToLeft = RightToLeft.No;
            TxtBuscar.SelectedText = "";
            TxtBuscar.SelectionLength = 0;
            TxtBuscar.SelectionStart = 0;
            TxtBuscar.ShortcutsEnabled = true;
            TxtBuscar.Size = new Size(502, 48);
            TxtBuscar.TabIndex = 0;
            TxtBuscar.TabStop = false;
            TxtBuscar.TextAlign = HorizontalAlignment.Left;
            TxtBuscar.TrailingIcon = null;
            TxtBuscar.UseSystemPasswordChar = false;
            TxtBuscar.TextChanged += TxtBuscar_TextChanged;
            // 
            // CmbFiltroCat
            // 
            CmbFiltroCat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CmbFiltroCat.AutoResize = false;
            CmbFiltroCat.BackColor = Color.FromArgb(255, 255, 255);
            CmbFiltroCat.Cursor = Cursors.Hand;
            CmbFiltroCat.Depth = 0;
            CmbFiltroCat.DrawMode = DrawMode.OwnerDrawVariable;
            CmbFiltroCat.DropDownHeight = 174;
            CmbFiltroCat.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbFiltroCat.DropDownWidth = 121;
            CmbFiltroCat.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CmbFiltroCat.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CmbFiltroCat.FormattingEnabled = true;
            CmbFiltroCat.Hint = "Categorias";
            CmbFiltroCat.IntegralHeight = false;
            CmbFiltroCat.ItemHeight = 43;
            CmbFiltroCat.Location = new Point(520, 60);
            CmbFiltroCat.Margin = new Padding(3, 2, 3, 2);
            CmbFiltroCat.MaxDropDownItems = 4;
            CmbFiltroCat.MouseState = MaterialSkin.MouseState.OUT;
            CmbFiltroCat.Name = "CmbFiltroCat";
            CmbFiltroCat.Size = new Size(301, 49);
            CmbFiltroCat.StartIndex = 0;
            CmbFiltroCat.TabIndex = 1;
            CmbFiltroCat.SelectedIndexChanged += CmbFiltroCat_SelectedIndexChanged;
            // 
            // LstProductos
            // 
            LstProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LstProductos.AutoSizeTable = false;
            LstProductos.BackColor = Color.FromArgb(255, 255, 255);
            LstProductos.BorderStyle = BorderStyle.None;
            LstProductos.Columns.AddRange(new ColumnHeader[] { Codigo, Nombre, Categoria, Precio, Existencias, Estado });
            LstProductos.Depth = 0;
            LstProductos.FullRowSelect = true;
            LstProductos.Location = new Point(12, 112);
            LstProductos.Margin = new Padding(3, 2, 3, 2);
            LstProductos.MinimumSize = new Size(175, 75);
            LstProductos.MouseLocation = new Point(-1, -1);
            LstProductos.MouseState = MaterialSkin.MouseState.OUT;
            LstProductos.Name = "LstProductos";
            LstProductos.OwnerDraw = true;
            LstProductos.Size = new Size(805, 193);
            LstProductos.TabIndex = 3;
            LstProductos.UseCompatibleStateImageBehavior = false;
            LstProductos.View = View.Details;
            LstProductos.SelectedIndexChanged += LstProductos_SelectedIndexChanged;
            // 
            // Codigo
            // 
            Codigo.Text = "Codigo";
            Codigo.Width = 90;
            // 
            // Nombre
            // 
            Nombre.Text = "Nombre";
            Nombre.Width = 200;
            // 
            // Categoria
            // 
            Categoria.Text = "Categoria";
            Categoria.Width = 120;
            // 
            // Precio
            // 
            Precio.Text = "Precio";
            Precio.Width = 100;
            // 
            // Existencias
            // 
            Existencias.Text = "Existencias";
            Existencias.Width = 120;
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            Estado.Width = 100;
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
            BtnNuevo.Location = new Point(12, 413);
            BtnNuevo.Margin = new Padding(4);
            BtnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.NoAccentTextColor = Color.Empty;
            BtnNuevo.Size = new Size(178, 36);
            BtnNuevo.TabIndex = 4;
            BtnNuevo.Text = "Nuevo Producto";
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
            BtnEditar.Location = new Point(198, 413);
            BtnEditar.Margin = new Padding(4);
            BtnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            BtnEditar.Name = "BtnEditar";
            BtnEditar.NoAccentTextColor = Color.Empty;
            BtnEditar.Size = new Size(180, 36);
            BtnEditar.TabIndex = 5;
            BtnEditar.Text = "Editar Producto";
            BtnEditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            BtnEditar.UseAccentColor = false;
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnEliminar.AutoSize = false;
            BtnEliminar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnEliminar.Cursor = Cursors.Hand;
            BtnEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnEliminar.Depth = 0;
            BtnEliminar.HighEmphasis = true;
            BtnEliminar.Icon = Properties.Resources.click;
            BtnEliminar.Location = new Point(670, 413);
            BtnEliminar.Margin = new Padding(4);
            BtnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.NoAccentTextColor = Color.Empty;
            BtnEliminar.Size = new Size(150, 36);
            BtnEliminar.TabIndex = 6;
            BtnEliminar.Text = "Deshabilitar";
            BtnEliminar.TextAlign = ContentAlignment.MiddleRight;
            BtnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            BtnEliminar.UseAccentColor = false;
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnGestionarCat
            // 
            BtnGestionarCat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnGestionarCat.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnGestionarCat.Cursor = Cursors.Hand;
            BtnGestionarCat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnGestionarCat.Depth = 0;
            BtnGestionarCat.HighEmphasis = true;
            BtnGestionarCat.Icon = null;
            BtnGestionarCat.Location = new Point(629, 311);
            BtnGestionarCat.Margin = new Padding(4);
            BtnGestionarCat.MouseState = MaterialSkin.MouseState.HOVER;
            BtnGestionarCat.Name = "BtnGestionarCat";
            BtnGestionarCat.NoAccentTextColor = Color.Empty;
            BtnGestionarCat.Size = new Size(194, 36);
            BtnGestionarCat.TabIndex = 7;
            BtnGestionarCat.Text = "Gestionar Categorias";
            BtnGestionarCat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnGestionarCat.UseAccentColor = false;
            BtnGestionarCat.UseVisualStyleBackColor = true;
            BtnGestionarCat.Click += BtnGestionarCat_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 255);
            panel1.Controls.Add(labelTitulo);
            panel1.Controls.Add(CmbFiltroCat);
            panel1.Controls.Add(LstProductos);
            panel1.Controls.Add(TxtBuscar);
            panel1.Controls.Add(BtnNuevo);
            panel1.Controls.Add(BtnGestionarCat);
            panel1.Controls.Add(BtnEditar);
            panel1.Controls.Add(BtnEliminar);
            panel1.Depth = 0;
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(15);
            panel1.MouseState = MaterialSkin.MouseState.HOVER;
            panel1.Name = "panel1";
            panel1.Padding = new Padding(12, 10, 12, 10);
            panel1.Size = new Size(836, 463);
            panel1.TabIndex = 8;
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
            labelTitulo.Size = new Size(231, 29);
            labelTitulo.TabIndex = 9;
            labelTitulo.Text = "Listado de Productos";
            // 
            // FormListadoProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 463);
            Controls.Add(panel1);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormListadoProductos";
            Padding = new Padding(0);
            Sizable = false;
            Text = "Gestion de Producto";
            Load += FormProductos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 TxtBuscar;
        private MaterialSkin.Controls.MaterialComboBox CmbFiltroCat;
        private MaterialSkin.Controls.MaterialListView LstProductos;
        private ColumnHeader Codigo;
        private ColumnHeader Nombre;
        private ColumnHeader Categoria;
        private ColumnHeader Precio;
        private ColumnHeader Existencias;
        private ColumnHeader Estado;
        private MaterialSkin.Controls.MaterialButton BtnNuevo;
        private MaterialSkin.Controls.MaterialButton BtnEditar;
        private MaterialSkin.Controls.MaterialButton BtnEliminar;
        private MaterialSkin.Controls.MaterialButton BtnGestionarCat;
        private MaterialSkin.Controls.MaterialCard panel1;
        private MaterialSkin.Controls.MaterialLabel labelTitulo;
    }
}