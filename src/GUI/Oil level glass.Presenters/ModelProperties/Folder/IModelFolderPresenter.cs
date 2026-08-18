using Oil_level_glass.Presenters.ModelProperties;
using Shared.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.Presenters.ModelProperties.Folder
{
    public interface IModelFolderPresenter : IModelPropertiesPresenter
    {
        Result Update(string folder);
    }
}
