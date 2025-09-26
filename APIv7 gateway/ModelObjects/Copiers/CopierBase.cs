using KompasAPI7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIv7_gateway.ModelObjects.Copiers
{
    public abstract class CopierBase : ModelObjectBase
    {
        public required abstract ModelObjectBase[] ModelObjects { set; }
    }
}
