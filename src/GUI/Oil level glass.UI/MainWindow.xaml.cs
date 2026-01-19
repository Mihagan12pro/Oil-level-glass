using KompasWPF;
using Oil_level_glass_UI.Windows.About;

namespace Oil_level_glass_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : KompasWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtAbout_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            AboutWindow window = new AboutWindow();

            window.Owner = this;

            window.ShowDialog();
        }
    }
}