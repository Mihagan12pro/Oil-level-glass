namespace KompasData.Structs;

public struct Appereance
{
    public double Ambient { get; set; } 

    public double Diffuse { get; set; } 

    public double Shininess { get; set; }

    public double Transparency { get; set; } 

    public double Specularity { get; set; }

    public double Emission { get; set; }
    
    public int Red { get; set; }
    
    public int Green { get; set; }
    
    public int Blue { get; set; }
    
    public int Color => ((Red | (Green << 8)) | (Blue << 16));
}