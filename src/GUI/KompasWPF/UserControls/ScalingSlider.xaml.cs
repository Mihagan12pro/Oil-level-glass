using System.Windows;
using System.Windows.Controls;

namespace KompasWPF.UserControls;

/// <summary>
/// Interaction logic for ScalingSlider.xaml
/// </summary>
public partial class ScalingSlider : UserControl
{
    public double ButtonDiameter
    {
        get
        {
            return (double)GetValue(SliderWidthProperty);
        }
        set
        {
            SetValue(SliderWidthProperty, value);
        }
    }

    public double SliderWidth
    {
        get
        {
            return (double)GetValue(SliderWidthProperty);
        }
        set
        {
            SetValue(SliderWidthProperty, value);
        }
    }

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


    public static readonly DependencyProperty ValueProperty = DependencyProperty.Register(
        nameof(Value),
        typeof(int),
        typeof(ScalingSlider),
        new FrameworkPropertyMetadata(10)
        );

    public static readonly DependencyProperty SliderWidthProperty = DependencyProperty.Register(
        nameof(SliderWidth),
        typeof(double),
        typeof(ScalingSlider),
        new FrameworkPropertyMetadata(80.0)
        );

    public static readonly DependencyProperty ButtonDiameterProperty = DependencyProperty.Register(
        nameof(ButtonDiameter),
        typeof(double),
        typeof(ScalingSlider),
        new FrameworkPropertyMetadata(24.0)
        );


    public ScalingSlider()
    {
        InitializeComponent();

        Value -= 10;
    }
}
