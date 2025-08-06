
namespace Oil_level_glass.Services
{
    internal static class NumberTypesValidator
    {
        public static bool IsInteger(string input, out int result)
        {
            return int.TryParse(input, out result);
        }


        public static bool IsDouble(string input, out double result)
        {
            return double.TryParse(input, out result);
        }


        public static bool BiggerThanZero(object input)
        {
            if (input is Int32)
            {
                return (int)input > 0;
            }

            if (input is Double)
            {
                return (double)input > 0;
            }

            throw new FormatException();
        }
    }
}
