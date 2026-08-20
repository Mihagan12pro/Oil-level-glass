using Oil_level_glass.Model.Data.Entities;
using Oil_level_glass.Presenters.Editors.ModelProperties.NamingEditor.HelpStructures;
using Oil_level_glass.UI.Abstractions.Editors.ModelProperties;

namespace Oil_level_glass.Presenters.Editors.ModelProperties.NamingEditor
{
    public interface INamingEditorPresenter 
        : IModelPrepertyEditorPresenter<
            BaseEntityModel,
            INamingEditorView,
            NamingUpdateResults,
            NamingUpdateData, 
            DefaultNaming>
    {

    }
}
