using Kompas6Constants3D;
using KompasAPI7;

namespace APIv7_gateway.ModelObjects.Chamfers
{
    public class ChamferByAngleObject : ChamferObjectBase
    {
        public required double Angle { get => chamfer.Angle; set => chamfer.Angle = value; }

        internal ChamferByAngleObject(IChamfer chamfer) : base(chamfer)
        {
            chamfer.BuildingType = ksChamferBuildingTypeEnum.ksChamferSideAngle;
        }
    }
}
