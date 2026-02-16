using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.ViewModels.Services.Windows;

namespace Oil_level_glass.ViewModels.Windows.Wizard3d
{
    public class Wizard3dViewModel : ViewModelBase
    {
        private readonly IKompasDialogsService _kompasDialogsService;
        public GlassModel? Glass { get; private set;  }

        public Wizard3dViewModel(IKompasDialogsService kompasDialogsService)
        {
            _kompasDialogsService = kompasDialogsService;

            Glass = new GlassModel();
        }
    }
}
