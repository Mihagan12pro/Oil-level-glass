using KompasWPF;
using Oil_level_glass.ViewModels.Windows.Wizard3d;

namespace Oil_level_glass_UI.Windows.Wizard3D
{
    /// <summary>
    /// Interaction logic for Wizard3DWindow.xaml
    /// </summary>
    public partial class Wizard3DWindow : KompasWindow
    {
        public Wizard3DWindow()
        {
            InitializeComponent();

            DataContext = new Wizard3dViewModel();
        }
    }
}
