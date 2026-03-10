using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using System.Windows;

namespace Oil_level_glass_UI.Windows.Editors
{
    /// <summary>
    /// Interaction logic for HousingEditorWindow.xaml
    /// </summary>
    public partial class HousingEditorWindow : EditorWindow
    {
        public HousingEditorWindow(HousingModel model) : base(model)
        {
            InitializeComponent();
        }

        protected override void BtCheck_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
