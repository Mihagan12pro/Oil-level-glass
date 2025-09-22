using APIv7_gateway.Enums;
using Kompas6Constants;
using Kompas6Constants3D;
using KompasAPI7;

namespace APIv7_gateway.Extrusion_params
{
    public class DistanceParameter : ExtrusionParameter
    {
        public bool IsNormal { get; set; } = true;

        private double _depth;
        public double Depth => _depth;

        private ksEndTypeEnum _endType;

        internal override void AcceptParameter(IModelObject? modelObject)
        {
            if (!(modelObject is IExtrusion))
                throw new InvalidDataException();

            IExtrusion? extrusion = (IExtrusion)modelObject;

            extrusion.Depth[IsNormal] = Depth;
            extrusion.ExtrusionType[IsNormal] = _endType;
        }


        public DistanceParameter(double depth)
        {
            _depth = depth;

            _endType = ksEndTypeEnum.etBlind;
        }


        public DistanceParameter(ExtrusionDistances distance)
        {
            switch(distance)
            {
                case ExtrusionDistances.throughAll:
                    _endType = ksEndTypeEnum.etThroughAll;
                    break;
            }
        }
    }
}
