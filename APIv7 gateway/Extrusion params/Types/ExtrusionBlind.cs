using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIv7_gateway.Extrusion_params.Types
{
    public sealed record ExtrusionBlind : ExtrusionTypeParameter
    {
        public ExtrusionBlind()
        {
            EndType = Kompas6Constants3D.ksEndTypeEnum.etBlind;
        }
    }
}
