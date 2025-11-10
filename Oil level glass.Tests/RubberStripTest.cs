using Model.Materials;
using Model.Other;
using Oil_level_glass.Model.Entities.Parts.Classic;
using Oil_level_glass.Model.KompasFile;
using Oil_level_glass_Core.Builders;

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


            model.ExternalDiameter = 200;
            model.InternalDiameter = 180;
            model.Height = 2;

            RubberStripBuilder builder = new RubberStripBuilder(true)
            { 
                EntityModel = model
            };

            builder.Create();
        }
    }
}
