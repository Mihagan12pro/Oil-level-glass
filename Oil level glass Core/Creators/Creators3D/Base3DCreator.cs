using Oil_level_glass_Core.Data.ModelProperties.Properties3D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass_Core.Creators.Creators3D
{
    public abstract class Base3DCreator<P> : BaseCreator<Model3DProperties>
    {
        public override void Create()
        {
            Properties.Part = Properties.KompasDocument.TopPart;
        }
    }
}
