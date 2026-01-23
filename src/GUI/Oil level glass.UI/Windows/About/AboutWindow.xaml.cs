using KompasWPF;
using Oil_level_glass.ViewModels.Windows.About;

namespace Oil_level_glass_UI.Windows.About
{
    /// <summary>
    /// Interaction logic for AboutWindow.xaml
    /// </summary>
    public partial class AboutWindow : KompasWindow
    {
        public AboutWindow()
        {
            InitializeComponent();

            DataContext = new AboutViewModel("../../../Resources/Texts/About.xps");
        }

        private void btClose_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Close();
        }
    }
}
