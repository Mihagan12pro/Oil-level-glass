using Oil_level_glass.BaseClasses;
using System.Globalization;

namespace Oil_level_glass.Wizards.Models.Wizard3D
{
    internal class HousingEntity : Kompas3DEntity
    {
        private string? _height;
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
        public string ?HousingDiameter
        {
            get
            {
                return _housingDiameter;
            }
            set
            {
                _housingDiameter = value;

                ValidateDiameters();
                OnPropertyChanged();
            }
        }


        private string? _housingHole;
        public string? HousingHole
        {
            get
            {
                return _housingHole;
            }
            set
            {
                _housingHole = value;

                ValidateDiameters();
                OnPropertyChanged();
            }
        }


        private void ValidateHeight()
        {
            ClearErrors(nameof(Height));

            if (!double.TryParse(new String(Height).Replace(',','.'), new CultureInfo("En-us"), out double height))
            {
                AddError(nameof(Height), "Высота заготовки корпуса должна быть числом!");

                return;
            }

            if (height <= 0)
                AddError(nameof(Height), "Высота заготовки должна быть больше нуля!");
        }


        private void ValidateDiameters()
        {
            ClearErrors(nameof(HousingDiameter));
            ClearErrors(nameof(HousingHole));

            if (!double.TryParse(new String(HousingDiameter).Replace(',', '.'), new CultureInfo("En-us"), out double housingDiameter) )
            {
                AddError(nameof(HousingDiameter), "Диаметр корпуса должен быть числом!");

                return;
            }

            if (housingDiameter <= 0)
            {
                AddError(nameof(HousingDiameter), "Диаметр корпуса должен быть больше!");

                return;
            }

            ClearErrors(nameof(HousingHole));

            if (!double.TryParse(new String(HousingHole).Replace(',', '.'), new CultureInfo("En-us"), out double housingHole))
            {
                AddError(nameof(HousingHole), "Диаметр корпуса должен быть числом!");

                return;
            }

            if (housingHole <= 0)
            {
                AddError(nameof(HousingHole), "Диаметр корпуса должен быть больше!");

                return;
            }

            if (housingHole >= housingDiameter)
            {
                AddError(nameof(HousingHole), "Диаметр корпуса должен быть больше диаметра отверстия!");
                AddError(nameof(HousingDiameter), "Диаметр корпуса должен быть больше диаметра отверстия!");
            }
        }


        public HousingEntity()
        {
            ModelColor = Color.Gold;

            Density = 7.731;

            Material = "Сталь";

            FileName = "Корпус";

            Height = "45";

            HousingDiameter = "180";

            HousingHole = "90";
        }
    }
}
