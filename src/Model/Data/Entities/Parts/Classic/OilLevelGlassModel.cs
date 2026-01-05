using Oil_level_glass.Model.Data.KompasFile;

namespace Oil_level_glass.Model.Data.Entities.Parts.Classic;

public class OilLevelGlassModel : BaseAssemblyModel
{
    public string? GlassPath { get; set; }
    public string? HousingPath { get; set; }
    public string? StripPath { get; set; }

    protected override string CheckField(string columnName)
    {
        string error = string.Empty;

        if (columnName == nameof(GlassPath) ||
            columnName == nameof(HousingPath) ||
            columnName == nameof(StripPath))
        {
            error = CheckEmptyString(columnName);

            if (error == string.Empty)
                error = CheckFile(columnName);
        }
        
        return error;
    }

    public OilLevelGlassModel()
    {
        File = new AssemblyFile();
    }
}