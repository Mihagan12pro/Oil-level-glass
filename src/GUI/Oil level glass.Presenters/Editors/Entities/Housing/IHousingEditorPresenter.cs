using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Presenters.Editors.Entities.Housing.DataStructures;
using Oil_level_glass.UI.Abstractions.Editors.Housing;
using Oil_level_glass.UI.Presenters.Editors;
using Shared.Results;

namespace Oil_level_glass.Presenters.Editors.Data.Entities.Housing
{
    public interface IHousingEditorPresenter 
        : IEditorPresenter<IHousingEditorView, HousingUpdateResults, HousingUpdateData, HousingDefaultSizes>
    {
        Result UpdateMainDiameter(string mainDiameter);

        Result UpdateMainHeight(string mainHeight);
    }
}
