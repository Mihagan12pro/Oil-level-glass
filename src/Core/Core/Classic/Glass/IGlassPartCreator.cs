using Oil_level_glass.Model.Data.Entities;
using Oil_level_glass.Model.Data.Entities.Parts.Classic;

namespace Oil_level_glass.Core.Classic.Glass
{
    public interface IGlassPartCreator 
        : ISolidPartCreator<GlassModel>
    {
        void AddSketch1();
        /// <summary>
        /// Edit sketch1 variables
        /// </summary>
        void EditSketch1();

        /// <summary>
        /// Edit sketch1
        /// </summary>
        void ExtrudeSketch1();

        /// <summary>
        /// Edit sketch1 extrusion (for emample, change direction)
        /// </summary>
        void EditSketch1Extrusion();
    }
}
