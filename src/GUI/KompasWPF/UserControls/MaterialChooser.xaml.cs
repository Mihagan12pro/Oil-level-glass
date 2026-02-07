using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace KompasWPF.UserControls
{
    /// <summary>
    /// Interaction logic for MaterialChooser.xaml
    /// </summary>
    public partial class MaterialChooser 
        : GroupControlBase
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

        public MaterialChooser()
        {
            InitializeComponent();
        }
    }
}
