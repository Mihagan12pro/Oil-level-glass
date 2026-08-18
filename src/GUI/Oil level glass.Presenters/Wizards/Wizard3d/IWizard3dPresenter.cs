using Oil_level_glass.UI.Abstractions.Wizards.Wizard3d;

namespace Oil_level_glass.Presenters.Wizards.Wizard3d
{
    public interface IWizard3dPresenter 
        : IWizardPresenter<IWizard3dView>
    {
        void SetDefaultFolder(string folder);
    }
}
