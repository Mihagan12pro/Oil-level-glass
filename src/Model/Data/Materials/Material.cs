namespace Oil_level_glass.Model.Data.Materials
{
    public abstract class Material 
        : BaseModel
    {
        public double Density { get; set; }
    
        public string? Title { get; set; }    
    
        public double MinDensity { get; init; }
    
        public double MaxDensity { get; init; }
    
        public int HatchStyle { get; init; }

        public List<string> TryUpdate(string title, double density, int hatchStyle)
        {
            string? oldTitle = Title;
            double oldDensity = Density;

            Density = density;

            Title = title;

            List<string> errors = new List<string>();

            if (hatchStyle != HatchStyle)
                errors.Add(InvalidHatchError);

            if (this[nameof(Density)] != string.Empty)
               errors.Add(this[nameof(Density)]);

            if (this[nameof(Title)] != string.Empty)
                errors.Add(this[nameof(Title)]);

            if (errors.Count > 0)
            {
                Density = oldDensity;
                Title = oldTitle;
            }

            return errors;
        }

        protected override string CheckField(string columnName)
        {
            string error = string.Empty;

            if (columnName == nameof(Density))
                error = CheckRange(columnName, MinDensity, MaxDensity, false);

            else if (columnName == nameof(Title))
                error = CheckEmptyString(columnName);

            return error;
        }

        public static string InvalidHatchError
            => "Invalid hatch!";
    }
}