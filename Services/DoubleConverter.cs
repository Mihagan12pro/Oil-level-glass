using System.Globalization;

namespace Oil_level_glass.Services
{
    internal static class DoubleConverter
    {
        public static double Convert(object? value)
        {
            if (value is double)
                return (double)value;

            string ?strNumber = value.ToString();

            if (double.TryParse(strNumber, NumberStyles.Float, new CultureInfo("En-us"), out double result))
            {
                return result;
            }
            else if (double.TryParse(strNumber, NumberStyles.Float, CultureInfo.CurrentCulture, out result))
            {
                return result;
            }

            throw new FormatException();
        }


        public static string? ConvertBack(object value)
        {
            if (!(value is double))
                throw new FormatException();

            if (value == null)
                throw new ArgumentNullException();

            string ?result = System.Convert.ToString((System.Convert.ToDouble(value), CultureInfo.CurrentCulture));

            return result;
        }
    }
}
