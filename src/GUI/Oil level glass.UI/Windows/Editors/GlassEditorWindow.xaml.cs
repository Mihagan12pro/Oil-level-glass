using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.ViewModels.Windows.Editors;
using Oil_level_glass_UI.Services.Windows;
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

            foreach(var control in grSizes.Children)
            {
                if (control is StackPanel stackPanel)
                {
                    stackPanel.DataContext = Model;
                }
            }

            DataContext = new GlassEditorViewModel(
                closeAction, 
                new ValidationWindowService(this),
                Model);
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
