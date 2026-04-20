using System.ComponentModel;

namespace Oil_level_glass.Model.Data.Operations
{
    public class ThreadModel 
        : BaseModel
    {
        private double _nominalDiameter, _pitch;
        private string? _standard;

        [DisplayName("Nominal diameter")]
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

        [DisplayName("Pitch")]
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

        [DisplayName("Standard")]
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
