using KompasAPI7;
using Oil_level_glass.Core.KompasDialogs;
using Oil_level_glass.Core.Records;
using Oil_level_glass.Model.Data.Other;

namespace Oil_level_glass.COM.KompasDialogs
{
    internal class ColorsDialog
        : ComDialogBase,
          IColorsDialog
    {
        public DialogResult SelectColor(RGB rgb)
        {
            int color = rgb.Color;

            applicationDialogs.SelectColor(hwnd, Title, ref color);

            byte[] values = BitConverter.GetBytes(color);

            rgb.Red = values[0];
            rgb.Green = values[1];
            rgb.Blue = values[2];

            return new DialogResult(true);
        }

        protected internal ColorsDialog(IApplication application) : base(application)
        {
            Title = "ВЫБОР ЦВЕТА";
        }
    }
}
