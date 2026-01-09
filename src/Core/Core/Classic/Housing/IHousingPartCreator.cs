using Oil_level_glass.Model.Data.Entities.Parts.Classic;

namespace Oil_level_glass.Core.Classic.Housing
{
    public interface IHousingPartCreator
        : ISolidPartCreator<HousingModel>
    {
        void AddSketch1();

        /// <summary>
        /// Edit sketch1 variables
        /// </summary>
        void EditSketch1();

        void AddSketch2();

        /// <summary>
        /// Edit sketch2 variables
        /// </summary>
        void EditSketch2();

        void AddSketch3();

        /// <summary>
        /// Edit sketch3 variables
        /// </summary>
        void EditSketch3();

        void ExtrudeSketch1();

        /// <summary>
        /// Edit extrusion sketch1 variables
        /// </summary>
        void EditSketch1Extrusion();

        void ExtrudeSketch2();

        /// <summary>
        /// Edit cut extrusion sketch1 variables
        /// </summary>
        void EditSketch2Extrusion();

        void AddScrewHoles();

        /// <summary>
        /// Edit screw holes. For example, set count = 5 or radius = 20
        /// </summary>
        void EditScrewHoles();

        /// <summary>
        /// Add chamfer or roundings
        /// </summary>
        void AddRounding();

        /// <summary>
        /// Edit chamfer or rounding. For example, set radius = 20 mm
        /// </summary>
        void EditRounding();
    }
}
