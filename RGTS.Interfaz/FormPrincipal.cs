using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MaterialSkin.Controls;
using RGTS.Entidades;


namespace RGTS.Interfaz
{
    public partial class FormPrincipal : MaterialForm
    {
        public static Usuario? UsuarioSesion { get; private set; }

        public FormPrincipal()
        {
            InitializeComponent();
        }

        public FormPrincipal(Usuario usuario) : this()
        {
            UsuarioSesion = usuario;

            // Aquí puedes configurar títulos o personalizar las pestañas según su Rol
            this.Text = $"RGTS Manager - {UsuarioSesion.NombreCompleto} ({UsuarioSesion.Rol?.NombreRol})";

            ConfigurarPermisosSegunRol(UsuarioSesion.Rol?.NombreRol);
        }

        private void ConfigurarPermisosSegunRol(string? nombreRol)
        {
            switch (nombreRol)
            {
                case "Administrador":
                    // Acceso a todo
                    break;
                case "Vendedor":
                    // Ocultar pestañas/botones de Compras, Usuarios, etc.
                    break;
                case "Encargado de Deposito":
                    // Ocultar ventas y clientes
                    break;
            }
        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
