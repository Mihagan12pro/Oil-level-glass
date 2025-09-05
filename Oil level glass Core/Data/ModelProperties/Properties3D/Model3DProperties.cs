using KompasAPI7;

namespace Oil_level_glass_Core.Data.ModelProperties.Properties3D
{
    public abstract record Model3DProperties : ModelProperties
    {
        public IPart7? Part { get; set; }

        public IModelContainer? ModelContainer { get; protected set; }

        public IKompasDocument3D KompasDocument { get; set; }
    }
}
