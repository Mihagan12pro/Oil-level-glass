using Oil_level_glass.Model.Data.Materials;
using Oil_level_glass.ViewModels.Services.Windows;

namespace Oil_level_glass.ViewModels.Commands.Factories
{
    internal class SelectMaterialFactory : DialogsFactory
    {
        public RelayCommand Create(Material material)
        {
            return new RelayCommand((obj) =>
            {
                dialogsService.SelectMaterial(material);
            });
        }

        public SelectMaterialFactory(IDialogsService kompasDialogsService) 
            : base(kompasDialogsService)
        {
          
        }
    }
}
