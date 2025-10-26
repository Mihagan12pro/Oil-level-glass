using KompasWPF;
using Oil_level_glass_UI.Dialogs.Three_D;

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

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            using (Wizard3DWindow wizard3DWindow = new Wizard3DWindow())
            {
                wizard3DWindow.Owner = this;

                wizard3DWindow.ShowDialog();
            }
        }
    }
}