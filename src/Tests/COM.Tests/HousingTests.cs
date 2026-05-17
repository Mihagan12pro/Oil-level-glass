using Oil_level_glass.Core.COM;
using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Model.Data.ScrewHoles;

namespace COM.Tests
{
    public class HousingTests : IPartTests
    {

        private HousingModel housing;

        [Fact]
        public void Test_CreatingPart()
        {
            CreatorsFactory creatorsFactory = new CreatorsFactory();

            var creator = creatorsFactory.CreateHousingPartCreator(housing);

            var result = creator.Create();
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

        public HousingTests()
        {
            housing = new HousingModel()
            {
                MainDiameter = 90,

                CentralHoleDiameter = 50,

                MainHeight = 8,

                GlassSocketDiameter = 60,

                GlassSocketHeight = 6,

                ScrewHolesDistance = 72
            };

            ((BasicScrewHoleModel)housing.Hole).Diameter = 8;
            housing.ScrewHolesCount = 4;

            housing.Chamfer.Side1 = 2;
            housing.Chamfer.Angle = 45;

            housing.File.Name.Naming = "Корпус";
            housing.File.Folder = "D:\\";
        }
    }
}
