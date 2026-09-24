using System.Text.RegularExpressions;

namespace RGTS.LogicaNegocio.Validaciones
{
    public static class RegexValidaciones
    {
        public static readonly Regex SoloTexto = new Regex(
            @"^([A-Za-zÑñÁáÉéÍíÓóÚú]+[\s]*)+$", RegexOptions.Compiled
        );

        public static readonly Regex Dni = new Regex(
            @"^\d{7,8}$", RegexOptions.Compiled
        );

        public static readonly Regex Email = new Regex(
            @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
            RegexOptions.Compiled | RegexOptions.IgnoreCase
        );

        public static readonly Regex Telefono = new Regex(
            @"^\+?[\d\s-]{7,15}$",
            RegexOptions.Compiled
        );
    }
}
