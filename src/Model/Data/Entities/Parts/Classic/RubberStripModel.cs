using Oil_level_glass.Model.ModelProperties.Materials;
using System.ComponentModel;
using System.Globalization;

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


        [DisplayName("Internal diameter")]
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

        [DisplayName("External diameter")]
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

        [DisplayName("Height")]
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

            switch(columnName)
            {
                case nameof(Height):
                    {
                        if (Height <= 0)
                            error = "Ring height must be greater than zero!";

                        break;
                    }
                case nameof(InternalDiameter):
                    {
                        if (InternalDiameter <= 0)
                            error = "Ring internal diameter must be greater than zero!";
                        else if (InternalDiameter >= ExternalDiameter)
                            error = "External diameter must be greater than internal diameter!";

                        break;
                    }
                case nameof(ExternalDiameter):
                    {
                        if (ExternalDiameter <= 0)
                            error = "Ring external diameter must be greater than zero!";
                        else if (InternalDiameter >= ExternalDiameter)
                            error = "External diameter must be greater than internal diameter!";

                        break;
                    }
            }

            return error;
        }
    }
}