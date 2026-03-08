using Oil_level_glass.Model.Data;
using Oil_level_glass.ViewModels.Services.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.ViewModels.Commands.Factories
{
    internal abstract class DialogsFactory<T> where T : BaseModel
    {
        protected readonly IDialogsService dialogsService;

        public abstract RelayCommand Create(T model);

        public DialogsFactory(IDialogsService kompasDialogsService)
        {
            dialogsService = kompasDialogsService;
        }
    }
}
