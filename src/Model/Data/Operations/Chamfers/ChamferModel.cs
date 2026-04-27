using System.ComponentModel;

namespace Oil_level_glass.Model.Data.Operations.Chamfers
{
    public abstract class ChamferModel 
        : BaseModel
    {
        private double _length;

        /// <summary>
        /// Length of the side 1 (in mm)
        /// </summary>
        [DisplayName("Length")]
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = value;

                OnPropertyChanged();
            }
        }

        public double MaxLength { get; set; }
    }
}
