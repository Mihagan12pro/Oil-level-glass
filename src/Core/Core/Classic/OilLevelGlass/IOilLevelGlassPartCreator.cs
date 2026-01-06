using Oil_level_glass.Model.Data.Entities.Parts.Classic;

namespace Oil_level_glass.Core.Classic.OilLevelGlass
{
    public interface IOilLevelGlassPartCreator
        : IAssemblyPartCreator<OilLevelGlassModel>
    {
        void AddHousing();

        void AddGlass();

        /// <summary>
        /// Add top rubber strip
        /// </summary>
        void AddTopRubberStrip();

        /// <summary>
        /// Add bottom rubber strip
        /// </summary>
        void AddBottomRubberStrip();

        /// <summary>
        /// Assemble all parts
        /// </summary>
        void Assemble();
    }
}
