using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Material = Oil_level_glass.Model.Data.Materials.Material;

namespace KompasWPF.UserControls
{
    /// <summary>
    /// Interaction logic for MaterialChooser.xaml
    /// </summary>
    public partial class MaterialChooser : UserControl
    {
        public Material Material
        {
            get
            {
                return (Material)GetValue(MaterialProperty);
            }
            set
            {
                SetValue(MaterialProperty, value);
            }
        }

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

        public ICommand SelectMaterialCommand
        {
            get
            {
                return (ICommand)GetValue(SelectMaterialCommandProperty);
            }
            set
            {
                SetValue(SelectMaterialCommandProperty, value);
            }
        }

        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(
            nameof(Title),
            typeof(string),
            typeof(MaterialChooser),
            new FrameworkPropertyMetadata(defaultValue: "Part")
            );

        public static readonly DependencyProperty MaterialProperty = DependencyProperty.Register(
            nameof(Material),
            typeof(Material),
            typeof(MaterialChooser)
            );

        public static DependencyProperty SelectMaterialCommandProperty = DependencyProperty.Register(
            nameof(SelectMaterialCommand),
            typeof(ICommand),
            typeof(MaterialChooser)
            );

        public MaterialChooser()
        {
            InitializeComponent();
        }
    }
}
