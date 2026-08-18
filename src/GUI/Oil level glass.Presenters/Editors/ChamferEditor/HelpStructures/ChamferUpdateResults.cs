using Oil_level_glass.Presenters.Editors.HelpStructures;
using Shared.Results;

namespace Oil_level_glass.Presenters.Editors.ChamferEditor.HelpStructures
{
    public class ChamferUpdateResults : UpdateResults
    {
        /// <summary>
        /// Always Side1
        /// </summary>
        public required Result FirstParam { get; set; }

        /// <summary>
        /// Can be Side2 or Angle
        /// </summary>
        public required Result SecondParam { get; set; }

        /// <summary>
        /// Can be Side2 or Angle
        /// </summary>
        public required string ThrirdParam { get; set; }
    }
}
