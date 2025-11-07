using Oil_level_glass.Model;

namespace Model.Materials;

public abstract class Material : BaseModel
{
    public double Density { get; set; }
    
    public string? Tittle { get; set; }    
    
    public double MinDensity { get; init; }
    
    public double MaxDensity { get; init; }
    
    public int HatchStyle { get; init; }
}