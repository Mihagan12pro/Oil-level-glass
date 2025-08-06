using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.Structs.EdgeModifiers
{
    internal struct Chamfer
    {
        private double _length1;

        public double Length1
        {
            get { return _length1; }
            set { _length1 = value; }
        }


        public double Length2 { get; private set; }


        public Chamfer()
        {
            
        }
    }
}
