using Oil_level_glass.Model.Data;

namespace Oil_level_glass.ViewModels.Windows.Validation
{
    public class ValidationViewModel : ViewModelBase
    {
        private readonly BaseModel _model;

        private string[] _errors;
        public string[] Errors
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

        public ValidationViewModel(BaseModel model)
        {
            _model = model;

            Errors = model.Error.Split('\n');
        }
    }
}
