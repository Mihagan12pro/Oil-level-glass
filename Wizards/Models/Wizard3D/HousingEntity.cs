using Oil_level_glass.BaseClasses;
using Oil_level_glass.Enums;
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
                AddError(nameof(Height), "Высота заготовки корпуса должна быть числом!", InputError.EmptyField);

                return;
            }

            if (height <= 0)
                AddError(nameof(Height), "Высота заготовки должна быть больше нуля!", InputError.TooSmall);
        }


        private void ValidateDiameters()
        {
            ClearErrors(nameof(HousingDiameter));

            double housingDiameter = 0;
            double housingHole = 0; 

            if (String.IsNullOrEmpty(HousingDiameter))
            {
                AddError(nameof(HousingDiameter), $"Поле 'Диаметр корпуса' обязательно для заполнения!", InputError.EmptyField);
            }

            if (GetErrors(nameof(HousingDiameter)) == null)
            {
                if (!double.TryParse(new String(HousingDiameter).Replace(',', '.'), new CultureInfo("En-us"), out housingDiameter))
                {
                    AddError(nameof(HousingDiameter), "Диаметр корпуса должен быть числом!", InputError.InvalidType);
                }

                if (GetErrors(nameof(HousingDiameter)) == null)
                {
                    if (housingDiameter <= 0)
                    {
                        AddError(nameof(HousingDiameter), "Диаметр корпуса должен быть больше нуля!", InputError.TooSmall);
                    }
                }
            }



            ClearErrors(nameof(HousingHole));

            if (String.IsNullOrEmpty(HousingHole))
            {
                AddError(nameof(HousingHole), $"Поле 'Диаметр центрального отверстия корпуса' обязательно для заполнения!", InputError.EmptyField);
            }

            if(GetErrors(nameof(HousingHole)) == null)
            {
                if (!double.TryParse(new String(HousingHole).Replace(',', '.'), new CultureInfo("En-us"), out housingHole))
                {
                    AddError(nameof(HousingHole), "Диаметр центрального отверстия должен быть числом!", InputError.InvalidType);

                    return;
                }

                if (GetErrors(nameof(HousingHole)) == null)
                {
                    if (housingHole <= 0)
                    {
                        AddError(nameof(HousingHole), "Диаметр центрального отверстия должен быть больше нуля!", InputError.TooSmall);
                    }
                }
            }




            if (GetErrors(nameof(HousingHole)) == null && GetErrors(nameof(HousingDiameter)) == null)
            {
                if (housingDiameter <= housingHole)
                {
                    AddError(nameof(HousingHole), "Диаметр центрального отверстия должен быть меньше диаметра корпуса!", InputError.BrokenHierarchy);

                    AddError(nameof(HousingDiameter), "Диаметр центрального отверстия должен быть меньше диаметра корпуса!", InputError.BrokenHierarchy);
                }
            }
        }


        public HousingEntity()
        {
            ModelColor = Color.Gold;

            Density = "7.731";

            Material = "Сталь";

            FileName = "Корпус";

            Height = "45";

            HousingDiameter = "180";

            HousingHole = "90";

            maxDensity = 10;
            minDensity = 0.534;
        }
    }
}
