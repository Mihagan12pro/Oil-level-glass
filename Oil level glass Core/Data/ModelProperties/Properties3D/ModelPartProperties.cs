using KompasAPI7;
using Oil_level_glass_Core.Data.Files;
using Oil_level_glass_Core.Data.Materials;
using Oil_level_glass_Core.Data.Structs;

namespace Oil_level_glass_Core.Data.ModelProperties.Properties3D
{
    public record ModelPartProperties : Model3DProperties
    {
        public required Material Material { get; set; }

        public Appearance Appearance { get; set; }

        public IPartDocument? KompasDocument { get; set; }

        protected IKompasDocument2D kompasDocument2D;

        public ModelPartProperties()
        {
            KompasFile = new PartFile();
        }
    }
}
