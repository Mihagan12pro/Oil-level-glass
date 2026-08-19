using Oil_level_glass.Model.Data.Entities;

namespace Oil_level_glass.UI.Abstractions.Editors.ModelProperties
{
    public interface IModelPropertyEditorView : IEditorView
    {
        void AddModel(BaseEntityModel model);

        void AddModelsRange(params BaseEntityModel[] models);
    }
}
