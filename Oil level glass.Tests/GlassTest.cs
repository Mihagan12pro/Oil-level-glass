using KompasData.KompasFile;
using KompasData.Materials;
using KompasData.Other;
using Oil_level_glass.Model.Parts;
using Oil_level_glass_Core.Builders;

namespace Oil_level_glass.Tests
{
    public class GlassTest
    {
        [Fact()]
        public void Test1()
        {
            Material material = new Glass() { Tittle = "Стекло", Density = 5 };

            Appereance appearance = new Appereance()
            {
                Transparency = -1,

                Diffuse = 0,

                Ambient = 0,

                Specularity = 0,

                Shininess = 0,

                Emission = 0,

                Blue = 255,

                Red = 255,

                Green = 255
            };


            PartFile file = new PartFile();
            file.Folder = @"C:\Test";
            file.Name.Marking = "КМС.000000.001";
            file.Name.Naming = "Линза";

            GlassModel glassModel = new GlassModel() { ExternalDiameter = 200, Height = 5 };

            GlassBuilder builder = new GlassBuilder(true)
            {
                Material = material,

                Appearance = appearance,

                File = file,

                Glass = glassModel
            };

            builder.Build();
        }
    }
}
