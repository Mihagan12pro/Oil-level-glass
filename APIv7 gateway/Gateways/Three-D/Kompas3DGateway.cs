using KompasAPI7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIv7_gateway.Gateways.Three_D
{
    public abstract class Kompas3DGateway : KompasGateway
    {
        public virtual IPart7? Part { get; protected set; }
    }
}
