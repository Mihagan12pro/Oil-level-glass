using Oil_level_glass.Presenters.Editors.Data.ChamferEditor;
using Oil_level_glass.UI.Abstractions.Editors.Housing.ChamferEditor;

namespace Oil_level_glass.Presenters
{
    public static class PresentersFactory
    {
        public static IChamferEditorPresenter CreateChamferEditorPresenter(IChamferEditorView form, Action checkData)
            => new ChamferEditorPresenter(form, checkData);
    }
}
