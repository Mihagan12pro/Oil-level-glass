using Oil_level_glass.Model.Data.Operations;
using Oil_level_glass.Presenters.Editors.ChamferEditor.HelpStructures;
using Oil_level_glass.UI.Abstractions.Editors.Housing.ChamferEditor;
using Oil_level_glass.UI.Presenters.Editors;
using Shared.Results;

namespace Oil_level_glass.Presenters.Editors.Data.ChamferEditor
{
    public interface IChamferEditorPresenter
        : IEditorPresenter<IChamferEditorView, ChamferUpdateResults, ChamferUpdateData, ChamferDefaultSizes>
    {
        void ChangeChamferType(ChamferType chamferType);
    }
}
