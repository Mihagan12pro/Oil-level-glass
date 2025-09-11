using KompasAPI7;
using Oil_level_glass_Core.Data.Materials;

namespace Oil_level_glass_Core.Creators.Creators3D.Builders
{
    public record RingBuilder : BaseBuilder
    {
        public double ExternalDiameter { get; set; }

        public double InternalDiameter { get; set; }

        public double RingHeight { get; set; }

       
        public RingBuilder()
        {
            Properties = new Data.ModelProperties.Properties3D.ModelPartProperties() { Material = new Rubber()};
        }
    }
}
