using Oil_level_glass.Utilities;

namespace Oil_level_glass.Services
{
    internal static class ControlAppereanceEditor
    {
        public static void ChangeBackColor(ControlAppearance appearance, bool hasErrors)
        {
            if (hasErrors)
            {
                appearance.BackColor = Color.FromArgb(254, 210, 203);

                return;
            }

            appearance.BackColor = Color.White;
        }


        public static void ChangeBackColor(ControlAppearance appearance, Dictionary<string, List<string>> errors)
        {
            ChangeBackColor(appearance, errors.ContainsKey(appearance.Name));
        }


        public static void ChangeEnableStatement(ControlAppearance appearance, List<bool> listOfRequirements)
        {
            appearance.Enabled = true;

            foreach (bool requirement in listOfRequirements)
            {
                appearance.Enabled &= requirement;
            }
        }


        public static void ChangeEnableStatement(ControlAppearance appearance, bool requirement)
        {
            appearance.Enabled = requirement;
        }
    }
}
