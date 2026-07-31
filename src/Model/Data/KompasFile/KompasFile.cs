using Oil_level_glass.Model.Data.Operations;
using Oil_level_glass.Model.Data.Other;

namespace Oil_level_glass.Model.Data.KompasFile
{
    public abstract class KompasFile : BaseModel
    {
        public required T Name { get; set; }

        private string? _folder;
        public required string? Folder
        {
            get
            {
                return _folder;
            }
            set
            {
                _folder = value;
                OnPropertyChanged();
            }
        }
    
        public string ?Extension { get; init; }

        public string FullName
        {
            get
            {
                if (Name.Marking == string.Empty)
                {
                    return $"{Folder}\\{Name.Naming}{Extension}";
                }

                return $"{Folder}\\{Name.Marking}_{Name.Naming}{Extension}";
            }
        }

        protected override string CheckField(string columnName)
        {
            string error = string.Empty;

            switch (columnName)
            {
                case nameof(Folder):
                    {
                        if (!Directory.Exists(Folder))
                            error = "This folder does not exists!";
                        break;
                    }
            }
            return error;
        }

        public KompasFile()
        {
            Folder = string.Empty;
        }
    }
}