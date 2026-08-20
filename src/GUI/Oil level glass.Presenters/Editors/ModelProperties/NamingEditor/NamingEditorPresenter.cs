using Oil_level_glass.Model.Data.Entities;
using Oil_level_glass.Model.Data.Entities.Parts;
using Oil_level_glass.Model.ModelProperties.Other;
using Oil_level_glass.Presenters.Editors.ModelProperties.FoldersEditor.HelpStructures;
using Oil_level_glass.Presenters.Editors.ModelProperties.NamingEditor.HelpStructures;
using Shared.Results;
using System.Collections;

namespace Oil_level_glass.Presenters.Editors.ModelProperties.NamingEditor
{
    internal class NamingEditorPresenter : INamingEditorPresenter
    {
        private List<BaseEntityModel> _models = new();

        private BaseEntityModel? _selected = null;

        private Name _oldName = null;

        public IEnumerable Models
            => _models.Select(f => f.DisplayName);

        public DefaultNaming DefaultSizes
            => throw new NotImplementedException();

        public void AddModel(BaseEntityModel model)
        {
            throw new NotImplementedException();
        }

        public void ResetFields()
        {
            throw new NotImplementedException();
        }

        public void SelectModel(int index)
        {
            try
            {
                if (index >= 0)
                {
                    _selected = _models[index];

                    _oldName = _selected.File.Name;
                }
            }
            finally
            {

            }
        }

        public NamingUpdateResults UpdateModel(NamingUpdateData updateData)
        {
            if (!string.IsNullOrWhiteSpace(updateData.Naming))
            {
                _oldName.Naming = updateData.Naming;
                _oldName.Marking = updateData.Marking;

                return new NamingUpdateResults() 
                {
                    Naming = new Result(true)
                };
            }
            string oldNaming = _oldName.Naming;

            _oldName.Naming = updateData.Naming;
            string errorsMessage = _oldName[nameof(_oldName.Naming)];
            _oldName.Naming = oldNaming;

            return new NamingUpdateResults()
            {
                Naming = new Result(false, errorsMessage)
            };
        }
    }
}
