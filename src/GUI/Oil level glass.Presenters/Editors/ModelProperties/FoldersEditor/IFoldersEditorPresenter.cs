using Oil_level_glass.Model.Data.Entities.Parts;
using Oil_level_glass.Presenters.Editors.ModelProperties.FoldersEditor.HelpStructures;
using Oil_level_glass.UI.Abstractions.Editors.ModelProperties;

namespace Oil_level_glass.Presenters.Editors.ModelProperties.FoldersEditor
{
    public interface IFoldersEditorPresenter 
        : IModelPrepertyEditorPresenter<
            BaseDetailModel,
            IFolderEditorView,
            FolderUpdateResults, 
            FolderUpdateData,
            DefaultFolders>
    {
    }
}
