using KompasAPI7;
using Oil_level_glass_Core.Data.Files;

namespace Oil_level_glass_Core.Data.ModelProperties.Properties3D
{
    public abstract record ModelAssemblyProperties :ModelProperties
    {

        public ModelAssemblyProperties()
        {
            KompasFile = new AssemblyFile();
        }
    }
}
