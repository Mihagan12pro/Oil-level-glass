using Oil_level_glass.BaseClasses;
using Oil_level_glass.Delegates;
using Oil_level_glass.Services;
using Oil_level_glass.Wizards.Models.HousingRefineData;
using System.ComponentModel;

namespace Oil_level_glass.Wizards.Models.Wizard3D
{
    internal class HousingData : Kompas3DData
    {
        private ScrewHoleData _screwHoleData;
        public ScrewHoleData ScrewHoleData
        {
            get
            {
                return _screwHoleData;
            }
            private set
            {
                _screwHoleData = value;

                OnPropertyChanged();
            }
        }

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
        public string ?MainDiameter
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
        public string? CentralHole
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


     


        private void ValidateHeight()
        {
            if (!Validator<HousingData>.CheckRequiredField(nameof(Height), Height, new ErrorAdder(AddError), new ErrorClearer(ClearErrors)))
            {
                if (!Validator<HousingData>.CheckDoubleField(nameof(Height), Height, new ErrorAdder(AddError), new ErrorClearer(ClearErrors), out double result))
                {
                    Validator<HousingData>.CheckBiggerThanZero(nameof(Height), Height, new ErrorAdder(AddError), new ErrorClearer(ClearErrors));
                }
            }
        }


       


        private void ValidateMainDiameters()
        {
            double housingDiameter = 0;
            double housingHole = 0;

            ErrorAdder adder = AddError;
            ErrorClearer clearer = ClearErrors;

            bool hasDiameterProblems = Validator<HousingData>.CheckRequiredField(nameof(MainDiameter), MainDiameter, adder, clearer);
            if (!hasDiameterProblems)
            {
                hasDiameterProblems = Validator<HousingData>.CheckDoubleField(nameof(MainDiameter), MainDiameter, adder, clearer, out housingDiameter);
                if (!hasDiameterProblems)
                {
                    hasDiameterProblems = Validator<HousingData>.CheckBiggerThanZero(nameof(MainDiameter), MainDiameter, adder, clearer);

                    if (!hasDiameterProblems)
                        ScrewHoleData.MainDiameter = _housingDiameter;
                }
            }


            bool hasHoleProblems = Validator<HousingData>.CheckRequiredField(nameof(CentralHole), CentralHole, adder, clearer);
            if (!hasHoleProblems)
            {
                hasHoleProblems = Validator<HousingData>.CheckDoubleField(nameof(CentralHole), CentralHole, adder, clearer, out housingHole);
                if (!hasHoleProblems)
                {
                    hasHoleProblems = Validator<HousingData>.CheckBiggerThanZero(nameof(CentralHole), CentralHole, adder, clearer);
                }
            }


            if (!hasDiameterProblems && !hasHoleProblems)
            {
                Validator<HousingData>.CheckHierarchy(nameof(CentralHole), CentralHole, nameof(MainDiameter), MainDiameter, adder, clearer);
            }
        }


        public HousingData()
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

            ScrewHoleData = new ScrewHoleData(MainDiameter, CentralHole, Height);
        }
    }
}
