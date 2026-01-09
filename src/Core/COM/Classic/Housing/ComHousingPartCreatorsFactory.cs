using Oil_level_glass.Core.Classic.Housing;

namespace Oil_level_glass.COM.Classic.Housing
{
    public class ComHousingPartCreatorsFactory
        : IHousingPartCreatorFactory
    {
        public IHousingPartCreator GetCreator()
        {
            return new HousingPartCreator();
        }
    }
}
