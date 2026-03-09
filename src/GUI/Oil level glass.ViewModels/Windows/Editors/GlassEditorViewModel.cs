using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.ViewModels.Commands;
using Oil_level_glass.ViewModels.Services.Windows;

namespace Oil_level_glass.ViewModels.Windows.Editors
{
    public class GlassEditorViewModel : EditorViewModel<GlassModel>
    {
        private double _height, _externalDiameter;

        public override RelayCommand CancelCommand
        {
            get
            {
                return new RelayCommand((obj) => 
                {
                    Model.Height = _height;
                    Model.ExternalDiameter = _externalDiameter;

                    closeAction.Invoke();
                });
            }
        }

        public GlassEditorViewModel(
            GlassModel glassModel,
            Action closeAction,
            IValidationWindowService validationService) : base(glassModel, closeAction, validationService)
        {
            _height = glassModel.Height;
            _externalDiameter = glassModel.ExternalDiameter;
        }
    }
}
