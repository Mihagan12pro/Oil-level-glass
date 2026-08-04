namespace Oil_level_glass.Model.ModelProperties.Other
{
    public class Appearance
        : BaseModel
    {
        public RGB Color { get; set; } = new RGB(144, 144, 144);

        private double _ambient;
        public double Ambient
        {
            get
            {
                return _ambient;
            }
            set
            {
                _ambient = value;

                OnPropertyChanged();
            }
        }

        private double _diffuse;
        public double Diffuse
        {
            get
            {
                return _diffuse;
            }
            set
            {
                _diffuse = value;

                OnPropertyChanged();
            }
        }

        private double _shininess;
        public double Shininess
        {
            get
            {
                return _shininess;
            }
            set
            {
                _shininess = value;

                OnPropertyChanged();
            }
        }

        private double _transparency;
        public double Transparency
        {
            get
            {
                return _transparency;
            }
            set
            {
                _transparency = value;

                OnPropertyChanged();
            }
        }

        private double _specularity;
        public double Specularity
        {
            get
            {
                return _specularity;
            }
            set
            {
                _specularity = value;

                OnPropertyChanged();
            }
        }

        private double _emission;
        public double Emission
        {
            get
            {
                return _emission;
            }
            set
            {
                _emission = value;

                OnPropertyChanged();
            }
        }

        protected override string CheckField(string columnName)
        {
            return string.Empty;
        }

        public Appearance()
        {
            Shininess = 0.8;
            Transparency = 1;
            Ambient = 0.5;
            Emission = 0.5;
            Specularity = 0.8;
            Diffuse = 0.6;
        }
    }
}