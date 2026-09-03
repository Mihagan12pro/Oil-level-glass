using Oil_level_glass.Model.Data.Entities;
using Oil_level_glass.Model.Data.Entities.Parts;
using Oil_level_glass.Presenters.Editors.Presenters.ModelProperties.Enums;
using Oil_level_glass.UI.Abstractions.Editors.ModelProperties;
using Oil_level_glass.UI.Presenters.Editors;
using Shared.Results;
using System.Collections;

namespace Oil_level_glass.Presenters.Editors.Presenters.ModelProperties
{
    public interface IModelPropertiesPresenter<TView> 
        where TView : IModelPropertyEditorView
    {
        ModelPropertyState ModelState { get; }

        IEnumerable ModelsTitles { get; }

        TView View { get; set; }

        void AddModel(BaseEntityModel model);

        void SelectModel(int index);
    }
}
