using APIv7_gateway.Gateways.Three_D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass_Core.Base
{
    public abstract class BaseBuilder
    {
        public KompasDetailGateway ?KompasPartGateway { get; protected set; }

        public abstract void Build();
    }
}
