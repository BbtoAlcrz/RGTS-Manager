namespace RGTS.Interfaz
{
    partial class FormProductos
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
            TxtBuscar.LeadingIcon = null;
            TxtBuscar.Location = new Point(17, 68);
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
            TxtBuscar.Size = new Size(561, 48);
            TxtBuscar.TabIndex = 0;
            TxtBuscar.TabStop = false;
            TxtBuscar.TextAlign = HorizontalAlignment.Left;
            TxtBuscar.TrailingIcon = null;
            TxtBuscar.UseSystemPasswordChar = false;
            TxtBuscar.Click += TxtBuscar_Click;
            TxtBuscar.KeyDown += TxtBuscar_KeyDown;
            // 
            // CmbFiltroCat
            // 
            CmbFiltroCat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CmbFiltroCat.AutoResize = false;
            CmbFiltroCat.BackColor = Color.FromArgb(255, 255, 255);
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
            CmbFiltroCat.Location = new Point(585, 68);
            CmbFiltroCat.MaxDropDownItems = 4;
            CmbFiltroCat.MouseState = MaterialSkin.MouseState.OUT;
            CmbFiltroCat.Name = "CmbFiltroCat";
            CmbFiltroCat.Size = new Size(343, 49);
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
            LstProductos.Location = new Point(17, 139);
            LstProductos.MinimumSize = new Size(200, 100);
            LstProductos.MouseLocation = new Point(-1, -1);
            LstProductos.MouseState = MaterialSkin.MouseState.OUT;
            LstProductos.Name = "LstProductos";
            LstProductos.OwnerDraw = true;
            LstProductos.Size = new Size(754, 293);
            LstProductos.TabIndex = 3;
            LstProductos.UseCompatibleStateImageBehavior = false;
            LstProductos.View = View.Details;
            LstProductos.SelectedIndexChanged += LstProductos_SelectedIndexChanged;
            // 
            // Codigo
            // 
            Codigo.Text = "Codigo";
            Codigo.Width = 80;
            // 
            // Nombre
            // 
            Nombre.Text = "Nombre";
            Nombre.Width = 100;
            // 
            // Categoria
            // 
            Categoria.Text = "Categoria";
            Categoria.Width = 100;
            // 
            // Precio
            // 
            Precio.Text = "Precio";
            Precio.Width = 80;
            // 
            // Existencias
            // 
            Existencias.Text = "Existencias";
            Existencias.Width = 80;
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            Estado.Width = 80;
            // 
            // BtnNuevo
            // 
            BtnNuevo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnNuevo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnNuevo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnNuevo.Depth = 0;
            BtnNuevo.HighEmphasis = true;
            BtnNuevo.Icon = null;
            BtnNuevo.Location = new Point(27, 489);
            BtnNuevo.Margin = new Padding(5, 5, 5, 5);
            BtnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.NoAccentTextColor = Color.Empty;
            BtnNuevo.Size = new Size(150, 36);
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
            BtnEditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnEditar.Depth = 0;
            BtnEditar.HighEmphasis = true;
            BtnEditar.Icon = null;
            BtnEditar.Location = new Point(208, 489);
            BtnEditar.Margin = new Padding(5, 5, 5, 5);
            BtnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            BtnEditar.Name = "BtnEditar";
            BtnEditar.NoAccentTextColor = Color.Empty;
            BtnEditar.Size = new Size(71, 36);
            BtnEditar.TabIndex = 5;
            BtnEditar.Text = "Editar";
            BtnEditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            BtnEditar.UseAccentColor = false;
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEliminar.AutoSize = false;
            BtnEliminar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnEliminar.Depth = 0;
            BtnEliminar.HighEmphasis = true;
            BtnEliminar.Icon = null;
            BtnEliminar.Location = new Point(790, 141);
            BtnEliminar.Margin = new Padding(5, 5, 5, 5);
            BtnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.NoAccentTextColor = Color.Empty;
            BtnEliminar.Size = new Size(139, 48);
            BtnEliminar.TabIndex = 6;
            BtnEliminar.Text = "estado";
            BtnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            BtnEliminar.UseAccentColor = false;
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnGestionarCat
            // 
            BtnGestionarCat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnGestionarCat.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnGestionarCat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnGestionarCat.Depth = 0;
            BtnGestionarCat.HighEmphasis = true;
            BtnGestionarCat.Icon = null;
            BtnGestionarCat.Location = new Point(735, 489);
            BtnGestionarCat.Margin = new Padding(5, 5, 5, 5);
            BtnGestionarCat.MouseState = MaterialSkin.MouseState.HOVER;
            BtnGestionarCat.Name = "BtnGestionarCat";
            BtnGestionarCat.NoAccentTextColor = Color.Empty;
            BtnGestionarCat.Size = new Size(194, 36);
            BtnGestionarCat.TabIndex = 7;
            BtnGestionarCat.Text = "Gestionar Categorias";
            BtnGestionarCat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            BtnGestionarCat.UseAccentColor = false;
            BtnGestionarCat.UseVisualStyleBackColor = true;
            BtnGestionarCat.Click += BtnGestionarCat_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            panel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(14, 13, 14, 13);
            panel1.MouseState = MaterialSkin.MouseState.HOVER;
            panel1.Name = "panel1";
            panel1.Padding = new Padding(14, 13, 14, 13);
            panel1.Size = new Size(947, 544);
            panel1.TabIndex = 8;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Depth = 0;
            labelTitulo.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            labelTitulo.Location = new Point(17, 13);
            labelTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(231, 29);
            labelTitulo.TabIndex = 9;
            labelTitulo.Text = "Listado de Productos";
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 552);
            Controls.Add(panel1);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "FormProductos";
            Padding = new Padding(3, 0, 3, 3);
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