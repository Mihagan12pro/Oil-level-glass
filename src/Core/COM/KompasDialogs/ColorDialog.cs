using KompasAPI7;
using Oil_level_glass.Core.KompasDialogs;
using Oil_level_glass.Model.Data.Other;

namespace Oil_level_glass.COM.KompasDialogs
{
    internal class ColorDialog
        : ComDialogBase, IColorDialog
    {
        public void SelectColor(Appereance appearance)
        {
            int color = appearance.Color;

            applicationDialogs.SelectColor(hwnd, Title, ref color);

            byte[] values = BitConverter.GetBytes(color);

            appearance.Red = values[0];
            appearance.Green = values[1];
            appearance.Blue = values[2];
        }

        protected internal ColorDialog(IApplication application) : base(application)
        {
            Title = "ВЫБОР ЦВЕТА";
        }
    }
}
