using Oil_level_glass.Presenters.Editors.HelpStructures;
using Shared.Results;

namespace Oil_level_glass.Presenters.Editors.HolesEditor.HelpStructures
{
    public class HolesUpdateResults : UpdateDataResults
    {
        public required Result Count { get; set; }

        public required Result Diameter { get; set; }
    }
}
