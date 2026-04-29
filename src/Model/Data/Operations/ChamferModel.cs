using System.ComponentModel;

namespace Oil_level_glass.Model.Data.Operations
{

    public class ChamferModel 
        : BaseModel
    {
        private double _side1, _side2;

        /// <summary>
        /// Length of the side 1 (in mm)
        /// </summary>
        [DisplayName("Side 1")]
        public double Side1
        {
            get
            {
                return _side1;
            }
            set
            {
                _side1 = value;

                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Length of the side 2 (in mm)
        /// </summary>
        [DisplayName("Side 2")]
        public double Side2
        {
            get
            {
                return _side2;
            }
            set
            {
                _side2 = value;

                OnPropertyChanged();
            }
        }

        public double MaxSide1, MaxSide2;

        private double _angle;

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

            switch (columnName)
            {
                case nameof(Angle):
                    {
                        if (Angle <= 0)
                            error = "Chamfer angle must be greater than zero!";
                        else if (Angle >= 90)
                            error = "Chamfer angle can't be equal or greater than 90!";
                        break;
                    }

                case nameof(Side1):
                    {
                        if (Side1 <= 0)
                            error = "Side 1 must be greater than zero!";
                        else if (MaxSide1 > 0 && Side1 > MaxSide1)
                            error = $"Side 1 can't be greater than {MaxSide1}!";

                        break;
                    }

                case nameof(Side2):
                    {
                        if (Side2 <= 0)
                            error = "Side 2 must be greater than zero!";
                        else if (MaxSide2 > 0 && Side2 >= MaxSide2)
                            error = $"Side 2 must be less than {MaxSide2}!";

                        break;
                    }
            }

            return error;
        }
    }
}
