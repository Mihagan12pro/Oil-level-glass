using Oil_level_glass.Properties;
using Oil_level_glass.Services;
using System.ComponentModel.DataAnnotations;

namespace Oil_level_glass.Utilities.Attributes.Numbers
{
    internal class NumberAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            double number = 0;
            if (value is string str)
            {
                try
                {
                    number = DoubleConverter.Convert(str);
                }
                catch
                {
                    ErrorMessageResourceName = nameof(Resources.OnlyNumbersStrError);

                    return false;
                }
            }
            else
            {
                if (!double.TryParse(value?.ToString(), out number))
                {
                    ErrorMessageResourceName = nameof(Resources.OnlyNumbersStrError);

                    return false;
                }
            }


            if (number <= 0)
            {
                ErrorMessageResourceName = nameof(Resources.OnlyPositiveNumbersStrError);

                return false;
            }


            return true;
        }


        public NumberAttribute()
        {
            ErrorMessageResourceType = typeof(Resources);
        }
    }
}
