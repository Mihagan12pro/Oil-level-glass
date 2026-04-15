namespace Oil_level_glass.UI.Presenters.Editors
{
    public interface IEditorPresenter : IPresenter
    {
        /// <summary>
        /// Undo model update
        /// </summary>
        void ResetFields();
    }
}
