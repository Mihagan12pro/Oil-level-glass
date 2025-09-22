using APIv7_gateway.Interfaces;
using KompasAPI7;

namespace APIv7_gateway.ModelObjects
{
    public abstract class ModelObjectBase : IApi7Object
    {
        internal abstract IModelObject? ModelObject { get; }


        public void Update()
        {
            ModelObject?.Update();
        }
    }
}
