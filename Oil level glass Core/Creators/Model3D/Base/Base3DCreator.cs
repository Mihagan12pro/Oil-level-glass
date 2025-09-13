using APIv7_gateway.Gateways.Three_D;
using KompasAPI7;
using Oil_level_glass_Core.Services;

namespace Oil_level_glass_Core.Creators.Model3D.Base
{
    public abstract record Base3DCreator : BaseCreator
    {
        protected IApplication application;


        public Base3DCreator()
        {
            application = (IApplication)COMConnector.GetInstance("KOMPAS.Application.7");
        }
    }
}
