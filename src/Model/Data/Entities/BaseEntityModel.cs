namespace Oil_level_glass.Model.Data.Entities;

public abstract class BaseEntityModel : BaseModel
{
    public KompasFile.KompasFile? File { get; init; }
}