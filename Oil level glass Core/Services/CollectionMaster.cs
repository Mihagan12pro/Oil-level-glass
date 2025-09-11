using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass_Core.Services
{
    internal static class CollectionMaster
    {
        public static Array ObjectToArray(object obj)
        {
            if (!(obj is Array))
                throw new InvalidDataException();

            return (Array)obj;
        }
    }
}
