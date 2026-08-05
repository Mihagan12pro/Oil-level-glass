using Oil_level_glass.Model.Data.Entities;
using Oil_level_glass.Presenters.Editors.ValueObjects;
using Shared.Results;
using System.Collections;

namespace Oil_level_glass.Presenters.Editors.ModelProperties
{
    internal class ModelPropertiesPresenter : IModelPropertiesPresenter
    {
        protected readonly ArrayList modelsTitles = new ArrayList();

        protected readonly List<BaseEntityModel> models = new List<BaseEntityModel>();

        protected BaseEntityModel _selectedModel = null;

        public IEnumerable ModelsTitles
            => modelsTitles;

        public void AddModel(BaseEntityModel model)
        {
            modelsTitles.Add(model.DisplayName);

            models.Add(model);
        }

        public Result IsValid()
        {
            throw new NotImplementedException();
        }

        public void SelectModel(int index)
        {
            if (index == -1)
            {
                _selectedModel = null;

                return;
            }

            _selectedModel = models[index];
        }
    }
}
