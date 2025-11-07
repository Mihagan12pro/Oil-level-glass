using Oil_level_glass.Model.ComplexEntities;
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

        public double BigSocketDiameter { get; set; }

        public double SmallSocketDiameter { get; set; }

        public double ChamferLength { get; set; } = 3;

        public double ChamferAngle { get; set; } = 45;

        public ThreadModel Thread { get; } = new ThreadModel();


        public int ScrewHolesCount { get; set; }
    }
}
