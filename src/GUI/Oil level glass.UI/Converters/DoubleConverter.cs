using System.Globalization;
using System.Windows.Data;

namespace Oil_level_glass_UI.Converters
{
    internal class DoubleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value.ToString()!;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string str)
            {
                if (double.TryParse(str, NumberStyles.Any, CultureInfo.CurrentCulture, out double result))
                    return result;

                if (double.TryParse(str, NumberStyles.Any, new CultureInfo("en-US"), out double result2))
                {
                    return result2;
                }
            }
            return null;
        }
    }
}
