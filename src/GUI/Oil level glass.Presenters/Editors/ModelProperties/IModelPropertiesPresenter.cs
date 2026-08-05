using Oil_level_glass.Model.Data.Entities;
using Oil_level_glass.Model.Data.Entities.Parts;
using Oil_level_glass.UI.Presenters.Editors;
using Shared.Results;
using System.Collections;

namespace Oil_level_glass.Presenters.Editors.ValueObjects
{
    public interface IModelPropertiesPresenter
    {
        IEnumerable ModelsTitles { get; }

        void AddModel(BaseEntityModel model);

        void SelectModel(int index);
    }
}
