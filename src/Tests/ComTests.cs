using Oil_level_glass.COM.Classic.Glass;
using Oil_level_glass.COM.Classic.Housing;
using Oil_level_glass.COM.Classic.OilLevelGlass;
using Oil_level_glass.COM.Classic.RubberStrip;
using Oil_level_glass.Core.Classic.Glass;
using Oil_level_glass.Core.Classic.Housing;
using Oil_level_glass.Core.Classic.OilLevelGlass;
using Oil_level_glass.Core.Classic.RubberStrip;
using Oil_level_glass.Model.Data.Entities.Parts.Classic;

namespace Oil_level_glass.Tests
{
    public class ComTests
    {
        [Fact()]
        public void TestOilLevelGlassCreator()
        {
            GlassModel glassModel = new GlassModel()
            {
                Height = 2,

                ExternalDiameter = 60
            };
            glassModel!.File!.Folder = @"C:\foo";
            glassModel!.File!.Name.Naming = "Линза";
            glassModel!.File!.Name.Marking = "МПСТ.000.000.002";

            RubberStripModel stripModel = new RubberStripModel()
            {
                Height = 2,
                
                InternalDiameter = 50,

                ExternalDiameter = 60
            };
            stripModel!.File!.Folder = @"C:\Сборка";
            stripModel.File.Name.Naming = "Прокладка";
            stripModel.File.Name.Marking = "МПСТ.000.000.003";

            HousingModel housingModel = new HousingModel()
            {
                MainDiameter = 90,
                CentralHoleDiameter = 50,
                MainHeight = 8,

                GlassSocketDiameter = 60,
                GlassSocketHeight = 6,

                ScrewHolesCount = 4,
                ScrewHolesDistance = 72,
            };
            housingModel.Chamfer.Angle = 60;
            housingModel.Chamfer.Length = 3;

            housingModel!.File!.Folder = @"C:\Сборка";
            housingModel.File.Name.Naming = "Корпус";
            housingModel.File.Name.Marking = "МПСТ.000.000.001";

            IOilLevelGlassPartCreatorFactory creatorFactory = new ComOilLevelGlassPartCreatorFactory();

            IOilLevelGlassPartCreator creator = creatorFactory.GetCreator();

            creator.PartModel = new OilLevelGlassModel()
            {
                GlassModel = glassModel,
                
                HousingModel = housingModel,

                RubberStripModel = stripModel
            };
            

            creator.Initialize();
            creator.Assemble();
        }

        [Fact()]
        public void TestStripCreator()
        {
            RubberStripModel stripModel = new RubberStripModel();
            stripModel!.File!.Folder = @"C:\Сборка";
            stripModel.File.Name.Naming = "Прокладка";
            stripModel.File.Name.Marking = "МПСТ.000.000.003";

            ComRubberStripPartCreatorFactory creatorFactory = new ComRubberStripPartCreatorFactory();
            IRubberStripPartCreator stripPartCreator = creatorFactory.GetCreator();

            stripPartCreator.PartModel = stripModel;

            stripPartCreator.Initialize();
            stripPartCreator.AddSketch1();
            stripPartCreator.ExtrudeSketch1();

            stripPartCreator.EditSavingParameter();
            stripPartCreator.EditNaming();
            stripPartCreator.SaveFile();
        }

        [Fact()]
        public void TestHousingCreator()
        {
            HousingModel housingModel = new HousingModel();
            housingModel!.File!.Folder = @"C:\Сборка";
            housingModel.File.Name.Naming = "Корпус";
            housingModel.File.Name.Marking = "МПСТ.000.000.001";

            ComHousingPartCreatorsFactory housingPartCreatorsFactory = new ComHousingPartCreatorsFactory();
            IHousingPartCreator housingPartCreator = housingPartCreatorsFactory.GetCreator();

            housingPartCreator.PartModel = housingModel;

            housingPartCreator.Initialize();

            housingPartCreator.AddSketch1();
            housingPartCreator.ExtrudeSketch1();

            housingPartCreator.AddSketch2();
            housingPartCreator.ExtrudeSketch2();

            housingPartCreator.AddSketch3();
            housingPartCreator.AddScrewHoles();

            housingPartCreator.AddRounding();

            housingPartCreator.EditSavingParameter();
            housingPartCreator.EditNaming();

            housingPartCreator.SaveFile();
        }

        [Fact()]
        public void TestGlassCreator()
        {
            GlassModel glassModel = new GlassModel();
            glassModel!.File!.Folder = @"C:\foo";
            glassModel!.File!.Name.Naming = "Линза";
            glassModel!.File!.Name.Marking = "МПСТ.000.000.002";

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
