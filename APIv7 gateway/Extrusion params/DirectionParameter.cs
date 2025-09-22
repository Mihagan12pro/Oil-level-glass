using APIv7_gateway.Enums;
using Kompas6Constants3D;
using KompasAPI7;

namespace APIv7_gateway.Extrusion_params
{
    public class DirectionParameter : ExtrusionParameter
    {
        private readonly ksDirectionTypeEnum _directionType;

        public bool IsNormal { get; set; }

        internal override void AcceptParameter(IModelObject? modelObject)
        {
            if (!(modelObject is IExtrusion))
                throw new InvalidDataException();

            IExtrusion? extrusion = (IExtrusion)modelObject;

            extrusion.Direction = _directionType;
        }


        public DirectionParameter(ExtrusionDirections direction = ExtrusionDirections.MiddlePlane)
        {
            switch(direction)
            {
                case ExtrusionDirections.Normal:
                    _directionType = ksDirectionTypeEnum.dtNormal;
                    break;
                case ExtrusionDirections.MiddlePlane:
                    _directionType = ksDirectionTypeEnum.dtMiddlePlane;
                    break;
                case ExtrusionDirections.Reverse:
                    _directionType = ksDirectionTypeEnum.dtReverse;
                    break;
            }
        }
    }
}
