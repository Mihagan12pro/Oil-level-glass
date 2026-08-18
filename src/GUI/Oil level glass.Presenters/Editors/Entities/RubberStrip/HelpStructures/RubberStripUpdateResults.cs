using Oil_level_glass.Presenters.Editors.HelpStructures;
using Shared.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.Presenters.Editors.Entities.RubberStrip.HelpStructures
{
    public class RubberStripUpdateResults : UpdateResults
    {
        public required Result InternalDiameter { get; set; }


        public required Result Height { get; set; }
    }
}
