using Oil_level_glass.Model.Entities.Parts.Classic;
using Oil_level_glass_Core.Assemblers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.Tests
{
   public class OilLevelGlassTests
   {
        [Fact()]
        public void Test1()
        {
            OilLevelGlassModel model = new OilLevelGlassModel()
            { 
                GlassModel = GetGlassModel(),
                HousingModel = GetHousingModel(), 
                RubberStripModel = GetRubberStripModel() 
            };

            OilLevelGlassAssembler assembler = new OilLevelGlassAssembler(true) { EntityModel =  model };
            assembler.Create();
        }


        public HousingModel GetHousingModel()
        {
            HousingModel model = new HousingModel();
            model.BigSocketDiameter = 200;
            model.SmallSocketDiameter = 180;
            model.MainDiameter = 300;
            model.MainHeight = 60;
            model.SocketHeight = 15;
            model.Thread.Pitch = 1.5;
            model.Thread.NominalDiameter = 10;
            model.ChamferLength = 5;
            model.ScrewHolesCount = 4;

            model.File!.Folder = @"C:\Test";
            model.File!.Name.Marking = "КМС.000000.003";
            model.File!.Name.Naming = "Корпус";

            model.Material!.Tittle = "Метал";
            model.Material.Density = 7;


            return model;
        }


        public RubberStripModel GetRubberStripModel()
        {
            RubberStripModel model = new RubberStripModel();

            model.File!.Folder = "C:\\Test";
            model.File.Name.Marking = "КМС.000000.002";
            model.File.Name.Naming = "Резиновая прокладка";

            model.Material!.Density = 1.2;
            model.Material!.Tittle = "Резина";


            model.ExternalDiameter = 200;
            model.InternalDiameter = 180;
            model.Height = 5;

            return model;
        }


        public GlassModel GetGlassModel()
        {
            GlassModel model = new GlassModel();

            model.File!.Folder = @"C:\Test";
            model.File!.Name.Marking = "КМС.000000.001";
            model.File!.Name.Naming = "Линза";

            model.Material!.Tittle = "Стекло";
            model.Material.Density = 5;

            model.ExternalDiameter = 200;
            model.Height = 5;

            return model;
        }
    }
}
