using APIv7_gateway.ModelObjects;
using APIv7_gateway.ModelObjects.Copiers;
using KompasAPI7;

namespace APIv7_gateway.Gateways.Three_D
{
    public abstract class KompasPartBaseGateway : KompasGateway
    {
        internal abstract IModelContainer? ModelContainer { get; }

        public CircularCopierObject CreateCircularCopier(Axis3DObject axis, ModelObjectBase[] objects)
        {
            return new CircularCopierObject((ICircularPattern)ModelContainer.AddObject(Kompas6Constants3D.ksObj3dTypeEnum.o3d_circularCopy)) { Axis = axis, ModelObjects = objects };
        }
    }
}
