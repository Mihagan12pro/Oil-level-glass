using Model.Materials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.Model.Parts
{
    public class GlassModel : BaseDetailModel
    {
        public double ExternalDiameter { get; set; }

        public double Height { get; set; }

        public GlassModel()
        {
            Material = new Glass();

            Appereance.Transparency = 0;
        }
    }
}
