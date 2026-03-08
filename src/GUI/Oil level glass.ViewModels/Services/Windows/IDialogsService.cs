using Oil_level_glass.Model.Data;
using Oil_level_glass.Model.Data.KompasFile;
using Oil_level_glass.Model.Data.Materials;
using Oil_level_glass.Model.Data.Operations;
using Oil_level_glass.Model.Data.Other;

namespace Oil_level_glass.ViewModels.Services.Windows
{
    public interface IDialogsService
    {
        /// <summary>
        /// Dialog for selecting materials
        /// </summary>
        /// <param name="material"></param>
        void SelectMaterial(Material material);

        /// <summary>
        /// Dialog for selecting folder
        /// </summary>
        /// <param name="file"></param>
        void SelectFolder(KompasFile file);

        /// <summary>
        /// Dialog for selecting thread
        /// </summary>
        /// <param name="threadModel"></param>
        void SelectThread(ThreadModel threadModel);

        /// <summary>
        /// Dialog for selecting thread with limited nominal diameter
        /// </summary>
        /// <param name="threadModel"></param>
        /// <param name="maximumDiameter"></param>
        /// <param name="isStrictly"></param>
        void SelectThread(
            ThreadModel threadModel,
            double maximumDiameter,
            bool isStrictly = false);

        /// <summary>
        /// Dialog for selecting part color
        /// </summary>
        /// <param name="color"></param>
        void SelectColor(RGB color);

        /// <summary>
        /// Invokes dialog for editing sizes 
        /// </summary>
        /// <param name="model"></param>
        void EditSizes(BaseModel model);
    }
}
