using Oil_level_glass_Core.Builders;
using Oil_level_glass.Model.Data.Entities.Parts.Classic;

namespace Oil_level_glass.Tests
{
    public class GlassTest
    {
        [Fact()]
        public void Test1()
        {
            GlassModel model = new GlassModel();

            model.File!.Folder = @"C:\Test";
            model.File!.Name.Marking = "КМС.000000.001";
            model.File!.Name.Naming = "Линза";

            model.Material!.Tittle = "Стекло";
            model.Material.Density = 5;

            model.ExternalDiameter = 60;
            model.Height = 3;

            GlassBuilder builder = new GlassBuilder(true)
            {
                EntityModel = model 
            };

            builder.Create();
        }
    }
}
