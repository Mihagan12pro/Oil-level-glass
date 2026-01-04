using Oil_level_glass.Model.Data.Entities.Parts.Classic;

namespace Oil_level_glass.Core.Classic.RubberStrip
{
    public interface IRubberStripPartCreator 
        : ISolidPartCreator<RubberStripModel>
    {
        void AddSketch1();

        /// <summary>
        /// Edit sketch1 variables
        /// </summary>
        void EditSketch1();

        void RotateSketch1();
    }
}
