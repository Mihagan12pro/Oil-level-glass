using Kompas6API5;
using Oil_level_glass.Core;
using Oil_level_glass.COM;
using NativeMethods;

namespace Oil_level_glass.COM
{
    internal abstract class ComCreator 
        : ICreator
    {
        public KompasObject KompasObject { get; private set; }  

        public virtual void Initialize()
        {
            KompasObject = (KompasObject)ComConnector.GetInstance("KOMPAS.Application.5");
        }

        public abstract void SaveFile();

        protected internal ComCreator()
        {
            
        }
    }
}
