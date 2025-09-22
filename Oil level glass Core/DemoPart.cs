using APIv7_gateway.DrawingObjects;
using APIv7_gateway.Gateways.Three_D;
using APIv7_gateway.Gateways.Two_D;
using APIv7_gateway.ModelObjects;
using KompasAPI7;
using Oil_level_glass_Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Oil_level_glass_Core
{
    public class DemoPart : BaseBuilder
    {
        public override void Build()
        {
            KompasPartGateway = new KompasPartGateway();

            SketchObject _sketch1 = KompasPartGateway.CreateSketch(KompasPartGateway.PlaneXOY);
        }


        public DemoPart()
        {
            
        }
    }
}
