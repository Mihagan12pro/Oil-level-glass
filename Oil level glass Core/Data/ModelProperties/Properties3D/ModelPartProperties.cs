using Oil_level_glass_Core.Data.Files;
using Oil_level_glass_Core.Data.Materials;
using Oil_level_glass_Core.Data.Structs;

namespace Oil_level_glass_Core.Data.ModelProperties.Properties3D
{
    public record ModelPartProperties : ModelProperties
    {
        public Material Material { get; set; }

        public Appearance Appearance { get; private set; }


       
        public ModelPartProperties()
        {
            KompasFile = new PartFile();

            Appearance = new Appearance();
        }
    }
}
