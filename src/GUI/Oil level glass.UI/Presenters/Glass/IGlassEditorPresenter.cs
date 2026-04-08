using Shared;

namespace Oil_level_glass.UI.Presenters.Glass
{
    internal interface IGlassEditorPresenter : IEditorPresenter
    {
        Result UpdateDiameter(string diameter);

        Result UpdateWidth(string width);
    }
}