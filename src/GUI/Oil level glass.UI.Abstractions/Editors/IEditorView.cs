namespace Oil_level_glass.UI.Abstractions.Editors
{
    public interface IEditorView : IView
    {
        bool IsValid { get; set; }

        delegate void ViewDataChanging();
        event ViewDataChanging DataChangingHandler;

        delegate void ClearData();
        event ClearData ClearDataHandler;

        delegate void CancelDataChanges();
        event CancelDataChanges CancelDataChangesHandler;

        delegate void AcceptDataChanges();
        event AcceptDataChanges AcceptDataChangesHandler;
    }
}
