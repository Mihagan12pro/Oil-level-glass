using Kompas6Constants3D;
using KompasAPI7;

namespace APIv7_gateway.Extrusion_params
{
    public abstract record DirectionParameter : IExtrusionParameter
    {
        public ksDirectionTypeEnum DirectionType { get; init; }

        public bool IsNormal { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AcceptParameter(IModelObject? modelObject)
        {
            if (!(modelObject is IExtrusion))
                throw new InvalidDataException();

            IExtrusion? extrusion = (IExtrusion)modelObject;

            extrusion.Direction = DirectionType;
        }
    }
}
