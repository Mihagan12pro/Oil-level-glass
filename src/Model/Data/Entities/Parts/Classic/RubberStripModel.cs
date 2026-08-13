using Oil_level_glass.Model.ModelProperties.Materials;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;

namespace Oil_level_glass.Model.Data.Entities.Parts.Classic
{
    public class RubberStripModel : BaseDetailModel
    {
        private double _internalDiameter, _height, _externalDiameter;

        public RubberStripModel()
        {
            Material = new Rubber();

            switch (CultureInfo.CurrentCulture.Name)
            {
                case "ru-RU":
                    {
                        DisplayName = "Резиновая прокладка";
                        break;
                    }
                default:
                    {
                        DisplayName = "Rubber strip";
                        break;
                    }
            }
        }


        [DisplayName("D")]
        public double InternalDiameter
        {
            get
            {
                return _internalDiameter; 
            }
            set
            {
                _internalDiameter = value;

                OnPropertyChanged();
            }
        }

        [DisplayName("D2")]
        public double ExternalDiameter
        {
            get
            {
                return _externalDiameter; 
            }
            set
            {
                _externalDiameter = value;

                OnPropertyChanged();
            }
        }

        [DisplayName("h")]
        public double Height
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

        protected override string CheckField(string columnName)
        {
            string error = string.Empty;

            string? displayName = this.GetType()
                         .GetProperties()
                         .Where(p => p.Name == columnName && p.GetCustomAttribute<DisplayNameAttribute>() != null)
                         .Select(p => p.GetCustomAttribute<DisplayNameAttribute>().DisplayName)
                         .FirstOrDefault();
            if (displayName != null)
            {
                switch (columnName)
                {
                    case nameof(Height):
                        {
                            if (Height <= 0)
                                error = string.Format(mustBeGraterThanZero, displayName);

                            break;
                        }
                    case nameof(InternalDiameter):
                        {
                            if (InternalDiameter <= 0)
                                error = string.Format(mustBeGraterThanZero, displayName);
                            else if (InternalDiameter >= ExternalDiameter)
                                error = string.Format(size0MustBeGreaterThanSize1, displayName);

                            break;
                        }
                    case nameof(ExternalDiameter):
                        {
                            if (ExternalDiameter <= 0)
                                error = string.Format(mustBeGraterThanZero, displayName);
                            else if (InternalDiameter >= ExternalDiameter)
                                error = string.Format(size0MustBeGreaterThanSize1, displayName);

                            break;
                        }
                }
            }

            return error;
        }
    }
}