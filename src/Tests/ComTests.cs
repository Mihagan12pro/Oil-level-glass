using Oil_level_glass.COM.Classic.Glass;
using Oil_level_glass.Core.Classic.Glass;
using Oil_level_glass.Model.Data.Entities.Parts.Classic;

namespace Oil_level_glass.Tests
{
    public class ComTests
    {
        [Fact()]
        public void TestGlassCreator()
        {
            GlassModel glassModel = new GlassModel();
            glassModel!.File!.Folder = @"C:\foo";
            glassModel!.File!.Name.Naming = "Линза";
            glassModel!.File!.Name.Marking = "МПСТ.000.000.001";

            ComGlassPartCreatorsFactory partCreatorsFactory = new ComGlassPartCreatorsFactory();

            IGlassPartCreator glassPartCreator = partCreatorsFactory.GetCreator();

            glassPartCreator.PartModel = glassModel;


            glassPartCreator.Initialize();
            glassPartCreator.AddSketch1();
            glassPartCreator.ExtrudeSketch1();

            glassPartCreator.EditAppearances();
            glassPartCreator.EditMaterial();
            glassPartCreator.EditNaming();
            glassPartCreator.EditSavingParameter();

            glassPartCreator.SaveFile();
        }
    }
}
