using Oil_level_glass_Core.Data.Structs;
using Oil_level_glass_Core.Services;
using System.ComponentModel.DataAnnotations;

namespace Oil_level_glass_Core.Data.Files
{
    public abstract record KompasFile
    {
        public string? Extension { get; init; }

        public string? FolderPath { get; set; }

        public Name Name;

        public string FullName
        {
            get
            {
                if (FolderPath == null || Name.Naming  == null || Name.Marking == null)
                    throw new NullReferenceException();


                return Path.Combine(FolderPath, $"{Name.Marking}_{Name.Naming}{Extension}");
            }
        }


        public KompasFile()
        {
            Name = new Name();
        }
    }
}
