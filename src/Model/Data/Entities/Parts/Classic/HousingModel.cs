using Oil_level_glass.Model.Data.Materials;
using Oil_level_glass.Model.Data.Operations;

namespace Oil_level_glass.Model.Data.Entities.Parts.Classic;

public class HousingModel : BaseDetailModel
{
    public HousingModel()
    {
        Material = new Metal();
    }

    public double MainDiameter { get; set; }

    public double MainHeight { get; set; }

    public double GlassSocketHeight { get; set; }
    public double GlassSocketDiameter { get; set; }

    public double CentralHoleDiameter { get; set; }

    public ChamferModel Chamfer { get; } = new() { Angle = 45, Length = 5 };

    public int ScrewHolesCount { get; set; }
    public double ScrewHolesDistance { get; set; }

    public ThreadModel Thread { get; } = new();

    protected override string CheckField(string columnName)
    {
        string error = string.Empty;

        if (columnName == nameof(MainDiameter) ||
            columnName == nameof(MainHeight) ||
            columnName == nameof(GlassSocketHeight) ||
            columnName == nameof(GlassSocketDiameter) ||
            columnName == nameof(CentralHoleDiameter) ||
            columnName == nameof(ScrewHolesCount) ||
            columnName == nameof(ScrewHolesDistance))
        {
            error = CheckMinimumValue(columnName); 
        }


        else if (columnName == nameof(ScrewHolesCount))
            error = CheckMinimumValue(columnName, 3);

        return error;
    }
}