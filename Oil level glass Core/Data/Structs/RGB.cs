using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass_Core.Data.Structs
{
    public struct RGB
    {
        public int Red = 144;

        public int Green = 144;

        public int Blue = 144;


        public int GetColor()
        {
            return ((Red | (Green << 8)) | (Blue << 16));
        }


        public RGB()
        {

        }
    }
}
