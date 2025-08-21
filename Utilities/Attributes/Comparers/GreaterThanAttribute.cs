using Oil_level_glass.Properties;
using Oil_level_glass.Services;
using Oil_level_glass.Utilities.Attributes.Numbers;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Oil_level_glass.Utilities.Attributes.Comparers
{
    internal class GreaterThanAttribute : CompareAttribute
    {
        public GreaterThanAttribute(string otherProperty) : base(otherProperty)
        {

        }


        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            NumberAttribute numberAttribute = new NumberAttribute();
            if (!numberAttribute.IsValid(value))
            {
                return new ValidationResult(numberAttribute.ErrorMessage);
            }

            PropertyInfo? otherPropertyInfo = validationContext.ObjectType.GetProperty(OtherProperty);
            object? otherValue = otherPropertyInfo?.GetValue(validationContext.ObjectInstance, null);

            if (!numberAttribute.IsValid(otherValue))
            {
                return ValidationResult.Success;
            }

            double numberValue = DoubleConverter.Convert(value);
            double smallerValue = DoubleConverter.Convert(otherValue);

            if (numberValue > smallerValue)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult(Resources.TooSmallNumberStrError);
        }
    }
}
