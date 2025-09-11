using KompasAPI7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIv7_gateway.ModelObjects
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
