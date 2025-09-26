using APIv7_gateway.Enums;
using KompasAPI7;

namespace APIv7_gateway.ModelObjects.Holes
{
    public class HoleObject : ModelObjectBase
    {
        protected readonly IHole3D hole;

        private readonly IHoleDisposal _holeDisposal;

        internal override IModelObject ModelObject => hole;

        public ThreadObject ThreadObject => new ThreadObject(hole.Thread) { Pitch = 0, Diameter = 0};

        public bool ShowThread 
        {
            get => hole.ShowThread; 

            set => hole.ShowThread = value; 
        }


        public double Diameter 
        {
            get => hole.Diameter; 

            set => hole.Diameter = value;
        }


        public double Depth
        {
            get => hole.Depth;

            set => hole.Depth = value;
        }


        public HoleDepthType DepthType
        {
            set
            {
                switch(value)
                {
                    case HoleDepthType.Blind:
                        hole.DepthType = Kompas6Constants3D.ksDepthTypeEnum.ksDTValue;
                        break;

                    case HoleDepthType.ThroughAll:
                        hole.DepthType = Kompas6Constants3D.ksDepthTypeEnum.ksDTReachThrough;
                        break;

                    default:
                        hole.DepthType = Kompas6Constants3D.ksDepthTypeEnum.ksDTObject;
                        break;
                }
            }
        }


        public required FaceObject Face
        {
            get
            {
                return new FaceObject((IFace)_holeDisposal.BaseSurface);
            }
            set
            {
                _holeDisposal.BaseSurface = value.ModelObject;
            }
        }


        public required VertexObject Vertex
        {
            get
            {
                return new VertexObject((IVertex)_holeDisposal.AssociationVertex);
            }
            set
            {
                _holeDisposal.AssociationVertex = value.ModelObject;
            }
        }


        internal HoleObject(IHole3D hole)
        {
            this.hole = hole;

            DepthType = HoleDepthType.Blind;

            _holeDisposal = (IHoleDisposal)hole;
        }
    }
}
