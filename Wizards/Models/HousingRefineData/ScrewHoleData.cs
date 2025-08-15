using Oil_level_glass.Delegates;
using Oil_level_glass.Services;
using Oil_level_glass.Wizards.Models.Wizard3D;
using System.ComponentModel;

namespace Oil_level_glass.Wizards.Models.HousingRefineData
{
    internal class ScrewHoleData : HousingRefineData
    {
        private const int _minHolesCount = 4;
        public int MinHolesCount { get => _minHolesCount; }


        private string _holeDistance;
        [Description("Диаметр окружности S")]
        public string HoleDistance
        {
            get
            {
                return _holeDistance;
            }
            set
            {
                _holeDistance = value;

                ValidateDistance();
                OnPropertyChanged();
            }
        }


        private string _holeDiameter;
        [Description("Диаметр отверстия d")]
        public string HoleDiameter
        {
            get
            {
                return _holeDiameter;
            }
            set
            {
                _holeDiameter = value;

                ValidateDiameter();
                OnPropertyChanged();
            }
        }


        private int _holeCount;
        [Description("Количество отверстий n")]
        public int HoleCount
        {
            get
            {
                return _holeCount;
            }
            set
            {
                _holeCount = value;

                OnPropertyChanged();
            }
        }


        private int _maxHoleCount;
        public int MaxHoleCount
        {
            get
            {
                return _maxHoleCount;
            }
            private set
            {
                _maxHoleCount = value;

                OnPropertyChanged();
            }
        }


        private void ValidateDistance()
        {
            ErrorAdder adder = AddError;
            ErrorClearer clearer = ClearErrors;
            

            if (!Validator<ScrewHoleData>.CheckStandardNumber(nameof(HoleDistance), HoleDistance, adder, clearer))
            {
                if (!Validator<ScrewHoleData>.CheckHierarchy(nameof(HoleDistance), HoleDistance, nameof(MainDiameter), MainDiameter, true, adder, clearer, false))
                {
                    Validator<ScrewHoleData>.CheckHierarchy(nameof(HoleDistance), HoleDistance, nameof(CentralHoleDiameter), CentralHoleDiameter, false, adder, clearer, false);
                }
            }
        }


        private void ValidateDiameter()
        {
            ErrorAdder adder = AddError;
            ErrorClearer clearer = ClearErrors;

            if (!Validator<ScrewHoleData>.CheckStandardNumber(nameof(HoleDiameter), HoleDiameter, adder, clearer))
            {
                if (!Validator<ScrewHoleData>.CheckRange(nameof(HoleDiameter), MinHolesCount, CulcMax(), adder, clearer))
                    MaxHoleCount = CulcMax();
            }
        }


        private int CulcMax()
        {
            return Convert.ToInt32(Math.Floor(Math.PI * Convert.ToDouble(HoleDistance) / Convert.ToDouble(HoleDiameter)));
        }



        public ScrewHoleData(string ?mainDiameter, string? centralHoleDiameter, string? height)
        {
            HoleDistance = "100";
            HoleDiameter = "10";
        }
    }
}
