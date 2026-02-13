using Oil_level_glass.Core.KompasDialogs;
using Oil_level_glass.Core.Records;
using Oil_level_glass.Model.Data.KompasFile;
using Oil_level_glass.Model.Data.Materials;
using Oil_level_glass.Model.Data.Operations;
using Oil_level_glass.Model.Data.Other;
using Oil_level_glass.ViewModels.Services.Windows;
using System.Windows;

namespace Oil_level_glass_UI.Services.Windows
{
    internal class KompasDialogsService
        : IKompasDialogsService
    {
        private readonly IDialogsProvider _provider;

        public void SelectMaterial(Material material)
        {
            IMaterialsDialog materialsDialog = _provider.GetMaterialsDialog();

            DialogResult result = materialsDialog.SelectMaterial(material);
            TryToShowErrorMessageBox(result);
        }

        public void SelectFolder(KompasFile file)
        {
            IFoldersDialog folderDialog = _provider.GetFoldersDialog();
            DialogResult result = folderDialog.SelectFolder(file);
        }

        public void SelectThread(ThreadModel threadModel)
        {
            IThreadsDialog threadsDialog = _provider.GetThreadsDialog();

            DialogResult result = threadsDialog.SelectThread(threadModel);
            TryToShowErrorMessageBox(result);
        }

        public void SelectThread(
            ThreadModel threadModel,
            double maximumDiameter,
            bool isStrictly = false)
        {
            IThreadsDialog threadsDialog = _provider.GetThreadsDialog();

            DialogResult result = threadsDialog.SelectThread(threadModel, maximumDiameter, isStrictly);
            TryToShowErrorMessageBox(result);
        }

        public void SelectColor(RGB color)
        {
            IColorsDialog colorsDialog = _provider.GetColorsDialog();
            colorsDialog.SelectColor(color);
        }


        private void TryToShowErrorMessageBox(DialogResult result)
        {
            if (!result.Success)
            {
                MessageBox.Show(result.Message,
                    result.Caption,
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }

        public KompasDialogsService(IDialogsProvider provider)
        {
            _provider = provider;
        }
    }
}
