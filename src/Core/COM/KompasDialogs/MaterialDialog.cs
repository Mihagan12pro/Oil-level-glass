using Kompas6Constants;
using Kompas6API5;
using KompasAPI7;
using Oil_level_glass.Core.KompasDialogs;
using Oil_level_glass.Model.Data.Materials;

namespace Oil_level_glass.COM.KompasDialogs
{
    internal class MaterialDialog
        : ComDialogBase, IMaterialDialog
    {
        public void SelectMaterial(Material material)
        {
            ChoiceMaterialDialogParam dialogParam = (ChoiceMaterialDialogParam)applicationDialogs.GetDialogParam(KompasAPIObjectTypeEnum.ksObjectChoiceMaterialDialogParam);

            applicationDialogs.ChoiceMaterial(hwnd, dialogParam);

            material.Density = dialogParam.Density;
            var a = material[nameof(material.Density)];
        }

        protected internal MaterialDialog(IApplication application) : base(application)
        {
            Title = "ВЫБОР МАТЕРИАЛА";
        }
    }
}
