using Oil_level_glass.UI.Presenters.Editors;
using Shared.Results;

namespace Oil_level_glass.Presenters.Editors.Data.Entities.Housing
{
    public interface IHousingEditorPresenter : IEditorPresenter
    {
        Result UpdateMainDiameter(string mainDiameter);

        Result UpdateMainHeight(string mainHeight);
    }
}
