using Oil_level_glass.Model.Data;
using Oil_level_glass.ViewModels.Windows.Validation;

namespace Oil_level_glass_UI.Windows.Validation
{
    /// <summary>
    /// Interaction logic for ValidationWindow.xaml
    /// </summary>
    public partial class ValidationWindow : NoneWindow
    {
        private readonly BaseModel _model;

        public ValidationWindow(BaseModel model)
        {
            InitializeComponent();

            _model = model;

            WindowHeader.PreviewMouseDown += WindowHeader_PreviewMouseDown;

            DataContext = new ValidationViewModel(_model);
        }

        private void btClose_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Close();
        }
    }
}
