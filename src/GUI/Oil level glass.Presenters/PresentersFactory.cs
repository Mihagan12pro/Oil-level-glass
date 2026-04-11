using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Presenters.Wizards.Wizard3d;
using Oil_level_glass.UI.Abstractions.Editors.Glass;
using Oil_level_glass.UI.Abstractions.Wizards.Wizard3d;
using Oil_level_glass.UI.Presenters.Editors.Glass;

namespace Oil_level_glass.Presenters
{
    public static class PresentersFactory
    {
        public static IGlassEditorPresenter CreateGlassEditorPresenter(IGlassEditorForm form)
        {
            return new GlassEditorPresenter(form);
        }

        public static IWizard3dPresenter CreateWizard3dPresenter(
            IWizard3dForm form,
            GlassModel glass,
            RubberStripModel rubberStrip,
            HousingModel housing)
        {
            return new Wizard3dPresenter(form, glass, rubberStrip, housing);
        }
    }
}
