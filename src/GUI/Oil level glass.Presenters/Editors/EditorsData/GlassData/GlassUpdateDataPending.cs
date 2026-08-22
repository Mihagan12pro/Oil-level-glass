using Oil_level_glass.Presenters.Editors.EditorsData.BaseData;

namespace Oil_level_glass.Presenters.Editors.EditorsData.GlassData
{
    public class GlassUpdateDataPending : UpdateDataPending
    {
        public readonly string Height;
        public readonly string Diameter;

        public GlassUpdateDataPending(
            string height,
            string diameter)
        {
            Height = height;

            Diameter = diameter;
        }
    }
}
