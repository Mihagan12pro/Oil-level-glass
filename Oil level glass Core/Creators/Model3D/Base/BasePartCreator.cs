using APIv7_gateway.Gateways.Three_D;
using APIv7_gateway.Gateways.Two_D;
using Oil_level_glass_Core.Data.ModelProperties.Properties3D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass_Core.Creators.Model3D.Base
{
    public abstract record BasePartCreator : Base3DCreator
    {
        public KompasPartGateway KompasPartGateway { get; protected set; }

        protected Geometry2DGateway geometry2DGateway;

        public BasePartCreator()
        {
            Properties = new ModelPartProperties();
        }
    }
}
