using Oil_level_glass.Model;
using Shared.Results;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Oil_level_glass.Presenters.Extensions
{
    internal static class BaseModelExtensions
    {
        public static Result TryConvertToInt32AndValidate(this BaseModel model, string propertyValue, string propertyTitle)
        {
            PropertyInfo property = ExtractPropertInfo(model, propertyTitle);

            if (int.TryParse(propertyValue, out int number))
            {
                property.SetValue(model, number);

                if (model[propertyTitle] != string.Empty)
                    return new Result(false, model[propertyTitle]);

                return new Result(true);
            }

            string message = "{0} ";

            switch (CultureInfo.CurrentCulture.Name)
            {
                case "ru-RU":
                    {
                        message += "должен быть числом!";

                        break;
                    }
                default:
                    {
                        message = "must be a number!";

                        break;
                    }
            }

            return new Result(false, string.Format(message, property.GetCustomAttribute<DisplayNameAttribute>().DisplayName));
        }

        public static Result TryConvertToDoubleAndValidate(this BaseModel model, string propertyValue, string propertyTitle)
        {
            PropertyInfo property = ExtractPropertInfo(model, propertyTitle);

            if (double.TryParse(propertyValue, out double number) ||
                double.TryParse(propertyValue, NumberStyles.AllowDecimalPoint, new CultureInfo("en-US"), out number))
            {
                property.SetValue(model, number);

                if (model[propertyTitle] != string.Empty)
                    return new Result(false, model[propertyTitle]);

                return new Result(true);
            }

            string message = "{0} ";

            switch(CultureInfo.CurrentCulture.Name)
            {
                case "ru-RU":
                    {
                        message += "должен быть числом!";

                        break;
                    }
                default:
                    {
                        message += "must be a number!";
                        
                        break;
                    }
            }

            return new Result(false, string.Format(message, property.GetCustomAttribute<DisplayNameAttribute>().DisplayName));
        }

        private static PropertyInfo ExtractPropertInfo(BaseModel model, string propertyTitle)
            => model.GetType().GetProperty(propertyTitle);
    }
}
