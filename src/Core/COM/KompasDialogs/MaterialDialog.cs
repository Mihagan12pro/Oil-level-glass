using Kompas6Constants;
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

            if (!applicationDialogs.ChoiceMaterial(hwnd, dialogParam))
                return;

            List<string> errors =  material.TryUpdate(dialogParam.Material, dialogParam.Density, dialogParam.HatchStyle);

            if (errors.Count > 0)
            {
                string message = string.Empty;

                application.MessageBoxEx("Был выбран неправильный материал для данного изделия!", "ОШИБКА!", 2);
            }
        }

        protected internal MaterialDialog(IApplication application) : base(application)
        {
            Title = "ВЫБОР МАТЕРИАЛА";
        }
    }
}
