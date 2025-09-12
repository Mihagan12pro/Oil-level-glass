using APIv7_gateway.Interfaces;
using KompasAPI7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIv7_gateway.ModelObjects
{
    public abstract record ModelObjectBase : IApi7Object
    {
        protected IModelObject? modelObject { get; init; }

        public IModelObject? ModelObject => modelObject;


        public void Update()
        {
            modelObject?.Update();
        }
    }
}
