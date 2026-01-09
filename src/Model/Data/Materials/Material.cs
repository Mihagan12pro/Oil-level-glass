namespace Oil_level_glass.Model.Data.Materials
{
    public abstract class Material : BaseModel
    {
        public double Density { get; set; }
    
        public string? Title { get; set; }    
    
        public double MinDensity { get; init; }
    
        public double MaxDensity { get; init; }
    
        public int HatchStyle { get; init; }

        protected override string CheckField(string columnName)
        {
            string error = string.Empty;

            if (columnName == nameof(Density))
                error = CheckRange(columnName, MinDensity, MaxDensity, false);

            else if (columnName == nameof(Title))
                error = CheckEmptyString(columnName);

            return error;
        }
    }
}