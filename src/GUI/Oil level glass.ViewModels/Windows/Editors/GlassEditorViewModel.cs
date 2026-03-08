using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.ViewModels.Commands;
using Oil_level_glass.ViewModels.Services.Windows;

namespace Oil_level_glass.ViewModels.Windows.Editors
{
    public class GlassEditorViewModel : EditorViewModel
    {
        public readonly GlassModel GlassModel;

        private double _height, _externalDiameter;

        public override RelayCommand CancelCommand
        {
            get
            {
                return new RelayCommand((obj) => 
                {
                    GlassModel.Height = _height;
                    GlassModel.ExternalDiameter = _externalDiameter;

                    closeAction.Invoke();
                });
            }
        }

        public override RelayCommand CheckCommand
        {
            get
            {
                return new RelayCommand((obj) => 
                {
                    validationWindowService.Check(GlassModel);

                    if (GlassModel.Error == string.Empty)
                    {
                        IsOkEnabled = true;
                        return;
                    }

                    IsOkEnabled = false;
                });
            }
        }

        public GlassEditorViewModel(
            Action closeAction,
            IValidationWindowService validationService,
            GlassModel glassModel) : base(closeAction, validationService)
        {
            GlassModel = glassModel;

            _height = glassModel.Height;
            _externalDiameter = glassModel.ExternalDiameter;
        }
    }
}
