using Oil_level_glass.Enums;
using Oil_level_glass.Properties;

namespace Oil_level_glass.Services
{
    internal static class ResourceString
    {
        public static string UseErrorString(string inputString, InputError error = InputError.None, string inputString2 = "", object ?otherParams = null)
        {
            string outputString = "";

            const string placeHolder = "???";
            const string placeHolder2 = "!!!";

            string resourceString = "";

            switch (error)
            {
                case InputError.InvalidType:
                    {
                        resourceString = Resources.InvalidTypeMessage;

                        break;
                    }

                case InputError.EmptyField:
                    {
                        resourceString = Resources.RequiredFieldMessage;

                        break;
                    }

                case InputError.TooSmallNumber:
                    {
                        resourceString = Resources.TooSmallFieldMessage;



                        if (otherParams == null)
                        {
                           inputString2 = "нуля";
                        }

                        break;
                    }

                case InputError.ZeroOrNegative:
                    {
                        resourceString = Resources.ZeroOrNegativeMessage;

                        break;
                    }

                case InputError.BrokenStrictHierarchy:
                    {
                        resourceString = Resources.BrokenStrictHierarchyMessage;

                        break;
                    }

                case InputError.BrokenHierarchy:
                    {
                        resourceString = Resources.BrokenHierarchyMessage;

                        break;
                    }

                case InputError.BadPath:
                    {
                        resourceString = Resources.BadPathMessage;

                        break;
                    }
                case InputError.BigName:
                    {
                        resourceString = Resources.BigNameMessage;

                        break;
                    }

                case InputError.LessMinDensity:
                    {
                        resourceString = Resources.LessMinDensityMessage;

                        break;
                    }

                case InputError.BiggerMaxDensity:
                    {
                        resourceString = Resources.BiggerMaxDensityMessage;

                        break;
                    }
            }

            outputString = resourceString.Replace(placeHolder, inputString).Replace(placeHolder2, inputString2);

            return outputString;
        }
    }
}
