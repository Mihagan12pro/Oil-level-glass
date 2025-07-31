using Oil_level_glass.BaseClasses;
using Oil_level_glass.Wizards.Models.Wizard3D;

namespace Oil_level_glass.Wizards.ViewModels
{
    internal class Wizard3DViewModel : BaseViewModel
    {
        private HousingEntity _housingEntity;
        public HousingEntity HousingEntity
        {
            get => _housingEntity;
        }


        public Wizard3DViewModel()
        {
            _housingEntity = new HousingEntity();
        }
    }
}
