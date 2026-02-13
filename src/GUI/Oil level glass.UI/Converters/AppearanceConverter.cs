using System.Globalization;
using System.Windows.Data;

namespace Oil_level_glass_UI.Converters
{
    internal class AppearanceConverter
        : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double numericValue = (double)value;

            return numericValue * 100;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double numericValue = (double)value;

            return numericValue / 100;
        }
    }
}
