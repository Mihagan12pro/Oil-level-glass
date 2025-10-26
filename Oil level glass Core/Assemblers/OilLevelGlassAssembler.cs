using Oil_level_glass.Model;
using Oil_level_glass.Model.Parts;
using Oil_level_glass_Core.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass_Core.Assemblers
{
    public class OilLevelGlassAssembler : BaseAssembler
    {
        public override void Assemble()
        {
            throw new NotImplementedException();
        }

        public required GlassBuilder GlassBuilder { get; set; }

        public required RubberStripBuilder RubberStripBuilder { get; set; }

        public required HousingBuilder HousingBuilder { get;set;}
    }
}
