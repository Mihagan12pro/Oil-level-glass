using Oil_level_glass.COM;
using Oil_level_glass.Core;
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
        public void Test1()
        {
            CreatorsFactory<IPartCreator> creatorsFactory = new CreatorsFactory<IPartCreator>();

            IPartCreator partCreator = creatorsFactory.GetCreator();
        }
    }
}
