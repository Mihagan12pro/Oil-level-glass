using KompasData.KompasFile;
using KompasData.Materials;
using KompasData.Other;
using Oil_level_glass.Model.Parts;
using Oil_level_glass_Core.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.Tests
{
    public class HousingTests
    {
        [Fact()]
        public void Test()
        {
            Appereance appereance = new Appereance();

            Metal metal = new Metal() { Tittle = "Метал", Density = 7 };

            PartFile file = new PartFile();
            file.Folder = @"C:\Test";
            file.Name.Marking = "КМС.000000.003";
            file.Name.Naming = "Корпус";

            HousingModel housing = new HousingModel();
            housing.BigSocketDiameter = 200;
            housing.SmallSocketDiameter = 180;
            housing.MainDiameter = 300;
            housing.MainHeight = 60;
            housing.SocketHeight = 25;
            housing.ScrewHoleCicleDiameter = 250;
            housing.ScrewHoleDiameter = 5;
            housing.ChamferLength = 0.5;

           

            HousingBuilder housingBuilder = new HousingBuilder(true)
            {
                Appearance = appereance,

                Material = metal,

                File = file,

                Housing = housing
            };

            housingBuilder.Build();
        }
    }
}
