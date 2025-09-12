using KompasAPI7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIv7_gateway.Gateways
{
    public abstract class KompasGateway
    {
        protected IKompasDocument? kompasDocument;


        public KompasGateway()
        {

        }
    }
}
