using Oil_level_glass.COM;
using Oil_level_glass.COM.Classic.Glass;
using Oil_level_glass.Core;
using Oil_level_glass.Core.Classic.Glass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.Tests
{
    public class ComTests
    {
        [Fact()]
        public void TestGlassCreator()
        {
            ComGlassPartCreatorsFactory partCreatorsFactory = new ComGlassPartCreatorsFactory();

            IGlassPartCreator glassPartCreator = partCreatorsFactory.GetCreator();

            glassPartCreator.Initialize();
            glassPartCreator.AddSketch1();
        }
    }
}
