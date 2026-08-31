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
            ListViewGroup listViewGroup2 = new ListViewGroup("Codigo", HorizontalAlignment.Left);
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
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TxtBuscar
            // 
            TxtBuscar.AnimateReadOnly = false;
            TxtBuscar.BackgroundImageLayout = ImageLayout.None;
            TxtBuscar.CharacterCasing = CharacterCasing.Normal;
            TxtBuscar.Depth = 0;
            TxtBuscar.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtBuscar.HideSelection = true;
            TxtBuscar.Hint = "Buscar por codigo o nombre";
            TxtBuscar.LeadingIcon = null;
            TxtBuscar.Location = new Point(31, 85);
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
            TxtBuscar.Size = new Size(585, 48);
            TxtBuscar.TabIndex = 0;
            TxtBuscar.TabStop = false;
            TxtBuscar.TextAlign = HorizontalAlignment.Left;
            TxtBuscar.TrailingIcon = null;
            TxtBuscar.UseSystemPasswordChar = false;
            // 
            // CmbFiltroCat
            // 
            CmbFiltroCat.AutoResize = false;
            CmbFiltroCat.BackColor = Color.FromArgb(255, 255, 255);
            CmbFiltroCat.Depth = 0;
            CmbFiltroCat.DrawMode = DrawMode.OwnerDrawVariable;
            CmbFiltroCat.DropDownHeight = 174;
            CmbFiltroCat.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbFiltroCat.DropDownWidth = 121;
            CmbFiltroCat.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CmbFiltroCat.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CmbFiltroCat.FormattingEnabled = true;
            CmbFiltroCat.Hint = "Categorias";
            CmbFiltroCat.IntegralHeight = false;
            CmbFiltroCat.ItemHeight = 43;
            CmbFiltroCat.Location = new Point(622, 85);
            CmbFiltroCat.MaxDropDownItems = 4;
            CmbFiltroCat.MouseState = MaterialSkin.MouseState.OUT;
            CmbFiltroCat.Name = "CmbFiltroCat";
            CmbFiltroCat.Size = new Size(200, 49);
            CmbFiltroCat.StartIndex = 0;
            CmbFiltroCat.TabIndex = 1;
            CmbFiltroCat.SelectedIndexChanged += materialComboBox1_SelectedIndexChanged;
            // 
            // LstProductos
            // 
            LstProductos.AutoSizeTable = false;
            LstProductos.BackColor = Color.FromArgb(255, 255, 255);
            LstProductos.BorderStyle = BorderStyle.None;
            LstProductos.Columns.AddRange(new ColumnHeader[] { Codigo, Nombre, Categoria, Precio, Existencias, Estado });
            LstProductos.Depth = 0;
            LstProductos.FullRowSelect = true;
            LstProductos.GridLines = true;
            listViewGroup2.Header = "Codigo";
            listViewGroup2.Name = "listViewGroup1";
            LstProductos.Groups.AddRange(new ListViewGroup[] { listViewGroup2 });
            LstProductos.Location = new Point(31, 139);
            LstProductos.MinimumSize = new Size(200, 100);
            LstProductos.MouseLocation = new Point(-1, -1);
            LstProductos.MouseState = MaterialSkin.MouseState.OUT;
            LstProductos.Name = "LstProductos";
            LstProductos.OwnerDraw = true;
            LstProductos.Size = new Size(868, 294);
            LstProductos.TabIndex = 3;
            LstProductos.UseCompatibleStateImageBehavior = false;
            LstProductos.View = View.Details;
            // 
            // BtnNuevo
            // 
            BtnNuevo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnNuevo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnNuevo.Depth = 0;
            BtnNuevo.HighEmphasis = true;
            BtnNuevo.Icon = null;
            BtnNuevo.Location = new Point(31, 442);
            BtnNuevo.Margin = new Padding(4, 6, 4, 6);
            BtnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.NoAccentTextColor = Color.Empty;
            BtnNuevo.Size = new Size(150, 36);
            BtnNuevo.TabIndex = 4;
            BtnNuevo.Text = "Nuevo Producto";
            BtnNuevo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnNuevo.UseAccentColor = false;
            BtnNuevo.UseVisualStyleBackColor = true;
            // 
            // BtnEditar
            // 
            BtnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnEditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnEditar.Depth = 0;
            BtnEditar.HighEmphasis = true;
            BtnEditar.Icon = null;
            BtnEditar.Location = new Point(183, 364);
            BtnEditar.Margin = new Padding(4, 6, 4, 6);
            BtnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            BtnEditar.Name = "BtnEditar";
            BtnEditar.NoAccentTextColor = Color.Empty;
            BtnEditar.Size = new Size(71, 36);
            BtnEditar.TabIndex = 5;
            BtnEditar.Text = "Editar";
            BtnEditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            BtnEditar.UseAccentColor = false;
            BtnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            BtnEliminar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnEliminar.Depth = 0;
            BtnEliminar.HighEmphasis = true;
            BtnEliminar.Icon = null;
            BtnEliminar.Location = new Point(262, 364);
            BtnEliminar.Margin = new Padding(4, 6, 4, 6);
            BtnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.NoAccentTextColor = Color.Empty;
            BtnEliminar.Size = new Size(88, 36);
            BtnEliminar.TabIndex = 6;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            BtnEliminar.UseAccentColor = false;
            BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnGestionarCat
            // 
            BtnGestionarCat.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnGestionarCat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnGestionarCat.Depth = 0;
            BtnGestionarCat.HighEmphasis = true;
            BtnGestionarCat.Icon = null;
            BtnGestionarCat.Location = new Point(667, 364);
            BtnGestionarCat.Margin = new Padding(4, 6, 4, 6);
            BtnGestionarCat.MouseState = MaterialSkin.MouseState.HOVER;
            BtnGestionarCat.Name = "BtnGestionarCat";
            BtnGestionarCat.NoAccentTextColor = Color.Empty;
            BtnGestionarCat.Size = new Size(194, 36);
            BtnGestionarCat.TabIndex = 7;
            BtnGestionarCat.Text = "Gestionar Categorias";
            BtnGestionarCat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            BtnGestionarCat.UseAccentColor = false;
            BtnGestionarCat.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(BtnGestionarCat);
            panel1.Controls.Add(BtnEditar);
            panel1.Controls.Add(BtnEliminar);
            panel1.Location = new Point(27, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(883, 440);
            panel1.TabIndex = 8;
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 552);
            Controls.Add(BtnNuevo);
            Controls.Add(LstProductos);
            Controls.Add(CmbFiltroCat);
            Controls.Add(TxtBuscar);
            Controls.Add(panel1);
            Name = "FormProductos";
            Text = "Gestion de Producto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Panel panel1;
    }
}