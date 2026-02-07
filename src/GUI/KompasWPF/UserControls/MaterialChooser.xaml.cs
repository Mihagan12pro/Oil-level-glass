using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace KompasWPF.UserControls
{
    /// <summary>
    /// Interaction logic for MaterialChooser.xaml
    /// </summary>
    public partial class MaterialChooser : UserControl
    {
        public double Density
        {
            get
            {
                return (double)GetValue(DensityProperty);
            }
            set
            {
                SetValue(DensityProperty, value);
            }
        }


        public static readonly DependencyProperty DensityProperty = DependencyProperty.Register(
            nameof(Density),
            typeof(double),
            typeof(MaterialChooser)
            );

        public string Title
        {
            get
            {
                return (string)GetValue(TittleProperty);
            }
            set
            {
                SetValue(TittleProperty, value);
            }
        }

        public static readonly DependencyProperty TittleProperty = DependencyProperty.Register(
            nameof(Title),
            typeof(string),
            typeof(MaterialChooser)
            );


        public string Header
        {
            get
            {
                return (string)GetValue(HeaderProperty);
            }
            set
            {
                SetValue(HeaderProperty, value);
            }
        }

        public static readonly DependencyProperty HeaderProperty = DependencyProperty.Register(
            nameof(Header),
            typeof(string),
            typeof(MaterialChooser),
            new FrameworkPropertyMetadata(defaultValue: "Part")
            );


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
