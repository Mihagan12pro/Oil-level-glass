using Oil_level_glass.BaseClasses;
using Oil_level_glass.Enums;
using Oil_level_glass.Wizards.Models.Wizard3D;
using System.Runtime.CompilerServices;

namespace Oil_level_glass.Wizards.ViewModels
{
    internal class Wizard3DViewModel : BaseViewModel
    {
        private HousingEntity _housingEntity;
        public HousingEntity HousingEntity
        {
            get
            {
                return _housingEntity;
            }
            private set
            {
                _housingEntity = value;

                _housingEntity.ErrorsChanged += OnHousingErrorsChanged;

                OnPropertyChanged();
            }
        }


        private Color _housingHeightColor;
        public Color HousingHeightColor
        {
            get
            {
                return _housingHeightColor;            
            }
            private set
            {
                _housingHeightColor = value;

                OnPropertyChanged();
            }
        }


        private Color _housingDiameterColor;
        public Color HousingDiameterColor
        {
            get
            {
                return _housingDiameterColor;
            }
            private set
            {
                _housingDiameterColor = value;

                ScrewHolesDistanceEnabled = (value != errorBackColor);

                OnPropertyChanged();
            }
        }


        private Color _housingHoleColor;
        public Color HousingHoleColor
        {
            get
            {
                return _housingHoleColor;
            }
            private set
            {
                _housingHoleColor = value;

                ScrewHolesDistanceEnabled = (value != errorBackColor);

                OnPropertyChanged();
            }
        }


        private Color _housingDensityColor;
        public Color HousingDensityColor
        {
            get
            {
                return _housingDensityColor;
            }
            private set
            {
                _housingDensityColor = value;

                OnPropertyChanged();
            }
        }


        private Color _housingNameColor;
        public Color HousingNameColor
        {
            get
            {
                return _housingNameColor;
            }
            private set
            {
                _housingNameColor = value;

                OnPropertyChanged();
            }
        }


        private Color _housingFolderColor;
        public Color HousingFolderColor
        {
            get
            {
                return _housingFolderColor;
            }
            private set
            {
                _housingFolderColor = value;

                OnPropertyChanged();
            }
        }


        private Color _housingMaterialColor;
        public Color HousingMaterialColor
        {
            get
            {
                return _housingMaterialColor;
            }
            private set
            {
                _housingMaterialColor = value;

                OnPropertyChanged();
            }
        }


        private Color _screwHolesDistanceColor;
        public Color ScrewHolesDistanceColor
        {
            get
            {
                return _screwHolesDistanceColor;
            }
            private set
            {
                _screwHolesDistanceColor = value;

                ScrewHolesDiameterEnabled = (value != errorBackColor);

                OnPropertyChanged();
            }
        }


        private Color _screwHolesDiameterColor;
        public Color ScrewHolesDiameterColor
        {
            get
            {
                return _screwHolesDiameterColor;
            }
            private set
            {
                _screwHolesDiameterColor = value;

                ScrewHolesCountEnabled = (value != errorBackColor);

                OnPropertyChanged();
            }
        }


        private bool _screwHolesDistanceEnabled;
        public bool ScrewHolesDistanceEnabled
        {
            get
            {
                return _screwHolesDistanceEnabled;
            }
            private set
            {
                _screwHolesDistanceEnabled = value;

                ScrewHolesDiameterEnabled = value;

                OnPropertyChanged();
            }
        }


        private bool _screwHoleDiameterEnabled;
        public bool ScrewHolesDiameterEnabled
        {
            get
            {
                return _screwHoleDiameterEnabled;
            }
            private set
            {
                _screwHoleDiameterEnabled = value;

                ScrewHolesCountEnabled = value;

                OnPropertyChanged();
            }
        }


        private bool _screwHolesCountEnabled;
        public bool ScrewHolesCountEnabled
        {
            get
            {
                return _screwHolesCountEnabled;
            }
            private set
            {
                _screwHolesCountEnabled = value;

                OnPropertyChanged();
            }
        }


        public Dictionary<string, List<(string, InputError)>> HousingErrors { get; private set; }


        private void OnHousingErrorsChanged(object? sender, System.ComponentModel.DataErrorsChangedEventArgs e)
        {
            OnPropertyChanged(nameof(HousingErrors));
        }


        public override void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (prop == nameof(HousingErrors))
            {
                _housingEntity.ErrorsChanged -= OnHousingErrorsChanged;

                HousingHoleColor = Color.White;
                HousingHeightColor = Color.White;
                HousingDiameterColor = Color.White;
                HousingDensityColor = Color.White;
                HousingNameColor = Color.White;
                HousingFolderColor = Color.White;
                HousingMaterialColor = Color.White;
                ScrewHolesDistanceColor = Color.White;
                ScrewHolesDiameterColor = Color.White;


                if (HousingEntity.GetErrors(nameof(HousingEntity.Height)) != null)
                {
                    HousingHeightColor = errorBackColor;

                    if (HousingErrors[nameof(HousingEntity.Height)][0].Item2 == InputError.BrokenStrictHierarchy)
                    {

                    }
                }


                if (HousingEntity.GetErrors(nameof(HousingEntity.HousingDiameter)) != null)
                {
                    HousingDiameterColor = errorBackColor;

                    if (HousingErrors[nameof(HousingEntity.HousingDiameter)][0].Item2 == InputError.BrokenStrictHierarchy)
                    {
                        HousingHoleColor = errorBackColor;
                    }
                }


                if (HousingEntity.GetErrors(nameof(HousingEntity.HousingHole)) != null)
                {
                    HousingHoleColor = errorBackColor;

                    if (HousingErrors[nameof(HousingEntity.HousingHole)][0].Item2 == InputError.BrokenStrictHierarchy)
                    {
                        HousingDiameterColor = errorBackColor;
                    }
                }


                if (HousingEntity.GetErrors(nameof(HousingEntity.Density)) != null)
                {
                    HousingDensityColor = errorBackColor;
                }


                if (HousingEntity.GetErrors(nameof(HousingEntity.FileName)) != null)
                {
                    HousingNameColor = errorBackColor;
                }

                if (HousingEntity.GetErrors(nameof(HousingEntity.FolderPath)) != null)
                {
                    HousingFolderColor = errorBackColor;
                }

                if (HousingEntity.GetErrors(nameof(HousingEntity.Material)) != null)
                {
                    HousingMaterialColor = errorBackColor;
                }

                if (HousingEntity.GetErrors(nameof(HousingEntity.ScrewHolesDistance)) != null)
                {
                    ScrewHolesDistanceColor = errorBackColor;
                }

                if (HousingEntity.GetErrors(nameof(HousingEntity.ScrewHolesDiameter)) != null)
                {
                    ScrewHolesDiameterColor = errorBackColor;
                }


                _housingEntity.ErrorsChanged += OnHousingErrorsChanged;
            }

            base.OnPropertyChanged(prop);
        }


        public Wizard3DViewModel()
        {
            HousingEntity = new HousingEntity();

            HousingErrors = HousingEntity.ErrorsByPropertyName;

            ScrewHolesDistanceEnabled = true;
        }
    }
}
