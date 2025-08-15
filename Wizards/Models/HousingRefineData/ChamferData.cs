using Oil_level_glass.Delegates;
using Oil_level_glass.Services;
using System.ComponentModel;

namespace Oil_level_glass.Wizards.Models.HousingRefineData
{
    internal class ChamferData : HousingRefineData
    {
        private ScrewHoleData _screwHoleData;


        private string _side1;
        [Description("Сторона l1")]
        public string Side1
        {
            get => _side1;

            set
            {
                _side1 = value;

                ValidateSide1();
                OnPropertyChanged();
            }
        }


        private string _side2;
        [Description("Сторона l2")]
        public string Side2
        {
            get => _side2;

            set
            {
                _side2 = value;

                OnPropertyChanged();
            }
        }


        private string _angle;
        [Description("Угол α")]
        public string Angle
        {
            get => _angle;

            set
            {
                _angle = value;

                ValidateAngle();
                OnPropertyChanged();
            }
        }


        private void ValidateSide1()
        {
            ErrorAdder adder = AddError;
            ErrorClearer clearer = ClearErrors;

            if (!Validator<ChamferData>.CheckStandardNumber(nameof(Side1), Side1, adder, clearer))
            {
                Validator<ChamferData>.CheckRange(nameof(Side1), Side1, Convert.ToDouble(_screwHoleData.HoleDistance) * 0.5 + Convert.ToDouble(_screwHoleData.HoleCount) * 0.5, adder, clearer);
            }
        }


        private void ValidateAngle()
        {
            ErrorAdder adder = AddError;
            ErrorClearer clearer = ClearErrors;

            if (!Validator<ChamferData>.CheckStandardNumber(nameof(Angle), Angle, adder, clearer))
            {
                Validator<ChamferData>.CheckWithinRange(nameof(Angle), Angle, 0.1, 89.9, adder, clearer);
            }
        }




        public ChamferData(ScrewHoleData screwHoleData)
        {
            _screwHoleData = screwHoleData;
        }
    }
}
