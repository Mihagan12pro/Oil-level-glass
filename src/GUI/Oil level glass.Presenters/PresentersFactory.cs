using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Presenters.Editors.Housing;
using Oil_level_glass.Presenters.Editors.Housing.HolesEditor;
using Oil_level_glass.Presenters.Editors.RubberStrip;
using Oil_level_glass.Presenters.Wizards.Wizard3d;
using Oil_level_glass.UI.Abstractions.Editors.Glass;
using Oil_level_glass.UI.Abstractions.Editors.Housing;
using Oil_level_glass.UI.Abstractions.Editors.Housing.HolesEditor;
using Oil_level_glass.UI.Abstractions.Editors.RubberStrip;
using Oil_level_glass.UI.Abstractions.Wizards.Wizard3d;
using Oil_level_glass.UI.Presenters.Editors.Glass;

namespace Oil_level_glass.Presenters
{
    public static class PresentersFactory
    {
        public static IHolesEditorPresenter CreateHolesEditorPresenter(IHolesEditorForm form, Action checkData)
            => new HolesEditorPresenter(form, checkData);

        public static IRubberStripEditorPresenter CreateRubberStripPresenter(
            IRubberStripEditorForm form,
            Action checkData) => new RubberStripEditorPresenter(form, checkData);

        public static IGlassEditorPresenter CreateGlassEditorPresenter(
            IGlassEditorForm form,
            Action checkData) => new GlassEditorPresenter(form, checkData);

        public static IHousingEditorPresenter CreateHousingEditorPresenter(
            IHousingForm form,
            Action checkData) => new HousingEditorPresenter(form, checkData);

        public static IWizard3dPresenter CreateWizard3dPresenter(
            IWizard3dForm form,
            GlassModel glass,
            RubberStripModel rubberStrip,
            HousingModel housing,
            Action invokeGlassEditor,
            Action invokeRubberStripEditor,
            Action invokeHousingEditor,
            Action checkData)
        {
            return new Wizard3dPresenter(
                form,
                glass, 
                rubberStrip,
                housing, 
                invokeGlassEditor,
                invokeRubberStripEditor,
                invokeHousingEditor,
                checkData);
        }
    }
}
