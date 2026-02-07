namespace Oil_level_glass.Model.Data.Operations
{
    public class ThreadModel : BaseModel
    {
        public double NominalDiameter { get; set; }

        public double Pitch { get; set; }

        public string Standard { get; set; } = string.Empty;
    }
}
