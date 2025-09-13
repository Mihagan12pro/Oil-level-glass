using KompasAPI7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIv7_gateway.Extrusion_params
{
    public record DepthParameter : IExtrusionParameter
    {
        public bool IsNormal { get; set; } = true;

        public required double Depth { get; set; }

        public void AcceptParameter(IModelObject? modelObject)
        {
            if (!(modelObject is IExtrusion))
                throw new InvalidDataException();

            IExtrusion? extrusion = (IExtrusion)modelObject;

            extrusion.Depth[IsNormal] = Depth;
        }
    }
}
