using Oil_level_glass.Core.Classic.RubberStrip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.COM.Classic.RubberStrip
{
    public class ComRubberStripPartCreatorFactory
        : IRubberStripPartCreatorFactory
    {
        public IRubberStripPartCreator GetCreator()
        {
            return new RubberStripPartCreator();
        }
    }
}
