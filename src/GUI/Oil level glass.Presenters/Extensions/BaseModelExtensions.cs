using Oil_level_glass.Model.Data;
using Shared;
using System.Globalization;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Oil_level_glass.Presenters.Extensions
{
    internal static class BaseModelExtensions
    {
        public static Result TryConvertToDouble(this BaseModel model, string str, string propertyTitle)
        {
            Type  type = model.GetType();

            PropertyInfo property = type.GetProperty(propertyTitle);

            if (double.TryParse(str, out double number) ||
                double.TryParse(str, NumberStyles.AllowDecimalPoint, new CultureInfo("en-US"), out number))
            {
                property.SetValue(model, number);

                string fieldTitle = string.Empty;

                string[] splited = Regex.Split(propertyTitle, @"(?=[A-Z])");
                for (int  i = 1; i < splited.Length; i++)
                {
                    var word = splited[i];

                    if (i > 1)
                    {
                        word = word.ToLower();
                    }

                    fieldTitle += word + ' ';
                }
                //if (model[propertyTitle] == string.Empty)
                //    => new Result(false, $"{Rege}");
            }

                //return double.TryParse(str, out number) || double.TryParse(
                //      str, NumberStyles.AllowDecimalPoint,
                //      new CultureInfo("en-US"),
                //      out number);
        }
    }
}
