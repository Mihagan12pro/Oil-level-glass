using Kompas6Constants;
using KompasAPI7;
using Oil_level_glass.Core.KompasDialogs;
using Oil_level_glass.Core.Records;
using Oil_level_glass.Model.Data.Materials;

namespace Oil_level_glass.COM.KompasDialogs
{
    internal class MaterialsDialog
        : ComDialogBase, IMaterialsDialog
    {
        public DialogResult SelectMaterial(Material material)
        {
            ChoiceMaterialDialogParam dialogParam = (ChoiceMaterialDialogParam)applicationDialogs.GetDialogParam(KompasAPIObjectTypeEnum.ksObjectChoiceMaterialDialogParam);
           
            if (material.Title != string.Empty && material.Density > 0)
            {
                dialogParam.Material = material.Title;
                dialogParam.Density = material.Density;
            }

            if (!applicationDialogs.ChoiceMaterial(hwnd, dialogParam))
                return new DialogResult(true);

            if (dialogParam.HatchStyle == material.HatchStyle && dialogParam.Density <= material.MaxDensity && dialogParam.Density >= material.MinDensity)
            {
                material.Density = dialogParam.Density;
                material.Title = dialogParam.Material;

                return new DialogResult(true);
            }

            return new DialogResult(false, "Был выбран неверный материал для данной детали!", "ОШИБКА!");
        }

        protected internal MaterialsDialog(IApplication application) : base(application)
        {
            Title = "ВЫБОР МАТЕРИАЛА";
        }
    }
}
