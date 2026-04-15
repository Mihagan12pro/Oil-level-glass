using Oil_level_glass.UI.Presenters.Editors;
using Shared;

namespace Oil_level_glass.Presenters.Editors.RubberStrip
{
    public interface IRubberStripEditorPresenter : IEditorPresenter
    {
        Result UpdateInternalDiameter(string diameter);
    }
}
