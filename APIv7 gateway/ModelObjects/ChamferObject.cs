using APIv7_gateway.Enums;
using KompasAPI7;

namespace APIv7_gateway.ModelObjects
{
    public class ChamferObject : ModelObjectBase
    {
        private IChamfer _chamfer;

        internal override IModelObject? ModelObject => _chamfer;

        public required double FirstSide { get => _chamfer.Distance1; set => _chamfer.Distance1 = value; }

        public required ChamferType ChamferType
        {
            set
            {
                switch(value)
                {
                    case ChamferType.ByAngleAndSide:
                        _chamfer.BuildingType = Kompas6Constants3D.ksChamferBuildingTypeEnum.ksChamferSideAngle;
                        break;

                    default:
                        _chamfer.BuildingType = Kompas6Constants3D.ksChamferBuildingTypeEnum.ksChamferTwoSides;
                        break;
                }

            }
        }

        public double SecondSide { get => _chamfer.Distance2; set => _chamfer.Distance2 = value; }

        public double Angle { get => _chamfer.Angle; set => _chamfer.Angle = value; }

        public required EdgeObject[] Edges
        {
            set
            {
                IEdge[] edges = new IEdge[value.Length];

                for(int i = 0; i < value.Length; i++)
                {
                    object ?obj = value[i].ModelObject;
                    if (obj == null)
                        throw new NullReferenceException();

                    edges[i] = (IEdge)obj;
                }

                _chamfer.BaseObjects = edges;
            }
        }

        internal ChamferObject(IChamfer chamfer)
        {
            _chamfer = chamfer;
        }
    }
}
