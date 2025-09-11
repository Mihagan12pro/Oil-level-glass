using KompasAPI7;

namespace APIv7_gateway.Gateways.Three_D
{
    internal abstract class Kompas3DGateway : KompasGateway
    {
        //protected IModelContainer? modelContainer;
        //public IModelContainer? ModelContainer => modelContainer;


        protected IPart7? part;
        public virtual IPart7? Part
        {
            get
            {
                return part;
            }
            protected set
            {
                part = value;

                //modelContainer = _part as IModelContainer;
            }
        }


        //public Kompas3DGateway(IKompasDocument3D document3D)
        //{
        //    Part = document3D.TopPart;
        //}
    }
}
