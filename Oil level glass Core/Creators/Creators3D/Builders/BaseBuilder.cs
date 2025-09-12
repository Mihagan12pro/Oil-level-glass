using Oil_level_glass_Core.Data.ModelProperties.Properties3D;
using Oil_level_glass_Core.Services;

namespace Oil_level_glass_Core.Creators.Creators3D.Builders
{
    public abstract record BaseBuilder : BaseCreator
    {
        public new ModelPartProperties? Properties { get; init; }

        public abstract void Create();
    }
}
