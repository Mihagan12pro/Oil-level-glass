using APIv7_gateway;
using APIv7_gateway.DrawingObjects;
using APIv7_gateway.Gateways.Three_D;
using APIv7_gateway.Gateways.Two_D;
using APIv7_gateway.ModelObjects;
using Oil_level_glass_Core.Base;

namespace Oil_level_glass_Core
{
    public class DemoPart : BaseBuilder
    {
        public override void Build()
        {
            KompasPartGateway partGateway = new KompasPartGateway();

            SketchObject sketch1 = partGateway.CreateSketch(partGateway.Part.PlaneXOY);

            SketchEditor sketch1Editor = sketch1.SketchEditor;

            
        }


        public DemoPart()
        {
            
        }
    }
}
