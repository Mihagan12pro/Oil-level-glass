using Oil_level_glass.UI.Presenters.Editors;
using Shared.Results;

namespace Oil_level_glass.Presenters.Editors.Data.HolesEditor
{
    public interface IHolesEditorPresenter : IEditorPresenter
    {
        Result UpdateCountOfHoles(string count);

        Result UpdateDiameter(string diameter);
    }
}
