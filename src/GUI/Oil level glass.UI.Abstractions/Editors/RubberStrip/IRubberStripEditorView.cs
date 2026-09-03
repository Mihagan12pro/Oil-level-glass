using Oil_level_glass.Model.Data.Entities.Parts.Classic;

namespace Oil_level_glass.UI.Abstractions.Editors.RubberStrip
{
    public interface IRubberStripEditorView : IEditorView
    {
        string RubberStripHeight { get; set; }
        string RubberStripHeightPlaceHolder { get; set; }

        string RubberStripInternalDiameter { get; set; }
        string RubberStripInternalDiameterPlaceHolder { get; set; }

        string RubberStripExternalDiameter { get; set; }
        string RubberStripExternalDiameterPlaceHolder { get; set; }
    }
}
