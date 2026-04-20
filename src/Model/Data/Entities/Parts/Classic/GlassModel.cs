using Oil_level_glass.Model.Data.Materials;
using System.ComponentModel;

namespace Oil_level_glass.Model.Data.Entities.Parts.Classic
{
    public class GlassModel : BaseDetailModel
    {
        public GlassModel()
        {
            Material = new Glass();

            Appearance.Transparency = 0.74;
            Appearance.Ambient = 0.5;
            Appearance.Diffuse = 0.6;
            Appearance.Specularity = 0.8;
            Appearance.Shininess = 0.8;
            Appearance.Emission = 0.5;
        }

        private double _externalDiameter;
        [DisplayName("Diameter")]
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

        private double _height;

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

        public override string Error
        {
            get
            {
                string errors = string.Empty;


                string heightError = this[nameof(Height)];
                if (heightError != string.Empty)
                    errors += heightError + '\n';
                
                string externalDiameterError = this[nameof(ExternalDiameter)];
                if (externalDiameterError != string.Empty)
                    errors += externalDiameterError;

                return errors;
            }
        }

        protected override string CheckField(string columnName)
        {
            string error = string.Empty;

            switch (columnName)
            {
                case nameof(Height):
                    {
                        if (Height <= 0)
                            error = "Height must be greater than zero!";

                        break;
                    }
                case nameof(ExternalDiameter):
                    {
                        if (ExternalDiameter <= 0)
                            error = "Diameter must be greater than zero!";

                        break;
                    }
            }

            return error;
        }
    }
}