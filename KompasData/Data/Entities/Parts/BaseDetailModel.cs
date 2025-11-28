using Oil_level_glass.Model.Data.KompasFile;
using Oil_level_glass.Model.Data.Materials;
using Oil_level_glass.Model.Data.Other;

namespace Oil_level_glass.Model.Data.Entities.Parts;

public abstract class BaseDetailModel : BaseEntityModel
{
    public BaseDetailModel()
    {
        File = new PartFile();

        Appereance = new Appereance();
    }

    public Appereance Appereance { get; init; }
    public Material? Material { get; init; }
}