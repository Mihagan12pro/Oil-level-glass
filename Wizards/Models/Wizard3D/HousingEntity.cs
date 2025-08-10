using Oil_level_glass.BaseClasses;
using Oil_level_glass.Delegates;
using Oil_level_glass.Services;
using System.ComponentModel;

namespace Oil_level_glass.Wizards.Models.Wizard3D
{
    internal class HousingEntity : Kompas3DEntity
    {
        private string? _height;

        [Description("Высота корпуса смотрового окна")]
        public string? Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;

                ValidateHeight();
                OnPropertyChanged();
            }
        }


        private string? _housingDiameter;

        [Description("Диаметр корпуса смотрового окна")]
        public string ?HousingDiameter
        {
            get
            {
                return _housingDiameter;
            }
            set
            {
                _housingDiameter = value;

                ValidateMainDiameters();
                OnPropertyChanged();
            }
        }


        private string? _housingHole;

        [Description("Центральное отверстие корпуса смотрового окна")]
        public string? HousingHole
        {
            get
            {
                return _housingHole;
            }
            set
            {
                _housingHole = value;

                ValidateMainDiameters();
                OnPropertyChanged();
            }
        }


        private string? _screwHolesDistance;
        [Description("Расстояние между отверстиями под винты")]
        public string? ScrewHolesDistance
        {
            get
            {
                return _screwHolesDistance;
            }
            set
            {
                _screwHolesDistance = value;

                ValidateScrewHolesDistance();
                OnPropertyChanged();
            }
        }


        private string ?_screwHolesDiameter;
        [Description("Диаметр отверстия под винты")]
        public string ?ScrewHolesDiameter
        {
            get
            {
                return _screwHolesDiameter;
            }
            set
            {
                _screwHolesDiameter = value;

                ValidateScrewHolesDiameter();
                OnPropertyChanged();
            }
        }


        private void ValidateHeight()
        {
            if (!Validator<HousingEntity>.CheckRequiredField(nameof(Height), Height, new ErrorAdder(AddError), new ErrorClearer(ClearErrors)))
            {
                if (!Validator<HousingEntity>.CheckDoubleField(nameof(Height), Height, new ErrorAdder(AddError), new ErrorClearer(ClearErrors), out double result))
                {
                    Validator<HousingEntity>.CheckBiggerThanZero(nameof(Height), Height, new ErrorAdder(AddError), new ErrorClearer(ClearErrors));
                }
            }
        }


        private void ValidateScrewHolesDistance()
        {
            ErrorAdder adder = new ErrorAdder(AddError);
            ErrorClearer clearer = new ErrorClearer(ClearErrors);

            if (!Validator<HousingEntity>.CheckRequiredField(nameof(ScrewHolesDistance), ScrewHolesDistance, adder, clearer))
            {
                if (!Validator<HousingEntity>.CheckDoubleField(nameof(ScrewHolesDistance), ScrewHolesDistance, adder, clearer, out double result))
                {

                }
            }
        }


        private void ValidateScrewHolesDiameter()
        {
            ErrorAdder adder = new ErrorAdder(AddError);
            ErrorClearer clearer = new ErrorClearer(ClearErrors);

            if (!Validator<HousingEntity>.CheckRequiredField(nameof(ScrewHolesDiameter), ScrewHolesDiameter, adder, clearer))
            {
                if (!Validator<HousingEntity>.CheckDoubleField(nameof(ScrewHolesDiameter), ScrewHolesDiameter, adder, clearer, out double result))
                {

                }
            }
        }


        private void ValidateMainDiameters()
        {
            double housingDiameter = 0;
            double housingHole = 0;

            ErrorAdder adder = AddError;
            ErrorClearer clearer = ClearErrors;

            bool hasDiameterProblems = Validator<HousingEntity>.CheckRequiredField(nameof(HousingDiameter), HousingDiameter, adder, clearer);
            if (!hasDiameterProblems)
            {
                hasDiameterProblems = Validator<HousingEntity>.CheckDoubleField(nameof(HousingDiameter), HousingDiameter, adder, clearer, out housingDiameter);
                if (!hasDiameterProblems)
                {
                    hasDiameterProblems = Validator<HousingEntity>.CheckBiggerThanZero(nameof(HousingDiameter), HousingDiameter, adder, clearer);
                }
            }


            bool hasHoleProblems = Validator<HousingEntity>.CheckRequiredField(nameof(HousingHole), HousingHole, adder, clearer);
            if (!hasHoleProblems)
            {
                hasHoleProblems = Validator<HousingEntity>.CheckDoubleField(nameof(HousingHole), HousingHole, adder, clearer, out housingHole);
                if (!hasHoleProblems)
                {
                    hasHoleProblems = Validator<HousingEntity>.CheckBiggerThanZero(nameof(HousingHole), HousingHole, adder, clearer);
                }
            }


            if (!hasDiameterProblems && !hasHoleProblems)
            {
                Validator<HousingEntity>.CheckHierarchy(nameof(HousingHole), HousingHole, nameof(HousingDiameter), HousingDiameter, adder, clearer);
            }
        }


        public HousingEntity()
        {
            maxDensity = 10;

            minDensity = 0.534;

            ModelColor = Color.Gold;

            Density = "7.731";

            Material = "Сталь";

            FileName = "Корпус";

            Height = "45";

            _housingDiameter = "180";

            _housingHole = "90";

            ScrewHolesDistance = "135";            
        }
    }
}
