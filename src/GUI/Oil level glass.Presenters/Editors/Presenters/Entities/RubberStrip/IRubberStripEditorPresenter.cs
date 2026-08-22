using Oil_level_glass.Presenters.Editors.Presenters.Entities.RubberStrip.HelpStructures;
using Oil_level_glass.UI.Abstractions.Editors.RubberStrip;
using Oil_level_glass.UI.Presenters.Editors;
using Shared.Results;

namespace Oil_level_glass.Presenters.Editors.Presenters.Entities.RubberStrip
{
    public interface IRubberStripEditorPresenter 
        : IEditorPresenter<IRubberStripEditorView, RubberStripUpdateResults, RubberStripUpdateData, RubberStripDefaultSizes>
    {
       
    }
}
