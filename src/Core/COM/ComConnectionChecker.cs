using Kompas6API5;
using NativeMethods;
using Oil_level_glass.Core;

namespace Oil_level_glass.COM
{
    public class ComConnectionChecker 
        : IConnectionChecker
    {
        public bool Check()
        {
            bool success = false;

            KompasObject kompasObject = (KompasObject)ComConnector.GetInstance("KOMPAS.Application.5");

            return success;
        }
    }
}
