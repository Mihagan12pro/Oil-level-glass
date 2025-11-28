using Oil_level_glass_Core.Builders;
using Oil_level_glass.Model.Data.Entities.Parts.Classic;

namespace Oil_level_glass.Tests
{
    public class HousingTests
    {
        [Fact()]
        public void Test()
        {
            HousingModel model = new HousingModel();
            model.GlassDiameter = 60;
            model.CentralHoleDiameter = 50;
            model.MainDiameter = 90;
            model.MainHeight = 8;
            model.GlassSocketHeight = 6;
            model.Chamfer.Length = 1.5;
            model.Thread.Pitch = 1.5;
            model.Thread.NominalDiameter = 5;
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
