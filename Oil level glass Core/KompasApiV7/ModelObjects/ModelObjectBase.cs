using KompasAPI7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass_Core.KompasApiV7.ModelObjects
{
    internal abstract record ModelObjectBase
    {
        protected IModelObject modelObject { get; init; }

        public IModelObject ModelObject => modelObject;

        public ModelObjectBase(IModelContainer modelContainer)
        {
         
        }
    }
}
