using Oil_level_glass.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.COM
{
    internal abstract class SolidPartCreator 
        : Creator, ISolidPartCreator
    {
        public void EditAppearances()
        {
            throw new NotImplementedException();
        }

        public void EditMaterial()
        {
            throw new NotImplementedException();
        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }
    }
}
