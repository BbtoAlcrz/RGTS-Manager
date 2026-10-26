namespace RGTS.Interfaz.Administrador
{
    partial class FormRespaldo
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
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            BtnRestaurar = new MaterialSkin.Controls.MaterialButton();
            LabelDescRestauracion = new MaterialSkin.Controls.MaterialLabel();
            LabelTituloRestauracion = new MaterialSkin.Controls.MaterialLabel();
            BtnBackup = new MaterialSkin.Controls.MaterialButton();
            LabelDescBackup = new MaterialSkin.Controls.MaterialLabel();
            LabelTituloBackup = new MaterialSkin.Controls.MaterialLabel();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(BtnRestaurar);
            materialCard1.Controls.Add(LabelDescRestauracion);
            materialCard1.Controls.Add(LabelTituloRestauracion);
            materialCard1.Controls.Add(BtnBackup);
            materialCard1.Controls.Add(LabelDescBackup);
            materialCard1.Controls.Add(LabelTituloBackup);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Fill;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(0, 0);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(1050, 450);
            materialCard1.TabIndex = 0;
            // 
            // BtnRestaurar
            // 
            BtnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnRestaurar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnRestaurar.Cursor = Cursors.Hand;
            BtnRestaurar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnRestaurar.Depth = 0;
            BtnRestaurar.HighEmphasis = true;
            BtnRestaurar.Icon = null;
            BtnRestaurar.Location = new Point(828, 123);
            BtnRestaurar.Margin = new Padding(4, 6, 4, 6);
            BtnRestaurar.MouseState = MaterialSkin.MouseState.HOVER;
            BtnRestaurar.Name = "BtnRestaurar";
            BtnRestaurar.NoAccentTextColor = Color.Empty;
            BtnRestaurar.Size = new Size(164, 36);
            BtnRestaurar.TabIndex = 11;
            BtnRestaurar.Text = "Restaurar backup";
            BtnRestaurar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            BtnRestaurar.UseAccentColor = false;
            BtnRestaurar.UseVisualStyleBackColor = true;
            BtnRestaurar.Click += BtnRestaurar_Click;
            // 
            // LabelDescRestauracion
            // 
            LabelDescRestauracion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LabelDescRestauracion.Depth = 0;
            LabelDescRestauracion.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelDescRestauracion.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            LabelDescRestauracion.Location = new Point(532, 60);
            LabelDescRestauracion.MouseState = MaterialSkin.MouseState.HOVER;
            LabelDescRestauracion.Name = "LabelDescRestauracion";
            LabelDescRestauracion.Size = new Size(460, 57);
            LabelDescRestauracion.TabIndex = 10;
            LabelDescRestauracion.Text = "Restaura la base de datos desde una copia previa (.bak). Atención: Esta acción sobrescribirá todos los registros actuales del sistema y reiniciará la aplicación.";
            // 
            // LabelTituloRestauracion
            // 
            LabelTituloRestauracion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LabelTituloRestauracion.AutoSize = true;
            LabelTituloRestauracion.Depth = 0;
            LabelTituloRestauracion.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LabelTituloRestauracion.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LabelTituloRestauracion.Location = new Point(532, 25);
            LabelTituloRestauracion.MouseState = MaterialSkin.MouseState.HOVER;
            LabelTituloRestauracion.Name = "LabelTituloRestauracion";
            LabelTituloRestauracion.Size = new Size(222, 24);
            LabelTituloRestauracion.TabIndex = 9;
            LabelTituloRestauracion.Text = "Restaurar Base de Datos";
            // 
            // BtnBackup
            // 
            BtnBackup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnBackup.Cursor = Cursors.Hand;
            BtnBackup.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnBackup.Depth = 0;
            BtnBackup.HighEmphasis = true;
            BtnBackup.Icon = null;
            BtnBackup.Location = new Point(339, 123);
            BtnBackup.Margin = new Padding(4, 6, 4, 6);
            BtnBackup.MouseState = MaterialSkin.MouseState.HOVER;
            BtnBackup.Name = "BtnBackup";
            BtnBackup.NoAccentTextColor = Color.Empty;
            BtnBackup.Size = new Size(147, 36);
            BtnBackup.TabIndex = 8;
            BtnBackup.Text = "Generar Backup";
            BtnBackup.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnBackup.UseAccentColor = false;
            BtnBackup.UseVisualStyleBackColor = true;
            BtnBackup.Click += BtnBackup_Click;
            // 
            // LabelDescBackup
            // 
            LabelDescBackup.Depth = 0;
            LabelDescBackup.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelDescBackup.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            LabelDescBackup.Location = new Point(17, 60);
            LabelDescBackup.MouseState = MaterialSkin.MouseState.HOVER;
            LabelDescBackup.Name = "LabelDescBackup";
            LabelDescBackup.Size = new Size(460, 57);
            LabelDescBackup.TabIndex = 7;
            LabelDescBackup.Text = "Genera una copia de seguridad en formato .bak con el estado actual de la base de datos de RGTS. Puede elegir la ruta de destino donde guardar la exportación";
            // 
            // LabelTituloBackup
            // 
            LabelTituloBackup.AutoSize = true;
            LabelTituloBackup.Depth = 0;
            LabelTituloBackup.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LabelTituloBackup.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LabelTituloBackup.Location = new Point(17, 25);
            LabelTituloBackup.MouseState = MaterialSkin.MouseState.HOVER;
            LabelTituloBackup.Name = "LabelTituloBackup";
            LabelTituloBackup.Size = new Size(254, 24);
            LabelTituloBackup.TabIndex = 6;
            LabelTituloBackup.Text = "Exportar Copia de Seguridad";
            // 
            // FormRespaldo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 450);
            Controls.Add(materialCard1);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "FormRespaldo";
            Padding = new Padding(0);
            Text = "FormRespaldo";
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton BtnRestaurar;
        private MaterialSkin.Controls.MaterialLabel LabelDescRestauracion;
        private MaterialSkin.Controls.MaterialLabel LabelTituloRestauracion;
        private MaterialSkin.Controls.MaterialButton BtnBackup;
        private MaterialSkin.Controls.MaterialLabel LabelDescBackup;
        private MaterialSkin.Controls.MaterialLabel LabelTituloBackup;
    }
}