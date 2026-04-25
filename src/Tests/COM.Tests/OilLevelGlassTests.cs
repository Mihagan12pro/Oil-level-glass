using Oil_level_glass.Core.COM;
using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Model.Data.Operations.Chamfers;
using Oil_level_glass.Model.Data.ScrewHoles;

namespace COM.Tests
{
    public class OilLevelGlassTests : IPartTests
    {
        private HousingModel housing;
        private GlassModel glass;
        private RubberStripModel rubberStrip;

        [Fact]
        public void Test_CreatingPart()
        {
            CreatorsFactory creatorsFactory = new CreatorsFactory();

            var creator = creatorsFactory.CreateOilLevelGlassPartCreator(glass, rubberStrip, housing);

            var result = creator.Create();

            Assert.True(result.IsSuccess);
        }

        [Fact]
        public void Test_CreatingPartWithoutKompas()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void Test_Errors()
        {
            throw new NotImplementedException();
        }

        public OilLevelGlassTests()
        {
            glass = new GlassModel()
            {
                Diameter = 60,

                Height = 2,
            };

            glass.File.Folder = "D:\\";
            glass.File.Name.Naming = "Линза";

            glass.Material.Density = 3.12;
            glass.Material.Title = "Стекло БК10 ГОСТ 3514-94";


            housing = new HousingModel()
            {
                MainDiameter = 90,

                CentralHoleDiameter = 50,

                MainHeight = 8,

                GlassSocketDiameter = 60,

                GlassSocketHeight = 6,

                ScrewHolesDistance = 72
            };

            ((ScrewHoleModel)housing.Hole).Diameter = 8;
            housing.ScrewHolesCount = 4;

            housing.Chamfer.Length = 2;
            ((ChamferAngleLengthModel)housing.Chamfer).Angle = 45;

            housing.File.Name.Naming = "Корпус";
            housing.File.Folder = "D:\\";


            rubberStrip = new RubberStripModel()
            {
                ExternalDiameter = 60,

                InternalDiameter = 50,

                Height = 2
            };

            rubberStrip.Material.Density = 1.28;
            rubberStrip.Material.Title = "Смесь резиновая 3063 ТУ 38-1051082-86";

            rubberStrip.File.Folder = "D:\\";
            rubberStrip.File.Name.Naming = "Резиновая прокладка";
        }
    }
}
