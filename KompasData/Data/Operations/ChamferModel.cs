namespace Oil_level_glass.Model.Data.Operations
{
    public class ChamferModel : BaseModel
    {
        public double Length { get; set; }  

        public double Angle { get; set; }

        protected override string CheckField(string columnName)
        {
            string error = string.Empty;

            switch (columnName)
            {
                case nameof(Angle):
                    {
                        if (Angle >= 90 && Angle <= 0)
                            error = InvalidChamferAngleError;
                        break;
                    }
                case nameof(Length):
                    {
                        if (Length <= 0)
                            error = TooSmallValueError;

                        break;
                    }
            }

            return error;
        }
    }
}
