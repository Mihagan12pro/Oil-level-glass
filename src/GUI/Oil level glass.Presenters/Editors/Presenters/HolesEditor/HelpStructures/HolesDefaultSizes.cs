using Oil_level_glass.Presenters.Editors.EditorsData.BaseData;

namespace Oil_level_glass.Presenters.Editors.Presenters.HolesEditor.HelpStructures
{
    public class HolesDefaultSizes : DefaultDataValues
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
