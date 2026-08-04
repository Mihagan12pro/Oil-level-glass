using Oil_level_glass.Model.ModelProperties.Materials;
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
        public double Diameter
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
                case nameof(Diameter):
                    {
                        if (Diameter <= 0)
                            error = "Diameter must be greater than zero!";

                        break;
                    }
            }

            return error;
        }
    }
}