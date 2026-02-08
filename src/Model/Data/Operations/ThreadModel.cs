namespace Oil_level_glass.Model.Data.Operations
{
    public class ThreadModel 
        : BaseModel
    {
        private double _nominalDiameter;
        public double NominalDiameter
        {
            get
            {
                return _nominalDiameter; 
            }
            set
            {
                _nominalDiameter = value;

                OnPropertyChanged();
            }
        }


        private double _pitch;
        public double Pitch
        {
            get
            {
                return _pitch; 
            }
            set
            {
                _pitch = value;

                OnPropertyChanged();
            }
        }


        private string? _standard;
        public string? Standard
        {
            get
            {
                return _standard; 
            }
            set
            {
                _standard = value;

                OnPropertyChanged();
            }
        }

        public ThreadModel()
        {
            Standard = string.Empty;
        }
    }
}
