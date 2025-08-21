using Oil_level_glass.BaseClasses.KompasData;
using Oil_level_glass.Utilities.Attributes.Numbers;
using Oil_level_glass.Services;
using System.ComponentModel.DataAnnotations;
using Oil_level_glass.Properties;
using Oil_level_glass.Utilities.Attributes.Comparers;

namespace Oil_level_glass.Wizards.Models.Wizard3D
{
    internal class HousingData : Kompas3DData
    {  
        private string? _height;

        [Number()]
        public string? Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;

                OnPropertyChanged();
            }
        }


        private string? _housingDiameter;

        [GreaterThan(nameof(CentralHole))]
        public string ?MainDiameter
        {
            get
            {
                return _housingDiameter;
            }
            set
            {
                _housingDiameter = value;

                OnPropertyChanged();
            }
        }


        private string? _centralHole;

        [SmallerThan(nameof(MainDiameter))]
        public string? CentralHole
        {
            get
            {
                return _centralHole;
            }
            set
            {
                _centralHole = value;

                OnPropertyChanged();
            }
        }



        public HousingData()
        {
            maxDensity = 10;

            minDensity = 0.534;

            ModelColor = Color.Gold;

            Density = "7.731";

            Material = "Сталь";

            Height = "45";

            _housingDiameter = "180";

            _centralHole = "90";
        }
    }
}
