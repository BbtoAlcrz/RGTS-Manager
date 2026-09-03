namespace RGTS.Interfaz
{
    partial class FormPrincipal
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
            PnlMenu = new Panel();
            PnlContenedor = new Panel();
            SuspendLayout();
            // 
            // PnlMenu
            // 
            PnlMenu.Dock = DockStyle.Left;
            PnlMenu.Location = new Point(3, 64);
            PnlMenu.Name = "PnlMenu";
            PnlMenu.Size = new Size(200, 453);
            PnlMenu.TabIndex = 0;
            // 
            // PnlContenedor
            // 
            PnlContenedor.Dock = DockStyle.Fill;
            PnlContenedor.Location = new Point(203, 64);
            PnlContenedor.Name = "PnlContenedor";
            PnlContenedor.Size = new Size(744, 453);
            PnlContenedor.TabIndex = 1;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 520);
            Controls.Add(PnlContenedor);
            Controls.Add(PnlMenu);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            FormClosed += FormPrincipal_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlMenu;
        private Panel PnlContenedor;
    }
}