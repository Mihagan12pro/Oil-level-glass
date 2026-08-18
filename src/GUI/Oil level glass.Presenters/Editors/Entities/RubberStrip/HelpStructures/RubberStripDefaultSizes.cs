using Oil_level_glass.Presenters.Editors.HelpStructures;

namespace Oil_level_glass.Presenters.Editors.Entities.RubberStrip.HelpStructures
{
    public class RubberStripDefaultSizes : DefaultSizes
    {
        public readonly string Height = string.Empty;
        public readonly string ExternalDiameter = string.Empty;
        public readonly string InternalDiameter = string.Empty;

        public RubberStripDefaultSizes(
            double height, 
            double externalDiameter,
            double internalDiameter)
        {
            if (height > 0)
                Height = height.ToString();

            if (externalDiameter > 0)
                ExternalDiameter = externalDiameter.ToString();

            if (internalDiameter > 0)
                InternalDiameter = internalDiameter.ToString();
        }
    }
}
