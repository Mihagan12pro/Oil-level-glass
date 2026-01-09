using Oil_level_glass.Core.Classic.OilLevelGlass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.COM.Classic.OilLevelGlass
{
    public class ComOilLevelGlassPartCreatorFactory
        : IOilLevelGlassPartCreatorFactory
    {
        public IOilLevelGlassPartCreator GetCreator()
        {
            return new OilLevelGlassPartCreator();
        }
    }
}
