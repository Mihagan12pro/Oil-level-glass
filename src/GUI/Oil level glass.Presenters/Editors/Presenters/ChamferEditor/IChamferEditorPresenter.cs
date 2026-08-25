using Oil_level_glass.Model.Data.Operations;
using Oil_level_glass.UI.Abstractions.Editors.Housing.ChamferEditor;
using Oil_level_glass.UI.Presenters.Editors;

namespace Oil_level_glass.Presenters.Editors.Presenters.ChamferEditor
{
    public interface IChamferEditorPresenter : IEditorPresenter<ChamferModel>
    {
        void ChangeChamferType(ChamferType chamferType);
    }
}
