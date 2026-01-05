using Oil_level_glass.Model.Data.Entities.Parts;

namespace Oil_level_glass.Core
{
    public interface IAssemblyPartCreator<TAssemblyModel>
        : ICreator
        where TAssemblyModel : BaseAssemblyModel
    {
        TAssemblyModel PartModel { get; set; }
    }
}
