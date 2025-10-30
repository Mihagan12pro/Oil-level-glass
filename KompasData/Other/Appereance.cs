namespace KompasData.Other;

public class Appereance
{
    public double Ambient { get; set; } = 0.5;

    public double Diffuse { get; set; } = 0.6;

    public double Shininess { get; set; } = 0.8;

    public double Transparency { get; set; } = 1;

    public double Specularity { get; set; } = 0.8;

    public double Emission { get; set; } = 0.5;
    
    public int Red { get; set; } = 144;

    public int Green { get; set; } = 144;

    public int Blue { get; set; } = 144;

    public int Color => ((Red | (Green << 8)) | (Blue << 16));
}