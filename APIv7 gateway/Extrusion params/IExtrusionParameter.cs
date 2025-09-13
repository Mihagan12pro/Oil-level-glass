using KompasAPI7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIv7_gateway.Extrusion_params
{
    public interface IExtrusionParameter
    {
        bool IsNormal { get; set; }

        void AcceptParameter(IModelObject? modelObject); 
    }
}
