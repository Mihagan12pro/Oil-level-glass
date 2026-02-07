using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Model.Data.Operations;
using Oil_level_glass.ViewModels.Commands;
using Oil_level_glass.ViewModels.Services.Windows;

namespace Oil_level_glass.ViewModels.Windows.Wizard3d
{
    public class Wizard3dViewModel 
        : ViewModelBase
    {
        private readonly IKompasDialogsService _kompasDialogsService;

        private GlassModel? _glass;
        public GlassModel? Glass
        {
            get 
            {
                return _glass; 
            } 
            set 
            {
                _glass = value;
            }
        }

        private HousingModel? _housing;
        public HousingModel? Housing
        {
            get
            {
                return _housing; 
            }
            set
            {
                _housing = value; 
            }
        }

        private RubberStripModel? _rubberStrip;
        public RubberStripModel? RubberStrip
        {
            get
            {
                return _rubberStrip;
            }
            set
            {
                _rubberStrip = value;
            }
        }

        public RelayCommand SelectMetalCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    _kompasDialogsService.SelectMaterial(Housing?.Material!);
                });
            }
        }

        public RelayCommand SelectGlassCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    _kompasDialogsService.SelectMaterial(Glass?.Material!);
                });
            }
        }

        public RelayCommand SelectRubberCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    _kompasDialogsService.SelectMaterial(RubberStrip?.Material!);
                });
            }
        }

        public RelayCommand EditSavingGlassCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    _kompasDialogsService.SelectFolder(Glass?.File!);
                });
            }
        }

        public RelayCommand EditSavingHousingCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    _kompasDialogsService.SelectFolder(Housing?.File!);
                });
            }
        }

        public RelayCommand EditSavingRubberStripCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    _kompasDialogsService.SelectFolder(RubberStrip?.File!);
                });
            }
        }


        public Wizard3dViewModel(IKompasDialogsService kompasDialogsService)
        {
            _kompasDialogsService = kompasDialogsService;

            Glass = new GlassModel();
            Housing = new HousingModel();
            RubberStrip = new RubberStripModel();
        }
    }
}
