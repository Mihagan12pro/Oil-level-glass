using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Model.Data.Materials;
using Oil_level_glass.ViewModels.Commands;
using Oil_level_glass.ViewModels.Commands.Factories;
using Oil_level_glass.ViewModels.Services.Windows;
using System.ComponentModel;
using System.Windows;

namespace Oil_level_glass.ViewModels.Windows.Wizard3d
{
    public class Wizard3dViewModel : ViewModelBase
    {
        private readonly int _maxPageNumber, _minPageNumber;

        private readonly IKompasDialogsService _kompasDialogsService;

        private readonly SelectMaterialFactory _selectMaterialFactory;

        private readonly BackgroundWorker _backgroundWorker;

        private bool _isNextEnabled, _isBackEnabled;

        private Visibility _pageOneVisibility, _pageTwoVisibility;

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

        private void CheckFields()
        {
            string empty = string.Empty;

            while (true) 
            {
                Thread.Sleep(1000);

                switch (PageNumber)
                {
                    case 0:
                        {
                            PageTwoVisibility = Visibility.Collapsed;
                            PageOneVisibility = Visibility.Visible;

                            Material glass = Glass.Material!;
                            Material rubber = RubberStrip.Material!;
                            Material metal = Housing.Material!;

                            if (glass.Error == empty &&  
                                metal.Error == empty &&
                                rubber.Error == empty)
                            {
                                IsNextEnabled = true;
                            }

                            break;
                        }
                    case 1:
                        {
                            IsBackEnabled = true;

                            PageTwoVisibility = Visibility.Visible;
                            PageOneVisibility = Visibility.Collapsed;

                            break;
                        }
                    default:
                        {
                            IsBackEnabled = false;
                            IsNextEnabled = false;
                            break;
                        }
                }
            }
        }

        private void LeafPage(int count)
        {
            if (PageNumber >= _minPageNumber && PageNumber <= _maxPageNumber)
                PageNumber += count;
        }


        public Wizard3dViewModel(IKompasDialogsService kompasDialogsService)
        {
            _kompasDialogsService = kompasDialogsService;

            _minPageNumber = 0;
            _maxPageNumber = 5;

            Glass = new GlassModel();
            RubberStrip = new RubberStripModel();
            Housing = new HousingModel();

            _selectMaterialFactory = new SelectMaterialFactory(_kompasDialogsService);

            SelectGlassMaterialCommand = _selectMaterialFactory.Create(Glass.Material!);
            SelectStripMaterialCommand = _selectMaterialFactory.Create(RubberStrip.Material!);
            SelectHousingMaterialCommand = _selectMaterialFactory.Create(Housing.Material!);

            BackCommand = new RelayCommand((obj) =>
            {
                LeafPage(-1);
            });

            NextCommand = new RelayCommand((obj) =>
            {
                LeafPage(1);
            });

            PageOneVisibility = Visibility.Visible;
            PageTwoVisibility = Visibility.Collapsed;

            _backgroundWorker = new BackgroundWorker();
            _backgroundWorker.DoWork += (obj, ea)
                => CheckFields();
            _backgroundWorker.RunWorkerAsync();
        }
    }
}
