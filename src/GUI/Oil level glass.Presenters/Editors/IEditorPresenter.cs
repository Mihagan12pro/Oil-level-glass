using Oil_level_glass.Model;
using Oil_level_glass.Presenters.Presenters;

namespace Oil_level_glass.UI.Presenters.Editors
{
    public interface IEditorPresenter<TModel> : IPresenter
        where TModel : BaseModel
    {
        void ActivateView();

        TModel Model { get; set; }
    }
}
