using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.Model.Parts
{
    public class OilLevelGlassModel : BaseEntityModel
    {
        public required HousingModel HousingModel { get; set; }

        public required GlassModel GlassModel { get; set; }

        public required RubberStripModel RubberStripModel { get; set; }


        public OilLevelGlassModel()
        {
            File = new Oil_level_glass.Model.KompasFile.AssemblyFile();
        }
    }
}
