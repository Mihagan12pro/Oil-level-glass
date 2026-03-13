using Oil_level_glass.ViewModels.Windows.Validation;

namespace Oil_level_glass_UI.Windows.Validation
{
    /// <summary>
    /// Interaction logic for NoProblemsWindow.xaml
    /// </summary>
    public partial class NoProblemsWindow : NoneWindow
    {
        public NoProblemsWindow()
        {
            InitializeComponent();

            WindowHeader.PreviewMouseDown += WindowHeader_PreviewMouseDown;

            DataContext = new NoProblemsViewModel(() => Close());
        }
    }
}
