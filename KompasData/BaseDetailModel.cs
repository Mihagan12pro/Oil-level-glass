using Model.Materials;
using Model.Other;
using Oil_level_glass.Model.KompasFile;

namespace Oil_level_glass.Model
{
    public abstract class BaseDetailModel : BaseEntityModel
    {
        public Appereance Appereance { get; init; }
        public Material? Material { get; init; }

        public BaseDetailModel()
        {
            File = new PartFile();

            Appereance = new Appereance();
        }
    }
}
