using Kompas6Constants3D;
using KompasAPI7;

namespace APIv7_gateway.Extrusion_params
{
    public class DirectionParameter : IExtrusionParameter
    {
        public readonly ksDirectionTypeEnum DirectionType;

        public bool IsNormal { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AcceptParameter(IModelObject? modelObject)
        {
            if (!(modelObject is IExtrusion))
                throw new InvalidDataException();

            IExtrusion? extrusion = (IExtrusion)modelObject;

            extrusion.Direction = DirectionType;
        }


        public DirectionParameter(ksDirectionTypeEnum direction = ksDirectionTypeEnum.dtBoth)
        {
            DirectionType = direction;
        }
    }
}
