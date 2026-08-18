using Oil_level_glass.Presenters.Editors.HelpStructures;

namespace Oil_level_glass.Presenters.Editors.Entities.Housing.DataStructures
{
    public class HousingUpdateData : UpdateData
    {
        public readonly string MainDiameter;

        public readonly string MainHeight;

        public HousingUpdateData(
            string mainDiameter, 
            string mainHeight)
        {
            MainDiameter = mainDiameter;

            MainHeight = mainHeight;
        }
    }
}
