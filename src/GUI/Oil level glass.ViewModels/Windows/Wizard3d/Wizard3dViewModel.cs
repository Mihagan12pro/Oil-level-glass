using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.ViewModels.Commands;
using Oil_level_glass.ViewModels.Commands.Factories;
using Oil_level_glass.ViewModels.Services.Windows;
using System.Windows;

namespace Oil_level_glass.ViewModels.Windows.Wizard3d
{
    public class Wizard3dViewModel : ViewModelBase
    {
        private readonly IDialogsService _dialogsService;

        private bool _isNextEnabled, _isBackEnabled;

        private bool _isRubberSizesEnabled, _isHousingSizesEnabled; 

        private Visibility _pageOneVisibility, _pageTwoVisibility;

        public RelayCommand EditGlassSizesCommand { get; private set; }
        public RelayCommand EditHousingSizesCommand { get; private set; }
        public RelayCommand EditRubberStripSizesCommand { get; private set; }

        public RelayCommand SelectGlassMaterialCommand { get; private set; }
        public RelayCommand SelectStripMaterialCommand { get; private set; }
        public RelayCommand SelectHousingMaterialCommand { get; private set; }

        public int PageNumber { get; set; }

        public RelayCommand NextCommand { get; private set; }
        public RelayCommand BackCommand { get; private set; }

        public bool IsNextEnabled
        {
            get
            {
                return _isNextEnabled;
            }
            set
            {
                _isNextEnabled = value;
                OnPropertyChanged();
            }
        }

        public bool IsBackEnabled
        {
            get
            {
                return _isBackEnabled;
            }
            set
            {
                _isBackEnabled = value;
                OnPropertyChanged();
            }
        }

        public bool IsRubberSizesEnabled
        {
            get
            {
                return _isRubberSizesEnabled;
            }
            set
            {
                _isRubberSizesEnabled = value;

                OnPropertyChanged();
            }
        }

        public bool IsHousingSizesEnabled
        {
            get
            {
                return _isHousingSizesEnabled;
            }
            set
            {
                _isHousingSizesEnabled = value;

                OnPropertyChanged();
            }
        }

        public Visibility PageOneVisibility
        {
            get
            {
                return _pageOneVisibility;
            }
            set
            {
                _pageOneVisibility = value;

                OnPropertyChanged();
            }
        }

        public Visibility PageTwoVisibility
        {
            get
            {
                return _pageTwoVisibility;
            }
            set
            {
                _pageTwoVisibility = value;

                OnPropertyChanged();
            }
        }

        public GlassModel Glass { get; private set;  }
        public RubberStripModel RubberStrip { get; private set; }
        public HousingModel Housing { get; private set; }


        public Wizard3dViewModel(IDialogsService dialogsService)
        {
            _dialogsService = dialogsService;

            Glass = new GlassModel();
            RubberStrip = new RubberStripModel();
            Housing = new HousingModel();

            SelectMaterialFactory selectMaterialFactory = new SelectMaterialFactory(_dialogsService);
            SizesEditorsFactory sizesEditorsFactory = new SizesEditorsFactory(_dialogsService);

            SelectGlassMaterialCommand = selectMaterialFactory.Create(Glass.Material!);
            SelectStripMaterialCommand = selectMaterialFactory.Create(RubberStrip.Material!);
            SelectHousingMaterialCommand = selectMaterialFactory.Create(Housing.Material!);

            EditGlassSizesCommand = sizesEditorsFactory.Create(Glass, () => 
            {
                if (Glass.Error != string.Empty)
                {
                    IsHousingSizesEnabled = false;
                    IsRubberSizesEnabled = false;

                    return;
                }
                IsRubberSizesEnabled = true;

                RubberStrip.ExternalDiameter = Glass.ExternalDiameter;
                RubberStrip.Height = Glass.Height;
            });

            EditRubberStripSizesCommand = sizesEditorsFactory.Create(RubberStrip, () => 
            {
                if (RubberStrip.Error != string.Empty)
                {
                    IsHousingSizesEnabled = false;

                    return;
                }

                IsHousingSizesEnabled = true;
            });

            EditHousingSizesCommand = sizesEditorsFactory.Create(Housing, () => 
            {
                if (Housing.Error != string.Empty)
                {

                }
            });
        }
    }
}
