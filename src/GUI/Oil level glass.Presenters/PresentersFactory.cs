using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Presenters.Editors.Data.ChamferEditor;
using Oil_level_glass.Presenters.Editors.Data.Entities.Glass;
using Oil_level_glass.Presenters.Editors.Data.Entities.Housing;
using Oil_level_glass.Presenters.Editors.Data.Entities.RubberStrip;
using Oil_level_glass.Presenters.Editors.Data.HolesEditor;
using Oil_level_glass.Presenters.Wizards.Wizard3d;
using Oil_level_glass.UI.Abstractions.Editors.Glass;
using Oil_level_glass.UI.Abstractions.Editors.Housing;
using Oil_level_glass.UI.Abstractions.Editors.Housing.ChamferEditor;
using Oil_level_glass.UI.Abstractions.Editors.Housing.HolesEditor;
using Oil_level_glass.UI.Abstractions.Editors.RubberStrip;
using Oil_level_glass.UI.Abstractions.Wizards.Wizard3d;

namespace Oil_level_glass.Presenters
{
    public static class PresentersFactory
    {
        public static IChamferEditorPresenter CreateChamferEditorPresenter(IChamferEditorView form, Action checkData)
            => new ChamferEditorPresenter(form, checkData);

        public static IHolesEditorPresenter CreateHolesEditorPresenter(IHolesEditorView form, Action checkData)
            => new HolesEditorPresenter(form, checkData);

        public static IRubberStripEditorPresenter CreateRubberStripPresenter(
            IRubberStripEditorView form,
            Action checkData) => new RubberStripEditorPresenter(form, checkData);

        public static IGlassEditorPresenter CreateGlassEditorPresenter(
            IGlassView form,
            Action checkData) => new GlassEditorPresenter(form, checkData);

        public static IHousingEditorPresenter CreateHousingEditorPresenter(
            IHousingEditorView form,
            Action checkData) => new HousingEditorPresenter(form, checkData);

        public static IWizard3dPresenter CreateWizard3dPresenter(
            IWizard3dView form,
            GlassModel glass,
            RubberStripModel rubberStrip,
            HousingModel housing,
            Action invokeGlassEditor,
            Action invokeRubberStripEditor,
            Action invokeHousingEditor,
            Action checkData)
        {
            return new Wizard3dPresenter();
        }
    }
}
