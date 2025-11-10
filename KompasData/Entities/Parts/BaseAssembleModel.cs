using Oil_level_glass.Model.KompasFile;

namespace Oil_level_glass.Model.Entities.Parts
{
    public abstract class BaseAssembleModel : BaseEntityModel
    {
        public BaseAssembleModel()
        {
            File = new AssemblyFile();
        }
    }
}
