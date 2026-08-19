using Oil_level_glass.Presenters.Editors.HelpStructures;

namespace Oil_level_glass.Presenters.Editors.ModelProperties.FoldersEditor.HelpStructures
{
    public class FolderUpdateData : UpdateData
    {
        public readonly string Folder;

        public FolderUpdateData(string folder)
            => Folder = folder;
    }
}
