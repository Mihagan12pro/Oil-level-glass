using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.Core
{
    /// <summary>
    /// Only for details. Not for assemblies or drawings
    /// </summary>
    public interface ISolidPartCreator 
        : ICreator
    {
        /// <summary>
        /// Edit density, material title, hatch style or etc
        /// </summary>
        void EditMaterial();

        /// <summary>
        /// Edit part color, transparency or etc
        /// </summary>
        void EditAppearances();
    }
}
