using Oil_level_glass.Model;
using Oil_level_glass.Presenters.Editors.HelpStructures;
using Oil_level_glass.UI.Abstractions;

namespace Oil_level_glass.UI.Presenters.Editors
{
    public interface IEditorPresenter<TView, TUpdateResults, TUpdateData, TDefaultSizes> : IPresenter
        where TView: IView
        where TUpdateData : UpdateData
        where TUpdateResults : UpdateDataResults
        where TDefaultSizes : DefaultData
    {
        /// <summary>
        /// Undo model update
        /// </summary>
        void ResetFields();

        TUpdateResults UpdateModel(TUpdateData updateData);

        TDefaultSizes DefaultSizes { get; }
    }
}
