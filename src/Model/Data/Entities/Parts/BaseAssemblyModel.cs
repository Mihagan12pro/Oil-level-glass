using Oil_level_glass.Model.Data.KompasFile;

namespace Oil_level_glass.Model.Data.Entities.Parts;

public abstract class BaseAssemblyModel : BaseEntityModel
{
    public BaseAssemblyModel()
    {
        File = new AssemblyFile();
    }
}