using Oil_level_glass.Presenters.Editors.HelpStructures;

namespace Oil_level_glass.Presenters.Editors.Entities.Glass.HelpStructures
{

    public class GlassDefaultSizes : DefaultData
    {
        public readonly string Diameter = string.Empty;

        public readonly string Height = string.Empty;

        public GlassDefaultSizes(double diameter, double height)
        {
            if (diameter > 0)
                Diameter = diameter.ToString();

            if (height > 0)
                Height = height.ToString();
        }
    }
}