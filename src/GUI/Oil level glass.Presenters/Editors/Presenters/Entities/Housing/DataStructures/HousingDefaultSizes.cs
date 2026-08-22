using Oil_level_glass.Presenters.Editors.EditorsData.BaseData;

namespace Oil_level_glass.Presenters.Editors.Presenters.Entities.Housing.DataStructures
{
    public class HousingDefaultSizes : DefaultDataValues
    {
        public readonly string MainDiameter = string.Empty;
        
        public readonly string MainHeight = string.Empty;

        public readonly string GlassSocketDiameter = string.Empty;

        public readonly string GlassSocketHeight = string.Empty;

        public HousingDefaultSizes(
            double mainDiameter,
            double glassSocketDiameter,
            double mainHeight, 
            double glassSocketHeight)
        {
            if (mainHeight > 0)
                MainHeight = mainHeight.ToString();

            if (mainDiameter > 0)
                MainDiameter = mainDiameter.ToString();

            if (glassSocketDiameter > 0)
                GlassSocketDiameter = glassSocketDiameter.ToString();

            if (glassSocketHeight > 0)
                GlassSocketHeight = glassSocketHeight.ToString();
        }
    }
}
