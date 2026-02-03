using Oil_level_glass.Core.KompasDialogs;
using Oil_level_glass.Core.Records;
using Oil_level_glass.Model.Data.Materials;
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
            if (!result.Success)
            {
                MessageBox.Show(result.Message, result.Caption, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public KompasDialogsService(IDialogsProvider provider)
        {
            _provider = provider;
        }
    }
}
