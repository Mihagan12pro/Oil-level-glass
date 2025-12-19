using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.Core.Classic.RubberStrip
{
    public interface IRubberStripPartCreator 
        : ISolidPartCreator
    {
        RubberStripModel RubberStrip { get; set; }

        void AddSketch1();

        /// <summary>
        /// Edit sketch1 variables
        /// </summary>
        void EditSketch1();

        void RotateSketch1();
    }
}
