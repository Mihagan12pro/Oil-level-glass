using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.ViewModels.Windows.Editors;
using System.Windows.Controls;
using System.Windows.Data;

namespace Oil_level_glass_UI.Windows.Editors
{
    /// <summary>
    /// Interaction logic for GlassEditorWindow.xaml
    /// </summary>
    public partial class GlassEditorWindow : EditorWindow
    {
        public GlassEditorWindow(GlassModel Model) 
        {
            InitializeComponent();

            WindowHeader.PreviewMouseDown += WindowHeader_PreviewMouseDown;

            grSizes.DataContext = Model;

            DataContext = new GlassEditorViewModel(closeAction, Model);

            btCheck.Click += BtCheck_Click;
        }

        protected override void BtCheck_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            BindingExpression heightExpression = tbHeight.GetBindingExpression(TextBox.TextProperty);

            BindingExpression diameterExpression = tbExternalDiameter.GetBindingExpression(TextBox.TextProperty);


            diameterExpression.UpdateSource();
            heightExpression.UpdateSource();
        }
    }
}
