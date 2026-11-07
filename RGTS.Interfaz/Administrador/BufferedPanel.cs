namespace RGTS.Interfaz.Administrador
{
    /// <summary>
    /// Panel con doble buffer para evitar el flicker al scrollear o redimensionar
    /// los paneles de métricas de FormReportes.
    /// </summary>
    public class BufferedPanel : Panel
    {
        public BufferedPanel()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
        }
    }
}
