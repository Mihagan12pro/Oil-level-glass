using System.Windows;
using System.Windows.Controls;

namespace KompasWPF.UserControls
{
    /// <summary>
    /// Interaction logic for MaterialChooser.xaml
    /// </summary>
    public partial class MaterialChooser : UserControl
    {
        public string Title
        {
            get
            {
                return (string)GetValue(TitleProperty);
            }
            set
            {
                SetValue(TitleProperty, value);
            }
        }

        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(
            nameof(Title),
            typeof(string),
            typeof(MaterialChooser),
            new FrameworkPropertyMetadata(defaultValue: "Part")
            );

        public MaterialChooser()
        {
            InitializeComponent();
        }
    }
}
