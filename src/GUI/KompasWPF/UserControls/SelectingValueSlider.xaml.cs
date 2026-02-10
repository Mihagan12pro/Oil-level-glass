using System.Windows;
using System.Windows.Controls;

namespace KompasWPF.UserControls
{
    /// <summary>
    /// Interaction logic for SelectingValueSlider.xaml
    /// </summary>
    public partial class SelectingValueSlider : UserControl
    {
        public int Value
        {
            get
            {
                return (int)GetValue(ValueProperty);
            }
            set
            {
                SetValue(ValueProperty, value);
            }
        }

        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register(
            nameof(Value),
            typeof(int),
            typeof(SelectingValueSlider));


        public int Maximum
        {
            get
            {
                return (int)GetValue(MaximumProperty);
            }
            set
            {
                SetValue(MaximumProperty, value);
            }
        }

        public static readonly DependencyProperty MaximumProperty = DependencyProperty.Register(
            nameof(Maximum),
            typeof(int),
            typeof(SelectingValueSlider),
            new FrameworkPropertyMetadata(100));


        public int Minimum
        {
            get
            {
                return (int)GetValue(ManimumProperty);
            }
            set
            {
                SetValue(ManimumProperty, value);
            }
        }

        public static readonly DependencyProperty ManimumProperty = DependencyProperty.Register(
            nameof(Minimum),
            typeof(int),
            typeof(SelectingValueSlider),
            new FrameworkPropertyMetadata(0));

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
            typeof(SelectingValueSlider));


        public SelectingValueSlider()
        {
            InitializeComponent();
        }
    }
}
