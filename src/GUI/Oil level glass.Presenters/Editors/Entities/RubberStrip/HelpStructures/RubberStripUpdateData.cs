using Oil_level_glass.Presenters.Editors.HelpStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.Presenters.Editors.Entities.RubberStrip.HelpStructures
{
    public class RubberStripUpdateData : UpdateData
    {
        public readonly string Height;
        public readonly string InternalDiameter;

        public RubberStripUpdateData(
            string height,
            string internalDiameter)
        {
            Height = height;

            InternalDiameter = internalDiameter;
        }
    }
}
