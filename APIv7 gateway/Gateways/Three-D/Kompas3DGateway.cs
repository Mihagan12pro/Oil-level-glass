using KompasAPI7;

namespace APIv7_gateway.Gateways.Three_D
{
    public abstract class Kompas3DGateway : KompasGateway
    {
        public virtual IPart7? Part { get; protected set; }
    }
}
