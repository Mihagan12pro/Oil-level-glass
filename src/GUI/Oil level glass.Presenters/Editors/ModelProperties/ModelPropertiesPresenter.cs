using Oil_level_glass.Model.Data.Entities;
using Oil_level_glass.Presenters.Editors.ModelProperties.Enums;
using Oil_level_glass.UI.Abstractions.Editors.ModelProperties;
using System.Collections;

namespace Oil_level_glass.Presenters.Editors.ModelProperties
{
    internal abstract class ModelPropertiesPresenter<TView> : ModelPropertiesPresenter, IModelPropertiesPresenter<TView>
        where TView : IModelPropertyEditorView
    {
        protected readonly ArrayList modelsTitles = new ArrayList();

        protected readonly List<BaseEntityModel> models = new List<BaseEntityModel>();

        protected TView view;

        protected BaseEntityModel selectedModel = null;

        protected ModelPropertyState modelState = ModelPropertyState.None;

        public IEnumerable ModelsTitles
            => modelsTitles;

        public virtual ModelPropertyState ModelState
            => modelState;

        public virtual TView View
        {
            get
            {
                return view;
            }
            set
            {
                view = value;

                view.PendingForUpdateHandler += View_PendingForUpdateHandler;
            }
        }

        protected virtual void View_PendingForUpdateHandler()
            => modelState = ModelPropertyState.PendingForUpdate;

        public virtual void AddModel(BaseEntityModel model)
        {
            modelsTitles.Add(model.DisplayName);

            models.Add(model);

            modelState = ModelPropertyState.None;
        }

        public virtual void SelectModel(int index)
        {
            try
            {
                if (index == -1)
                {
                    selectedModel = null;

                    return;
                }

                selectedModel = models[index];
                modelState = ModelPropertyState.None;
            }
            finally
            {

            }
        }
    }

    internal class ModelPropertiesPresenter
    {

    }
}
