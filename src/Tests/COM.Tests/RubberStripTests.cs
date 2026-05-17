using Oil_level_glass.Core.COM;
using Oil_level_glass.Core.Glass;
using Oil_level_glass.Core.RubberStrip;
using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Model.Data.Materials;

namespace COM.Tests
{
    public class RubberStripTests : IPartTests
    {
        private RubberStripModel rubberStrip;

        [Fact]
        public void Test_CreatingPartWithoutKompas()
        {
            CreatorsFactory creatorsFactory = new CreatorsFactory();

            IRubberStripPartCreator creator = creatorsFactory.CreateRubberStripPartCreator(rubberStrip);

            var result = creator.Create();

            Assert.False(result.IsSuccess);
        }

        [Fact]
        public void Test_CreatingPart()
        {
            CreatorsFactory creatorsFactory = new CreatorsFactory();

            IRubberStripPartCreator creator = creatorsFactory.CreateRubberStripPartCreator(rubberStrip);

            var result = creator.Create();

            Assert.True(result.IsSuccess);
        }

        [Fact]
        public void Test_Errors()
        {
            var failedRubberStrip = new RubberStripModel()
            {
                Height = 2,
            };

            failedRubberStrip.File.Folder = "D:\\";
            failedRubberStrip.File.Name.Naming = "Линза";

            CreatorsFactory creatorsFactory = new CreatorsFactory();

            IRubberStripPartCreator creator = creatorsFactory.CreateRubberStripPartCreator(failedRubberStrip);

            var result = creator.Create();

            Assert.False(result.IsSuccess);
        }

        public RubberStripTests()
        {
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
