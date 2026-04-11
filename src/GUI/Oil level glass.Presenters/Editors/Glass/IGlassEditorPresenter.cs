using Shared;

namespace Oil_level_glass.UI.Presenters.Editors.Glass
{
    public interface IGlassEditorPresenter : IEditorPresenter
    {
        Result UpdateDiameter(string diameter);

        Result UpdateWidth(string width);
    }
}