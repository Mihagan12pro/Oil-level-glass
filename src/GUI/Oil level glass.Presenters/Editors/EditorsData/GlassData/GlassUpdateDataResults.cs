using Oil_level_glass.Presenters.Editors.EditorsData.BaseData;
using Shared.Results;

namespace Oil_level_glass.Presenters.Editors.EditorsData.GlassData
{
    public class GlassUpdateDataResults : UpdateDataResults
    {
        public required Result Diameter { get; set; }

        public required Result Height { get; set; }
    }
}