using KompasAPI7;
using Oil_level_glass_Core.Data.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass_Core.Data.ModelProperties.Properties3D
{
    public abstract record ModelAssemblyProperties : Model3DProperties
    {
        public IAssemblyDocument? KompasDocument { get; set; }

        public ModelAssemblyProperties()
        {
            KompasFile = new AssemblyFile();
        }
    }
}
