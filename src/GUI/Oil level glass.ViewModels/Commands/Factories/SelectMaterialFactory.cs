using Oil_level_glass.Model.Data.Materials;
using Oil_level_glass.ViewModels.Services.Windows;

namespace Oil_level_glass.ViewModels.Commands.Factories
{
    public class SelectMaterialFactory
    {
        private readonly IKompasDialogsService _kompasDialogsService;

        public RelayCommand Create(Material material)
        {
            return new RelayCommand((obj) =>
            {
                _kompasDialogsService.SelectMaterial(material);
            });
        }

        public SelectMaterialFactory(IKompasDialogsService kompasDialogsService)
        {
            _kompasDialogsService = kompasDialogsService;
        }
    }
}
