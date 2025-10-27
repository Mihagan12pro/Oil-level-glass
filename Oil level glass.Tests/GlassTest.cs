using KompasData.Materials;
using KompasData.Other;
using KompasData.KompasFile;
using Oil_level_glass.Model.Parts;
using Oil_level_glass_Core.Builders;

namespace Oil_level_glass.Tests
{
    public class GlassTest
    {
        [Fact]
        public void Test1()
        {
            Material material = new Glass() { Tittle = "Стекло", Density = 5 };

            Appereance appearance = new Appereance() {Transparency = 10};
         

            PartFile file = new PartFile();

            GlassModel glassModel = new GlassModel() { ExternalDiameter = 20, Height = 5};
             
            GlassBuilder builder = new GlassBuilder(false)
            {
               Material = material,

               Appearance = appearance,

               File = file,

               Glass = glassModel
            };
        }
    }
}