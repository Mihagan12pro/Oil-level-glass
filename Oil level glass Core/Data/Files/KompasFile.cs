using Oil_level_glass_Core.Data.Structs;
using Oil_level_glass_Core.Services;
using System.ComponentModel.DataAnnotations;

namespace Oil_level_glass_Core.Data.Files
{
    public abstract record KompasFile
    {
        public string? Extension { get; init; }

        public string? FolderPath { get; set; }

        public string? Marking { get; set; }
        
        public string? Name { get; set; }


        public string FullName
        {
            get
            {
                if (FolderPath == null || Marking == null || Name == null)
                    throw new NullReferenceException();

                return Path.Combine(FolderPath, $"{Marking}_{Name}{Extension}");
            }
        }
    }
}
