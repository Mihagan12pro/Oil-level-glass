namespace Oil_level_glass.Model.Data.Materials
{
    public abstract class Material 
        : BaseModel
    {
        private double _density;
        public double Density
        {
            get 
            {
                return _density; 
            }
            set 
            {
                _density = value; 
                OnPropertyChanged(nameof(Density)); 
            }
        }


        private string _title;
        public string Title
        {
            get 
            {
                return _title;
            }
            set
            {
                _title = value; 
                OnPropertyChanged(nameof(Title)); 
            }
        }


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

            switch(columnName)
            {
                case nameof(Title):
                    { 
                        if (string.IsNullOrEmpty(Title))
                            error = "Material title can't be empty string!";
                            break;
                    }

                case nameof(Density):
                    {
                        if (MaxDensity < Density)
                            error = "Material density can't be greater than max density for this material class!";
                        else if (MinDensity > Density)
                            error = "Material density must be greater than min density for this class!";
                            break;
                    }
            }

            return error;
        }

        public static string InvalidHatchError
            => "Invalid hatch!";

        protected Material()
        {
            Title = string.Empty;   
        }
    }
}