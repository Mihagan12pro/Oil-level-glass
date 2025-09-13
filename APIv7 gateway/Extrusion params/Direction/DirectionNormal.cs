using Kompas6Constants3D;

namespace APIv7_gateway.Extrusion_params.Direction
{
    public sealed record DirectionNormal : DirectionParameter
    {
        public DirectionNormal()
        {
            DirectionType = ksDirectionTypeEnum.dtNormal;
        }
    }
}
