using Oil_level_glass.COM.Classic.Glass;
using Oil_level_glass.COM.Classic.Housing;
using Oil_level_glass.COM.Classic.RubberStrip;
using Oil_level_glass.Core.Classic.Glass;
using Oil_level_glass.Core.Classic.Housing;
using Oil_level_glass.Core.Classic.RubberStrip;
using Oil_level_glass.Model.Data.Entities.Parts.Classic;

namespace Oil_level_glass.Tests
{
    public class ComTests
    {
        [Fact()]
        public void TestStripCreator()
        {
            ComRubberStripPartCreatorFactory creatorFactory = new ComRubberStripPartCreatorFactory();
            IRubberStripPartCreator stripPartCreator = creatorFactory.GetCreator();

            stripPartCreator.Initialize();
            stripPartCreator.AddSketch1();
            stripPartCreator.RotateSketch1();
        }

        [Fact()]
        public void TestHousingCreator()
        {
            ComHousingPartCreatorsFactory housingPartCreatorsFactory = new ComHousingPartCreatorsFactory();

            IHousingPartCreator housingPartCreator = housingPartCreatorsFactory.GetCreator();
            housingPartCreator.Initialize();

            housingPartCreator.AddSketch1();
            housingPartCreator.ExtrudeSketch1();

            housingPartCreator.AddSketch2();
            housingPartCreator.ExtrudeSketch2();

            housingPartCreator.AddSketch3();

            housingPartCreator.AddScrewHoles();

            housingPartCreator.AddRounding();
        }

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
