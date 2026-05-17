using Oil_level_glass.UI.Presenters;
using Shared.Results;

namespace Oil_level_glass.Presenters.Wizards
{
    public interface IWizardPresenter : IPresenter
    {
        void InvokeEditor(object tag);

        void UpdateModel();

        Result Create();

        Action InvokeGlassEditor { get; }
        Action InvokeHousingEditor { get; }
        Action InvokeRubberStripEditor { get; }
    }
}
