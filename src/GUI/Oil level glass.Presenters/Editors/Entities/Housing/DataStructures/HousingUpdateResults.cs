using Oil_level_glass.Presenters.Editors.HelpStructures;
using Shared.Results;

namespace Oil_level_glass.Presenters.Editors.Entities.Housing.DataStructures
{
    public class HousingUpdateResults : UpdateDataResults
    {
        public required Result MainDiameter { get; set; }

        public required Result MainHeight { get; set; }
    }
}
