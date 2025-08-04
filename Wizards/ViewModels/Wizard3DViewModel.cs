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


                if (HousingEntity.GetErrors(nameof(HousingEntity.Height)) != null)
                {
                    HousingHeightColor = errorBackColor;

                    if (HousingErrors[nameof(HousingEntity.Height)][0].Item2 == InputError.BrokenHierarchy)
                    {

                    }
                }


                if (HousingEntity.GetErrors(nameof(HousingEntity.HousingDiameter)) != null)
                {
                    HousingDiameterColor = errorBackColor;

                    if (HousingErrors[nameof(HousingEntity.HousingDiameter)][0].Item2 == InputError.BrokenHierarchy)
                    {
                        HousingHoleColor = errorBackColor;
                    }
                }


                if (HousingEntity.GetErrors(nameof(HousingEntity.HousingHole)) != null)
                {
                    HousingHoleColor = errorBackColor;

                    if (HousingErrors[nameof(HousingEntity.HousingHole)][0].Item2 == InputError.BrokenHierarchy)
                    {
                        HousingDiameterColor = errorBackColor;
                    }
                }


                if (HousingEntity.GetErrors(nameof(HousingEntity.Density)) != null)
                {
                    HousingDensityColor = errorBackColor;
                }


                _housingEntity.ErrorsChanged += OnHousingErrorsChanged;
            }

            base.OnPropertyChanged(prop);
        }


        public Wizard3DViewModel()
        {
            HousingEntity = new HousingEntity();

            HousingErrors = HousingEntity.ErrorsByPropertyName;
        }
    }
}
