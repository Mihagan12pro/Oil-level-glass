using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.ViewModels.Commands;
using Oil_level_glass.ViewModels.Commands.Factories;
using Oil_level_glass.ViewModels.Services.Windows;

namespace Oil_level_glass.ViewModels.Windows.Wizard3d
{
    public class Wizard3dViewModel : ViewModelBase
    {
        private readonly IKompasDialogsService _kompasDialogsService;

        private readonly SelectMaterialFactory _selectMaterialFactory;

        public RelayCommand SelectGlassMaterialCommand { get; private set; }
        public RelayCommand SelectStripMaterialCommand { get; private set; }
        public RelayCommand SelectHousingMaterialCommand { get; private set; }

        public GlassModel Glass { get; private set;  }
        public RubberStripModel RubberStrip { get; private set; }
        public HousingModel Housing { get; private set; }


        public Wizard3dViewModel(IKompasDialogsService kompasDialogsService)
        {
            _kompasDialogsService = kompasDialogsService;

            Glass = new GlassModel();
            RubberStrip = new RubberStripModel();
            Housing = new HousingModel();

            _selectMaterialFactory = new SelectMaterialFactory(_kompasDialogsService);

            SelectGlassMaterialCommand = _selectMaterialFactory.Create(Glass.Material!);
            SelectStripMaterialCommand = _selectMaterialFactory.Create(RubberStrip.Material!);
            SelectHousingMaterialCommand = _selectMaterialFactory.Create(Housing.Material!);
        }
    }
}
