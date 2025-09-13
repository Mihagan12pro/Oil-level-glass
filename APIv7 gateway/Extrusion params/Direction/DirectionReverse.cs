using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIv7_gateway.Extrusion_params.Direction
{
    public sealed record DirectionReverse : DirectionParameter
    {
        public DirectionReverse()
        {
            DirectionType = Kompas6Constants3D.ksDirectionTypeEnum.dtReverse;
        }
    }
}
