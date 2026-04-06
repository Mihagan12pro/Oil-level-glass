using Oil_level_glass.Model.Data.Entities.Parts.Classic;

namespace Oil_level_glass.UI.Wizard3d.Editors.Glass
{
    internal interface IGlassEditor : IEditor<GlassModel>
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
