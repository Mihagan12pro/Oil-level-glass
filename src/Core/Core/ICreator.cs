using Oil_level_glass.Model;
using Shared.Results;

namespace Oil_level_glass.Core
{
    /// <summary>
    /// Base interface for all builders
    /// </summary>
    public interface ICreator<TModel> where TModel : BaseModel
    {
        /// <summary>
        /// Creates a model
        /// </summary>
        /// <returns></returns>
        Result Create();
    }
}
