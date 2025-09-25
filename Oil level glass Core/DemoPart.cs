using APIv7_gateway;
using APIv7_gateway.DrawingObjects;
using APIv7_gateway.Gateways.Three_D;
using APIv7_gateway.ModelObjects;
using APIv7_gateway.ModelObjects.Extrusions;
using Oil_level_glass_Core.Base;

namespace Oil_level_glass_Core
{
    public class DemoPart : BaseBuilder
    {
        public override void Build()
        {
            KompasPartGateway partGateway = new KompasPartGateway();

            SketchObject sketch1 = partGateway.CreateSketch(partGateway.Part.PlaneXOY);
            sketch1.BeginEdit();

            CircleObject circleExternal = sketch1.AddCircle(100, 0, 0);

            CircleObject circleInternal = sketch1.AddCircle(200, 0, 0);

            sketch1.EndEdit();

            BossExtrusionObject bossExtrusion1 = partGateway.CreateExtrusion();
        }


        public DemoPart()
        {
            
        }
    }
}
