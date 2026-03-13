using Oil_level_glass.ViewModels.Commands;
using System.ComponentModel;
using System.Windows.Threading;

namespace Oil_level_glass.ViewModels.Windows.Validation
{
    public class NoProblemsViewModel : ViewModelBase
    {
        private int _seconds;
        private readonly Action _closeAction;
        private BackgroundWorker _backgroundWorker;
        private readonly Dispatcher _dispatcher;

        public RelayCommand CloseCommand
        {
            get
            {
                return new RelayCommand((obj => 
                {
                    _closeAction.Invoke();
                }));
            }
        }

        public int Seconds
        {
            get
            {
                return _seconds;
            }
            private set
            {
                _seconds = value;

                OnPropertyChanged();
            }
        }

        private void TimerWork()
        {
            while (Seconds > 0)
            {
                Thread.Sleep(1000);

                Seconds--;
            }

            _dispatcher.Invoke(_closeAction);
        }

        public NoProblemsViewModel(
            Action closeAction,
            int seconds = 3)
        {
            Seconds = seconds;
            _closeAction = closeAction;
            _dispatcher = Dispatcher.CurrentDispatcher;

            _backgroundWorker = new BackgroundWorker();
            _backgroundWorker.DoWork += (obj, ea)
                => TimerWork();
            _backgroundWorker.RunWorkerAsync();
        }
    }
}
