using System.Windows;

namespace KompasWPF.UserControls
{
    /// <summary>
    /// Interaction logic for ThreadChooser.xaml
    /// </summary>
    public partial class ThreadChooser 
        : GroupControlBase
    {
        public string Standard
        {
            get
            {
                return (string)GetValue(StandardProperty);
            }
            set
            {
                SetValue(StandardProperty, value);
            }
        }

        public static readonly DependencyProperty StandardProperty = DependencyProperty.Register(
            nameof(Standard),
            typeof(string),
            typeof(ThreadChooser)
            );

        public double NominalDiameter
        {
            get
            {
                return (double)GetValue(NominalDiameterProperty);
            }
            set
            {
                SetValue(NominalDiameterProperty, value);
            }
        }

        public static readonly DependencyProperty NominalDiameterProperty = DependencyProperty.Register(
            nameof(NominalDiameter),
            typeof(double),
            typeof(ThreadChooser)
            );

        public double Pitch
        {
            get
            {
                return (double)GetValue(PitchProperty);
            }
            set
            {
                SetValue(PitchProperty, value);
            }
        }

        public static readonly DependencyProperty PitchProperty = DependencyProperty.Register(
            nameof(Pitch),
            typeof(double),
            typeof(ThreadChooser)
            );

        public double MaxNominalDiameter
        {
            get
            {
                return (double)GetValue(MaxNominalDiameterProperty);
            }
            set
            {
                SetValue(MaxNominalDiameterProperty, value);
            }
        }

        public static readonly DependencyProperty MaxNominalDiameterProperty = DependencyProperty.Register(
            nameof(MaxNominalDiameter),
            typeof(double),
            typeof(ThreadChooser)
            );

        public ThreadChooser()
        {
            InitializeComponent();

            Header = "Резьба";
        }
    }
}
