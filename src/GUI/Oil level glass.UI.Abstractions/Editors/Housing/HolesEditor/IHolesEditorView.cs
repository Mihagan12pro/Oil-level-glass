namespace Oil_level_glass.UI.Abstractions.Editors.Housing.HolesEditor
{
    public interface IHolesEditorView : IEditorView
    {
        delegate void ConfigHolesCount(out bool result, out string message);
        event ConfigHolesCount ConfigHolesCountHandler;

        delegate void ConfigHolesSizes();
        event ConfigHolesSizes ConfigHolesSizesHandler;
    }
}
