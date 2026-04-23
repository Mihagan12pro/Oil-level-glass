using Oil_level_glass.Core.Glass;
using Oil_level_glass.Core.Housing;
using Oil_level_glass.Core.OilLevelGlass;
using Oil_level_glass.Core.RubberStrip;
using Oil_level_glass.Model.Data.Entities.Parts.Classic;

namespace Oil_level_glass.Core
{
    public interface ICreatorsFactory
    {
        IGlassPartCreator CreateGlassPart(GlassModel glass);

        IRubberStripPartCreator CreateRubberStripPart(RubberStripModel rubberStripModel);

        IHousingPartCreator CreateHousingPart(HousingModel housing);

        IOilLevelGlassPartCreator CreateOilLevelGlassAssembly(GlassModel glass, RubberStripModel rubberStrip, HousingModel housing);
    }
}
