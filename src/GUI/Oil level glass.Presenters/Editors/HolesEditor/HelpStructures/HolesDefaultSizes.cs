using Oil_level_glass.Presenters.Editors.HelpStructures;

namespace Oil_level_glass.Presenters.Editors.HolesEditor.HelpStructures
{
    public class HolesDefaultSizes : DefaultSizes
    {
        public readonly string HolesCount = "3";

        public readonly string Diameter = string.Empty;

        public HolesDefaultSizes(
            double diameter, 
            int holesCount)
        {
            if (diameter > 0)
                Diameter = diameter.ToString();

            if (holesCount > 3)
                HolesCount = holesCount.ToString();
        }
    }
}
