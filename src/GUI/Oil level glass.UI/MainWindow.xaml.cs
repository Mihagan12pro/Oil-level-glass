using KompasWPF;
using Oil_level_glass.COM;
using Oil_level_glass.ViewModels;
using Oil_level_glass.ViewModels.Services.Windows;
using Oil_level_glass_UI.Services.Windows;

namespace Oil_level_glass_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : KompasWindow
    {
        private readonly IWindowsService _windowsService;

        public MainWindow()
        {
            InitializeComponent();

            _windowsService = new WindowsService(new ComConnectionChecker(), this);

            DataContext = new MainViewModel(_windowsService);
        }

        private void BtAbout_Click(object sender, System.Windows.RoutedEventArgs e)
        {
       
        }
    }
}