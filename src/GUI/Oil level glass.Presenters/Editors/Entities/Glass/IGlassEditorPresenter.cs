using Oil_level_glass.Presenters.Editors.Entities.Glass.HelpStructures;
using Oil_level_glass.UI.Abstractions.Editors.Glass;
using Oil_level_glass.UI.Presenters.Editors;
using Shared.Results;

namespace Oil_level_glass.Presenters.Editors.Data.Entities.Glass
{
    public interface IGlassEditorPresenter
        : IEditorPresenter<IGlassEditorView, GlassUpdateResults, GlassUpdateData, GlassDefaultSizes>
    {
       
    }
}