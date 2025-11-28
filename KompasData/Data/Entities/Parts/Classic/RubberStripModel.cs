using Oil_level_glass.Model.Data.Materials;

namespace Oil_level_glass.Model.Data.Entities.Parts.Classic;

public class RubberStripModel : BaseDetailModel
{
    public RubberStripModel()
    {
        Material = new Rubber();

        Appereance.Blue = 0;
        Appereance.Red = 0;
        Appereance.Green = 0;
    }

    public double InternalDiameter { get; set; }

    public double ExternalDiameter { get; set; }

    public double Height { get; set; }

    protected override string CheckField(string columnName)
    {
        string error = string.Empty;

        if ( columnName == nameof(Height) ||
             columnName == nameof(ExternalDiameter) ||
             columnName == nameof(InternalDiameter) )
        {
            error = CheckMinimumValue(columnName);
        }

        return error;
    }
}