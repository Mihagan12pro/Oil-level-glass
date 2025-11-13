using Oil_level_glass.Model.Entities.Parts.Classic;
using Oil_level_glass_Core.Assemblers;

namespace Oil_level_glass.Tests
{
   public class OilLevelGlassTests
   {
        [Fact()]
        public void Test1()
        {
            OilLevelGlassModel model = new OilLevelGlassModel()
            {
                GlassPath = @"C:\Test\КМС.000000.001_Линза..m3d",

                StripPath = @"C:\Test\КМС.000000.002_Резиновая прокладка..m3d",

                HousingPath = @"C:\Test\КМС.000000.003_Корпус..m3d"
            };
            model.MainDiameter = 90;
            model.MainHeight = 8;
            model.GlassSocketHeight = 6;
            model.GlassWidth = 3;
            model.Chamfer.Angle = 45;
            model.Chamfer.Length = 2;
            model.CentralHoleDiameter = 50;
            model.GlassDiameter = 60;
            model.File!.Name.Naming = "Смотровое окно";
            model.File!.Name.Marking = "КМС.000000.000";


            OilLevelGlassAssembler assembler = new OilLevelGlassAssembler(true) { EntityModel =  model };
            assembler.Create();
        }
    }
}
