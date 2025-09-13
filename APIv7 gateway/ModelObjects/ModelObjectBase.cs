using APIv7_gateway.Interfaces;
using KompasAPI7;

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
