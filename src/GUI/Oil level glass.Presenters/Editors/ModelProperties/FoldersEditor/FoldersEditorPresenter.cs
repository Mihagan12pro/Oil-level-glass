using Oil_level_glass.Model.Data.Entities.Parts;
using Oil_level_glass.Presenters.Editors.ModelProperties.FoldersEditor.HelpStructures;
using Shared.Results;
using System.Collections;

namespace Oil_level_glass.Presenters.Editors.ModelProperties.FoldersEditor
{
    internal class FoldersEditorPresenter : IFoldersEditorPresenter
    {
        private List<BaseDetailModel> _models = new ();

        private string? _oldFolder = string.Empty;

        private BaseDetailModel? _selected = null;

        public IEnumerable Models
            => _models.Select(f => f.DisplayName);

        public DefaultFolders DefaultSizes
            => new DefaultFolders(_oldFolder);

        public void AddModel(BaseDetailModel model)
            => _models.Add(model);

        public void ResetFields()
        {
            if (_selected != null && _selected.File != null) 
                _selected.File.Folder = _oldFolder;
        }

        public void SelectModel(int index)
        {
            try
            {
               if (index >= 0)
                {
                    _selected = _models[index];

                    _oldFolder = _selected.File!.Folder;
                }
            }
            finally
            {

            }
        }

        public FolderUpdateResults UpdateModel(FolderUpdateData updateData)
        {
            if (Directory.Exists(updateData.Folder))
            {
                _selected.File.Folder = updateData.Folder;
                _oldFolder = updateData.Folder;

                return new FolderUpdateResults(new Result(true));
            }

            _selected.File.Folder = updateData.Folder;
            string errorsMessage = _selected[nameof(_selected.File.Folder)];
            _selected.File.Folder = _oldFolder;

            return new FolderUpdateResults(new Result(false, errorsMessage));
        }
    }
}
