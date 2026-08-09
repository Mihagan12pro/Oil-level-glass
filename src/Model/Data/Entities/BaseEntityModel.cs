namespace Oil_level_glass.Model.Data.Entities
{
    /// <summary>
    /// Base class for entities that describe kompas models (e.g. solid parts, assemblies and e.tc.)
    /// </summary>
    public abstract class BaseEntityModel 
        : BaseModel
    {
        public ModelProperties.KompasFile.KompasFile? File { get; init; }

        public string DisplayName { get; init; }
    }
}