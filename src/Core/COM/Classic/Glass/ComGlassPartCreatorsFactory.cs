using Oil_level_glass.Core.Classic.Glass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.COM.Classic.Glass
{
    public class ComGlassPartCreatorsFactory
        : IGlassPartCreatorFactory
    {
        public IGlassPartCreator GetCreator()
        {
            return new GlassPartCreator();
        }
    }
}
