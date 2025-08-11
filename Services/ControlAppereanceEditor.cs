using Oil_level_glass.Enums;
using Oil_level_glass.Utilities;

namespace Oil_level_glass.Services
{
    internal static class ControlAppereanceEditor
    {
        public static void ChangeBackColor(ControlAppearance appearance, Dictionary<string, List<(string, InputError)>> errors)
        {
            if (errors.ContainsKey(appearance.Name))
            {
                appearance.BackColor =  Color.FromArgb(254, 210, 203);

                return;
            }

            appearance.BackColor = Color.White;
        }


        public static bool ChangeEnableStatement(List<bool> listOfRequirements)
        {
            bool enableStatement = true;

            foreach (bool requirement in listOfRequirements)
            {
                enableStatement &= requirement;
            }

            return enableStatement;
        }
    }
}
