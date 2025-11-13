namespace Oil_level_glass.Model.Entities
{
    public abstract class BaseEntityModel : BaseModel
    {
        public KompasFile.KompasFile? File { get; init; }
    }
}
