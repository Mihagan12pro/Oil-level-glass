using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.ViewModels.Services.Windows;

namespace Oil_level_glass.ViewModels.Windows.Editors
{
    public class RubberStripViewModel : EditorViewModel<RubberStripModel>
    {


        public RubberStripViewModel(
            RubberStripModel model,
            Action closeAction, 
            IValidationWindowService validationWindowService) : base(model, closeAction, validationWindowService)
        {
        }
    }
}
