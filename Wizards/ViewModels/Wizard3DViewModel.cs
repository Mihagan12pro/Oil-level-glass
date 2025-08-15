using Oil_level_glass.BaseClasses;
using Oil_level_glass.Enums;
using Oil_level_glass.Services;
using Oil_level_glass.Utilities;
using Oil_level_glass.Wizards.Models.HousingRefineData;
using Oil_level_glass.Wizards.Models.Wizard3D;
using System.Runtime.CompilerServices;


namespace Oil_level_glass.Wizards.ViewModels
{
    internal class Wizard3DViewModel : BaseViewModel
    {
        private HousingData _housingData;

        private Dictionary<Type, List<ControlAppearance>> _kompasDataDictionary = new Dictionary<Type, List<ControlAppearance>>();

        public Dictionary<string, List<string>> HousingErrors { get; private set; }
        public Dictionary<string, List<string>> ScrewHoleErrors { get; private set; }


        public int MaxTabIndex { get; private set; }


        public ControlAppearance HousingDiameterTextBox = new ControlAppearance(nameof(HousingData.MainDiameter));
        
        public ControlAppearance HousingHoleTextBox = new ControlAppearance(nameof(HousingData.CentralHole));
        
        public ControlAppearance HousingHeightTextBox = new ControlAppearance(nameof(HousingData.Height));
        
        public ControlAppearance HousingDensityTextBox = new ControlAppearance(nameof(HousingData.Density));
        
        public ControlAppearance HousingMaterialTextBox = new ControlAppearance(nameof(HousingData.Material));
        
        public ControlAppearance HousingFolderTextBox = new ControlAppearance(nameof(HousingData.FolderPath));
        
        public ControlAppearance HousingFileNameTextBox = new ControlAppearance(nameof(HousingData.FileName));


        public ControlAppearance ScrewDistanceTextBox { get; private set; } = new ControlAppearance(nameof(HousingData.ScrewHoleData.HoleDistance));
        public ControlAppearance ScrewDiameterTextBox { get; private set; } = new ControlAppearance(nameof(HousingData.ScrewHoleData.HoleDiameter));
        public ControlAppearance ScrewCountTextBox { get; private set; } = new ControlAppearance(nameof(HousingData.ScrewHoleData.HoleCount));



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
                _housingData.ScrewHoleData.ErrorsChanged += ScrewHoleData_ErrorsChanged;

                OnPropertyChanged();
            }
        }


        private void ScrewHoleData_ErrorsChanged(object? sender, System.ComponentModel.DataErrorsChangedEventArgs e)
        {
            OnPropertyChanged(nameof(ScrewHoleErrors));

            _housingData.ScrewHoleData.ErrorsChanged -= ScrewHoleData_ErrorsChanged;

            foreach (ControlAppearance controlAppearance in _kompasDataDictionary[typeof(ScrewHoleData)])
            {
                ControlAppereanceEditor.ChangeBackColor(controlAppearance, ScrewHoleErrors);
            }


            ControlAppereanceEditor.ChangeEnableStatement(ScrewDiameterTextBox, !ScrewHoleErrors.ContainsKey(ScrewDistanceTextBox.Name));
            ControlAppereanceEditor.ChangeEnableStatement(ScrewCountTextBox, new List<bool> { ScrewDiameterTextBox.Enabled, !ScrewHoleErrors.ContainsKey(ScrewDiameterTextBox.Name) });

            _housingData.ScrewHoleData.ErrorsChanged += ScrewHoleData_ErrorsChanged;
        }


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
            ScrewHoleErrors = HousingData.ScrewHoleData.ErrorsByPropertyName;

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


            _kompasDataDictionary[typeof(ScrewHoleData)] = new List<ControlAppearance>
            {
                ScrewDistanceTextBox,

                ScrewDiameterTextBox,

                ScrewCountTextBox
            };

            MaxTabIndex = 1;
        }
    }
}
