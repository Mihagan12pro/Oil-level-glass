using KompasAPI7;
using NativeMethods;
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

        protected const string kompasProgId = "KOMPAS.Application.7";

        protected readonly IApplication? kompasApplication;

        public KompasGateway()
        {
            kompasApplication = ComConnector.GetInstance(kompasProgId) as IApplication;
        }
    }
}
