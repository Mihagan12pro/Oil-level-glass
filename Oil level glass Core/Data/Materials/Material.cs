using Oil_level_glass_Core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass_Core.Data.Materials
{
    public abstract record Material
    {
        [Required(ErrorMessage = StringMaster.RequiredError)]
        public string? Tittle { get; set; }

        public double Density { get; set; }

        public double MinDensity { get; init; }

        public double MaxDensity { get; init; }

        public int HatchStyle { get; init; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Density < MinDensity || Density > MaxDensity)
                yield return new ValidationResult(StringMaster.OutOfRangeError);
        }
    }
}
