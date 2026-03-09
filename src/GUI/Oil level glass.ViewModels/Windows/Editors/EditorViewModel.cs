using Oil_level_glass.Model.Data;
using Oil_level_glass.ViewModels.Commands;
using Oil_level_glass.ViewModels.Services.Windows;

namespace Oil_level_glass.ViewModels.Windows.Editors
{
    public abstract class EditorViewModel<TModel> : ViewModelBase where TModel : BaseModel
    {
        public readonly TModel Model;

        protected readonly Action closeAction;
        protected readonly IValidationWindowService validationWindowService;

        public virtual RelayCommand CancelCommand
        {
            get
            {
                return new RelayCommand((obj) => 
                {
                    closeAction.Invoke();
                });
            }
        }

        public RelayCommand OkCommand
        {
            get
            {
                return new RelayCommand((obj) =>
                {
                    closeAction.Invoke();
                });
            }
        }

        public virtual RelayCommand CheckCommand
        {
            get
            {
                return new RelayCommand((obj) =>
                {
                });
            }
        }


        private bool _isOkEnabled;
        public bool IsOkEnabled
        {
            get
            {
                return _isOkEnabled;
            }
            set
            {
                _isOkEnabled = value;

                OnPropertyChanged();
            }
        }


        public EditorViewModel(TModel model, Action closeAction, IValidationWindowService validationWindowService)
        {
            Model = model;
            this.validationWindowService = validationWindowService;
            this.closeAction = closeAction;
        }
    }
}
