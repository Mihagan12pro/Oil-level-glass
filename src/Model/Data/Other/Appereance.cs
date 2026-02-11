namespace Oil_level_glass.Model.Data.Other
{
    public class Appearance
        : BaseModel
    {
        public RGB Color { get; set; } = new RGB(144, 144, 144);

        public double Ambient { get; set; } = 0.5;

        public double Diffuse { get; set; } = 0.6;

        public double Shininess { get; set; } = 0.8;

        public double Transparency { get; set; } = 1;

        public double Specularity { get; set; } = 0.8;

        public double Emission { get; set; } = 0.5;

        protected override string CheckField(string columnName)
        {
            return string.Empty;
        }
    }
}