using Oil_level_glass.Model.Data.Materials;
using Oil_level_glass.ViewModels.Services.Windows;

namespace Oil_level_glass.ViewModels.Commands.Factories
{
    internal class SelectMaterialFactory
    {
        private readonly IDialogsService _kompasDialogsService;

        public RelayCommand Create(Material material)
        {
            return new RelayCommand((obj) =>
            {
                _kompasDialogsService.SelectMaterial(material);
            });
        }

        public SelectMaterialFactory(IDialogsService kompasDialogsService)
        {
            _kompasDialogsService = kompasDialogsService;
        }
    }
}
