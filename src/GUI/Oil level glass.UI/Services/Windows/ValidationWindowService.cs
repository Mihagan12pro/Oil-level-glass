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
            Window window = null;

            if (model.Error == string.Empty)
                window = new NoProblemsWindow();
            else
                window = new ValidationWindow(model); 

            window.Owner = _owner;

            window.ShowDialog();
        }

        public ValidationWindowService(Window owner)
        {
            _owner = owner;
        }
    }
}
