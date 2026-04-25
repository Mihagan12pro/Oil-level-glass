namespace Oil_level_glass.Model.Data.Operations.Chamfers
{
    public class ChamferAngleLengthModel : ChamferModel
    {
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
