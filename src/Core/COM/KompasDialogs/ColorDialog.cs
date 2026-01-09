using KompasAPI7;
using Oil_level_glass.Core.KompasDialogs;
using Oil_level_glass.Model.Data.Other;

namespace Oil_level_glass.COM.KompasDialogs
{
    internal class ColorDialog
        : ComDialogBase, IColorDialog
    {
        protected internal ColorDialog(IApplication application) : base(application)
        {
        }

        public void SelectColor(Appereance appearance)
        {
            throw new NotImplementedException();
        }
    }
}
