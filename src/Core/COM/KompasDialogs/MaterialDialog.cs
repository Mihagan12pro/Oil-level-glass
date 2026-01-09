using KompasAPI7;
using Oil_level_glass.Core.KompasDialogs;
using Oil_level_glass.Model.Data.Materials;

namespace Oil_level_glass.COM.KompasDialogs
{
    internal class MaterialDialog
        : ComDialogBase, IMaterialDialog
    {
        protected internal MaterialDialog(IApplication application) : base(application)
        {
        }

        public void SelectMaterial(Material material)
        {
            throw new NotImplementedException();
        }
    }
}
