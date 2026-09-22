namespace RGTS.Interfaz
{
    partial class FormGestionClientes
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
            BtnAlta = new MaterialSkin.Controls.MaterialButton();
            BtnNuevo = new MaterialSkin.Controls.MaterialButton();
            BtnEditar = new MaterialSkin.Controls.MaterialButton();
            btnEliminar = new MaterialSkin.Controls.MaterialButton();
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
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(255, 255, 255);
            panel2.Controls.Add(BtnAlta);
            panel2.Controls.Add(BtnNuevo);
            panel2.Controls.Add(BtnEditar);
            panel2.Controls.Add(btnEliminar);
            panel2.Controls.Add(lstClientes);
            panel2.Controls.Add(TxtBuscar);
            panel2.Controls.Add(LListado);
            panel2.Depth = 0;
            panel2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panel2.Location = new Point(4, 8);
            panel2.Margin = new Padding(12, 10, 12, 10);
            panel2.MouseState = MaterialSkin.MouseState.HOVER;
            panel2.Name = "panel2";
            panel2.Padding = new Padding(12, 10, 12, 10);
            panel2.Size = new Size(832, 411);
            panel2.TabIndex = 1;
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
            BtnAlta.Location = new Point(550, 55);
            BtnAlta.Margin = new Padding(4);
            BtnAlta.MouseState = MaterialSkin.MouseState.HOVER;
            BtnAlta.Name = "BtnAlta";
            BtnAlta.NoAccentTextColor = Color.Empty;
            BtnAlta.Size = new Size(112, 48);
            BtnAlta.TabIndex = 20;
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
            BtnNuevo.Location = new Point(16, 361);
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
            // BtnEditar
            // 
            BtnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnEditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnEditar.Depth = 0;
            BtnEditar.HighEmphasis = true;
            BtnEditar.Icon = null;
            BtnEditar.Location = new Point(155, 361);
            BtnEditar.Margin = new Padding(4);
            BtnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            BtnEditar.Name = "BtnEditar";
            BtnEditar.NoAccentTextColor = Color.Empty;
            BtnEditar.Size = new Size(133, 36);
            BtnEditar.TabIndex = 18;
            BtnEditar.Text = "Editar Cliente";
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
            btnEliminar.Location = new Point(670, 55);
            btnEliminar.Margin = new Padding(4);
            btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.NoAccentTextColor = Color.Empty;
            btnEliminar.Size = new Size(112, 48);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "DAR DE BAJA";
            btnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnEliminar.UseAccentColor = false;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lstClientes
            // 
            lstClientes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lstClientes.AutoSizeTable = false;
            lstClientes.BackColor = Color.FromArgb(255, 255, 255);
            lstClientes.BorderStyle = BorderStyle.None;
            lstClientes.Columns.AddRange(new ColumnHeader[] { ID, DNI, Apellido, Nombre, Teléfono, Email, Estado });
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
            lstClientes.Location = new Point(16, 109);
            lstClientes.Margin = new Padding(3, 2, 3, 2);
            lstClientes.MinimumSize = new Size(175, 75);
            lstClientes.MouseLocation = new Point(-1, -1);
            lstClientes.MouseState = MaterialSkin.MouseState.OUT;
            lstClientes.Name = "lstClientes";
            lstClientes.OwnerDraw = true;
            lstClientes.Size = new Size(766, 156);
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
            Teléfono.Width = 100;
            // 
            // Email
            // 
            Email.Text = "Email";
            Email.Width = 100;
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            Estado.Width = 100;
            // 
            // TxtBuscar
            // 
            TxtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtBuscar.AnimateReadOnly = false;
            TxtBuscar.BorderStyle = BorderStyle.None;
            TxtBuscar.Depth = 0;
            TxtBuscar.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtBuscar.Hint = "Buscar DNI";
            TxtBuscar.LeadingIcon = null;
            TxtBuscar.Location = new Point(16, 55);
            TxtBuscar.Margin = new Padding(3, 2, 3, 2);
            TxtBuscar.MaxLength = 50;
            TxtBuscar.MouseState = MaterialSkin.MouseState.OUT;
            TxtBuscar.Multiline = false;
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.Size = new Size(527, 50);
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
            // FormGestionClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 424);
            Controls.Add(panel2);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormGestionClientes";
            Padding = new Padding(3, 0, 3, 2);
            Sizable = false;
            Text = "Gestion de Cliente";
            Load += AdminGestionCliente_Load;
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
        private MaterialSkin.Controls.MaterialButton btnEliminar;
        private MaterialSkin.Controls.MaterialButton BtnEditar;
        private MaterialSkin.Controls.MaterialButton BtnNuevo;
        private ColumnHeader Estado;
        private MaterialSkin.Controls.MaterialButton BtnAlta;
    }
}