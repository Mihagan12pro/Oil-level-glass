using Oil_level_glass.Model.Data.KompasFile;
using Oil_level_glass.Model.Data.Materials;
using Oil_level_glass.Model.Data.Operations;

namespace Oil_level_glass.ViewModels.Services.Windows
{
    public interface IKompasDialogsService
    {
        void SelectMaterial(Material material);

        void SelectFolder(KompasFile file);

        void SelectThread(ThreadModel threadModel);

        void SelectThread(
            ThreadModel threadModel,
            double maximumDiameter,
            bool isStrictly = false);
    }
}
