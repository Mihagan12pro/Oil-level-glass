using Oil_level_glass.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.COM
{
    public class CreatorsFactory<TCreator> 
        : ICreatorsFactory<TCreator> 
            where TCreator : ICreator
    {
        public TCreator GetCreator()
        {
            Type type = typeof(TCreator);

            throw new NotImplementedException();
        }
    }
}