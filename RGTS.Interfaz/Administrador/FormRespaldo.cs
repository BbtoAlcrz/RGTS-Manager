using MaterialSkin.Controls;
using RGTS.LogicaNegocio.Servicios;
using System;

namespace RGTS.Interfaz.Administrador
{
    public partial class FormRespaldo : MaterialForm
    {
        private readonly BackupServicio _backupServicio;
        public FormRespaldo()
        {
            _backupServicio = new BackupServicio();
            InitializeComponent();

        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            using var dialogo = new SaveFileDialog
            {
                Filter = "Backup de SQL Server (*.bak)|*.bak",
                FileName = _backupServicio.NombreSugerido()
            };

            if (dialogo.ShowDialog() != DialogResult.OK) return;

            try
            {
                Cursor = Cursors.WaitCursor;
                _backupServicio.ExportarBackup(FormPrincipal.UsuarioSesion, dialogo.FileName);
                MessageBox.Show("Backup generado correctamente.", "Copia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo generar el backup: {ex.Message}", "Error de Backup", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }

        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            using var dialogo = new OpenFileDialog { Filter = "Backup de SQL Server (*.bak)|*.bak" };
            if (dialogo.ShowDialog() != DialogResult.OK) return;

            try
            {
                // Valida el archivo y extrae la fecha
                Cursor = Cursors.WaitCursor;
                DateTime fecha = _backupServicio.ValidarArchivoParaRestaurar(FormPrincipal.UsuarioSesion, dialogo.FileName);
                Cursor = Cursors.Default;

                // Cuadro modal de confirmación con contraseña
                string? contrasena = null;
                using (var form = new Form
                {
                    Text = "Confirmar Restauración de Base de Datos",
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    StartPosition = FormStartPosition.CenterParent,
                    MaximizeBox = false,
                    MinimizeBox = false,
                    ClientSize = new Size(420, 210)
                })
                {
                    var lblAviso = new Label
                    {
                        Text = $"Backup seleccionado: {Path.GetFileName(dialogo.FileName)}\n" +
                               $"Fecha de creación: {fecha:dd/MM/yyyy HH:mm}\n\n" +
                               "ATENCIÓN: Se reemplazarán TODOS los datos actuales. Los cambios posteriores a este backup se perderán de forma permanente.",
                        Left = 15,
                        Top = 15,
                        Width = 390,
                        Height = 90,
                        ForeColor = Color.DarkRed
                    };
                    var lblClave = new Label { Text = "Ingrese su contraseña de Administrador para confirmar:", Left = 15, Top = 115, Width = 390 };
                    var txtClave = new TextBox { Left = 15, Top = 138, Width = 390, UseSystemPasswordChar = true };
                    var btnOk = new Button { Text = "Restaurar", Left = 225, Top = 170, Width = 85, Enabled = false, DialogResult = DialogResult.OK };
                    var btnCancelar = new Button { Text = "Cancelar", Left = 320, Top = 170, Width = 85, DialogResult = DialogResult.Cancel };

                    txtClave.TextChanged += (_, _) => btnOk.Enabled = txtClave.Text.Trim().Length > 0;

                    form.Controls.AddRange(new Control[] { lblAviso, lblClave, txtClave, btnOk, btnCancelar });
                    form.AcceptButton = btnOk;
                    form.CancelButton = btnCancelar;

                    if (form.ShowDialog(this) == DialogResult.OK)
                        contrasena = txtClave.Text;
                }

                if (string.IsNullOrWhiteSpace(contrasena)) return; // Operación cancelada por el usuario

                // Ejecución de la restauración de la BD
                Cursor = Cursors.WaitCursor;
                string respaldoSeguridad = _backupServicio.RestaurarBackup(FormPrincipal.UsuarioSesion, dialogo.FileName, contrasena);

                MessageBox.Show($"Base de datos restaurada correctamente.\nSe generó un respaldo previo de seguridad en:\n{respaldoSeguridad}\n\nLa aplicación se reiniciará automáticamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Application.Restart();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al Restaurar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}
