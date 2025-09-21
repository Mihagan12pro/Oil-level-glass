using APIv7_gateway.Gateways.Three_D;
using Oil_level_glass_Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass_Core
{
    public class DemoPart : BaseBuilder
    {
        public override void Build()
        {
            KompasPartGateway = new KompasPartGateway();
        }


        public DemoPart()
        {
            
        }
    }
}
