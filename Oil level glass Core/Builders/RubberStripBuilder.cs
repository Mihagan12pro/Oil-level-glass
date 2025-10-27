using Oil_level_glass.Model.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass_Core.Builders
{
    public class RubberStripBuilder : BaseBuilder
    {
        public required RubberStripModel RubberStrip { get; set; }

        public override void Build()
        {
            throw new NotImplementedException();
        }

        public RubberStripBuilder(bool createNewDocument) : base(createNewDocument)
        {
            
        }
    }
}
