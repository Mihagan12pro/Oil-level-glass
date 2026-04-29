namespace Oil_level_glass.Model.Data.Other
{
    public class RGB : BaseModel
    {
        private int _red;
        public int Red
        {
            get
            {
                return _red;
            }
            set
            {
                _red = value;
                OnPropertyChanged();
            }
        }

        private int _green;
        public int Green
        {
            get
            {
                return _green;
            }
            set
            {
                _green = value;
                OnPropertyChanged();
            }
        }

        private int _blue;
        public int Blue
        {
            get
            {
                return _blue;
            }
            set
            {
                _blue = value;
                OnPropertyChanged();
            }
        }

        public int Color
        {
            get
            {
                return ((Red | (Green << 8)) | (Blue << 16));
            }
        }

        public override string Error => string.Empty;

        public RGB(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        protected override string CheckField(string columnName)
        {
            return string.Empty;
        }
    }
}
