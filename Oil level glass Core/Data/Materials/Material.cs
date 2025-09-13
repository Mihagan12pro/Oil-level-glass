using System.ComponentModel.DataAnnotations;

namespace Oil_level_glass_Core.Data.Materials
{
    public abstract record Material
    {
        public string? Tittle { get; set; }

        public double Density { get; set; }

        public double MinDensity { get; init; }

        public double MaxDensity { get; init; }

        public int HatchStyle { get; init; }
    }
}
