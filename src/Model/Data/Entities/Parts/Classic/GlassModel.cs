using Oil_level_glass.Model.ModelProperties.Materials;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;

namespace Oil_level_glass.Model.Data.Entities.Parts.Classic
{
    [DisplayName("Glass")]
    public class GlassModel : BaseDetailModel
    {
        private double _diameter;
        [DisplayName("D")]
        public double Diameter
        {
            get
            {
                return _diameter; 
            }
            set
            {
                _diameter = value;
            }
        }

        private double _height;

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
            }
        }

        protected override string CheckField(string columnName)
        {
            string error = string.Empty;

            string? displayName = this.GetType()
                                      .GetProperties()
                                      .Where(p => p.GetCustomAttribute<DisplayNameAttribute>() != null && p.Name == columnName)
                                      .Select(p => p.GetCustomAttribute<DisplayNameAttribute>().DisplayName)
                                      .FirstOrDefault();

            if (displayName != null)
            {
                switch (columnName)
                {
                    case nameof(Height):
                        {
                            if (Height <= 0)
                                error = string.Format(messageMustBeGraterThanZero, displayName);

                            break;
                        }
                    case nameof(Diameter):
                        {
                            if (Diameter <= 0)
                                error = string.Format(messageMustBeGraterThanZero, displayName);

                            break;
                        }
                }
            }

            return error;
        }

        public GlassModel()
        {
            Material = new Glass();

            Appearance.Transparency = 0.74;
            Appearance.Ambient = 0.5;
            Appearance.Diffuse = 0.6;
            Appearance.Specularity = 0.8;
            Appearance.Shininess = 0.8;
            Appearance.Emission = 0.5;

            switch (CultureInfo.CurrentCulture.Name)
            {
                case "ru-RU":
                    {
                        DisplayName = "Линза";

                        break;
                    }
                default:
                    {
                        DisplayName = "Glass";

                        break;
                    }
            }
        }
    }
}