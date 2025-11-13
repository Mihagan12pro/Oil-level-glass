using Model.Other;

namespace Oil_level_glass.Model.KompasFile
{
    public abstract class KompasFile : BaseModel
    {
        public Name Name { get; }
    
        public string ?Folder { get; set; }
    
        public string ?Extension { get; init; }

        public string FullName => $"{Folder}\\{Name.Marking}_{Name.Naming}.{Extension}";

        public KompasFile()
        {
            Name = new Name();
        }

        public static implicit operator KompasFile(System.Reflection.Metadata.AssemblyFile v)
        {
            throw new NotImplementedException();
        }
    }
}