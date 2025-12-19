using Oil_level_glass.Core.Classic.Housing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.COM.Classic.Housing
{
    public class ComHousingPartCreatorsFactory
        : IHousingPartCreatorFactory
    {
        public IHousingPartCreator GetCreator()
        {
            return new HousingPartCreator();
        }
    }
}
