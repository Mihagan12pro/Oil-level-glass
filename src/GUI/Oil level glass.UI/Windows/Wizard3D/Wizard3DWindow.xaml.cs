using KompasWPF;
using Oil_level_glass.COM.KompasDialogs;
using Oil_level_glass.Core.KompasDialogs;
using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.ViewModels.Services.Windows;
using Oil_level_glass.ViewModels.Windows.Wizard3d;
using Oil_level_glass_UI.Services.Windows;
using Oil_level_glass_UI.Windows.Editors;
using System.Windows;

namespace Oil_level_glass_UI.Windows.Wizard3D
{
    /// <summary>
    /// Interaction logic for Wizard3DWindow.xaml
    /// </summary>
    public partial class Wizard3DWindow : KompasWindow
    {
        private readonly IDialogsProvider _dialogsProvider;
        private readonly IDialogsService _kompasDialogsService;
        private readonly Wizard3dViewModel _wizard3dViewModel;

        public Wizard3DWindow()
        {
            InitializeComponent();

            _dialogsProvider = new ComDialogsProvider();
            _kompasDialogsService = new KompasDialogsService(_dialogsProvider);

            _wizard3dViewModel = new Wizard3dViewModel(_kompasDialogsService);

            DataContext = _wizard3dViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GlassEditorWindow glassEditorWindow = new GlassEditorWindow(new GlassModel());
            glassEditorWindow.Owner = this;
            glassEditorWindow.ShowDialog();
        }
    }
}
