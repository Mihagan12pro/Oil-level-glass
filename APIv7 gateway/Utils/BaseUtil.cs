using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIv7_gateway.Utils
{
    internal abstract class BaseUtil<T>
    {
        public required bool IsNormal;

        public required T Value;
    }
}
