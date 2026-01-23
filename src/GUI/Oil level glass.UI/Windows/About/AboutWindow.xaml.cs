using KompasWPF;
using Oil_level_glass.ViewModels.Windows.About;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Controls;
using System.Windows.Xps.Packaging;

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

            DataContext = new AboutViewModel("../../../Resources/Texts/About.txt");
        }

        private void btClose_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Close();
        }

        private void Grid_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            XpsDocument doc = new XpsDocument("../../../Resources/Texts/About.xps", FileAccess.Read);
            dvAbout.Document = doc.GetFixedDocumentSequence();
        }
    }
}
