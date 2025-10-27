using KompasAPI7;
using Oil_level_glass.Model.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass_Core.Builders
{
    public class HousingBuilder : BaseBuilder
    {
        public IPart7 Part { get; }

        public override void Build()
        {
            throw new NotImplementedException();
        }

        public required HousingModel Housing { get;set; }


        public HousingBuilder(bool createNewDocument): base(createNewDocument)
        {
            
        }
    }
}
