using APIv7_gateway.DrawingObjects;
using APIv7_gateway.Enums;
using APIv7_gateway.Extrusion_params;
using APIv7_gateway.Gateways.Three_D;
using APIv7_gateway.ModelObjects;
using APIv7_gateway.ModelObjects.Copiers;
using APIv7_gateway.ModelObjects.Extrusions;
using APIv7_gateway.ModelObjects.Holes;
using Oil_level_glass_Core.Base;

namespace Oil_level_glass_Core
{
    public class DemoPart : BaseBuilder
    {
        public override void Build()
        {
            KompasDetailGateway partGateway = new KompasDetailGateway();

            SketchObject sketch1 = partGateway.CreateSketch(partGateway.Part.PlaneXOY);
            sketch1.BeginEdit();

            CircleObject circleExternal = sketch1.AddCircle(100, 0, 0);

            CircleObject circleInternal = sketch1.AddCircle(200, 0, 0);

            sketch1.EndEdit();

            BossExtrusionObject bossExtrusion1 = partGateway.CreateExtrusion(sketch1, new DistanceParameter(20), new DirectionParameter());
            bossExtrusion1.Update();

            EdgeObject edge = partGateway.Part.GetEdgeByPoint(100, 0, 10);

            ChamferObject chamfer1 = partGateway.CreateChamfer(3, ChamferType.ByAngleAndSide, new EdgeObject[] { edge });
            chamfer1.Angle = 60;
            chamfer1.Update();

            FaceObject face = partGateway.Part.GetFaceByPoint(FaceTypes.Planar, 97, 0, 10);

            SketchObject sketch2 = partGateway.CreateSketch(face);

            PointObject point = sketch2.AddPoint(70, 0);

            sketch2.EndEdit();

            HoleObject hole = partGateway.CreateHole(partGateway.Part.GetVertexByPoint(70, 0, 10), face);

            hole.DepthType = HoleDepthType.ThroughAll;
            hole.Diameter = 20;

            ThreadObject thread = hole.ThreadObject;
            thread.Pitch = 1.75;
            thread.IsAutoDiameter = true;
            thread.IsAutoLength = true;

            hole.ShowThread = true;
            hole.Update();


            CircularCopierObject circularCopier = partGateway.CreateCircularCopier(partGateway.Part.AxisOZ, new ModelObjectBase[] { hole});
            circularCopier.RingCount = 6;
            circularCopier.Update();
        }


        public DemoPart()
        {
            
        }
    }
}
