using System.ComponentModel;
using System.Reflection;

namespace Oil_level_glass.Model.Data
{
    public abstract class BaseModel 
        : IDataErrorInfo
    {
        public virtual string this[string columnName]
        {
            get
            {
                return CheckField(columnName);
            }
        }

        protected string CheckDirectory(string columnName)
        {
            Type type = this.GetType();

            PropertyInfo property = type.GetProperty(columnName)!;

            try
            {
                string? value = property?.GetValue(this)?.ToString();

                if (!Directory.Exists(value))
                    return DirectoryDoesNotExistsError;
            }
            catch
            {
                Console.WriteLine("Invalid data type!");
            }

            return string.Empty;
        }

        protected string CheckFile(string columnName)
        {
            Type type = this.GetType();

            PropertyInfo property = type.GetProperty(columnName)!;

            try
            {
                string? value = property?.GetValue(this)?.ToString();

                if (!File.Exists(value))
                    return FileDoesNotExistsError;
            }
            catch
            {
                Console.WriteLine("Invalid data type!");
            }

            return string.Empty;
        }

        protected string CheckEmptyString(string columnName)
        {
            Type type = this.GetType();

            PropertyInfo? property = type.GetProperty(columnName);

            try
            {
                string? value = property?.GetValue(this)?.ToString();

                if (string.IsNullOrWhiteSpace(value))
                    return EmptyStringError;
            }
            catch
            {
                Console.WriteLine("Invalid data type!");
            }

            return string.Empty;
        }
       
        protected string CheckMinimumValue(string columnName, double minimumValue = 0, bool isStrictlyBigger = true)
        {
            Type type = this.GetType();

            PropertyInfo property = type.GetProperty(columnName)!;

            try
            {
                double value = Convert.ToDouble(property.GetValue(this));

                if ( (isStrictlyBigger && minimumValue >= value) ||
                    (!isStrictlyBigger && minimumValue > value) )
                {
                    return TooSmallValueError;
                }
            }
            catch
            {
                Console.WriteLine("Invalid data type!");
            }

            return string.Empty;
        }

        protected string CheckRange(string columnName, double minimum, double maximum, bool isStrictly = true)
        {
            Type type = this.GetType();

            PropertyInfo property = type.GetProperty(columnName)!;

            try
            {
                double value = Convert.ToDouble(property.GetValue(this));

                if (isStrictly)
                {
                    if (value >= maximum ||  value <= minimum)
                        return InvalidRangeError;
                }

                if (value > maximum || value < minimum)
                    return InvalidRangeError;
            }
            catch
            {
                Console.WriteLine("Invalid data type!");
            }

            return string.Empty;
        }

        public virtual string Error => throw new NotImplementedException();

        protected abstract string CheckField(string columnName);

        public static string InvalidRangeError => "Invalid range!";

        public static string TooSmallValueError => "Too small value!";

        public static string EmptyStringError => "Can not be empty!";

        public static string DirectoryDoesNotExistsError => "Directory does not exists!";

        public static string FileDoesNotExistsError => "File does not exists!";
    }
}
