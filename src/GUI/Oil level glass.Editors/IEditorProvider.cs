using Oil_level_glass.Model.Data.Entities.Parts.Classic;

namespace Oil_level_glass.Editors
{
    public interface IEditorProvider
    {
        /// <summary>
        /// Invokes glass editor
        /// </summary>
        /// <param name="glassModel"></param>
        void ShowGlassEditor(GlassModel glassModel);
    }
}
