using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.Core
{
    public interface IPartCreator
    {
        /// <summary>
        /// Save file with a solid part
        /// </summary>
        void SaveFile();
    }
}
