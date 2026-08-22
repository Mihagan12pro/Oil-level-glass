using Oil_level_glass.Presenters.Editors.Presenters.HolesEditor.HelpStructures;
using Oil_level_glass.UI.Abstractions.Editors.Housing.HolesEditor;
using Oil_level_glass.UI.Presenters.Editors;
using Shared.Results;

namespace Oil_level_glass.Presenters.Editors.Presenters.HolesEditor
{
    public interface IHolesEditorPresenter 
        : IEditorPresenter<IHolesEditorView, HolesUpdateResults, HolesUpdateData, HolesDefaultSizes>
    {
       
    }
}
