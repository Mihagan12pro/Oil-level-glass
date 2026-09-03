namespace Oil_level_glass.UI.Abstractions.Editors.Glass
{
    public interface IGlassEditorView : IEditorView
    {
        public string GlassHeight { get; set; }

        public string GlassDiameter { get; set; }

        public string GlassHeightPlaceHolder { get; set; }

        public string GlassDiameterPlaceholder { get; set; }
    }
}
