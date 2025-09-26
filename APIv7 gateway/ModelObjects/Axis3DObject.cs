using KompasAPI7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIv7_gateway.ModelObjects
{
    public class Axis3DObject : ModelObjectBase
    {
        private readonly IAxis3D _axis;

        internal override IModelObject? ModelObject => _axis;

        internal Axis3DObject(IAxis3D axis3D)
        {
            _axis = axis3D;
        }
    }
}
