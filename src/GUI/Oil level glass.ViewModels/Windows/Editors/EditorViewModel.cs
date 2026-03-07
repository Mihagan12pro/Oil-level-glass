using Oil_level_glass.ViewModels.Commands;
using System.ComponentModel;
using System.Windows.Input;

namespace Oil_level_glass.ViewModels.Windows.Editors
{
    public abstract class EditorViewModel : ViewModelBase
    {
        protected readonly Action closeAction;

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


        public EditorViewModel(Action closeAction)
        {
            this.closeAction = closeAction;
        }
    }
}
