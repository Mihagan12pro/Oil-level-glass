using KompasAPI7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIv7_gateway.ModelObjects
{
    internal abstract record PlaneObjectBase : ModelObjectBase
    {
        public PlaneObjectBase(IModelContainer modelContainer) : base(modelContainer)
        {
        }
    }
}
