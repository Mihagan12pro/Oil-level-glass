using Oil_level_glass.Presenters.Editors.EditorsData.BaseData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.Presenters.Editors.Presenters.Entities.RubberStrip.HelpStructures
{
    public class RubberStripUpdateData : UpdateDataPending
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
