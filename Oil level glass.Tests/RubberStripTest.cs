using Oil_level_glass_Core.Builders;
using Oil_level_glass.Model.Data.Entities.Parts.Classic;

namespace Oil_level_glass.Tests
{
    public class RubberStripTest
    {
        [Fact]
        public void Test2()
        {
            RubberStripModel model = new RubberStripModel();

            model.File!.Folder = "C:\\Test";
            model.File.Name.Marking =  "КМС.000000.002";
            model.File.Name.Naming =  "Резиновая прокладка";

            model.Material!.Density = 1.2;
            model.Material!.Tittle = "Резина";


            model.ExternalDiameter = 60;
            model.InternalDiameter = 50;
            model.Height = 1.5;

            RubberStripBuilder builder = new RubberStripBuilder(true)
            { 
                EntityModel = model
            };

            builder.Create();
        }
    }
}
