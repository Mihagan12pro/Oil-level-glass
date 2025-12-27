using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.Core.Classic.Housing
{
    public interface IHousingPartCreator
        : ISolidPartCreator<HousingModel>
    {
        /// <summary>
        /// Domain model
        /// </summary>
        HousingModel Housing { get; set; }

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

        void RotateSketch1();

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
