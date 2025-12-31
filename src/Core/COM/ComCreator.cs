using Kompas6API5;
using KompasAPI7;
using NativeMethods;
using Oil_level_glass.Core;

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

        public abstract void EditNaming();

        public abstract void EditSavingParameter();

        protected internal ComCreator()
        {
            
        }
    }
}
