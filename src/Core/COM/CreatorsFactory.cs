using Oil_level_glass.Core.COM.Api7.Glass;
using Oil_level_glass.Core.Glass;
using Oil_level_glass.Core.Housing;
using Oil_level_glass.Core.OilLevelGlass;
using Oil_level_glass.Core.RubberStrip;
using Oil_level_glass.Model.Data.Entities.Parts.Classic;

namespace Oil_level_glass.Core.COM
{
    public class CreatorsFactory : ICreatorsFactory
    {
        public IGlassPartCreator CreateGlassPart(GlassModel glass)
            => new GlassPartCreator7(glass);

        public IHousingPartCreator CreateHousingPart(HousingModel housing)
        {
            throw new NotImplementedException();
        }

        public IOilLevelGlassPartCreator CreateOilLevelGlassAssembly(GlassModel glass, RubberStripModel rubberStrip, HousingModel housing)
        {
            throw new NotImplementedException();
        }

        public IRubberStripPartCreator CreateRubberStripPart(RubberStripModel rubberStripModel)
        {
            throw new NotImplementedException();
        }
    }
}
