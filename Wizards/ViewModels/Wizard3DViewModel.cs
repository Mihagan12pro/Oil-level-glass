using Oil_level_glass.BaseClasses;
using Oil_level_glass.Enums;
using Oil_level_glass.Services;
using Oil_level_glass.Utilities;
using Oil_level_glass.Wizards.Models.Wizard3D;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace Oil_level_glass.Wizards.ViewModels
{
    internal class Wizard3DViewModel : BaseViewModel
    {
        private HousingData _housingData;

        private Dictionary<Type, List<ControlAppearance>> _kompasDataDictionary = new Dictionary<Type, List<ControlAppearance>>();


        public ControlAppearance HousingDiameterTextBox { get; private set; }
        public ControlAppearance HousingHoleTextBox { get; private set; }
        public ControlAppearance HousingHeightTextBox { get; private set; }
        public ControlAppearance HousingDensityTextBox { get; private set; }
        public ControlAppearance  HousingMaterialTextBox { get; private set; }
        public ControlAppearance HousingFolderTextBox { get; private set; }
        public ControlAppearance HousingFileNameTextBox { get; private set; }
       
        public ControlAppearance HousingRefineTabPage { get; private set; } = new ControlAppearance();


        public HousingData HousingData
        {
            get
            {
                return _housingData;
            }
            private set
            {
                _housingData = value;

                _housingData.ErrorsChanged += OnHousingErrorsChanged;
             

                OnPropertyChanged();
            }
        }


        public int MaxTabIndex { get; private set; }
        //private int   = 1;


        //private int _selectedTab;
        //public int SelectedTab
        //{
        //    get
        //    {
        //        return _selectedTab;
        //    }
        //    set
        //    {
        //        if (ReturnToPreviousTab == false || value <= _maxSelectedTab)
        //        {
        //            _selectedTab = value;

        //            OnPropertyChanged();
        //        }
        //    }
        //}


        //private bool _returnToPreviousTab;
        //public bool ReturnToPreviousTab
        //{
        //    get
        //    {
        //        return _returnToPreviousTab;
        //    }
        //    private set
        //    {
        //        _returnToPreviousTab = value;

        //        OnPropertyChanged();
        //    }
        //}
        //private bool _screwHolesDistanceEnabled;
        //public bool ScrewHolesDistanceEnabled
        //{
        //    get
        //    {
        //        return _screwHolesDistanceEnabled;
        //    }
        //    private set
        //    {
        //        _screwHolesDistanceEnabled = value;

        //        ScrewHolesDiameterEnabled = value;

        //        OnPropertyChanged();
        //    }
        //}


        //private bool _screwHoleDiameterEnabled;
        //public bool ScrewHolesDiameterEnabled
        //{
        //    get
        //    {
        //        return _screwHoleDiameterEnabled;
        //    }
        //    private set
        //    {
        //        _screwHoleDiameterEnabled = value;

        //        ScrewHolesCountEnabled = value;

        //        OnPropertyChanged();
        //    }
        //}


        //private bool _screwHolesCountEnabled;
        //public bool ScrewHolesCountEnabled
        //{
        //    get
        //    {
        //        return _screwHolesCountEnabled;
        //    }
        //    private set
        //    {
        //        _screwHolesCountEnabled = value;

        //        OnPropertyChanged();
        //    }
        //}


        public Dictionary<string, List<(string, InputError)>> HousingErrors { get; private set; }


        private void OnHousingErrorsChanged(object? sender, System.ComponentModel.DataErrorsChangedEventArgs e)
        {
            OnPropertyChanged(nameof(HousingErrors));

            _housingData.ErrorsChanged -= OnHousingErrorsChanged;

            foreach(ControlAppearance controlAppearance in _kompasDataDictionary[typeof(HousingData)])
            {
                ControlAppereanceEditor.ChangeBackColor(controlAppearance, HousingErrors);
            }

            _housingData.ErrorsChanged += OnHousingErrorsChanged;
        }


        public override void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (prop == nameof(HousingErrors))
            {
                if (HousingData.HasErrors)
                {
                    MaxTabIndex = 0;
                }
                else
                {
                    MaxTabIndex = 1;
                }
            }

            base.OnPropertyChanged(prop);
        }


        public Wizard3DViewModel()
        {
            HousingData = new HousingData();

            HousingErrors = HousingData.ErrorsByPropertyName;

            HousingDiameterTextBox = new ControlAppearance(nameof(HousingData.MainDiameter));
            HousingHoleTextBox = new ControlAppearance(nameof(HousingData.CentralHole));
            HousingHeightTextBox = new ControlAppearance(nameof(HousingData.Height));
            HousingDensityTextBox = new ControlAppearance(nameof(HousingData.Density));
            HousingMaterialTextBox = new ControlAppearance(nameof(HousingData.Material));
            HousingFolderTextBox = new ControlAppearance(nameof(HousingData.FolderPath));
            HousingFileNameTextBox = new ControlAppearance(nameof(HousingData.FileName));

            _kompasDataDictionary[typeof(HousingData)] = new List<ControlAppearance>
                {
                    HousingDiameterTextBox,

                    HousingHoleTextBox,

                    HousingHeightTextBox,

                    HousingDensityTextBox,

                    HousingMaterialTextBox,

                    HousingFolderTextBox,

                    HousingFileNameTextBox
                };

            MaxTabIndex = 1;
        }
    }
}
