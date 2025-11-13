using Model.Materials;
using Oil_level_glass.Model.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.Model.Entities.Parts.Classic
{
    public class HousingModel : BaseDetailModel
    {
        public double MainDiameter { get; set; }

        public double MainHeight { get; set; }

        public double GlassSocketHeight { get; set; }

        public double GlassDiameter { get; set; }

        public double CentralHoleDiameter { get; set; }

        public ChamferModel Chamfer { get; } = new ChamferModel() { Angle = 45, Length = 5 };

        public int ScrewHolesCount { get; set; }

        public ThreadModel Thread { get; } = new ThreadModel();

 
        public HousingModel()
        {
            Material = new Metal();
        }
    }
}
