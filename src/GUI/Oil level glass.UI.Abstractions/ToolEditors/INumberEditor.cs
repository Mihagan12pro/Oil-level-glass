namespace Oil_level_glass.UI.Abstractions.ToolEditors
{
    public interface INumberEditor<T> : IToolEditorView
    {
        T Min { get; set; }

        T Max { get; set; }

        T Value { get; set; }
    }
}
