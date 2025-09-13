using Oil_level_glass_Core.Data.ModelProperties.Properties3D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass_Core.Creators.Model3D.Base
{
    public abstract record BaseAssembleCreator : Base3DCreator
    {
        public BaseAssembleCreator()
        {
            Properties = new ModelAssemblyProperties();
        }
    }
}
