namespace Oil_level_glass.Model.Data.Operations
{
    public class ChamferModel : BaseModel
    {
        public double Length { get; set; }  

        public double Angle { get; set; }

        protected override string CheckField(string columnName)
        {
            string error = string.Empty;

            if (columnName == nameof(Angle))
                error = CheckRange(columnName, 0, 90);

            else if (columnName == nameof(Length))
                error = CheckMinimumValue(columnName);


            return error;
        }
    }
}
