using Oil_level_glass.Presenters.Editors.EditorsData.BaseData;
using Shared.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.Presenters.Editors.Presenters.Entities.RubberStrip.HelpStructures
{
    public class RubberStripUpdateResults : UpdateDataResults
    {
        public required Result InternalDiameter { get; set; }


        public required Result Height { get; set; }
    }
}
