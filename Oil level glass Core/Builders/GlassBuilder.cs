using Oil_level_glass.Model.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass_Core.Builders
{
    public class GlassBuilder : BaseBuilder
    {
        public required GlassModel Glass {get; set;}

        public override void Build()
        {
            throw new NotImplementedException();
        }
    }
}
