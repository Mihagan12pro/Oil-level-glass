using Oil_level_glass.Presenters.Editors.EditorsData.BaseData;

namespace Oil_level_glass.Presenters.Editors.EditorsData.GlassData
{

    public class GlassDefaultDataValues : DefaultDataValues
    {
        public readonly string Diameter = string.Empty;

        public readonly string Height = string.Empty;

        public GlassDefaultDataValues(double diameter, double height)
        {
            if (diameter > 0)
                Diameter = diameter.ToString();

            if (height > 0)
                Height = height.ToString();
        }
    }
}