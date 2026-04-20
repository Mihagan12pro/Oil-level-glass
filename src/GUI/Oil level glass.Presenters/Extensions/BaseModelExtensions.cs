using Oil_level_glass.Model.Data;
using Shared;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Oil_level_glass.Presenters.Extensions
{
    internal static class BaseModelExtensions
    {
        public static Result TryConvertToInt32(this BaseModel model, string str, string propertyTitle)
        {
            PropertyInfo property = ExtractPropertInfo(model, propertyTitle);

            if (int.TryParse(str, out int number))
            {
                property.SetValue(model, number);

                if (model[propertyTitle] != string.Empty)
                    return new Result(false, model[propertyTitle]);

                return new Result(true);
            }

            return new Result(false, $"{property.GetCustomAttribute<DisplayNameAttribute>().DisplayName} must be a number!");
        }

        public static Result TryConvertToDouble(this BaseModel model, string str, string propertyTitle)
        {
            PropertyInfo property = ExtractPropertInfo(model, propertyTitle);

            if (double.TryParse(str, out double number) ||
                double.TryParse(str, NumberStyles.AllowDecimalPoint, new CultureInfo("en-US"), out number))
            {
                property.SetValue(model, number);

                if (model[propertyTitle] != string.Empty)
                    return new Result(false, model[propertyTitle]);

                return new Result(true);
            }


            return new Result(false, $"{property.GetCustomAttribute<DisplayNameAttribute>().DisplayName} must be a real number!");
        }

        private static PropertyInfo ExtractPropertInfo(BaseModel model, string propertyTitle)
            => model.GetType().GetProperty(propertyTitle);
    }
}
