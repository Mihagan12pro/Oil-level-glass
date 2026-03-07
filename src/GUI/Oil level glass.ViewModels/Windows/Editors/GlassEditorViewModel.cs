using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.ViewModels.Commands;

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
                    if (GlassModel.Error == string.Empty)
                    {
                        IsOkEnabled = true;
                        return;
                    }

                    IsOkEnabled = false;
                });
            }
        }

        public GlassEditorViewModel(Action closeAction, GlassModel glassModel)
            : base(closeAction)
        {
            GlassModel = glassModel;

            _height = glassModel.Height;
            _externalDiameter = glassModel.ExternalDiameter;
        }
    }
}
