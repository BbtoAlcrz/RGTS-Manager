using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace RGTS.LogicaNegocio.Servicios
{
    public class ManualUsuarioServicio
    {
        public void AbrirManualPorVistaActiva(Control? vistaRaiz)
        {
            if (vistaRaiz == null)
            {
                AbrirPdfEnSeccion(3);
                return;
            }

            // Determina el nombre real de la vista activa considerando subformularios
            string nombreVistaFinal = ResolverNombreVistaReal(vistaRaiz);

            // Mapear el nombre de la vista con el número de página que le corresponde en el manual
            int numeroPagina = MapearVistaAPagina(nombreVistaFinal);

            // Abre el pdf
            AbrirPdfEnSeccion(numeroPagina);
        }

        private string ResolverNombreVistaReal(Control vistaRaiz)
        {
            // Busca si existe algún subformulario incrustado y visible dentro del árbol de controles
            Form? subFormularioIncrustado = BuscarSubFormularioIncrustado(vistaRaiz);

            if (subFormularioIncrustado != null)
            {
                return subFormularioIncrustado.GetType().Name;
            }

            // Si no hay subformulario, retorna el nombre de la vista principal
            return vistaRaiz.GetType().Name;
        }

        private Form? BuscarSubFormularioIncrustado(Control padre)
        {
            foreach (Control control in padre.Controls)
            {
                // Si encontramos un control de tipo Form que esté visible en pantalla
                if (control is Form formHijo && formHijo.Visible)
                {
                    return formHijo;
                }

                // Búsqueda recursiva en profundidad dentro de paneles o contenedores
                if (control.HasChildren)
                {
                    Form? resultado = BuscarSubFormularioIncrustado(control);
                    if (resultado != null) return resultado;
                }
            }

            return null;
        }

        private int MapearVistaAPagina(string nombreVista)
        {
            return nombreVista switch
            {
                "FormListadoUsuarios" => 6,
                "FormAltaEdicionUsuario" => 7,

                "FormListadoProductos" => 9,
                "FormAltaEdicionProducto" => 10,
                "FormListadoCategorias" => 12,
                "FormAltaEdicionCategoria" => 13,

                "FormListadoProveedores" => 15,
                "FormAltaEdicionProveedor" => 16,
                "FormDetalleProveedor" => 18,

                "FormListadoClientes" => 19,
                "FormAltaEdicionClientes" => 20,

                "FormListadoVentas" => 22,
                "FormDetalleVenta" => 23,
                "FormNuevaVenta" => 24,

                "FormListadoCompras" => 26,
                "FormDetalleCompra" => 27,
                "FormNuevaCompra" => 28,

                "FormReportes" => 29,
                "FormRespaldo" => 32,
                _ => 3
            };
        }

        private void AbrirPdfEnSeccion(int numeroPagina)
        {
            string rutaPdf = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Recursos",
                "Manual_de_Usuario_RGTS-Manager.pdf"
            );

            if (!File.Exists(rutaPdf))
            {
                throw new FileNotFoundException(
                    $"No se encontró el manual de usuario en:\n{rutaPdf}"
                );
            }

            try
            {
                string urlConPagina = $"{new Uri(rutaPdf).AbsoluteUri}#page={numeroPagina}";

                Process.Start(new ProcessStartInfo
                {
                    FileName = "msedge.exe",
                    Arguments = $"\"{urlConPagina}\"",
                    UseShellExecute = true
                });
            }
            catch
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = rutaPdf,
                    UseShellExecute = true
                });
            }
        }
    }
}