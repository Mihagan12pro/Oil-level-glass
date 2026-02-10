using System.Windows;
using System.Windows.Media;

namespace KompasWPF.UserControls
{
    /// <summary>
    /// Interaction logic for AppearanceEditor.xaml
    /// </summary>
    public partial class AppearanceEditor 
        : GroupControlBase
    {
        public int Red
        {
            get
            {
                return (int)GetValue(RedProperty);
            }
            set
            {
                SetValue(RedProperty, value);
                UpdateColor();
            }
        }

        public static readonly DependencyProperty RedProperty = DependencyProperty.Register(
            nameof(Red),
            typeof(int),
            typeof(AppearanceEditor)
            );

        public int Green
        {
            get
            {
                return (int)GetValue(GreenProperty);
            }
            set
            {
                SetValue(GreenProperty, value);
                UpdateColor();
            }
        }

        public static readonly DependencyProperty GreenProperty = DependencyProperty.Register(
            nameof(Green),
            typeof(int),
            typeof(AppearanceEditor)
            );

          public int Blue
        {
            get
            {
                return (int)GetValue(BlueProperty);
            }
            set
            {
                SetValue(BlueProperty, value);
                UpdateColor();
            }
        }

        public static readonly DependencyProperty BlueProperty = DependencyProperty.Register(
            nameof(Blue),
            typeof(int),
            typeof(AppearanceEditor)
            );

        public double Emission
        {
            get
            {
                return (double)GetValue(EmissionProperty) / 100;
            }
            set
            {
                SetValue(EmissionProperty, value * 100);
            }
        }

        public static readonly DependencyProperty EmissionProperty = DependencyProperty.Register(
            nameof(Emission),
            typeof(double),
            typeof(AppearanceEditor)
            );


        public double Transparency
        {
            get
            {
                return (double)GetValue(TransparencyProperty) / 100;
            }
            set
            {
                SetValue(TransparencyProperty, value * 100);
            }
        }

        public static readonly DependencyProperty TransparencyProperty = DependencyProperty.Register(
            nameof(Transparency),
            typeof(double),
            typeof(AppearanceEditor )
            );

        public double Shininess
        {
            get
            {
                return (double)GetValue(ShininessProperty) / 100;
            }
            set
            {
                SetValue(ShininessProperty, value * 100);
            }
        }

        public static readonly DependencyProperty ShininessProperty = DependencyProperty.Register(
            nameof(Shininess),
            typeof(double),
            typeof(AppearanceEditor )
            );


        public double Specularity
        {
            get
            {
                return (double)GetValue(SpecularityProperty) / 100;
            }
            set
            {
                SetValue(SpecularityProperty, value * 100);
            }
        }

        public static readonly DependencyProperty SpecularityProperty = DependencyProperty.Register(
            nameof(Specularity),
            typeof(double),
            typeof(AppearanceEditor )
            );

        public double Diffuse
        {
            get
            {
                return (double)GetValue(DiffuseProperty) / 100;
            }
            set
            {
                SetValue(DiffuseProperty, value * 100);
            }
        }

        public static readonly DependencyProperty DiffuseProperty = DependencyProperty.Register(
            nameof(Diffuse),
            typeof(double),
            typeof(AppearanceEditor )
            );


        public double Ambient
        {
            get
            {
                return (double)GetValue(AmbientProperty) / 100;
            }
            set
            {
                SetValue(AmbientProperty, value * 100);
            }
        }

        public static readonly DependencyProperty AmbientProperty = DependencyProperty.Register(
            nameof(Ambient),
            typeof(double),
            typeof(AppearanceEditor )
            );

        private void UpdateColor()
        {
            Color color = new Color();
            color.R = Convert.ToByte(Red);
            color.G = Convert.ToByte(Green);
            color.B = Convert.ToByte(Blue);

            lbColor.Background = new SolidColorBrush(color);
        }

        public AppearanceEditor()
        {
            InitializeComponent();
        }
    }
}
