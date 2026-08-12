using Oil_level_glass.Presenters.Editors.HelpStructures;
using Shared.Results;

namespace Oil_level_glass.Presenters.Editors.Entities.Glass.HelpStructures
{
    public class GlassUpdateResults : UpdateResults
    {
        public required Result Diameter { get; set; }

        public required Result Height { get; set; }
    }
}