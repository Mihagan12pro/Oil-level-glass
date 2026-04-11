using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.UI.Abstractions.Wizards.Wizard3d;

namespace Oil_level_glass.Presenters.Wizards.Wizard3d
{
    internal class Wizard3dPresenter : IWizard3dPresenter
    {
        private readonly IWizard3dForm _wizardForm;

        private readonly HousingModel _housing;
        private readonly RubberStripModel _stripModel;
        private readonly GlassModel _glass;

        public Action InvokeGlassEditor { get; set; }

        public Action InvokeHousingEditor { get; set; }

        public Action InvokeRubberStripEditor { get; set; }

        public void InvokeEditor(object tag)
        {
            throw new NotImplementedException();
        }

        public void UpdateModel()
        {
            throw new NotImplementedException();
        }

        public Wizard3dPresenter(
            IWizard3dForm wizardForm, 
            GlassModel glass,
            RubberStripModel rubberStrip, 
            HousingModel housing)
        {
            _wizardForm = wizardForm;

            _glass = glass;
            _stripModel = rubberStrip;
            _housing = housing;
        }
    }
}
