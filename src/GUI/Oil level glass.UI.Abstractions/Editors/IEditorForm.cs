using Oil_level_glass.Model;

namespace Oil_level_glass.UI.Abstractions.Editors
{
    public interface IEditorForm<TModel> : IForm where TModel : BaseModel
    {
        TModel Model { get; set; }

        //void CheckFormData();
    }
}
