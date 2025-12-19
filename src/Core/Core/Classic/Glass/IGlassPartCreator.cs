using Oil_level_glass.Model.Data.Entities;
using Oil_level_glass.Model.Data.Entities.Parts.Classic;

namespace Oil_level_glass.Core.Classic.Glass
{
    public interface IGlassPartCreator 
        : ISolidPartCreator
    {
        /// <summary>
        /// Domain model
        /// </summary>
        GlassModel GlassModel { get; set; }

        void AddSketch1();
        /// <summary>
        /// Edit sketch1 variables
        /// </summary>
        void EditSketch1();

        void RotateSketch1();
    }
}
