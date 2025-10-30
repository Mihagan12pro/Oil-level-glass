using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.Model.Parts
{
    public class HousingModel : BaseModel
    {
        public double MainDiameter { get; set; }

        public double MainHeight { get; set; }

        public double SocketHeight { get; set; }

        public double BigSocketDimeter { get; set; }

        public double SmallSocketDiameter { get; set; }

        public double ChamferLength { get; set; } = 3;

        public double ChamferAngle { get; set; } = 45;

        public double ScrewHoleDiameter { get; set; }

        public double ScrewHoleCicleDiameter { get; set; }

        public int ScrewHolesCount { get; set; }
    }
}
