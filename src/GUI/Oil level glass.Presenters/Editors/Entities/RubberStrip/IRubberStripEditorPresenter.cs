using Oil_level_glass.UI.Abstractions.Editors.RubberStrip;
using Oil_level_glass.UI.Presenters.Editors;
using Shared.Results;

namespace Oil_level_glass.Presenters.Editors.Data.Entities.RubberStrip
{
    public interface IRubberStripEditorPresenter 
        : IEditorPresenter<IRubberStripEditorView>
    {
        Result UpdateInternalDiameter(string diameter);

        Result UpdateHeight(string height);
    }
}
