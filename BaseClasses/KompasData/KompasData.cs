using Oil_level_glass.BaseClasses.ModelsBase;
using Oil_level_glass.Wizards.Models.CommonModels;

namespace Oil_level_glass.BaseClasses.KompasData
{
    internal abstract class KompasData : BaseModel
    {
        private FileData _fileData;
        public FileData FileData
        {
            get
            {
                return _fileData;
            }
        }


        public KompasData(FileData fileData)
        {
            _fileData = fileData;
        }


        public KompasData()
        {

        }
    }
}
