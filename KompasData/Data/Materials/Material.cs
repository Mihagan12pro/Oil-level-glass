using KompasAPI7;

namespace Oil_level_glass.Model.Data.Materials;

public abstract class Material : BaseModel
{
    public double Density { get; set; }
    
    public string? Tittle { get; set; }    
    
    public double MinDensity { get; init; }
    
    public double MaxDensity { get; init; }
    
    public int HatchStyle { get; init; }

    protected override string CheckField(string columnName)
    {
        string error = string.Empty;

        switch(columnName)
        {
            case nameof(Density):
                {
                    if (MinDensity > Density || MaxDensity < Density)
                        error = InvalidDensityError;

                    break;
                }
            case nameof(Tittle):
                {
                    if (string.IsNullOrWhiteSpace(Tittle))
                        error = EmptyStringError;

                    break;
                }
        }

        return error;
    }
}