namespace Oil_level_glass.Core.Classic.OilLevelGlass
{
    public interface IOilLevelGlassPartCreator 
        : ICreator
    {
        void AddHousing();

        void AddGlass();

        /// <summary>
        /// Add only top rubber strip
        /// </summary>
        void AddTopRubberStrip();

        /// <summary>
        /// Add only bottom rubber strip
        /// </summary>
        void AddBottomRubberStrip();

        /// <summary>
        /// Add two rubber strips
        /// </summary>
        void AddRubberStrips();

        /// <summary>
        /// Add all parts
        /// </summary>
        void AddAllParts();

        /// <summary>
        /// Assemble all parts
        /// </summary>
        void Assemble();
    }
}
