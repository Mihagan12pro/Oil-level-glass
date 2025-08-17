using Oil_level_glass.BaseClasses.KompasData;
using Oil_level_glass.Utilities.Attributes.Numbers;
using Oil_level_glass.Services;
using System.ComponentModel.DataAnnotations;
using Oil_level_glass.Properties;

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

        [Number()]
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

        [Number()]
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


        protected override IEnumerable<ValidationResult> Validate(ValidationContext validationContext, List<ValidationResult> errors)
        {
            if (!errorsByPropertyName.ContainsKey(nameof(CentralHole)) && !errorsByPropertyName.ContainsKey(nameof(MainDiameter)))
            {
                if (DoubleConverter.Convert(CentralHole) >= DoubleConverter.Convert(MainDiameter))
                {
                    errors.Add(new ValidationResult(Resources.TooBigNumberStrError, new List<string> 
                        {
                            nameof(CentralHole) 
                        }
                    ));


                    errors.Add(new ValidationResult(Resources.TooSmallNumberStrError, new List<string> 
                        {
                            nameof(MainDiameter) 
                        }
                    ));
                }
            }


            return errors;
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
