using Oil_level_glass.Model;

namespace Oil_level_glass.UI.Abstractions.Editors
{
    public interface IEditorView<TModel> : IView where TModel : BaseModel
    {
        TModel Model { get; set; }

        //void CheckFormData();
    }
}
