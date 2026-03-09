using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.ViewModels.Windows.Editors;
using Oil_level_glass_UI.Services.Windows;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Oil_level_glass_UI.Windows.Editors
{
    /// <summary>
    /// Interaction logic for RubberStripEditor.xaml
    /// </summary>
    public partial class RubberStripEditorWindow : EditorWindow
    {
        public RubberStripEditorWindow(RubberStripModel model) : base(model)
        {
            InitializeComponent();

            WindowHeader.PreviewMouseDown += WindowHeader_PreviewMouseDown;

            foreach (var control in grSizes.Children)
            {
                if (control is StackPanel stackPanel)
                {
                    stackPanel.DataContext = model;
                }
            }

            DataContext = new RubberStripViewModel(
                model,
                closeAction,
                new ValidationWindowService(this)
                );
        }

        protected override void BtCheck_Click(object sender, RoutedEventArgs e)
        {
            BindingExpression tbInternalDiameterExpression = tbInternalDiameter
                .GetBindingExpression(TextBox.TextProperty);

            tbInternalDiameterExpression.UpdateSource();
        }
    }
}
