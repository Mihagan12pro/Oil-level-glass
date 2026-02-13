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
        public Brush Color
        {
            get
            {
                return (Brush)GetValue(ColorProperty);
            }
            set
            {
                SetValue(ColorProperty, value);
            }
        }

        public static readonly DependencyProperty ColorProperty = DependencyProperty.Register(
            nameof(Color),
            typeof(Brush),
            typeof(AppearanceEditor),
            new PropertyMetadata(null, OnColorChanged));

        private static void OnColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is AppearanceEditor editor)
            {
                if (editor.rectColor != null)
                {
                    var rect = editor.rectColor;

                    rect.Fill = e.NewValue as Brush;
                }
            }
        }

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
            typeof(AppearanceEditor)
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


        public AppearanceEditor()
        {
            InitializeComponent();
        }
    }
}
