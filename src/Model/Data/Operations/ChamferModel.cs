using System.ComponentModel;

namespace Oil_level_glass.Model.Data.Operations
{
    public class ChamferModel 
        : BaseModel
    {
        private double _length, _angle;

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

        /// <summary>
        /// Angle in degrees
        /// </summary>
        [DisplayName("Angle")]
        public double Angle
        {
            get
            {
                return _angle; 
            }
            set
            {
                _angle = value;

                OnPropertyChanged();
            }
        }

        protected override string CheckField(string columnName)
        {
            string error = string.Empty;

            switch(columnName)
            {
                case nameof(Angle):

                    if (Angle <= 0)
                        error = "Chamfer angle must be greater than zero!";
                    else if (Angle >= 90)
                        error = "Chamfer angle can't be equal or greater than 90!";
                    break;

                case nameof(Length):

                    if (Length <= 0)
                        error = "Length must be greater than zero!";
                    break;
            }


            return error;
        }
    }
}
