using Oil_level_glass.Model.Data;
using Oil_level_glass.ViewModels.Services.Windows;
using Oil_level_glass_UI.Windows.Validation;
using System.Windows;

namespace Oil_level_glass_UI.Services.Windows
{
    internal class ValidationWindowService : IValidationWindowService
    {
        private readonly Window _owner;

        public void Check(BaseModel model)
        {
            ValidationWindow validationWindow = new ValidationWindow(model);

            validationWindow.Owner = _owner;

            validationWindow.ShowDialog();
        }

        public ValidationWindowService(Window owner)
        {
            _owner = owner;
        }
    }
}
