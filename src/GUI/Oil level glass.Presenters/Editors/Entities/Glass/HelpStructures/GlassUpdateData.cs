using Oil_level_glass.Presenters.Editors.HelpStructures;

namespace Oil_level_glass.Presenters.Editors.Entities.Glass.HelpStructures
{
    public class GlassUpdateData : UpdateData
    {
        public readonly string Height;
        public readonly string Diameter;

        public GlassUpdateData(
            string height,
            string diameter)
        {
            Height = height;

            Diameter = diameter;
        }
    }
}
