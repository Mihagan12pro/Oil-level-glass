using KompasData.KompasFile;
using KompasData.Materials;
using KompasData.Other;
using Oil_level_glass.Model.Parts;
using Oil_level_glass_Core.Builders;

namespace Oil_level_glass.Tests
{
    public class RubberStripTest
    {
        [Fact]
        public void Test2()
        {
            Appereance appeareance = new Appereance()
            {
                Blue = 0,

                Red = 0,

                Green = 0
            };


            RubberStripModel rubberStrip = new RubberStripModel()
            {
                ExternalDiameter = 200,

                InternalDiameter = 180,

                Height = 2
            };


            Rubber rubber = new Rubber() 
            {
                Tittle = "Резина", 
            
                Density = 1.2 
            };

            PartFile file = new PartFile()
            {
                Folder = @"C:\Test",
            };

            file.Name.Marking = "КМС.000000.002";
            file.Name.Naming = "Резиновая прокладка";

            RubberStripBuilder rubberStripBuilder = new RubberStripBuilder(true)
            {
                Appearance = appeareance,

                RubberStrip = rubberStrip,

                Material = rubber,

                File = file
            };

            rubberStripBuilder.Build();
        }
    }
}
