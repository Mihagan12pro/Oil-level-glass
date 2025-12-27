using Oil_level_glass.Model.Data.Entities.Parts;
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
    public interface ISolidPartCreator<TPartModel>
        : ICreator
        where TPartModel : BaseDetailModel
    {
        public TPartModel PartModel { get; set; }

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
