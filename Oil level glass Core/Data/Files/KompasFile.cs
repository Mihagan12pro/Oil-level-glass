using Oil_level_glass_Core.Data.Structs;
using Oil_level_glass_Core.Services;
using System.ComponentModel.DataAnnotations;

namespace Oil_level_glass_Core.Data.Files
{
    public abstract record KompasFile
    {
        public string? Extension { get; init; }

        public string? FolderPath { get; set; }

        public Naming Naming;
        



        public string FullName
        {
            get
            {
                if (FolderPath == null || Naming.Marking == null || Naming.Name == null)
                    throw new NullReferenceException();

                return Path.Combine(FolderPath, $"{Naming.Marking}_{Naming.Name}{Extension}");
            }
        }


        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (!Directory.Exists(FolderPath))
            {
                yield return new ValidationResult(StringMaster.FolderNotExistsError);
            }
        }


        public KompasFile()
        {
            Naming = new Naming();
        }
    }
}
