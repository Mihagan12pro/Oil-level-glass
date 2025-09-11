using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass_Core.KompasApiV7.Utils
{
    internal abstract class BaseUtil<T>
    {
        public required bool IsNormal;

        public required T Value;
    }
}
