using Oil_level_glass.Model.Data;
using System.ComponentModel;

namespace Oil_level_glass.UI.Editors
{
    internal interface IEditorForm<TModel> : IForm where TModel : BaseModel
    {
        TModel Model { get; set; }

        void CheckFormData();
    }
}
