namespace Oil_level_glass.UI.Abstractions.ToolEditors
{
    public interface IToolEditorView : IView
    {
        bool Result { get; }

        string Header { get; set; }
    }
}
