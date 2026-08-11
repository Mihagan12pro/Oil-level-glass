using Oil_level_glass.Model;
using Oil_level_glass.UI.Abstractions;

namespace Oil_level_glass.UI.Presenters.Editors
{
    public interface IEditorPresenter<TModel> : IPresenter
        where TModel: IView
    {
        /// <summary>
        /// Undo model update
        /// </summary>
        void ResetFields();
    }
}
