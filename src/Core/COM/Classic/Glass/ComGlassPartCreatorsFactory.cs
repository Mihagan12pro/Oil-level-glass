using Oil_level_glass.Core.Classic.Glass;

namespace Oil_level_glass.COM.Classic.Glass
{
    public class ComGlassPartCreatorsFactory
        : IGlassPartCreatorFactory
    {
        public IGlassPartCreator GetCreator()
        {
            return new GlassPartCreator();
        }
    }
}
