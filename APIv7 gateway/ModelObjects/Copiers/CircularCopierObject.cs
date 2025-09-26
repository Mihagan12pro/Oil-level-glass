using KompasAPI7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIv7_gateway.ModelObjects.Copiers
{
    public class CircularCopierObject : CopierBase
    {
        private ICircularPattern _circularCopier;

        internal override IModelObject? ModelObject => throw new NotImplementedException();

        internal CircularCopierObject(ICircularPattern copier)
        {
            _circularCopier = copier;
        }
    }
}
