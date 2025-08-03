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

                OnPropertyChanged(nameof(HousingHeightColor));
            }
        }


   

        public Dictionary<string, List<(string, InputError)>> HousingErrors { get; private set; }


        private void OnHousingErrorsChanged(object? sender, System.ComponentModel.DataErrorsChangedEventArgs e)
        {
           OnPropertyChanged(nameof(HousingErrors));
        }


        public override void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if ((GetType().GetProperty(prop)?.PropertyType != typeof(Color)))
            {
                _housingEntity.ErrorsChanged -= OnHousingErrorsChanged;

                HousingHeightColor = Color.White;

                if (HousingEntity.GetErrors(nameof(HousingEntity.Height)) != null)
                {
                    HousingHeightColor = errorBackColor;
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
