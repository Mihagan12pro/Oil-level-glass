using Oil_level_glass.Model.Data;
using Oil_level_glass.ViewModels.Services.Windows;

namespace Oil_level_glass.ViewModels.Commands.Factories
{
    internal class SizesEditorsFactory : DialogsFactory
    {
        public RelayCommand Create(BaseModel model, Action action)
        {
            return new RelayCommand((obj) => 
            {
                dialogsService.EditSizes(model);

                action.Invoke();
            });
        }

        public SizesEditorsFactory(IDialogsService dialogsService) 
            : base(dialogsService)
        {
        }
    }
}
