using Oil_level_glass.Presenters.Editors.EditorsData.BaseData;

namespace Oil_level_glass.Presenters.Editors.Presenters.Entities.Housing.DataStructures
{
    public class HousingUpdateData : UpdateDataPending
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
