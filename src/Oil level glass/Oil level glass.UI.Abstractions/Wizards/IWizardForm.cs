namespace Oil_level_glass.UI.Abstractions.Wizards
{
    public interface IWizardForm : IForm
    {
        Action<bool> CanCreate { get; }
    }
}
