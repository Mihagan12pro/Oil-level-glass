using Oil_level_glass.Core.Classic.RubberStrip;

namespace Oil_level_glass.COM.Classic.RubberStrip
{
    public class ComRubberStripPartCreatorFactory
        : IRubberStripPartCreatorFactory
    {
        public IRubberStripPartCreator GetCreator()
        {
            return new RubberStripPartCreator();
        }
    }
}
