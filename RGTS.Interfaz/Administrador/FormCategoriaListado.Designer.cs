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
            panel2 = new Panel();
            BtnAlta = new MaterialSkin.Controls.MaterialButton();
            BtnNuevo = new MaterialSkin.Controls.MaterialButton();
            BtnEditar = new MaterialSkin.Controls.MaterialButton();
            btnEliminar = new MaterialSkin.Controls.MaterialButton();
            lstClientes = new MaterialSkin.Controls.MaterialListView();
            ID = new ColumnHeader();
            Estado = new ColumnHeader();
            Nombre = new ColumnHeader();
            Descripcion = new ColumnHeader();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(BtnAlta);
            panel2.Controls.Add(BtnNuevo);
            panel2.Controls.Add(BtnEditar);
            panel2.Controls.Add(btnEliminar);
            panel2.Controls.Add(lstClientes);
            panel2.Location = new Point(18, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(719, 380);
            panel2.TabIndex = 2;
            // 
            // BtnAlta
            // 
            BtnAlta.AutoSize = false;
            BtnAlta.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnAlta.BackColor = Color.IndianRed;
            BtnAlta.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnAlta.Depth = 0;
            BtnAlta.ForeColor = Color.Firebrick;
            BtnAlta.HighEmphasis = true;
            BtnAlta.Icon = null;
            BtnAlta.Location = new Point(572, 109);
            BtnAlta.Margin = new Padding(5);
            BtnAlta.MouseState = MaterialSkin.MouseState.HOVER;
            BtnAlta.Name = "BtnAlta";
            BtnAlta.NoAccentTextColor = Color.Empty;
            BtnAlta.Size = new Size(111, 47);
            BtnAlta.TabIndex = 20;
            BtnAlta.Text = "DAR DE ALTA";
            BtnAlta.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            BtnAlta.UseAccentColor = false;
            BtnAlta.UseVisualStyleBackColor = true;
            BtnAlta.Click += BtnAlta_Click;
            // 
            // BtnNuevo
            // 
            BtnNuevo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnNuevo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnNuevo.Depth = 0;
            BtnNuevo.HighEmphasis = true;
            BtnNuevo.Icon = null;
            BtnNuevo.Location = new Point(361, 303);
            BtnNuevo.Margin = new Padding(5);
            BtnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.NoAccentTextColor = Color.Empty;
            BtnNuevo.Size = new Size(153, 36);
            BtnNuevo.TabIndex = 19;
            BtnNuevo.Text = "Nueva Categoria";
            BtnNuevo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnNuevo.UseAccentColor = false;
            BtnNuevo.UseVisualStyleBackColor = true;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnEditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnEditar.Depth = 0;
            BtnEditar.HighEmphasis = true;
            BtnEditar.Icon = null;
            BtnEditar.Location = new Point(174, 303);
            BtnEditar.Margin = new Padding(5);
            BtnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            BtnEditar.Name = "BtnEditar";
            BtnEditar.NoAccentTextColor = Color.Empty;
            BtnEditar.Size = new Size(155, 36);
            BtnEditar.TabIndex = 18;
            BtnEditar.Text = "Editar Categoria";
            BtnEditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            BtnEditar.UseAccentColor = false;
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.AutoSize = false;
            btnEliminar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEliminar.Depth = 0;
            btnEliminar.ForeColor = Color.Firebrick;
            btnEliminar.HighEmphasis = true;
            btnEliminar.Icon = null;
            btnEliminar.Location = new Point(572, 31);
            btnEliminar.Margin = new Padding(5);
            btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.NoAccentTextColor = Color.Empty;
            btnEliminar.Size = new Size(111, 47);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "DAR DE BAJA";
            btnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnEliminar.UseAccentColor = false;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lstClientes
            // 
            lstClientes.AutoSizeTable = false;
            lstClientes.BackColor = Color.FromArgb(255, 255, 255);
            lstClientes.BorderStyle = BorderStyle.None;
            lstClientes.Columns.AddRange(new ColumnHeader[] { ID, Estado, Nombre, Descripcion });
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
            lstClientes.Location = new Point(56, 31);
            lstClientes.MinimumSize = new Size(200, 100);
            lstClientes.MouseLocation = new Point(-1, -1);
            lstClientes.MouseState = MaterialSkin.MouseState.OUT;
            lstClientes.Name = "lstClientes";
            lstClientes.OwnerDraw = true;
            lstClientes.Size = new Size(458, 233);
            lstClientes.TabIndex = 17;
            lstClientes.UseCompatibleStateImageBehavior = false;
            lstClientes.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 50;
            // 
            // Estado
            // 
            Estado.DisplayIndex = 2;
            // 
            // Nombre
            // 
            Nombre.DisplayIndex = 1;
            Nombre.Text = "Nombre";
            Nombre.Width = 100;
            // 
            // FormCategoriaListado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 522);
            Controls.Add(panel2);
            Name = "FormCategoriaListado";
            Text = "Categorias";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private MaterialSkin.Controls.MaterialButton BtnAlta;
        private MaterialSkin.Controls.MaterialButton BtnNuevo;
        private MaterialSkin.Controls.MaterialButton BtnEditar;
        private MaterialSkin.Controls.MaterialButton btnEliminar;
        private MaterialSkin.Controls.MaterialListView lstClientes;
        private ColumnHeader ID;
        private ColumnHeader Estado;
        private ColumnHeader Nombre;
        private ColumnHeader Descripcion;
    }
}