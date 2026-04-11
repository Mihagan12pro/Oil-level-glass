using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.UI.Abstractions.Wizards;
using Shared;

namespace Oil_level_glass.UI.Presenters.Wizard3d
{
    internal class Wizard3dPresenter
    {
        private readonly IWizardForm _wizardForm;

        private readonly HousingModel _housing;
        private readonly RubberStripModel _rubberStrip;
        private readonly GlassModel _glass;

        public Wizard3dPresenter(
            IWizardForm mainForm,
            HousingModel housing,
            RubberStripModel rubberStrip,
            GlassModel glass)
        {
            _wizardForm = mainForm;

            _glass = glass;
            _housing = housing;
            _rubberStrip = rubberStrip;
        }

        public void UpdateModel()
        {
            _rubberStrip.ExternalDiameter = _glass.ExternalDiameter;

            _housing.GlassSocketDiameter = _glass.ExternalDiameter;
            _housing.CentralHoleDiameter = _rubberStrip.InternalDiameter;
            _housing.GlassSocketHeight = _rubberStrip.Height;

            _wizardForm.CanCreate.Invoke(_housing.Error == string.Empty &&
                _glass.Error == string.Empty &&
                 _rubberStrip.Error == string.Empty);
        }
    }
}
