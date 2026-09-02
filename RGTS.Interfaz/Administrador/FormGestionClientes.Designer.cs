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
            panel1 = new Panel();
            btnLimpiar = new MaterialSkin.Controls.MaterialButton();
            btnGuardar = new MaterialSkin.Controls.MaterialButton();
            LNombre = new MaterialSkin.Controls.MaterialLabel();
            LDatos = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            LDni = new MaterialSkin.Controls.MaterialLabel();
            txtTelefono = new MaterialSkin.Controls.MaterialTextBox();
            txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            txtDni = new MaterialSkin.Controls.MaterialTextBox();
            txtApellido = new MaterialSkin.Controls.MaterialTextBox();
            txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            panel2 = new Panel();
            btnEliminar = new MaterialSkin.Controls.MaterialButton();
            lstClientes = new MaterialSkin.Controls.MaterialListView();
            ID = new ColumnHeader();
            DNI = new ColumnHeader();
            Apellido = new ColumnHeader();
            Nombre = new ColumnHeader();
            Teléfono = new ColumnHeader();
            Email = new ColumnHeader();
            TxtBuscar = new MaterialSkin.Controls.MaterialTextBox();
            LListado = new MaterialSkin.Controls.MaterialLabel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(LNombre);
            panel1.Controls.Add(LDatos);
            panel1.Controls.Add(materialLabel4);
            panel1.Controls.Add(materialLabel3);
            panel1.Controls.Add(materialLabel2);
            panel1.Controls.Add(LDni);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtDni);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(txtNombre);
            panel1.Location = new Point(32, 69);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(872, 229);
            panel1.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            btnLimpiar.AutoSize = false;
            btnLimpiar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLimpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLimpiar.Depth = 0;
            btnLimpiar.HighEmphasis = true;
            btnLimpiar.Icon = null;
            btnLimpiar.Location = new Point(593, 164);
            btnLimpiar.Margin = new Padding(4);
            btnLimpiar.MouseState = MaterialSkin.MouseState.HOVER;
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.NoAccentTextColor = Color.Empty;
            btnLimpiar.Size = new Size(100, 48);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnLimpiar.UseAccentColor = false;
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.AutoSize = false;
            btnGuardar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnGuardar.Depth = 0;
            btnGuardar.HighEmphasis = true;
            btnGuardar.Icon = null;
            btnGuardar.Location = new Point(716, 164);
            btnGuardar.Margin = new Padding(4);
            btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            btnGuardar.Name = "btnGuardar";
            btnGuardar.NoAccentTextColor = Color.Empty;
            btnGuardar.Size = new Size(100, 48);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGuardar.UseAccentColor = false;
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Depth = 0;
            LNombre.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LNombre.Location = new Point(38, 48);
            LNombre.MouseState = MaterialSkin.MouseState.HOVER;
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(61, 19);
            LNombre.TabIndex = 16;
            LNombre.Text = "Nombre:";
            // 
            // LDatos
            // 
            LDatos.AutoSize = true;
            LDatos.Depth = 0;
            LDatos.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LDatos.Location = new Point(0, 0);
            LDatos.MouseState = MaterialSkin.MouseState.HOVER;
            LDatos.Name = "LDatos";
            LDatos.Size = new Size(120, 19);
            LDatos.TabIndex = 15;
            LDatos.Text = "Datos del Cliente";
            LDatos.Click += materialLabel5_Click;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(519, 110);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(51, 19);
            materialLabel4.TabIndex = 14;
            materialLabel4.Text = "Correo:";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(38, 110);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(62, 19);
            materialLabel3.TabIndex = 13;
            materialLabel3.Text = "Apellido:";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(519, 48);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(68, 19);
            materialLabel2.TabIndex = 12;
            materialLabel2.Text = "Telefono:";
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Depth = 0;
            LDni.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LDni.Location = new Point(38, 173);
            LDni.MouseState = MaterialSkin.MouseState.HOVER;
            LDni.Name = "LDni";
            LDni.Size = new Size(31, 19);
            LDni.TabIndex = 11;
            LDni.Text = "DNI:";
            // 
            // txtTelefono
            // 
            txtTelefono.AnimateReadOnly = false;
            txtTelefono.BorderStyle = BorderStyle.None;
            txtTelefono.Depth = 0;
            txtTelefono.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTelefono.Hint = "Teléfono de contacto";
            txtTelefono.LeadingIcon = null;
            txtTelefono.Location = new Point(593, 34);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.MaxLength = 50;
            txtTelefono.MouseState = MaterialSkin.MouseState.OUT;
            txtTelefono.Multiline = false;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(223, 50);
            txtTelefono.TabIndex = 9;
            txtTelefono.Text = "";
            txtTelefono.TrailingIcon = null;
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.Hint = "Correo electrónico";
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(593, 99);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.MaxLength = 50;
            txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(223, 50);
            txtEmail.TabIndex = 10;
            txtEmail.Text = "";
            txtEmail.TrailingIcon = null;
            // 
            // txtDni
            // 
            txtDni.AnimateReadOnly = false;
            txtDni.BorderStyle = BorderStyle.None;
            txtDni.Depth = 0;
            txtDni.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDni.Hint = "DNI (Solo números)";
            txtDni.LeadingIcon = null;
            txtDni.Location = new Point(110, 164);
            txtDni.Margin = new Padding(3, 2, 3, 2);
            txtDni.MaxLength = 50;
            txtDni.MouseState = MaterialSkin.MouseState.OUT;
            txtDni.Multiline = false;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(223, 50);
            txtDni.TabIndex = 8;
            txtDni.Text = "";
            txtDni.TrailingIcon = null;
            // 
            // txtApellido
            // 
            txtApellido.AnimateReadOnly = false;
            txtApellido.BorderStyle = BorderStyle.None;
            txtApellido.Depth = 0;
            txtApellido.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtApellido.Hint = "Apellido";
            txtApellido.LeadingIcon = null;
            txtApellido.Location = new Point(110, 99);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.MaxLength = 50;
            txtApellido.MouseState = MaterialSkin.MouseState.OUT;
            txtApellido.Multiline = false;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(223, 50);
            txtApellido.TabIndex = 7;
            txtApellido.Text = "";
            txtApellido.TrailingIcon = null;
            // 
            // txtNombre
            // 
            txtNombre.AnimateReadOnly = false;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Depth = 0;
            txtNombre.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombre.Hint = "Nombre";
            txtNombre.LeadingIcon = null;
            txtNombre.Location = new Point(110, 34);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.MaxLength = 50;
            txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            txtNombre.Multiline = false;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(223, 50);
            txtNombre.TabIndex = 6;
            txtNombre.Text = "";
            txtNombre.TrailingIcon = null;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(btnEliminar);
            panel2.Controls.Add(lstClientes);
            panel2.Controls.Add(TxtBuscar);
            panel2.Controls.Add(LListado);
            panel2.Location = new Point(32, 313);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(872, 252);
            panel2.TabIndex = 1;
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
            btnEliminar.Location = new Point(704, 26);
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
            lstClientes.AutoSizeTable = false;
            lstClientes.BackColor = Color.FromArgb(255, 255, 255);
            lstClientes.BorderStyle = BorderStyle.None;
            lstClientes.Columns.AddRange(new ColumnHeader[] { ID, DNI, Apellido, Nombre, Teléfono, Email });
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
            lstClientes.Location = new Point(50, 80);
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
            // TxtBuscar
            // 
            TxtBuscar.AnimateReadOnly = false;
            TxtBuscar.BorderStyle = BorderStyle.None;
            TxtBuscar.Depth = 0;
            TxtBuscar.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtBuscar.Hint = "Buscar DNI";
            TxtBuscar.LeadingIcon = null;
            TxtBuscar.Location = new Point(50, 26);
            TxtBuscar.Margin = new Padding(3, 2, 3, 2);
            TxtBuscar.MaxLength = 50;
            TxtBuscar.MouseState = MaterialSkin.MouseState.OUT;
            TxtBuscar.Multiline = false;
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.Size = new Size(647, 50);
            TxtBuscar.TabIndex = 13;
            TxtBuscar.Text = "";
            TxtBuscar.TrailingIcon = null;
            // 
            // LListado
            // 
            LListado.AutoSize = true;
            LListado.Depth = 0;
            LListado.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LListado.Location = new Point(3, 0);
            LListado.MouseState = MaterialSkin.MouseState.HOVER;
            LListado.Name = "LListado";
            LListado.Size = new Size(139, 19);
            LListado.TabIndex = 15;
            LListado.Text = "Listado de Clientes ";
            // 
            // AdminGestionCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(942, 569);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminGestionCliente";
            Padding = new Padding(3, 48, 3, 2);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion de Cliente";
            Load += AdminGestionCliente_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MaterialSkin.Controls.MaterialLabel LUsuario;
        private MaterialSkin.Controls.MaterialLabel LNombre;
        private MaterialSkin.Controls.MaterialTextBox txtDni;
        private MaterialSkin.Controls.MaterialTextBox txtApellido;
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private MaterialSkin.Controls.MaterialTextBox txtTelefono;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel LDatos;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel LDni;
        private MaterialSkin.Controls.MaterialButton btnLimpiar;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private Panel panel2;
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
    }
}