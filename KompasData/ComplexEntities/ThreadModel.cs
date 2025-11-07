using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.Model.ComplexEntities
{
    public class ThreadModel
    {
        public double NominalDiameter { get; set; }

        public double Pitch { get; set; }

        public string Standard { get; set; } = string.Empty;
    }
}
