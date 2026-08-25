namespace Oil_level_glass.UI.Abstractions.Editors.Housing
{
    public interface IHousingEditorView : IEditorView
    {
        string HousingMainDiameter { get; set; }
        string HousingMainDiameterPlaceholder { get; set; }

        string HousingMainHeight { get; set; }
        string HousingMainHeightPlaceholder { get; set; }

        string HousingGlassSocketDiameter { get; set; }
        string HousingGlassSocketDiameterPlaceholder { get; set; }

        string HousingGlassSocketHeight { get; set; }
        string HousingGlassSocketHeightPlaceholder { get; set; }

        bool ScrewHoleCanBeConfigured { get; set; }

        bool ChamferCanBeConfigured { get; set; }

        delegate void ConfigChamfer();
        event ConfigChamfer ConfigChamferHandler;

        delegate void ConfigHoles();
        event ConfigHoles ConfigHolesHandler;
    }
}
