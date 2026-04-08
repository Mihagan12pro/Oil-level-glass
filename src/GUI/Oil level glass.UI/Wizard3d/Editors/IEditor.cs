using Oil_level_glass.Model.Data;
using System.ComponentModel;

namespace Oil_level_glass.UI.Wizard3d.Editors
{
    internal interface IEditor<TModel> where TModel : BaseModel
    {
        TModel Model { get; set; }

        void CheckFormData();
    }
}
