using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.UI.Editors;

namespace Oil_level_glass.UI.Editors.Glass
{
    internal interface IGlassEditor : IEditorForm<GlassModel>
    {

    }

    enum GlassEditorTextBox
    {
        /// <summary>
        /// TextBox for diameter
        /// </summary>
        Diameter,

        /// <summary>
        /// TextBox for Width
        /// </summary>
        Width
    }
}
