using Oil_level_glass.Core.Records;
using Oil_level_glass.Model.Data;
using Oil_level_glass.Model.Data.KompasFile;
using Oil_level_glass.Model.Data.Materials;
using Oil_level_glass.Model.Data.Operations;
using Oil_level_glass.Model.Data.Other;

namespace Oil_level_glass.ViewModels.Services.Windows
{
    public interface IDialogsService
    {
        void SelectMaterial(Material material);

        void SelectFolder(KompasFile file);

        void SelectThread(ThreadModel threadModel);

        void SelectThread(
            ThreadModel threadModel,
            double maximumDiameter,
            bool isStrictly = false);

        void SelectColor(RGB color);

        DialogResult CheckValues(BaseModel model);
    }
}
