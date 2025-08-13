using Oil_level_glass.Delegates;
using Oil_level_glass.Enums;
using System.ComponentModel;
using System.Reflection;

namespace Oil_level_glass.Services
{
    internal static class Validator<T>
    {
        public static bool CheckRange(string propName, object minValue, object maxValue, ErrorAdder adder, ErrorClearer clearer)
        {
            clearer.Invoke(propName);

            double min = Convert.ToDouble(minValue);
            double max = Convert.ToDouble(maxValue);

            if (min > max)
            {
                adder.Invoke(propName, ResourceString.UseErrorString(propName, InputError.TooBigNumber), InputError.TooBigNumber);
            }

            return false;
        }


        public static bool CheckDensityValue(string propName, string? propValue,double minDensity, double maxDensity, ErrorAdder adder, ErrorClearer clearer)
        {
            clearer.Invoke(propName);

            double number = DoubleConverter.Convert(propValue);

            if (number > maxDensity)
            {
                adder.Invoke(propName, ResourceString.UseErrorString(propName, InputError.BiggerMaxDensity), InputError.BiggerMaxDensity);

                return true;
            }

            if (number < minDensity)
            {
                adder.Invoke(propName, ResourceString.UseErrorString(propName, InputError.LessMinDensity), InputError.LessMinDensity);

                return true;
            }


            return false;
        }


        public static bool CheckFileName(string propName, string? propValue, ErrorAdder adder, ErrorClearer clearer)
        {
            clearer.Invoke(propName);

            if (propValue?.Length > 256)
            {
                adder.Invoke(propName, ResourceString.UseErrorString(GetDescription(propName), InputError.BigName), InputError.BigName);

                return true;
            }

            return false;
        }


        public static bool CheckPath(string propName, string? propValue, ErrorAdder adder, ErrorClearer clearer)
        {
            clearer.Invoke(propName);

            if (!Directory.Exists(propValue))
            {
                adder.Invoke(propName, ResourceString.UseErrorString(GetDescription(propName), InputError.BadPath), InputError.BadPath);

                return true;
            }
            return false;
        }


        public static bool CheckHierarchy(string propName, string propValue, string otherPropName, string otherPropValue, bool currentPropBigger, ErrorAdder adder, ErrorClearer clearer, bool strict = true)
        {
            clearer.Invoke(propName);

            double numberProp = Convert.ToDouble(propValue);
            
            if (!currentPropBigger)
            {
                double smallerPropValue = Convert.ToDouble(otherPropValue);
                if (strict && numberProp < smallerPropValue)
                {
                    adder.Invoke(propName, ResourceString.UseErrorString(GetDescription(otherPropName), InputError.BrokenStrictHierarchy, GetDescription(propName)), InputError.BrokenStrictHierarchy);

                    return true;
                }
                else if (!strict && numberProp <= smallerPropValue)
                {
                    adder.Invoke(propName, ResourceString.UseErrorString(GetDescription(otherPropName), InputError.BrokenStrictHierarchy, GetDescription(propName)), InputError.BrokenStrictHierarchy);

                    return true;
                }

                return false;
            }
            else
            {
                double biggerPropValue = Convert.ToDouble(otherPropValue);
                if (strict && numberProp > biggerPropValue)
                {
                    adder.Invoke(propName, ResourceString.UseErrorString(GetDescription( propName), InputError.BrokenStrictHierarchy, GetDescription(otherPropName)), InputError.BrokenStrictHierarchy);

                    return true;
                }
                else if (!strict && numberProp >= biggerPropValue)
                {
                    adder.Invoke(propName, ResourceString.UseErrorString(GetDescription(propName), InputError.BrokenStrictHierarchy, GetDescription(otherPropName)), InputError.BrokenStrictHierarchy);

                    return true;
                }

                return false;
            }
        }


        public static bool CheckHierarchy(string smallPropName, string smallPropValue, string bigPropName, string bigPropValue, ErrorAdder adder, ErrorClearer clearer, bool isStrictlyBigger = true)
        {
            clearer.Invoke(smallPropName);
            clearer.Invoke(bigPropName);

            double small = DoubleConverter.Convert(smallPropValue);
            double big = DoubleConverter.Convert(bigPropValue);

            if (isStrictlyBigger && small >= big)
            {
                adder.Invoke(bigPropName, ResourceString.UseErrorString(GetDescription(smallPropName), InputError.BrokenStrictHierarchy, GetDescription(bigPropName)), InputError.BrokenStrictHierarchy);
                adder.Invoke(smallPropName, ResourceString.UseErrorString(GetDescription(smallPropName), InputError.BrokenStrictHierarchy, GetDescription(bigPropName)), InputError.BrokenStrictHierarchy);

                return true;
            }

            if (!isStrictlyBigger && small > big)
            {
                adder.Invoke(bigPropName, ResourceString.UseErrorString(GetDescription(smallPropName), InputError.BrokenHierarchy, GetDescription(bigPropName)), InputError.BrokenHierarchy);
                adder.Invoke(smallPropName, ResourceString.UseErrorString(GetDescription(smallPropName), InputError.BrokenHierarchy, GetDescription(bigPropName)), InputError.BrokenHierarchy);

                return true;
            }

            return false;
        }


        public static bool CheckBiggerThanZero(string propName, string? propValue, ErrorAdder adder, ErrorClearer clearer)
        {
            clearer.Invoke(propName);

            double number = DoubleConverter.Convert(propValue);

            if (number <= 0)
            {
                adder.Invoke(propName, ResourceString.UseErrorString(GetDescription(propName), InputError.ZeroOrNegative), InputError.ZeroOrNegative);

                return true;
            }

            return false;
        }


        public static bool CheckDoubleField(string propName, string? propValue, ErrorAdder adder, ErrorClearer clearer, out double result)
        {
            clearer.Invoke(propName);

            try
            {
                DoubleConverter.Convert(propValue);

                return false;
            }
            catch
            {
                adder.Invoke(propName, ResourceString.UseErrorString(GetDescription(propName), InputError.InvalidType), InputError.InvalidType);
            }
            finally
            {
                result = 0;
            }


            return true;
        }


        public static bool CheckRequiredField(string propName, string? propValue, ErrorAdder adder, ErrorClearer clearer)
        {
            clearer.Invoke(propName);

            if (String.IsNullOrWhiteSpace(propValue) || String.IsNullOrEmpty(propValue))
            {
                adder.Invoke(propName, ResourceString.UseErrorString(GetDescription(propName), InputError.EmptyField), InputError.EmptyField);


                return true;
            }

            return false;
        }


        private static string GetDescription(string propName)
        {
            PropertyInfo? propInfo = typeof(T).GetProperty(propName);

            if (propInfo == null)
                throw new ArgumentNullException();

            DescriptionAttribute? descriptionAttribute = propInfo?.GetCustomAttribute<DescriptionAttribute>();

            if (descriptionAttribute == null)
                throw new ArgumentNullException();

            string description = descriptionAttribute.Description;

            return description;
        }
    }
}
