using Oil_level_glass.Model;
using Oil_level_glass.Presenters.Editors.DataStorages;
using Oil_level_glass.Presenters.Editors.EditorsData.BaseData;
using Oil_level_glass.Presenters.Presenters;
using Oil_level_glass.UI.Abstractions;

namespace Oil_level_glass.UI.Presenters.Editors
{
    public interface IEditorPresenter<TView, TUpdateResults, TUpdateData, TDefaultSizes> : IPresenter
        where TView: IView
        where TUpdateData : UpdateDataPending
        where TUpdateResults : UpdateDataResults
        where TDefaultSizes : DefaultDataValues
    {
        /// <summary>
        /// Undo model update
        /// </summary>
        void ResetFields();

        TUpdateResults UpdateModel(TUpdateData updateData);

        TDefaultSizes DefaultSizes { get; }
    }

    public interface IEditorPresenter<TView, TDataStorage> : IPresenter
        where TView : IView
        where TDataStorage : EditorDataStorage
    {
        void ResetFields();

        void UpdateModel(UpdateDataPending pending, out UpdateDataResults results);
    }

    public interface IEditorPresenter<TModel> : IPresenter
        where TModel : BaseModel
    {
        void ResetFields();

        void ActivateView();

        TModel Model { get; set; }
    }
}
