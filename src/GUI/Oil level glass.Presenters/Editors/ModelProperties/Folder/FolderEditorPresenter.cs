using Oil_level_glass.Presenters.Editors.ModelProperties.Enums;
using Oil_level_glass.UI.Abstractions.Editors.ModelProperties;
using Shared.Results;

namespace Oil_level_glass.Presenters.Editors.ModelProperties.Folder
{
    internal class FolderEditorPresenter : ModelPropertiesPresenter<IFolderEditorView>, IFolderEditorPresenter
    {
        private IFolderEditorView _view;

        private void view_PendingForUpdateHandler()
            => modelState = ModelPropertyState.PendingForUpdate;


        public IFolderEditorView View
        {
            get
            {
                return _view;
            }
            set
            {
                _view = value;

                _view.PendingForUpdateHandler += view_PendingForUpdateHandler;
            }
        }

        public Result Update(string folder)
        {
            if (Directory.Exists(folder))
                return new Result(false, "This folder does not exists!");

            return new Result(true);
        }
    }
}
