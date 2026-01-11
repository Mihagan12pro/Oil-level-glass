using Oil_level_glass.Model.Data.Other;

namespace Oil_level_glass.Model.Data.KompasFile
{
    public abstract class KompasFile : BaseModel
    {
        public Name Name { get; }
    
        public string ?Folder { get; set; } = string.Empty;
    
        public string ?Extension { get; init; }

        public string FullName => $"{Folder}\\{Name.Marking}_{Name.Naming}.{Extension}";

        public KompasFile()
        {
            Name = new Name();
        }

        protected override string CheckField(string columnName)
        {
            string error = string.Empty;

            if (columnName == nameof(Folder))
                error = CheckDirectory(columnName);

            return error;
        }
    }
}