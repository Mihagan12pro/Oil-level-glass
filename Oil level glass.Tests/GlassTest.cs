using Model.Materials;
using Model.Other;
using Oil_level_glass.Model.Parts;
using Oil_level_glass_Core.Builders;

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

            model.ExternalDiameter = 200;
            model.Height = 5;

            GlassBuilder builder = new GlassBuilder(true)
            {
                EntityModel = model 
            };

            builder.Create();
        }
    }
}
