using Oil_level_glass.Model.Data;
using Oil_level_glass.ViewModels.Services.Windows;

namespace Oil_level_glass.ViewModels.Commands.Factories
{
    internal class SizesEditorsFactory : DialogsFactory<BaseModel>
    {
        public override RelayCommand Create(BaseModel model)
        {
            return new RelayCommand((obj) => 
            {
                dialogsService.EditSizes(model);
            });
        }

        public SizesEditorsFactory(IDialogsService dialogsService) 
            : base(dialogsService)
        {
        }
    }
}
