using Kompas6Constants3D;
using KompasAPI7;

namespace Oil_level_glass_Core.Data.ModelProperties.Properties3D
{
    public abstract record Model3DProperties<D> : ModelProperties<IKompasDocument3D>
    {
        private IPart7? _part;
        internal IPart7? Part 
        {
            get => _part;
            set
            {
                _part = value;

                ModelContainer = _part as IModelContainer;

                PlaneXOY = _part?.DefaultObject[ksObj3dTypeEnum.o3d_planeXOY];

                PlaneYOZ = _part?.DefaultObject[ksObj3dTypeEnum.o3d_planeYOZ];

                PlaneXOZ = _part?.DefaultObject[ksObj3dTypeEnum.o3d_planeXOZ];
            }
        }

        internal IModelContainer? ModelContainer { get; private set; }

        internal IModelObject? PlaneXOY { get; private set; }

        internal IModelObject? PlaneYOZ { get; private set; }

        internal IModelObject? PlaneXOZ { get; private set; }
    }
}
