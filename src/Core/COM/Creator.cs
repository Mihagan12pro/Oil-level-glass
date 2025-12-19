using Kompas6API5;
using Oil_level_glass.Core;
using Oil_level_glass.COM;
using NativeMethods;

namespace Oil_level_glass.COM
{
    internal class Creator 
        : ICreator
    {
        public KompasObject KompasObject { get; private set; }  

        public void Initialize()
        {
            KompasObject = (KompasObject)ComConnector.GetInstance("KOMPAS.Application.5");
        }

        protected internal Creator()
        {
            
        }
    }
}
