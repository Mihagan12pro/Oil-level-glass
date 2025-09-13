using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIv7_gateway.Extrusion_params.Direction
{
    public sealed record DirectionMiddle : DirectionParameter
    {
        public DirectionMiddle()
        {
            DirectionType = Kompas6Constants3D.ksDirectionTypeEnum.dtMiddlePlane;
        }
    }
}
