using Oil_level_glass.Properties;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace Oil_level_glass.Utilities.Attributes
{
    internal class DirectoryAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            string ?directory = Convert.ToString(value);

            return Directory.Exists(directory);
        }
    }
}
