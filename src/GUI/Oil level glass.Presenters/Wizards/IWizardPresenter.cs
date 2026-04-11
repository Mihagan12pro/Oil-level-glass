using Oil_level_glass.UI.Presenters;

namespace Oil_level_glass.Presenters.Wizards
{
    public interface IWizardPresenter : IPresenter
    {
        void InvokeEditor(object tag);

        void UpdateModel();

        Action InvokeGlassEditor { get; set; }

        Action InvokeHousingEditor { get; set; }

        Action InvokeRubberStripEditor { get; set; }
    }
}
