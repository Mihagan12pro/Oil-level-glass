using Oil_level_glass.Presenters.Editors.Presenters.ModelProperties;
using Oil_level_glass.UI.Abstractions.Editors.ModelProperties;
using Shared.Results;

namespace Oil_level_glass.Presenters.Editors.Presenters.ModelProperties.Folder
{
    public interface IFolderEditorPresenter : IModelPropertiesPresenter<IFolderEditorView>
    {
        Result Update(string folder);
    }
}
