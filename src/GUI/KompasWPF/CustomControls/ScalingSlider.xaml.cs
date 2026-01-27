using System.Windows;
using System.Windows.Controls;

namespace KompasWPF.CustomControls
{
    /// <summary>
    /// Interaction logic for ScalingSlider.xaml
    /// </summary>
    public partial class ScalingSlider : UserControl
    {
        public static readonly DependencyProperty ValueProperty;

        public int Value
        {
            get
            {
                return (int)GetValue(ValueProperty);
            }
            set 
            { 
                SetValue(ValueProperty, value);
                lblScaleDisplayer.Content = $"{value} %";
            }
        }

        private void btMinimize_Click(object sender, RoutedEventArgs e)
        {
            if (Value >= 10)
                Value -= 10;
            else
                Value = 0;
        }

        private void btMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (Value <= 90)
                Value += 10;
            else
                Value = 100;
        }

        private void slrScaler_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Value = Convert.ToInt32(slrScaler.Value);
        }


        public ScalingSlider()
        {
            InitializeComponent();

            Value -= 10;
        }

        static ScalingSlider()
        {
            ValueProperty = DependencyProperty.Register(
                nameof(Value),
                typeof(int),
                typeof(ScalingSlider),
                new FrameworkPropertyMetadata(10)
                );
        }
    }
}
