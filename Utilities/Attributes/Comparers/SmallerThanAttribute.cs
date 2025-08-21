using Oil_level_glass.Properties;
using Oil_level_glass.Services;
using Oil_level_glass.Utilities.Attributes.Numbers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.Utilities.Attributes.Comparers
{
    internal class SmallerThanAttribute : CompareAttribute
    {
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
            double greaterValue = DoubleConverter.Convert(otherValue);

            if (numberValue < greaterValue)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult(Resources.TooBigNumberStrError);
        }


        public SmallerThanAttribute(string otherProperty) : base(otherProperty)
        {

        }
    }
}
