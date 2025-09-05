using Kompas6Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass_Core.Data.Materials
{
    public record Glass : Material
    {
        public Glass()
        {
            MinDensity = 2.2;

            MaxDensity = 7.5;

            HatchStyle = (int)ksHatchStyleEnum.ksHatchGlass;
        }
    }
}
