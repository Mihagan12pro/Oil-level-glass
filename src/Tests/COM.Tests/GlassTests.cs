using Oil_level_glass.Core.COM;
using Oil_level_glass.Core.Glass;
using Oil_level_glass.Model.Data.Entities.Parts.Classic;

namespace COM.Tests
{
    public class GlassTests : IPartTests
    {
        private GlassModel glass;

        [Fact]
        public void Test_CreatingPartWithoutKompas()
        {
            CreatorsFactory creatorsFactory = new CreatorsFactory();

            IGlassPartCreator creator = creatorsFactory.CreateGlassPart(glass);

            var result = creator.Create();

            Assert.False(result.IsSuccess);
        }

        [Fact]
        public void Test_CreatingPart()
        {
            CreatorsFactory creatorsFactory = new CreatorsFactory();

            IGlassPartCreator creator = creatorsFactory.CreateGlassPart(glass);

            var result = creator.Create();

            Assert.True(result.IsSuccess);
        }

        [Fact]
        public void Test_Errors()
        {
            var failedGlass = new GlassModel()
            {
                Diameter = 0,

                Height = 2,
            };

            failedGlass.File.Folder = "D:\\";
            failedGlass.File.Name.Naming = "Ëèíçà";

            CreatorsFactory creatorsFactory = new CreatorsFactory();

            IGlassPartCreator creator = creatorsFactory.CreateGlassPart(failedGlass);

            var result = creator.Create();

            Assert.False(result.IsSuccess);
        }

        public GlassTests()
        {
            glass = new GlassModel()
            {   
                Diameter = 60,

                Height = 2,
            };

            glass.File.Folder = "D:\\";
            glass.File.Name.Naming = "Ëèíçà";

            glass.Material.Density = 3.12;
            glass.Material.Title = "Ñòåêëî ÁÊ10 ÃÎÑÒ 3514-94";
        }
    }
}