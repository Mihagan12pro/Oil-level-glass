using Oil_level_glass.Presenters.Editors.HelpStructures;

namespace Oil_level_glass.Presenters.Editors.HolesEditor.HelpStructures
{
    public class HolesUpdateData : UpdateData
    {
        public readonly string Diameter;

        public readonly string Count;

        public HolesUpdateData(
            string diameter,
            string count)
        {
            Diameter = diameter;

            Count = count;
        }
    }
}
