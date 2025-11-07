namespace Oil_level_glass.Model
{
    public abstract class BaseEntityModel : BaseModel
    {
        public Oil_level_glass.Model.KompasFile.KompasFile? File { get; init; }
    }
}
