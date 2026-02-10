using KompasAPI7;
using Oil_level_glass.Core.KompasDialogs;
using Oil_level_glass.Core.Records;
using Oil_level_glass.Model.Data.Other;

namespace Oil_level_glass.COM.KompasDialogs
{
    internal class ColorsDialog
        : ComDialogBase, IColorsDialog
    {
        public DialogResult SelectColor(Appearance appearance)
        {
            int color = appearance.Color.Color;

            applicationDialogs.SelectColor(hwnd, Title, ref color);

            byte[] values = BitConverter.GetBytes(color);

            appearance.Color = new RGB(values[0], values[1], values[2]);

            return new DialogResult(true);
        }

        protected internal ColorsDialog(IApplication application) : base(application)
        {
            Title = "ВЫБОР ЦВЕТА";
        }
    }
}
