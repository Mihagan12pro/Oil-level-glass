using Model.Materials;
using Model.Other;
using Oil_level_glass.Model.Entities.Parts.Classic;
using Oil_level_glass.Model.KompasFile;
using Oil_level_glass_Core.Builders;

namespace Oil_level_glass.Tests
{
    public class HousingTests
    {
        [Fact()]
        public void Test()
        {
            HousingModel model = new HousingModel();
            model.BigSocketDiameter = 200;
            model.SmallSocketDiameter = 180;
            model.MainDiameter = 300;
            model.MainHeight = 60;
            model.SocketHeight = 25;
            model.Thread.Pitch = 1.5;
            model.Thread.NominalDiameter = 10;
            model.ChamferLength = 5;
            model.ScrewHolesCount = 4;

            model.File!.Folder = @"C:\Test";
            model.File!.Name.Marking = "КМС.000000.003";
            model.File!.Name.Naming = "Корпус";

            model.Material!.Tittle = "Метал";
            model.Material.Density = 7;


            HousingBuilder builder = new HousingBuilder(true)
            {
                EntityModel = model
            };

            builder.Create();
        }
    }
}
