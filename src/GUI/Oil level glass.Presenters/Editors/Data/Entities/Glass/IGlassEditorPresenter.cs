using Oil_level_glass.UI.Presenters.Editors;
using Shared.Results;

namespace Oil_level_glass.Presenters.Editors.Data.Entities.Glass
{
    public interface IGlassEditorPresenter : IEditorPresenter
    {
        Result UpdateDiameter(string diameter);

        Result UpdateHeight(string width);
    }
}