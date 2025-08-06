using Oil_level_glass.Enums;
using Oil_level_glass.Properties;

namespace Oil_level_glass.Services
{
    internal static class ResourceString
    {
        public static string UseString(string inputString, InputError error = InputError.None)
        {
            string outputString = "";

            const string placeHolder = "???";

            string resourceString = "";

            switch(error)
            {
                case InputError.None:
                    resourceString = Resources.CulcCountOfScrewHoles;

                    break;

                case InputError.EmptyField:
                    resourceString = Resources.RequiredFieldMessage;

                    break;
            }

            outputString = Properties.Resources.CulcCountOfScrewHoles.Replace(placeHolder, inputString);

            return outputString;
        }
    }
}
