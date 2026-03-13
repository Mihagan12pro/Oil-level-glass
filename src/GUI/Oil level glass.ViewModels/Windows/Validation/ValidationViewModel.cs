using Oil_level_glass.Model.Data;
using Oil_level_glass.ViewModels.Commands;

namespace Oil_level_glass.ViewModels.Windows.Validation
{
    public class ValidationViewModel : ViewModelBase
    {
        private readonly BaseModel _model;
        private readonly Action _closeAction;

        private string[]? _errors;
        public string[]? Errors
        {
            get
            {
                return _errors; 
            }
            private set
            {
                _errors = value;

                OnPropertyChanged();
            }
        }

        public RelayCommand CloseCommand
        {
            get
            {
                return new RelayCommand((obj) =>
                {
                    _closeAction.Invoke();
                });
            }
        }

        public ValidationViewModel(BaseModel model, Action closeAction)
        {
            _model = model;
            _closeAction = closeAction;

            Errors = model.Error.Split('\n');
            _closeAction = closeAction;
        }
    }
}
