using Oil_level_glass.Presenters.Editors.HelpStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.Presenters.Editors.ModelProperties.FoldersEditor.HelpStructures
{
    public class DefaultFolders : DefaultSizes
    {
        public readonly string Folder;

        public DefaultFolders(string folder)
            => Folder = folder;
    }
}
