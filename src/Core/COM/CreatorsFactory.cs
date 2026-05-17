using Oil_level_glass.Core.COM.Api7.Glass;
using Oil_level_glass.Core.COM.Api7.Housing;
using Oil_level_glass.Core.COM.Api7.OilLevelGlass;
using Oil_level_glass.Core.COM.Api7.RubberStrip;
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

        public IHousingPartCreator CreateHousingPartCreator(HousingModel housing)
            => new HousingPartCreator7(housing);

        public IRubberStripPartCreator CreateRubberStripPartCreator(RubberStripModel rubberStripModel)
            => new RubberStripCreator7(rubberStripModel);

        public IOilLevelGlassPartCreator CreateOilLevelGlassPartCreator(GlassModel glass, RubberStripModel rubberStrip, HousingModel housing)
            => new OilLevelGlassPartCreator(glass, rubberStrip, housing);
    }
}
