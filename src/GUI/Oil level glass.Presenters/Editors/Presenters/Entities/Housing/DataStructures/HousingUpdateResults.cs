using Oil_level_glass.Presenters.Editors.EditorsData.BaseData;
using Shared.Results;

namespace Oil_level_glass.Presenters.Editors.Presenters.Entities.Housing.DataStructures
{
    public class HousingUpdateResults : UpdateDataResults
    {
        public required Result MainDiameter { get; set; }

        public required Result MainHeight { get; set; }
    }
}
