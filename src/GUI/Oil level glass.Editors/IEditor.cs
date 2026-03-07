using Oil_level_glass.Model.Data;

namespace Oil_level_glass.Editors
{
    public interface IEditor<TModel> where TModel : BaseModel
    {
        void SetModel(TModel model);
    }
}
