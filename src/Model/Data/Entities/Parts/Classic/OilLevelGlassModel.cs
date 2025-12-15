using Oil_level_glass.Model.Data.KompasFile;
using Oil_level_glass.Model.Data.Operations;

namespace Oil_level_glass.Model.Data.Entities.Parts.Classic;

public class OilLevelGlassModel : BaseEntityModel
{
    public string? GlassPath { get; set; }
    public string? HousingPath { get; set; }
    public string? StripPath { get; set; }

    public OilLevelGlassModel()
    {
        File = new AssemblyFile();
    }

    public double MainDiameter { get; set; }

    public double MainHeight { get; set; }

    public int ScrewHolesCount { get; set; }

    public double CentralHoleDiameter { get; set; }

    public double GlassDiameter { get; set; }

    public double GlassWidth { get; set; }

    public double GlassSocketHeight { get; set; }

    public ThreadModel? ThreadModel { get; set; }

    public ChamferModel Chamfer { get; } = new() { Angle = 45, Length = 5 };

    protected override string CheckField(string columnName)
    {
        string error = string.Empty;

        if (columnName == nameof(MainDiameter) ||
            columnName == nameof(MainHeight) ||
            columnName == nameof(CentralHoleDiameter) ||
            columnName == nameof(GlassDiameter) ||
            columnName == nameof(GlassWidth) ||
            columnName == nameof(GlassSocketHeight))
        {
            error = CheckMinimumValue(columnName);
        }

        else if (columnName == nameof(GlassPath) ||
            columnName == nameof(HousingPath) ||
            columnName == nameof(StripPath))
        {
            error = CheckEmptyString(columnName);

            if (error == string.Empty)
                error = CheckFile(columnName);
        }
        
        return error;
    }
}