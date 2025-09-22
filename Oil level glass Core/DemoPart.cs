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
            KompasPartGateway = new KompasPartGateway();

            SketchObject _sketch1 = KompasPartGateway.CreateSketch(KompasPartGateway.PlaneXOY);

            SketchEditor sketchEditor = _sketch1.SketchEditor;

            Geometry2DGateway geometry2DGateway = new Geometry2DGateway(sketchEditor);

            CircleObject circleObject = geometry2DGateway.AddCircle(100, 0, 0);
            circleObject.Update();

            CircleObject circleObject2 = geometry2DGateway.AddCircle(200, 0, 0);
            circleObject2.Update();

            sketchEditor.EndEdit();
        }


        public DemoPart()
        {
            
        }
    }
}
