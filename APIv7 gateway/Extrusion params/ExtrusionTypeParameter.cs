using Kompas6Constants3D;
using KompasAPI7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIv7_gateway.Extrusion_params.Types
{
    public class ExtrusionTypeParameter : IExtrusionParameter
    {
        public readonly ksEndTypeEnum EndType;

        public bool IsNormal { get; set; }

        public void AcceptParameter(IModelObject? modelObject)
        {
            if (!(modelObject is IExtrusion))
                throw new InvalidDataException();

            IExtrusion? extrusion = (IExtrusion)modelObject;

            extrusion.ExtrusionType[IsNormal] = EndType;
        }


        public ExtrusionTypeParameter(ksEndTypeEnum endType = ksEndTypeEnum.etBlind)
        {
            EndType = endType;
        }
    }
}
