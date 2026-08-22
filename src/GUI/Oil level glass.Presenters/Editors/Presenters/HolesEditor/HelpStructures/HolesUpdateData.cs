using Oil_level_glass.Presenters.Editors.EditorsData.BaseData;

namespace Oil_level_glass.Presenters.Editors.Presenters.HolesEditor.HelpStructures
{
    public class HolesUpdateData : UpdateDataPending
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
