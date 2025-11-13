using Model.Materials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.Model.Entities.Parts.Classic
{
    public class GlassModel : BaseDetailModel
    {
        public double ExternalDiameter { get; set; }

        public double Height { get; set; }

        public GlassModel()
        {
            Material = new Glass();

            Appereance.Transparency = 0.74;
            Appereance.Ambient = 0.5;
            Appereance.Diffuse = 0.6;
            Appereance.Specularity = 0.8;
            Appereance.Shininess = 0.8;
            Appereance.Emission = 0.5;
        }
    }
}
