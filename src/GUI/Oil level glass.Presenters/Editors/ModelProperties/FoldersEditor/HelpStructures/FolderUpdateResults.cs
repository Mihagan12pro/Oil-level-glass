using Oil_level_glass.Presenters.Editors.HelpStructures;
using Shared.Results;

namespace Oil_level_glass.Presenters.Editors.ModelProperties.FoldersEditor.HelpStructures
{
    public class FolderUpdateResults : UpdateResults
    {
        public readonly Result FolderResult;

        public FolderUpdateResults(Result folder)
            => FolderResult = folder;
    }
}
