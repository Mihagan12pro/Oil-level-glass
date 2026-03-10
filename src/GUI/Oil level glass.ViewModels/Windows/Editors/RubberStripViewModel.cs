using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.ViewModels.Commands;
using Oil_level_glass.ViewModels.Services.Windows;

namespace Oil_level_glass.ViewModels.Windows.Editors
{
    public class RubberStripViewModel : EditorViewModel<RubberStripModel>
    {
        private double _height, _externalDiameter, _internalDiameter;

        public override RelayCommand CancelCommand
        {
            get
            {
                return new RelayCommand((obj) =>
                {
                    Model.Height = _height;
                    Model.ExternalDiameter = _externalDiameter;
                    Model.InternalDiameter = _internalDiameter;

                    closeAction.Invoke();
                });
            }
        }

        public RubberStripViewModel(
            RubberStripModel model,
            Action closeAction, 
            IValidationWindowService validationWindowService) : base(model, closeAction, validationWindowService)
        {
            _height = model.Height;
            _externalDiameter = model.ExternalDiameter;
            _internalDiameter = model.InternalDiameter;
        }
    }
}
