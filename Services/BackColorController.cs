using Oil_level_glass.BaseClasses;
using Oil_level_glass.Enums;
using System.ComponentModel;

namespace Oil_level_glass.Services
{
    internal static class BackColorController
    {
        public static Color ChangeBackColor(string prop, Dictionary<string, List<(string, InputError)>> errors)
        {
            Color backColor;

            if (errors.ContainsKey(prop))
            {
                backColor = Color.FromArgb(254, 210, 203);
            }
            else
            {
                backColor = Color.White;
            }

            return backColor;
        }
    }
}
