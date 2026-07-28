using Oil_level_glass.Model.Data.KompasFile;
using Oil_level_glass.Model.Data.Materials;
using Oil_level_glass.Model.Data.Other;

namespace Oil_level_glass.Model.Data.Entities.Parts
{
    /// <summary>
    /// Base class for entities that describe solid parts
    /// </summary>
    public abstract class BaseDetailModel 
        : BaseEntityModel
    {
        public BaseDetailModel()
        {
            Appearance = new Appearance();
        }

        public Appearance Appearance { get; init; }
        public Material? Material { get; init; }
    }
}