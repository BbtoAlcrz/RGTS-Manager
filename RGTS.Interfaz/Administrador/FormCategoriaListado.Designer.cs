namespace RGTS.Interfaz.Administrador
{
    partial class FormCategoriaListado
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
            ListViewGroup listViewGroup1 = new ListViewGroup("ListViewGroup", HorizontalAlignment.Left);
            ListViewGroup listViewGroup2 = new ListViewGroup("ListViewGroup", HorizontalAlignment.Left);
            ListViewGroup listViewGroup3 = new ListViewGroup("ListViewGroup", HorizontalAlignment.Left);
            panel2 = new MaterialSkin.Controls.MaterialCard();
            labelTitulo = new MaterialSkin.Controls.MaterialLabel();
            BtnAlta = new MaterialSkin.Controls.MaterialButton();
            BtnNuevo = new MaterialSkin.Controls.MaterialButton();
            BtnEditar = new MaterialSkin.Controls.MaterialButton();
            btnEliminar = new MaterialSkin.Controls.MaterialButton();
            lstClientes = new MaterialSkin.Controls.MaterialListView();
            ID = new ColumnHeader();
            Nombre = new ColumnHeader();
            Descripcion = new ColumnHeader();
            Estado = new ColumnHeader();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(255, 255, 255);
            panel2.Controls.Add(labelTitulo);
            panel2.Controls.Add(BtnAlta);
            panel2.Controls.Add(BtnNuevo);
            panel2.Controls.Add(BtnEditar);
            panel2.Controls.Add(btnEliminar);
            panel2.Controls.Add(lstClientes);
            panel2.Depth = 0;
            panel2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panel2.Location = new Point(16, 10);
            panel2.Margin = new Padding(12, 10, 12, 10);
            panel2.MouseState = MaterialSkin.MouseState.HOVER;
            panel2.Name = "panel2";
            panel2.Padding = new Padding(12, 10, 12, 10);
            panel2.Size = new Size(790, 478);
            panel2.TabIndex = 2;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Depth = 0;
            labelTitulo.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            labelTitulo.Location = new Point(16, 17);
            labelTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(208, 29);
            labelTitulo.TabIndex = 3;
            labelTitulo.Text = "Lista de Categorías";
            // 
            // BtnAlta
            // 
            BtnAlta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAlta.AutoSize = false;
            BtnAlta.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnAlta.BackColor = Color.IndianRed;
            BtnAlta.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnAlta.Depth = 0;
            BtnAlta.ForeColor = Color.Firebrick;
            BtnAlta.HighEmphasis = true;
            BtnAlta.Icon = null;
            BtnAlta.Location = new Point(677, 122);
            BtnAlta.Margin = new Padding(4);
            BtnAlta.MouseState = MaterialSkin.MouseState.HOVER;
            BtnAlta.Name = "BtnAlta";
            BtnAlta.NoAccentTextColor = Color.Empty;
            BtnAlta.Size = new Size(97, 35);
            BtnAlta.TabIndex = 3;
            BtnAlta.Text = "DAR DE ALTA";
            BtnAlta.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            BtnAlta.UseAccentColor = false;
            BtnAlta.UseVisualStyleBackColor = true;
            BtnAlta.Click += BtnAlta_Click;
            // 
            // BtnNuevo
            // 
            BtnNuevo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnNuevo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnNuevo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnNuevo.Depth = 0;
            BtnNuevo.HighEmphasis = true;
            BtnNuevo.Icon = null;
            BtnNuevo.Location = new Point(16, 424);
            BtnNuevo.Margin = new Padding(4);
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
            BtnEditar.Location = new Point(177, 424);
            BtnEditar.Margin = new Padding(4);
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
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.AutoSize = false;
            btnEliminar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEliminar.Depth = 0;
            btnEliminar.ForeColor = Color.Firebrick;
            btnEliminar.HighEmphasis = true;
            btnEliminar.Icon = null;
            btnEliminar.Location = new Point(677, 79);
            btnEliminar.Margin = new Padding(4);
            btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.NoAccentTextColor = Color.Empty;
            btnEliminar.Size = new Size(97, 35);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "DAR DE BAJA";
            btnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnEliminar.UseAccentColor = false;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
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
            listViewGroup1.CollapsedState = ListViewGroupCollapsedState.Expanded;
            listViewGroup1.Footer = "ID";
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "ID";
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "DNI";
            listViewGroup3.Header = "ListViewGroup";
            listViewGroup3.Name = "listViewGroup1";
            lstClientes.Groups.AddRange(new ListViewGroup[] { listViewGroup1, listViewGroup2, listViewGroup3 });
            lstClientes.Location = new Point(16, 79);
            lstClientes.Margin = new Padding(3, 2, 3, 2);
            lstClientes.MinimumSize = new Size(175, 75);
            lstClientes.MouseLocation = new Point(-1, -1);
            lstClientes.MouseState = MaterialSkin.MouseState.OUT;
            lstClientes.Name = "lstClientes";
            lstClientes.OwnerDraw = true;
            lstClientes.Size = new Size(639, 339);
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
            // FormCategoriaListado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 500);
            Controls.Add(panel2);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormCategoriaListado";
            Padding = new Padding(3, 0, 3, 2);
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
        private MaterialSkin.Controls.MaterialButton btnEliminar;
        private MaterialSkin.Controls.MaterialListView lstClientes;
        private ColumnHeader ID;
        private ColumnHeader Estado;
        private ColumnHeader Nombre;
        private ColumnHeader Descripcion;
        private MaterialSkin.Controls.MaterialLabel labelTitulo;
    }
}