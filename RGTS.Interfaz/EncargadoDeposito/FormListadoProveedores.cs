using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RGTS.Entidades;
using RGTS.LogicaNegocio;

namespace RGTS.Interfaz.EncargadoDeposito
{
    public partial class FormListadoProveedores : MaterialForm
    {
        public FormListadoProveedores()
        {
            InitializeComponent();
        }

        private void BtnAgregarProveedor_Click(object sender, EventArgs e)
        {
            using (var form = new FormAgregarProveedor())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //
                }
            }
        }

        private void BtnEditarProveedor_Click(object sender, EventArgs e)
        {
            
            using (var form = new FormAgregarProveedor())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //
                }
            }
        }
    }
}
