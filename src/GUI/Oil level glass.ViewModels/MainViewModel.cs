using Oil_level_glass.ViewModels.Commands;
using Oil_level_glass.ViewModels.Services.Windows;

namespace Oil_level_glass.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IWindowsService _windowsService;

        public RelayCommand ShowAboutCommand
        {
            get
            {
                return new RelayCommand(obj => 
                {
                    _windowsService.ShowAboutWindow();
                });
            }
        }

        public MainViewModel(IWindowsService windowsService)
        {
            _windowsService = windowsService;
        }
    }
}
