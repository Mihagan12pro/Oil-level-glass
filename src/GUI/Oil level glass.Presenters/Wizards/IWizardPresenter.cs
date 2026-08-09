using Oil_level_glass.UI.Abstractions.Wizards;
using Oil_level_glass.UI.Presenters;
using Shared.DataStructues;
using Shared.Results;

namespace Oil_level_glass.Presenters.Wizards
{
    public interface IWizardPresenter<TView> : IPresenter
        where TView : IWizardView
    {
        void SelectPart(string displayName);

        void SetView(TView view);

        Catalog GetParts();

        Result CanBeConfigured { get; }
    }
}
