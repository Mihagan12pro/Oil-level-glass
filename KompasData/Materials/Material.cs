namespace KompasData.Materials;
using Kompas6Constants;

public abstract record Material
{
    public double Density { get; set; }
    
    public required string Tittle { get; set; }    
    
    public double MinDensity { get; init; }
    
    public double MaxDensity { get; init; }
    
    public int HatchStyle { get; init; }
}