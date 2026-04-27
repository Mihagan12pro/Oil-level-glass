using Oil_level_glass.UI.Presenters.Editors;
using Shared.Results;

namespace Oil_level_glass.Presenters.Editors.Housing.ChamferEditor
{
    public interface IChamferEditorPresenter : IEditorPresenter
    {
        Result UpdateAngle(string angle);

        Result UpdateLength(string length);
    }
}
